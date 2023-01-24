using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GanttChart
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {
            //Init data
            List<Stanice> list = new List<Stanice>();
            list.Add(new Stanice() { ID = 1, Name = "STANICA 1" });
            list.Add(new Stanice() { ID = 2, Name = "STANICA 2" });
            list.Add(new Stanice() { ID = 3, Name = "STANICA 3" });
            list.Add(new Stanice() { ID = 4, Name = "STANICA 4" });
            //Set display and value member
            startDropDown.DataSource = list;
            startDropDown.ValueMember = "ID";
            startDropDown.DisplayMember = "Name";


            vremePocetno.MaxDate = DateTime.Now.AddMinutes(-5);
            vremePocetno.Value = DateTime.Now.AddDays(-5).AddSeconds(-10);

            vremeKrajnje.MaxDate = DateTime.Now;
            vremeKrajnje.Value = DateTime.Now.AddSeconds(-10);

        }

        private void startMenuButton_Click(object sender, EventArgs e)
        {
            if (vremeKrajnje.Value.CompareTo(vremePocetno.Value) < 0)
            {
                MessageBox.Show("Krajnje vreme ne sme da biti ranije od pocetnog! \nIzaberite ponovo", "Greska pri izboru vremena", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                if (startDropDown.SelectedIndex == 0)
                {
                    Stanica1 stn1 = new Stanica1();
                    Stanica1.instance.pocetno = vremePocetno.Value;
                    Stanica1.instance.krajnje = vremeKrajnje.Value;
                    stn1.FormClosed += (s, args) => this.Close();
                    stn1.Show();
                }
                else if (startDropDown.SelectedIndex == 1)
                {
                    Stanica2 stn2 = new Stanica2();
                    //stn2.FormClosed += (s, args) => this.Close();
                    stn2.Show();
                }
                else if (startDropDown.SelectedIndex == 2)
                {
                    Stanica3 stn3 = new Stanica3();
                    //stn3.FormClosed += (s, args) => this.Close();
                    stn3.Show();
                }
                else if (startDropDown.SelectedIndex == 3)
                {
                    Stanica4 stn4 = new Stanica4();
                    //stn4.FormClosed += (s, args) => this.Close();
                    stn4.Show();
                }
            }
        }
    }
}
