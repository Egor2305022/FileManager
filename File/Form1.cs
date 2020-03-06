using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using MetroFramework;
using MetroFramework.Components;

namespace File
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text[metroTextBox1.Text.Length - 1] == '\\') 
            {
                metroTextBox1.Text = metroTextBox1.Text.Remove(metroTextBox1.Text.Length - 1, 1); 
                while (metroTextBox1.Text[metroTextBox1.Text.Length - 1] != '\\')
                {
                    metroTextBox1.Text = metroTextBox1.Text.Remove(metroTextBox1.Text.Length - 1, 1);
                }
            }
            else if (metroTextBox1.Text[metroTextBox1.Text.Length - 1] != '\\')
            {
                while (metroTextBox1.Text[metroTextBox1.Text.Length - 1] != '\\')
                {
                    metroTextBox1.Text = metroTextBox1.Text.Remove(metroTextBox1.Text.Length - 1, 1);
                }
            }

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DirectoryInfo q = new DirectoryInfo(metroTextBox1.Text);
            DirectoryInfo[] w = q.GetDirectories();
            foreach (DirectoryInfo y in w)
            {
                listBox1.Items.Add(e);
            }
            FileInfo[] r = q.GetFiles();
            foreach (FileInfo t in r)
            {
                listBox1.Items.Add(t);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Path.GetExtension(Path.Combine(metroTextBox1.Text, listBox1.SelectedItem.ToString())) == "")
            {
                metroTextBox1.Text = Path.Combine(metroTextBox1.Text, listBox1.SelectedItem.ToString());
                listBox1.Items.Clear();
                DirectoryInfo q = new DirectoryInfo(metroTextBox1.Text);
                DirectoryInfo[] w = q.GetDirectories();
                foreach (DirectoryInfo y in w)
                {
                    listBox1.Items.Add(e);
                }
                FileInfo[] r = q.GetFiles();
                foreach (FileInfo t in r)
                {
                    listBox1.Items.Add(w);
                }

            }
            else
            {
                Process.Start(Path.Combine(metroTextBox1.Text, listBox1.SelectedItem.ToString()));
            }

        }
    }
}
