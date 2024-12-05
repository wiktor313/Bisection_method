using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NCalc;

namespace Metoda_bisekcji
{
    public partial class Form1 : Form
    {
        public static List<double> xValues = new List<double>();
        public static List<double> yValues = new List<double>();
        double a;
        double b;
        double eps;
        double skok;
        string wzorF;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericEps.Increment = 0.001M; //Zmiana skoku dla numericEps.
            numericDokladnosc.Increment = 0.01M;
            ToolKid_Ustawienia(); //Wprowadza podpowiedzi dla NumericUpDown.
            Wyczysc_liste();
        }

        private void button1_Click(object sender, EventArgs e) //Przycisk wyznacz.
        {

            if (PoprawnoscWprowadzania())
            {
                if (Sprawdz_funkcje(wzorF))
                {
                    if (Bisekcja(a, b, eps))
                    {
                        if(((Math.Abs(a)+Math.Abs(b))/skok)<5000)
                        {
                            Wyznaczanie_wykresu(wzorF, a, skok, b);
                            Form2 frm = new Form2();  //Tworzenie nowego forms'a z wykresem.
                            frm.ShowDialog(); //Wyświetla nowego forms'a z wykresem.
                        }
                        else
                        {
                            MessageBox.Show("Zbyt duża liczba współrzędnych dla wykresu (spróbuj zmniejszyć dokładność).");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wprowadź poprawnie funkcję (patrz \"Pomoc\").");
                }
            }
            else
            {
                MessageBox.Show("Wprowadź poprawne dane (patrz \"Pomoc\").");
            }
             Wyczysc_liste(); //funkcja sprwadzenia błędu.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)  //Przycisk zamknij.
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }

        bool PoprawnoscWprowadzania()
        {
            try
            {
                if ((Convert.ToDouble(numericEps.Value)) > 0 && (Convert.ToDouble(numericDokladnosc.Value)) > 0 && (Convert.ToDouble(numericA.Value)< Convert.ToDouble(numericB.Value)))
                {
                    wzorF = textBox1.Text.ToString();
                    a = Convert.ToDouble(numericA.Value);
                    b = Convert.ToDouble(numericB.Value);
                    skok = Convert.ToDouble(numericDokladnosc.Value);
                    eps = Convert.ToDouble(numericEps.Value);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        void Wyznaczanie_wykresu(string wzor, double sx_start, double sx_jmp, double sx_end)
        {

            double x_start = sx_start;
            double x_jmp = sx_jmp;
            double x_end = sx_end;

            wzor = wzor.Replace("X", "x"); // zmiana duzych X na male x
            wzor = wzor.Replace("E", "e");
            wzor = wzor.Replace("e", "2.718281");

            try
            {
                int counter = 0;

                while (x_start <= x_end)
                {
                    xValues.Add(x_start);
                    string tmp = wzor;
                    string tmp2 = xValues[counter].ToString();      //Zamiana wartości x na String, aby móc zamienić niewiadomoą x na wartość ze zmiennej xValues[counter].
                    tmp2 = tmp2.Replace(",", ".");                 //Zamiana przecinków na kropki.
                    tmp = tmp.Replace("x", tmp2);                 //Zamiana niewiadomej x na wartość ze zmiennej xValues[counter].

                    var parsedExpression = new Expression(tmp);
                    var result = parsedExpression.Evaluate();

                    double y = Convert.ToDouble(result);
                    yValues.Add(y);

                    x_start = x_start + x_jmp;
                    counter++;
                }
            }
            catch
            {
                MessageBox.Show("Błąd wyliczenia.");
            }


        }

        double LiczeniePunktu(string wzor, double punkt_x)
        {
            wzor = wzor.Replace("X", "x"); // zmiana duzych X na male x
            wzor = wzor.Replace("E", "e");
            wzor = wzor.Replace("e", "2.718281");
            string tmp = wzor;
            string tmp2 = punkt_x.ToString();
            tmp2 = tmp2.Replace(",", ".");
            tmp = tmp.Replace("x", tmp2);

            var parsedExpression = new Expression(tmp);
            var result = parsedExpression.Evaluate();

            double y = Convert.ToDouble(result);
            return y;
        }

        bool Sprawdz_funkcje(string wzor)
        {
            try 
            {
                string f = wzor;
                if(f.Contains("^")) { return false; }
                f = f.Replace("X", "x"); // zmiana duzych X na male x
                f = f.Replace("E", "e");
                f = f.Replace("e", "2.718281");
                double tmp2 = 1;

                string tmp = f;
                string tmp3 = tmp2.ToString();
                tmp = tmp.Replace("x", tmp3);

                var parsedExpression = new Expression(tmp);
                var result = parsedExpression.Evaluate();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        bool Bisekcja(double poc, double kon, double epsi)
        {

            double poczatek = poc;
            double koniec = kon;
            double epsilon = epsi;

            double m = 0;

            int iteracja = 0;
            while (Math.Abs(poczatek - koniec) > epsilon)
            {
                iteracja++;
                m = (poczatek + koniec) / 2;
                if (LiczeniePunktu(wzorF, m) == 0)
                {
                    break;
                }
                else if ((LiczeniePunktu(wzorF, m) * LiczeniePunktu(wzorF, poczatek)) < 0)
                {
                    koniec = m;
                }
                else
                {
                    poczatek = m;
                }
            }
            if ((LiczeniePunktu(wzorF, poczatek) * LiczeniePunktu(wzorF, koniec)) >= 0)
            {
                MessageBox.Show("Funkcja nie spełnia warunków metody bisekcji.");
                MessageBox.Show("Najbliżej miejsca zerowego jest punkt: " + m.ToString() + ".\nZostało wyznaczone w " + iteracja.ToString() + " iteracji.");
                return false;
            }
            else
            {
                MessageBox.Show("Miejsca zerowego dla tego równiania to: " + m.ToString() + ".\nZostało wyznaczone" + " w " + iteracja + " iteracji.");
                return true;
            }
        }

        void ToolKid_Ustawienia() //Wprowadza podpowiedzi dla NumericUpDown
        {
            toolTip1.SetToolTip(numericA, "Wprowadź początkowy przedział izolacji pierwiastka.");
            toolTip2.SetToolTip(numericB, "Wprowadź końcowy przedział izolacji pierwiastka.");
            toolTip3.SetToolTip(numericEps, "Wprowadź epsilon (od 0.00001 do 1).");
            toolTip4.SetToolTip(label4, "Wprowadź funkcję, dla której będzie szukane miejsce zerowe, np Pow(x,2)-2. Więcej informacji - Pomoc");
        }

        void Wyczysc_liste()
        {
            for (int i = (Form1.xValues.Count() - 1); i >= 0; i--)
            {
                Form1.xValues.RemoveAt(i);
                Form1.yValues.RemoveAt(i);
            }
        }

    }
}
