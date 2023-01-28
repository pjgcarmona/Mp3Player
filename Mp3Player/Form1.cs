using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mp3Player
{
    public partial class Mp3Player : Form
    {
        public Mp3Player()
        {
            InitializeComponent();
        }

        //Arrays to song titles and paths
        String[] paths, files;

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            //Code to select songs
            OpenFileDialog ofd = new OpenFileDialog();
            //Code to select multiple files
            ofd.Multiselect= true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //Save the names in files[]
                paths = ofd.FileNames; //Save the paths in patsh[]

                //Display the titles in Listbox
                for (int i = 0;i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]); //Display songs in listbox
                }

            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Code to play songs
            axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];

        }

        private void axWindowsMediaPlayerMusic_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //code to close
            this.Close();

        }
    }
}
