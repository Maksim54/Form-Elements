using Microsoft.VisualBasic;
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
        CheckBox box_lbl, box_btn;
        CheckBox c_btn1, c_btn2;
        bool t = true;
        RadioButton r_btn1, r_btn2;
        
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
            img.Image = Image.FromFile(@"..\..\allo.png");
            img.Image = Image.FromFile(@"..\..\bf.jpg");
            img.Image = Image.FromFile(@"..\..\pixel.png");
            img.Image = Image.FromFile(@"..\..\petyx.png");
            img.DoubleClick += Img_DoubleClick;

            //-----------------------------------------------//

            c_btn1 = new CheckBox();
            c_btn1.Text = "vali mind";
            c_btn1.Size = new Size(c_btn1.Text.Length * 9,20);
            c_btn1.Location = new Point(300, 300);
            c_btn1.CheckedChanged += C_btn1_CheckedChanged;
            c_btn2 = new CheckBox();
            c_btn2.Size = new Size(100, 100);

            c_btn2.Image = Image.FromFile(@"..\..\pixel.png");
            c_btn2.Location = new Point(300, 350);

            //-----------------------------------------------//

            tree.Nodes.Add(tn);
            this.Controls.Add(tree);

            //-----------------------------------------------//
        }
       int Click = 0;
       private void Img_DoubleClick(object sender, EventArgs e)
       {
            string[] images = { "park1.jpg", "park2.jp", "park3.jpg" };
            string fail = images[Click];
            img.Image = Image.FromFile(@"..\..\" + fail);
            Click++;
            if (Click==3)
            {
                Click = 0;
            }
        }

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

        private void Box_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (box_btn.Checked)
            {
                Controls.Add(btn);
            }
            else
            {
                Controls.Remove(btn);
            }
        }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Button")
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
            else if (e.Node.Text == "Märkeruut-CheckBox")
            {
                this.Controls.Add(c_btn1);
                this.Controls.Add(c_btn2);
            }

            else if (e.Node.Text == "Radionupp")
            {
                r_btn1 = new RadioButton();
                r_btn1.Text = "Black theme";
                r_btn1.Location = new Point(300, 150);
                r_btn2.Text = "White theme";
                r_btn2 = new RadioButton();
                this.Controls.Add(r_btn1);
                this.Controls.Add(r_btn2);
                r_btn1.CheckedChanged += new EventHandler(r_btn_Checked);
            }

            else if (e.Node.Text == "Messagebox")
            {
                MessageBox.Show("MessageBox", "oh hello there!");
                var answer = MessageBox.Show("Want to see inputbox?","window with button",
                    MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    string text = Interaction.InputBox("Write here your text", "InputBox", "some text");
                    if (MessageBox.Show("Do you want to send that text to textbox?", "Text filling", MessageBoxButtons.OKCancel)
                        == DialogResult.OK)
                    {
                        lbl.Text = text;
                        Controls.Add(lbl);
                    }
                    else
                    {
                        lbl.Text = "So i would like to choose my text!";
                        Controls.Add(lbl);
                    }
                }
                else
                {
                    MessageBox.Show("One more message", "The easiest window");
                }
            }
        }

        private void r_btn_Checked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void C_btn1_CheckedChanged(object sender, EventArgs e)
            {
                if (t)
                {
                    this.Size = new Size(400,500);
                    img.BorderStyle = BorderStyle.Fixed3D;
                    c_btn1.Text = "teeme väiksem suurus";
                    c_btn1.Font = new Font("Arial", 36, FontStyle.Bold);
                    t = false;
                }
                else
                {
                    this.Size = new Size(700, 500);
                    c_btn1.Text = "Suurendame";
                    c_btn1.Font = new Font("Arial", 36, FontStyle.Regular);
                    t = true;
                }
            }
        }
}
