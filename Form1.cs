using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsElements
{
    public partial class Form1 : Form
    {
        TreeView tree;
        Button btn;
        Label lbl;
        PictureBox img;
        public Form1()
        {
            this.Height = 400;
            this.Width = 500;
            this.Text ="Elements form";
            //this.BackgroundImage = "bg.jpg";//
            this.BackColor = Color.Green;
            tree = new TreeView();
            tree.Dock =DockStyle.Left;
            tree.AfterSelect += Tree_AfterSelect;
            TreeNode tn = new TreeNode("Elements");
            tn.Nodes.Add(new TreeNode("Button"));
            tn.Nodes.Add(new TreeNode("Silt-Label"));
            tn.Nodes.Add(new TreeNode("PictureBox"));
            tn.Nodes.Add(new TreeNode("Märkeruut-CheckBox"));
            tn.Nodes.Add(new TreeNode("Radionupp-Radiobutton"));
            tn.Nodes.Add(new TreeNode("Tekstkast-Textbox"));
            tn.Nodes.Add(new TreeNode("Kaart-TabControl"));
            tn.Nodes.Add(new TreeNode("MessageBox"));

            //------------------------------------------------//
            //Button
            btn = new Button();
            btn.Text = "Don't click that button!";
            btn.Location = new Point(250, 20);
            btn.Height = 20;
            btn.Width = 100;
            btn.Click += Btn_Click;

            //Silt Label
            lbl = new Label();
            lbl.Text = "Elementide loomine c# abil";
            lbl.Size = new Size(300, 30);
            lbl.Location = new Point(250, 50);
            lbl.MouseHover += Lbl_MouseHover;
            lbl.MouseLeave += Lbl_MouseLeave;

            //PictureBox
            img = new PictureBox();
            img.Size = new Size(100,100);
            img.Location = new Point(250,60);
            img.SizeMode = PictureBoxSizeMode.StretchImage;
            img.Image = Image.FromFile(@"..\..\Images\park1.jpg");
            img.Image = Image.FromFile(@"..\..\Images\park2.jpg");
            img.Image = Image.FromFile(@"..\..\Images\park3.jpg");
            img.Image = Image.FromFile(@"..\..\Images\park4.jpg");
            img.MouseDoubleClick += img_MouseDoubleClick;

            //-----------------------------------------------//

            tree.Nodes.Add(tn);
            this.Controls.Add(tree);

            //-----------------------------------------------//
        }

       //private void img_MouseDoubleClick(object sender, MouseEventArgs e)
       //{
       //    PictureBox img = newPictureBox();
       //    img.Width = 400;
       //    img.Height = 400;
       //    Bitmap image = newBitmap("bg.jpg");
       //    img.Dock = DockStyle.Fill;
       //    img.Image = (Image)image;
       //    Controls.Add(img);
       //}

        private void Lbl_MouseLeave(object sender, EventArgs e)
        {
            lbl.BackColor = Color.Transparent;
        }

        private void Lbl_MouseHover(object sender, EventArgs e)
        {
            lbl.BackColor = Color.FromArgb(200,100,50);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text=="Button")
            {
                this.Controls.Add(btn);
            }

            else if (e.Node.Text == "Silt-Label")
            {
                this.Controls.Add(lbl);
            }

            else if (e.Node.Text == "Images")
            {

            }
        }
    }
}
