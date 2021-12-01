using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        RadioButton rad;
        RadioButton rad2;
        TabPage tabPage1, tabPage2, tabPage3;
        TabControl tabc;
        TabControl tabC;
        ListBox list;
        TextBox txt;
        DataGridView dgrid;
        public Form1()
        {
          //----------------------------------------------------------\\
            //                                                         \\
            this.Height = 450;//                                        \\
            this.Width = 800;//                                          \\
            this.Text ="Elements form";//                                 \\
            //this.BackgroundImage = "bg.jpg";                             \\
            this.BackColor = Color.Green;//                                 \\
            tree = new TreeView();//                                         \\
            tree.Dock =DockStyle.Left;//                                      \\
            tree.AfterSelect += Tree_AfterSelect;//                            \\
            TreeNode tn = new TreeNode("Elements");                            //
            tn.Nodes.Add(new TreeNode("Button"));                             //
            tn.Nodes.Add(new TreeNode("Silt-Label"));                        //
            tn.Nodes.Add(new TreeNode("PictureBox"));                       //
            tn.Nodes.Add(new TreeNode("Märkeruut-CheckBox"));              //
            tn.Nodes.Add(new TreeNode("Radionupp-Radiobutton"));          //
            tn.Nodes.Add(new TreeNode("Tekstkast-Textbox"));             //
            tn.Nodes.Add(new TreeNode("Kaart-TabControl"));             //
            tn.Nodes.Add(new TreeNode("MainMenu"));                    //
            tn.Nodes.Add(new TreeNode("MessageBox"));                 //
            tn.Nodes.Add(new TreeNode("Listbox"));                   //
            tn.Nodes.Add(new TreeNode("DataGridView"));             //
            //-----------------------------------------------------//
            //                                                     \\
            //Button                                                \\
            btn = new Button();//                                    \\
            btn.Text = "Don't click that button!"; //                 \\
            btn.Location = new Point(310, 20);     //                  \\
            btn.Height = 20;                                           //
            btn.Width = 100;                                          //
            btn.Click += Btn_Click;                                  //
                                                                    //
          //-------------------------------------------------------//
            //                                                     \\
            //Silt Label                                            \\
            lbl = new Label();//                                     \\
            lbl.Text = "Elementide loomine c# abil";//                \\
            lbl.Size = new Size(300, 30);//                            \\
            lbl.Location = new Point(250, 50);                         //
            lbl.MouseHover += Lbl_MouseHover;                         //
            lbl.MouseLeave += Lbl_MouseLeave;                        //
                                                                    //
          //-------------------------------------------------------//
            //                                                     \\
            //PictureBox                                            \\
            img = new PictureBox();//                                \\
            img.Size = new Size(100,100);//                           \\
            img.Location = new Point(250,60);//                        \\
            img.SizeMode = PictureBoxSizeMode.StretchImage;//           \\
            img.Image = Image.FromFile(@"..\..\allo.png");              //
            img.Image = Image.FromFile(@"..\..\bf.jpg");               //
            img.Image = Image.FromFile(@"..\..\pixel.png");           //
            img.Image = Image.FromFile(@"..\..\petyx.png");          //
            img.DoubleClick += Img_DoubleClick;                     //
                                                                   //
          //------------------------------------------------------//
            //                                                    \\
            //CheckBox                                             \\
            c_btn1 = new CheckBox();//                              \\
            c_btn1.Text = "vali mind";//                             \\
            c_btn1.Size = new Size(c_btn1.Text.Length * 9,20);//      \\
            c_btn1.Location = new Point(300, 300);//                   \\
            c_btn1.CheckedChanged += C_btn1_CheckedChanged;//           \\
            c_btn2 = new CheckBox();//                                   \\
            c_btn2.Size = new Size(100, 100);                            //
                                                                        //
            c_btn2.Image = Image.FromFile(@"..\..\pixel.png");         //
            c_btn2.Location = new Point(300, 350);                    //
                                                                     //
          //--------------------------------------------------------//
         //                                                         \\
        //                                                        \\
       //                                                        \\
                                                                      //
                                                                     //
            //------------------------------------------------------//
            txt = new TextBox();
            txt.Size = new Size(75,25);
            txt.Location = new Point(70,225);
            txt.Font = new Font("Georgia",12);

            rad = new RadioButton();
            rad.Size = new Size(40, 25);
            rad.Location = new Point(150, 190);
            rad.Text = "1";
            rad.Click += Rad_Click; ;

            rad2 = new RadioButton();
            rad2.Size = new Size(40, 25);
            rad2.Location = new Point(150, 225);
            rad2.Text = "2";
            rad2.Click += Rad_Click2; ;

            tree.Nodes.Add(tn);
            this.Controls.Add(tree);
        }
       int Click = 0;
       private void Img_DoubleClick(object sender, EventArgs e)
       {
            string[] images = { "allo.png", "bf.jpg", "pixel.png" };
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
            if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.Red;
                lbl.BackColor = Color.Green;
                lbl.ForeColor = Color.White;
            }
            else
            {
                btn.BackColor = Color.Blue;
                lbl.BackColor = Color.White;
                lbl.ForeColor = Color.Green;
                this.Close();
            }
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

            else if (e.Node.Text == "Kaart-TabControl")
            {
                tabC = new TabControl();
                tabC.Location = new Point(500, 220);
                tabC.Size = new Size(250, 200);
                TabPage tabP1 = new TabPage("Esimene");//Заголовок вкладки. Создали вкладку
                WebBrowser wb = new WebBrowser();
                wb.Url = new Uri("https://www.tthk.ee/");
                tabP1.Controls.Add(wb);


                TabPage tabP2 = new TabPage("Teine");//Заголовок вкладки. Создали вкладку
                WebBrowser wb2 = new WebBrowser();
                wb2.Url = new Uri("https://github.com/NikitaRimitsen/");
                tabP2.Controls.Add(wb2);

                TabPage tabP3 = new TabPage("Kolmas");//Заголовок вкладки. Создали вкладку
                WebBrowser wb3 = new WebBrowser();
                wb3.Url = new Uri("https://www.youtube.com/");
                tabP3.Controls.Add(wb3);

                TabPage tabP4 = new TabPage("Neljas");//Заголовок вкладки. Создали вкладку
                tabP4.DoubleClick += TabP4_DoubleClick;
                tabC.DoubleClick += TabC_DoubleClick;

                //tabC.Selected += TabC_Selected;//Создали функцию, которая закрывает все вкладки, если нажать на вкладку

                tabC.Controls.Add(tabP1);
                tabC.Controls.Add(tabP2);
                tabC.Controls.Add(tabP3);
                tabC.Controls.Add(tabP4);
                this.Controls.Add(tabC);
            }

            else if (e.Node.Text == "Märkeruut-CheckBox")
            {
                box_btn = new CheckBox();
                box_btn.Text = "Näita nupp";
                box_btn.Location = new Point(200, 30);
                this.Controls.Add(box_btn);
                box_lbl = new CheckBox();
                box_lbl.Text = "Näita silt";
                box_lbl.Location = new Point(200, 70);
                this.Controls.Add(box_lbl);
                box_btn.CheckedChanged += Box_btn_CheckedChanged;
            }

            else if (e.Node.Text == "TextBox")
            {
                this.Controls.Add(txt);
            }

            else if (e.Node.Text == "ListBox")
            {
                this.Controls.Add(list);
            }

            else if (e.Node.Text == "MainMenu")
            {
                MainMenu menu = new MainMenu();
                MenuItem mf = new MenuItem("File");
                mf.MenuItems.Add("Exit", new EventHandler(menuFile_Select));
                mf.MenuItems.Add("Image", new EventHandler(menuFile_Select2));
                mf.MenuItems.Add("Full sized", new EventHandler(menuFile_Select3));
                mf.MenuItems.Add("Minimized", new EventHandler(menuFile_Select4));
                menu.MenuItems.Add(mf);
                this.Menu = menu;
            }

            else if (e.Node.Text == "DataGridView")
            {
                DataSet ds = new DataSet("XML fail.menuu");
                ds.ReadXml(@"..\..\menu.xml");
                DataGridView dg = new DataGridView();
                dg.Width = 300;
                dg.Height = 160;
                dg.Location = new Point(150,250);
                dg.AutoGenerateColumns = true;
                dg.DataSource = ds;
                dg.DataMember = "food";
                this.Controls.Add(dg);
            }

            else if (e.Node.Text == "MessageBox")
            {
                MessageBox.Show("MessageBox", "Самое обычное окно");
                var answer = MessageBox.Show("Хочешь посмотреть какая сегодня погода?", "Погода", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    Process.Start("https://pogoda.ee/");

                    string text = Interaction.InputBox("Напиши своё впечатление о погоде", "InputBox", "Mingi tekst");
                    if (MessageBox.Show("Kas tahad tekst saada Tekskastisse?", "Teksti salvestamine", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        lbl.Text = text;
                        Controls.Add(lbl);
                    }
                    else
                    {
                        MessageBox.Show("Ты меня расстраиваешь", "Грустное окно");

                    }
                }
                else
                {
                    MessageBox.Show("Ты меня расстраиваешь", "Грустное окно");
                }
            }
        }

        private void menuFile_Select3(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void menuFile_Select4(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void menuFile_Select2(object sender, EventArgs e)
        {
            img.Image = Image.FromFile(@"../../pixel.png");
        }

        private void menuFile_Select(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TabC_DoubleClick(object sender, EventArgs e)
        {
            this.tabC.TabPages.Remove(tabC.SelectedTab);
        }

        private void TabP4_DoubleClick(object sender, EventArgs e)
        {
            string title = "tabP" + (tabC.TabCount + 1).ToString();
            TabPage tb = new TabPage(title);
            tabC.TabPages.Add(tb);
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (list.SelectedIndex)
            {
                case 0:
                    list.BackColor = Color.Green;
                    break;
                case 1:
                    list.BackColor = Color.Red;
                    break;
                case 2:
                    list.BackColor = Color.Yellow;
                    break;
                case 3:
                    list.BackColor = Color.Orange;
                    break;
                case 4:
                    list.BackColor = Color.Violet;
                    break;
                default:
                    list.BackColor = Color.Transparent;
                    break;
            }

        }

        private void menuFile_Exit_Select(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tabc_DoubleClick(object sender, EventArgs e)
        {
            string title = "tabPage" + (tabc.TabCount + 1).ToString();
            TabPage tb = new TabPage(title);
            tabc.TabPages.Add(tb);
        }

        private void Tabc_Selected(object sender, TabControlEventArgs e)
        {
            this.tabc.TabPages.Clear();
            this.tabc.TabPages.Remove(tabc.SelectedTab);
        }

        private void TabPage3_DoubleClick(object sender, EventArgs e)
        {
            string title = "tabPage" + (tabc.TabCount + 1).ToString();
            TabPage tb = new TabPage(title);
            tabc.TabPages.Add(tb);
        }

        private void Rad_Click(object sender, EventArgs e)
        {
            tree.BackColor = Color.Black;
            tree.ForeColor = Color.White;
        }
        private void Rad_Click2(object sender, EventArgs e)
        {
            tree.BackColor = Color.White;
            tree.ForeColor = Color.Black;
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

    internal class Interaction
    {
        internal static string InputBox(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }
    }
}