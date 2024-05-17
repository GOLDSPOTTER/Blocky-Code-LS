using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LS
{
    public partial class ProjectEditor : Form
    {
        PictureBox[] pictures = new PictureBox[4];
        List<string> blocks = new List<string>();

        public ProjectEditor()
        {
            InitializeComponent();

            // The 4 here is dependent on how many rows in the table
            for (int i = 0; i < 4; i++)
            {
                pictures[i] = new PictureBox();
                pictures[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pictures[i].AllowDrop = true;
                pictures[i].DragEnter += new DragEventHandler(pictures_DragEnter);
                pictures[i].DragDrop += new DragEventHandler(pictures_DragDrop);
                pictures[i].MouseDown += new MouseEventHandler(codeBlock_MouseDown);
                tblCodeArea.Controls.Add(pictures[i]);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void codeBlock_MouseDown(object sender, MouseEventArgs e)
        {
            // Defines sender as a PictureBox so we can use it
            PictureBox codeBlock = sender as PictureBox;

            // Ensure the PictureBox has an image to drag
            if (codeBlock != null && codeBlock.Image != null)
            {
                // Define a data object and store the image and the tag
                DataObject dragImage = new DataObject();
                dragImage.SetData(DataFormats.Bitmap, true, codeBlock.Image);
                dragImage.SetData(DataFormats.Text, true, codeBlock.Tag);

                // Copies the data object as we drag
                DoDragDrop(dragImage, DragDropEffects.Copy);
            }
        }

        private void pictures_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictures_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox picture = sender as PictureBox;

            if (picture != null)
            {
                picture.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
                picture.Tag = e.Data.GetData(DataFormats.Text);

                lblList.Text = "";
                blocks.Clear();

                for (int i = 0; i < 4; i++)
                {
                    // Check if the Tag is not null before accessing it
                    if (pictures[i].Tag != null)
                    {
                        blocks.Add(pictures[i].Tag.ToString());

                        if (blocks[i].Contains("For"))
                        {
                            lblList.Text += "Initiate a For Loop here\n";
                        }
                        else if (blocks[i].Contains("When"))
                        {
                            lblList.Text += "Handle a click event here\n";
                        }
                    }
                }
            }
        }
    }
}
