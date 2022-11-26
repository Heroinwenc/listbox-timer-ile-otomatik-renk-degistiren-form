using System;
using System.Drawing;
using System.Windows.Forms;

namespace listbox_renk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        
        private void timer1_Tick(object sender, EventArgs e)
        {
           listBox1.SelectedIndex = rnd.Next(0, 6);
           label2.Text = listBox1.SelectedItem + " Seçildi";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.Text)
            {
                case "Mavi":
                    {
                        this.BackColor = Color.Blue;
                        break;
                    }
                case "Yeşil":
                    {
                        this.BackColor = Color.Green;
                        break;
                    }
                case "Kırmızı":
                    {
                        this.BackColor = Color.Red;
                        break;
                    }
                case "Sarı":
                    {
                        this.BackColor = Color.Yellow;
                        break;
                    }
                case "Mor":
                    {
                        this.BackColor = Color.Purple;
                        break;
                    }
                case "Gri":
                    {
                        this.BackColor = Color.Gray;
                        break;
                    }
            }
        }
    }
}
/**/