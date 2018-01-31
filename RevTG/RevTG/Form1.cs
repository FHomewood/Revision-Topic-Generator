using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevTG
{
    public partial class RevTG_Form1 : Form
    {
        List<DateTime> LecDates = new List<DateTime>();
        List<String> LecTitle = new List<String>();


        public RevTG_Form1()
        {
            InitializeComponent();

            //Hardcoding my schedule
            //Week 1
            LecDates.Add(new DateTime(2018, 02, 5));
            LecTitle.Add("Thermal and Statistical Physics");
            LecDates.Add(new DateTime(2018, 02, 5));
            LecTitle.Add("Theoretical Physics");
            LecDates.Add(new DateTime(2018, 02, 6));
            LecTitle.Add("Thermal and Statistical Physics");
            LecDates.Add(new DateTime(2018, 02, 6));
            LecTitle.Add("Skills in Physics II");
            LecDates.Add(new DateTime(2018, 02, 6));
            LecTitle.Add("Quantum Mechanics I");
            LecDates.Add(new DateTime(2018, 02, 7));
            LecTitle.Add("Theoretical Physcis");
            LecDates.Add(new DateTime(2018, 02, 7));
            LecTitle.Add("Skills in Physics II");
            LecDates.Add(new DateTime(2018, 02, 9));
            LecTitle.Add("Quantum Mechanics I");
            LecDates.Add(new DateTime(2018, 02, 9));
            LecTitle.Add("Theoretical Physcis");
            //Week 2 - 11
            foreach (int k in new int[] { 0, 1, 2, 3, 4, 5, 8, 9, 10, 11 })
            {
                LecDates.Add(new DateTime(2018, 02, 12).AddDays(7 * k));
                LecTitle.Add("Thermal and Statistical Physics");
                LecDates.Add(new DateTime(2018, 02, 12).AddDays(7 * k));
                LecTitle.Add("Theoretical Physcis");
                LecDates.Add(new DateTime(2018, 02, 13).AddDays(7 * k));
                LecTitle.Add("Thermal and Statistical Physics");
                LecDates.Add(new DateTime(2018, 02, 13).AddDays(7 * k));
                LecTitle.Add("Skills in Physics II");
                LecDates.Add(new DateTime(2018, 02, 13).AddDays(7 * k));
                LecTitle.Add("Quantum Mechanics I");
                LecDates.Add(new DateTime(2018, 02, 14).AddDays(7 * k));
                LecTitle.Add("Theoretical Physcis");
                LecDates.Add(new DateTime(2018, 02, 14).AddDays(7 * k));
                LecTitle.Add("Skills in Physics II");
                LecDates.Add(new DateTime(2018, 02, 15).AddDays(7 * k));
                LecTitle.Add("Theoretical Physcis");
                LecDates.Add(new DateTime(2018, 02, 16).AddDays(7 * k));
                LecTitle.Add("Theoretical Physcis");
                LecDates.Add(new DateTime(2018, 02, 16).AddDays(7 * k));
                LecTitle.Add("Quantum Mechanics I");
            }
            //Week 12
            LecDates.Add(new DateTime(2018, 05, 8));
            LecTitle.Add("Thermal and Statistical Physics");
            LecDates.Add(new DateTime(2018, 05, 8));
            LecTitle.Add("Skills in Physics II");
            LecDates.Add(new DateTime(2018, 05, 8));
            LecTitle.Add("Quantum Mechanics I");
            LecDates.Add(new DateTime(2018, 05, 9));
            LecTitle.Add("Theoretical Physcis");
            LecDates.Add(new DateTime(2018, 05, 9));
            LecTitle.Add("Skills in Physics II");
            LecDates.Add(new DateTime(2018, 05, 10));
            LecTitle.Add("Theoretical Physcis");
            LecDates.Add(new DateTime(2018, 05, 11));
            LecTitle.Add("Theoretical Physcis");
            LecDates.Add(new DateTime(2018, 05, 11));
            LecTitle.Add("Quantum Mechanics I");
            update(2018, DateTime.Today.Month, DateTime.Today.Day);
        }

        public void btnFind_Click(object sender, EventArgs e)
        { update(2018, int.Parse(txbMonth.Text), int.Parse(txbDay.Text)); }
        private void update(int year, int month, int day)
        {
            rbOutput.Text = "";
            DateTime RequestDate = DateTime.Today;
            bool validDate = true;
            try { RequestDate = new DateTime(year, month, day); }
            catch { validDate = false; }

            if (validDate)
                for (int i = 0; i < LecTitle.Count(); i++)
                {
                    foreach (int k in new int[] { 2, 6, 14, 30, 62 }) //this is the list of days you will be reminded about the lecture
                    {
                        if ((RequestDate - LecDates[i]).Days == k)
                        {
                            rbOutput.Text += LecTitle[i] + "\n" + LecDates[i].ToShortDateString() + "\n" + k.ToString() + " Days. \n\r";
                        }
                    }
                }
            else rbOutput.Text += "That date doesn't exist please input a real date <day> <month>";
            if (rbOutput.Text == "") rbOutput.Text += "No work scheduled for today";
        }
    }
}
