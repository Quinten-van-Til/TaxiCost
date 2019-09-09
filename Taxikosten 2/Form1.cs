using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxikosten_2
{
    public partial class Form1 : Form
    {
        public int Afstand = 0;
        public DateTime Begin;
        public DateTime Eind;
        public int Datum;
        public Double Kosten = 0;
        Double verschil = 0;
        bool toeslag = false;
        public Form1()
        {
            InitializeComponent();

        }





        private void Tijden()
        {
            TimeSpan start = new TimeSpan(8, 0, 0);
            TimeSpan end = new TimeSpan(18, 0, 0);
            Double verschil1 = 0;
            Double verschil2 = 0;

            Kosten = toeslag ? Kosten / 1.15 : Kosten;
            Kosten -= verschil;
            verschil = 0;

            // voor 08:00
            if (Eind.TimeOfDay < start)
            {
                verschil = ((Eind.TimeOfDay - Begin.TimeOfDay).TotalMinutes) * 0.45;
                verschil = verschil < 0 ? 0 : verschil;

                Kosten += verschil;
            }

            // na 18:00
            else if (Begin.TimeOfDay > end)
            {
                verschil = ((Eind.TimeOfDay - Begin.TimeOfDay).TotalMinutes) * 0.45;
                verschil = verschil < 0 ? 0 : verschil;

                Kosten += verschil;
            }

            // tussen 08:00 - 18:00
            else if (Begin.TimeOfDay > start && Eind.TimeOfDay < end)
            {
                verschil = ((Eind.TimeOfDay - Begin.TimeOfDay).TotalMinutes) * 0.25;
                verschil = verschil < 0 ? 0 : verschil;

                Kosten += verschil;
            }

            // Begin voor 08:00 en Eind voor 18:00
            else if (Eind.TimeOfDay < end)
            {
                verschil1 = ((start - Begin.TimeOfDay).TotalMinutes) * 0.45;
                verschil2 = ((Eind.TimeOfDay - start).TotalMinutes) * 0.25;
                verschil = verschil1 + verschil2;
                verschil = verschil < 0 ? 0 : verschil;

                Kosten += verschil;
            }

            // Begin na 08:00 en Eind na 18:00
            else if (Begin.TimeOfDay < start)
            {
                verschil1 = ((end - Begin.TimeOfDay).TotalMinutes) * 0.25;
                verschil2 = ((Eind.TimeOfDay - end).TotalMinutes) * 0.45;
                verschil = verschil1 + verschil2;
                verschil = verschil < 0 ? 0 : verschil;

                Kosten += verschil;
            }

            // Begin voor 08:00 en Eind na 18:00
            else
            {
                verschil1 = ((start - Begin.TimeOfDay).TotalMinutes) * 0.25;
                verschil2 = ((Eind.TimeOfDay - end).TotalMinutes) * 0.45;
                verschil = verschil1 + verschil2 + ((10 * 60) * 0.25);
                verschil = verschil < 0 ? 0 : verschil;

                Kosten += verschil;
            }
            Prijs.Text = Kosten.ToString("C2");
        }

        private void weekendtoeslag()
        {
            TimeSpan start = new TimeSpan(22, 0, 0);
            TimeSpan end = new TimeSpan(7, 0, 0);
            Datum = (int)(DatePicker.Value.DayOfWeek);

            if (Datum == 5 && Begin.TimeOfDay > start || Datum == 6 || Datum == 7 || Datum == 1 && Begin.TimeOfDay < end)
            {
                if (Afstand != 0 && verschil != 0)
                {
                    toeslag = true;
                    Kosten *= 1.15;
                    Prijs.Text = Kosten.ToString("C2");
                }
                else
                {
                    toeslag = false;
                }
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Kosten = toeslag ? Kosten / 1.15 : Kosten;
            Kosten -= Afstand;
            int.TryParse(Kilometers.Text, out Afstand);
            Kosten += Afstand;
            weekendtoeslag();
            Prijs.Text = Kosten.ToString("C2");
        }

        private void TimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Begin = TimePicker1.Value;
            Tijden();
            weekendtoeslag();
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Eind = TimePicker2.Value;
            Tijden();
            weekendtoeslag();
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            weekendtoeslag();
        }


    }
}
