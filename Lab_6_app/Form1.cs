using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Lab_6_app
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            l1.Visible = false;
            l2.Visible = false;
            lr.Visible = false;
            result.Visible = false;

            tb_1_1.Visible = false;
            tb_2_1.Visible = false;
            tb_1_2.Visible = false;
            tb_2_2.Visible = false;
        }
        /*
координатами центру і радіусом
діаметром
координатами центру і точки на колі
         */
        public void IsEverythingEntered()
        {
            switch (init_data.SelectedIndex)
            {
                case 0:
                    if (tb_1_1.Text.All(char.IsDigit) && tb_1_1.Text!="" && tb_1_2.Text.All(char.IsDigit) && tb_1_2.Text != "" && tb_2_1.Text.All(char.IsDigit) && tb_2_1.Text != "")
                    {
                        double[] p = { Convert.ToDouble(tb_1_1.Text), Convert.ToDouble(tb_1_2.Text) };
                        Circle c = new Circle(p, Convert.ToDouble(tb_2_1.Text));
                        switch (cb_find.SelectedIndex)
                        {
                            case 0:
                                result.Text = c.getS().ToString();
                                result.Visible = true;
                                lr.Visible = true;
                                break;
                            case 1:
                                result.Text = c.getL().ToString();
                                result.Visible = true;
                                lr.Visible = true;
                                break;
                            case 2:
                                result.Text = c.getV().ToString();
                                result.Visible = true;
                                lr.Visible = true;
                                break;
                        }
                    }
                    break;

                case 1:
                    if (tb_1_1.Text.All(char.IsDigit) && tb_1_1.Text != "")
                    {
                        Circle c = new Circle(Convert.ToDouble(tb_1_1.Text));
                        switch (cb_find.SelectedIndex)
                        {
                            case 0:
                                result.Text = c.getS().ToString();
                                result.Visible = true;
                                lr.Visible = true;
                                break;
                            case 1:
                                result.Text = c.getL().ToString();
                                result.Visible = true;
                                lr.Visible = true;
                                break;
                            case 2:
                                result.Text = c.getV().ToString();
                                result.Visible = true;
                                lr.Visible = true;
                                break;
                        }
                    }
                    break;
                case 2:
                    if (tb_1_1.Text.All(char.IsDigit) && tb_1_1.Text != "" && tb_1_2.Text.All(char.IsDigit) && tb_1_2.Text != "" && tb_2_1.Text.All(char.IsDigit) && tb_2_1.Text != "" && tb_2_2.Text.All(char.IsDigit) && tb_2_2.Text != "")
                    {
                        double[] p1 = { Convert.ToDouble(tb_1_1.Text), Convert.ToDouble(tb_1_2.Text) };
                        double[] p2 = { Convert.ToDouble(tb_2_1.Text), Convert.ToDouble(tb_2_2.Text) };
                        Circle c = new Circle(p1, p2);
                        switch (cb_find.SelectedIndex)
                        {
                            case 0:
                                result.Text = c.getS().ToString();
                                result.Visible = true;
                                lr.Visible = true;
                                break;
                            case 1:
                                result.Text = c.getL().ToString();
                                result.Visible = true;
                                lr.Visible = true;
                                break;
                            case 2:
                                result.Text = c.getV().ToString();
                                result.Visible = true;
                                lr.Visible = true;
                                break;
                        }
                    }
                    break;
            }
        }
        private void init_data_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (init_data.SelectedIndex) 
            {
                case 0:
                    l1.Visible = true;
                    l2.Visible = true;
                    tb_1_1.Visible = true;
                    tb_2_1.Visible = true;
                    tb_1_2.Visible = true;
                    tb_2_2.Visible = false;
                    l1.Text = "Enter Coords:";
                    l2.Text = "Enter Radius:";
                    break;
                case 1:
                    l1.Visible = true;
                    l2.Visible = false;
                    tb_1_1.Visible = true;
                    tb_2_1.Visible = false;
                    tb_1_2.Visible = false;
                    tb_2_2.Visible = false;
                    l1.Text = "Enter diameter:";

                    break;
                case 2:
                    
                     l1.Visible = true;
                    l2.Visible = true;
                    tb_1_1.Visible = true;
                    tb_2_1.Visible = true;
                    tb_1_2.Visible = true;
                    tb_2_2.Visible = true;
                    l1.Text = "Enter Coords Center:";
                    l2.Text = "Enter Coords on Circle:";
                    break;
            }
        }

        private void tb_1_1_TextChanged(object sender, EventArgs e)
        {
            IsEverythingEntered();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tb_1_2_TextChanged(object sender, EventArgs e)
        {
            IsEverythingEntered();
        }

        private void tb_2_1_TextChanged(object sender, EventArgs e)
        {
            IsEverythingEntered();
        }

        private void tb_2_2_TextChanged(object sender, EventArgs e)
        {
            IsEverythingEntered();
        }

        private void cb_find_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsEverythingEntered();
        }
    }
}
