using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multimediaplayer
{
    public partial class Form1 : Form
    {
        string[] files, path;
        public Form1()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog1.SafeFileNames;
                path = openFileDialog1.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    Playlist.Items.Add(files[i]);
                }
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = path[Playlist.SelectedIndex];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tUM-Player\nDeveloped by Umair Munir Ahmad", "Credits");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}