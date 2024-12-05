using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Metoda_bisekcji
{
    public partial class Form2 : Form
    {
        public Form2()
        {
                InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Edycja_Wykresu(); //Wprowadza dane do wykres i edytuje jego wygląd.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                zapis();
            }
            catch
            {
                MessageBox.Show("Błąd zapisu!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Wyczysc_wykres();
            Close();
        }
        void Edycja_Wykresu() //Wprowadza dane do wykres i edytuje jego wygląd.
        {

            chart1.ChartAreas[0].AxisX.LineWidth = 3; //Ustawia szerokość lini podziału osi X.
            chart1.ChartAreas[0].AxisY.LineWidth = 3; //Ustawia szerokość lini podziału osi Y.
            chart1.Series["Wykres"].Color = Color.Blue;
            chart1.Series["Wykres"].BorderWidth = 2;
            chart1.Series["OsX0"].Color = Color.Black;
            chart1.Series["OsX0"].BorderWidth = 2;
            for (int i = (Form1.xValues.Count() - 1); i >= 0; i--)
            {
                chart1.Series["Wykres"].Points.AddXY(Form1.xValues[i], Form1.yValues[i]);  //Dodanie współrzędnych X i Y do wykresu.
                chart1.Series["OsX0"].Points.AddXY(Form1.xValues[i], 0);                  //Dodanie współrzędnych X i Y do wykresu osi X.
            }

        }

        void Wyczysc_wykres()
        {
            for (int i = (Form1.xValues.Count() - 1); i >= 0; i--)
            {
                chart1.Series["Wykres"].Points.RemoveAt(i);  //Usuwanie współrzędnych X i Y do wykresu.
                chart1.Series["OsX0"].Points.RemoveAt(i);   //Usuwanie współrzędnych X i Y do wykresu.
                Form1.xValues.RemoveAt(i);
                Form1.yValues.RemoveAt(i);
            }
        }

        void zapis()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image (*.png)|*.png|JPEG Image (*.jpg)|*.jpg|Wszystkie pliki (*.*)|*.*";  //Opcje zapisu.
            saveFileDialog.FilterIndex = 1;                                                                       //Domyślny indeks spokosu zapisu.
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                this.chart1.SaveImage(path, ChartImageFormat.Png);
            }
        }
    }
}
