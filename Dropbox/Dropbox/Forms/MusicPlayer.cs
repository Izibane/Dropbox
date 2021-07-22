﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dropbox;
using System.Media;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Dropbox.Misc
{
    public partial class MusicPlayer : Form
    {
        // A Thread random is inherently more random and will not produce same results as commonly as a normal random.
        // This is C# equivalent of Java's ThreadLocalRandom
        private static readonly ThreadLocal<Random> rand = new ThreadLocal<Random>(() => new Random());

        public MusicPlayer(Main m)
        {
            parent = m;
            InitializeComponent();
        }

        public Main parent;
        public SoundPlayer player = new SoundPlayer();

        public Boolean shuffle = true;

        public CancellationTokenSource cancelSource = new CancellationTokenSource();
        public CancellationToken cancelToken = new CancellationToken();

        public List<UnmanagedMemoryStream> songs = new List<UnmanagedMemoryStream>();

        int cur = 0, max = 0;
        public Task musicThread;

        private void MusicPlayer_Load(object sender, EventArgs e)
        {
            // Can check for amount of files in future, but for now, it will not exceed 10 songs.
            for (int i = 0; i < 10; i++)
            {
                // Define it for code cleaness
                UnmanagedMemoryStream ums = Properties.Resources.ResourceManager.GetStream("m" + i);
                if(ums!= null) {
                    songs.Add(ums); 
                } else {
                    continue;
                }
            }

            if (songs.Count > 0)
            {
                // Max will be the count of the array
                max = songs.Count;
                
                // Update debug stat
                trackLabel.Text = "Current Track: " + (cur + 1) + "/" + max;

                // Load first song in list
                player.Stream = songs[cur];
                
                // Start
                start();
            }
        }

        public void start()
        {
            // Hopefully a way to cancel the music from settings?
            cancelToken = cancelSource.Token;

            // Allow songs to play concurrently
            musicThread = Task.Factory.StartNew(() => play(SongFinished), cancelToken);

        }

        public void play(EventHandler callback = null)
        {
            using (player)
            {
                player.PlaySync();
            }

            if (callback != null)
            {
                callback(this, new EventArgs());
            }
        }


        private void SongFinished(object sender, EventArgs e)
        {
            player.Stop();
            if (!shuffle)
            {
                // Ascend the list
                cur++;
                if (cur >= max)
                {
                    cur = 0;
                }
            }
            else
            {
                // Choose a song from random
                cur = rand.Value.Next(0, max - 1);
            }

            // update debug
            trackLabel.Text = "Current Track: " + (cur + 1) + "/" + max;

            // select the song
            player.Stream = songs[cur];

            // play
            start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // debug timer

            // flip isCompleted to show playing state. If it isnt completed; its playing.
            if (musicThread != null)
            {
                playLabel.Text = "Is Playing?: " + !musicThread.IsCompleted;
                if (musicThread.IsCompleted)
                {
                    // How do I stop the thread from being 'completed'?
                    // This will stop once the list has been reset to 0..
                    musicThread.Dispose();
                    musicThread = null;
                    start();
                }
            }
        }

        
    }
}
