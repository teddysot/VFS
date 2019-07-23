using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ToolRunner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void colorLabel_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string output = $"Username is {nameTextBox.Text}" + Environment.NewLine
                           + $"Favourite Color is {colorTextBox.Text}";

            outputTextBox.Text = output;
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            progressBar.Value = trackBar.Value;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            trackBar.Value = 0;
        }

        private void colorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void instructionLabel_Click(object sender, EventArgs e)
        {

        }

        private void selectImageButton_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox.BackgroundImage = new Bitmap(open.FileName);
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void mayaButton_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Maya File(*.ma)|*.ma";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string file = ".\\log.xml";
                XmlTextWriter writer = new XmlTextWriter(file, null);
                writer.WriteStartDocument();
                writer.WriteStartElement("Log");
                writer.WriteString(open.ToString());
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
        }
    }
}
