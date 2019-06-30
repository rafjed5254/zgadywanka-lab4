using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;

namespace GraGUI
{
    public partial class Form1 : Form
    {
        private Gra g;
        
        public Form1()
        {
            InitializeComponent();            
        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            groupBoxLosuj.Visible = true;
            buttonNowaGra.Enabled = false;
            groupBoxLosuj.Enabled = true;
            buttonLosuj.Enabled = true;
            textBoxZakresDo.Text = "";
            textBoxZakresOd.Text = "";
            textBoxZakresDo.Enabled = true;
            textBoxZakresOd.Enabled = true;
            textSprawdz.Enabled = true;
            textSprawdz.Text = "";
            buttonSprawdz.Enabled = true;
            textBoxSprawdz.Text = "";
        }

        private void buttonLosuj_Click(object sender, EventArgs e)
        {
            textSprawdz.Text = "";
            string test1 = textBoxZakresOd.Text;
            string test2 = textBoxZakresDo.Text;
            if (string.IsNullOrEmpty(test1) || string.IsNullOrEmpty(test2))
            {
                string message = "Podaj prawidłowy zakres!";
                string title = "UWAGA";
                DialogResult result = MessageBox.Show(message, title);
                textBoxZakresDo.Text = null;
                textBoxZakresOd.Text = null;
            }
            else
            {
                int num = -1;
                if (!int.TryParse(test1, out num) || !int.TryParse(test2, out num))
                {
                    string message = "Podaj prawidłowy zakres!";
                    string title = "UWAGA";
                    DialogResult result = MessageBox.Show(message, title);
                    textBoxZakresDo.Text = null;
                    textBoxZakresOd.Text = null;
                }
                else
                {
                    int a = int.Parse(textBoxZakresOd.Text);
                    int b = int.Parse(textBoxZakresDo.Text);

                    g = new Gra(a, b);

                    buttonLosuj.Enabled = false;
                    textBoxZakresOd.Enabled = false;
                    textBoxZakresDo.Enabled = false;
                    groupBox1.Visible = true;

                    string wyn = Convert.ToString(g.Wylosowana);

                    
                }

            }

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ButtonSprawdz_Click(object sender, EventArgs e)
        {
            string test3 = textSprawdz.Text;
            if (string.IsNullOrEmpty(test3))
            {
                string message = "Podaj liczbę";
                string title = "UWAGA";
                DialogResult result = MessageBox.Show(message, title);
            }
            else
            {
                int c = int.Parse(textSprawdz.Text);
                string wynik = Convert.ToString(g.Ocena(c));
                if (wynik == "ZaMalo") wynik = "Za Mało, podaj większą liczbę.";
                else if (wynik == "ZaDuzo") wynik = "Za Dużo, podaj mniejszą liczbę.";
                else
                {
                    wynik = "";
                    textSprawdz.Enabled = false;
                    buttonSprawdz.Enabled = false;
                    string wyn = textSprawdz.Text;

                    string message = "Brawo zgadłeś wylosowaną liczbę: " + wyn + ". Czy chcesz zagrać jeszcze raz?";
                    string caption = "Wygrałeś!!!!";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

                    
                    if (result == DialogResult.Yes)
                    { 
                        buttonNowaGra.Enabled = true;
                        groupBoxLosuj.Visible = false;
                        groupBox1.Visible = false;
                        groupBoxLosuj.Visible = true;
                        buttonNowaGra.Enabled = false;
                        groupBoxLosuj.Enabled = true;
                        buttonLosuj.Enabled = true;
                        textBoxZakresDo.Text = "";
                        textBoxZakresOd.Text = "";
                        textBoxZakresDo.Enabled = true;
                        textBoxZakresOd.Enabled = true;
                        textSprawdz.Enabled = true;
                        textSprawdz.Text = "";
                        buttonSprawdz.Enabled = true;
                        textBoxSprawdz.Text = " ";
                        
                    }
                    else
                    {
                        wynik = "Wygrałeś. Zakończ lub Zamknij z grę.";
                    }
                }
                textBoxSprawdz.Text = wynik; 
            }
        }

        private void ButtonZakoncz_Click(object sender, EventArgs e)
        {
            buttonNowaGra.Enabled = true;
            groupBoxLosuj.Visible = false;
            groupBox1.Visible = false;
        }

        private void ButtonWyjdz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
