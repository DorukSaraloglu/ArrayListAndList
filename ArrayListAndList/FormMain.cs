using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListAndList
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            // System.Array
            int[] Numbers = new int[5];
            Numbers[0] = 10;
            Numbers[1] = 12;
            Numbers[2] = 18;
            Numbers[3] = 25;
            Numbers[4] = 61;
            lbxData.Items.Clear();
            foreach (int number in Numbers)
            {
                lbxData.Items.Add(number);
            }
        }

        private void btnArrayList_Click(object sender, EventArgs e)
        {
            ArrayList ary = new ArrayList();
            ary.Add(1);
            ary.Add(12.25);
            ary.Add(15);
            ary.Add(11);
            ary.Add("Şamil");
            ary.Add("Burcu");
            lbxData.Items.Clear();

            //  ArrayDizi.Remove(15);
            ary.RemoveAt(2);
            foreach (object element in ary)
            {
                lbxData.Items.Add(element);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<string> List = new List<string>();

            List.Add("01");
            List.Add("11");
            List.Add("8.2");
            List.Add("14");
            List.Add("DB");
            lbxData.Items.Clear();
            foreach (var element in List)
            {
                lbxData.Items.Add(element);
            }
        }

        

        private void btnList2_Click(object sender, EventArgs e)
        {


            Button btn = (Button)sender;
            if (btn.Name == "btn0")
            {
                MessageBox.Show("Birinci butona tiklandi.");
            }
            else
            {
                MessageBox.Show("Tiklanan buton numarasi : " + btn.Tag);
            }

        }
        private List<Button> Buttons = new List<Button>();

        
        private void btnButtons_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            Buttons.Clear();

            for (int i = 0; i < 7; i++)
            {
                Button btn = new Button();
                btn.Text = ("Görev" + i).ToString();
                btn.Name = "btn" + i;
                btn.Tag = i;
                btn.Click += new EventHandler(btnList2_Click);
                Buttons.Add(btn);

                flowLayoutPanel.Controls.Add(Buttons[i]);
                //  lstData.Items.Add(Dugmeler[i].Text);

            }

            MessageBox.Show(Buttons.Count + " yeni buton eklendi.");
            btnColorize.Show();


        }

        private void btnColorize_Click(object sender, EventArgs e)
        {
            int Blue = 30;
            foreach (Button b in Buttons)
            {
                //b.BackColor = Color.FromArgb( b.BackColor.R, b.BackColor.G, Mavi );
                //b.BackColor = Color.FromArgb( 128, 128, Mavi );
                b.BackColor = Color.FromArgb(Blue / 4, Blue / 4, Blue);
                Blue += 30;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
