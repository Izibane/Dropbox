using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dropbox;
using Dropbox.Misc;

namespace Dropbox.Forms
{
    public partial class Settings : Form
    {

        public static Boolean musicEnabled = true;
        public static int startingDifficulty = 2, minLength = 55, maxLength = 120;

        public static String name = "User";

        public Theme theme = Theme.NONE;

        private Main parent;

        public Settings(Main m)
        {
            this.parent = m;
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            musicEnabled = checkBox1.Checked;
            if (!musicEnabled)
            {
                parent.getMusicPlayer().cancelSource.Cancel();
                parent.getMusicPlayer().Close();
                parent.getMusicPlayer().Dispose();
            }
            else
            {
                parent.setMusicPlayer(new MusicPlayer(parent));
                parent.getMusicPlayer().start();
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            difficultyBox.Text = "" + startingDifficulty;
            minWidthBox.Text = "" + minLength;
            maxWidthBox.Text = "" + maxLength;
        }

        private void difficultyBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
               startingDifficulty =  Convert.ToInt16(difficultyBox.Text);
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void maxWidthBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                maxLength = Convert.ToInt16(maxWidthBox.Text);
                if (maxLength < minLength)
                {
                    maxLength = minLength;
                    maxWidthBox.Text = "" + minLength;
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }


        public int getMinLength()
        {
            return minLength;
        }

        public int getMaxLength()
        {
            return maxLength;
        }

        public int getStartingDifficulty()
        {
            return startingDifficulty;
        }

        private void minWidthBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                minLength = Convert.ToInt16(minWidthBox.Text);
                if (minLength > maxLength)
                {
                    minLength = maxLength;
                    minWidthBox.Text = "" + minLength;
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {
            name = nameInput.Text;
        }

        public String getName()
        {
            return name;
        }

        internal Theme getTheme()
        {
            return theme;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            theme = (Theme)Enum.GetValues(typeof(Theme)).GetValue(comboBox1.SelectedIndex);
        }
    }

}
