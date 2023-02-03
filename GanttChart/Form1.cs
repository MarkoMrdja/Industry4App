using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GanttChart
{
    public partial class Form1 : Form
    {
        GanttChart ganttChart1;
        public int cnt1 = 0, cnt2 = 0, cnt3 = 0, cnt4 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public struct TwoLists
        {
            public List<DateTime> pList;
            public List<DateTime> eList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            siticoneShadowForm1.SetShadowForm(this);

            dtpStart.MaxDate = DateTime.Now.AddMinutes(-5);
            dtpStart.Value = DateTime.Now.AddDays(-5).AddSeconds(-10);

            dtpEnd.MaxDate = DateTime.Now;
            dtpEnd.Value = DateTime.Now.AddSeconds(-10);

            txtCurrDateStart.Text = dtpStart.Value.ToString("dd-MM-yyyy");
            txtCurrDateEnd.Text = dtpEnd.Value.ToString("dd-MM-yyyy");

            station11.BringToFront();
        }

        private void btnStanica1_CheckedChanged(object sender, EventArgs e)
        {
            if (btnStanica1.Checked) station11.BringToFront();
        }

        private void btnStanica2_CheckedChanged(object sender, EventArgs e)
        {
            if (btnStanica2.Checked) station21.BringToFront();
        }

        private void btnStanica3_CheckedChanged(object sender, EventArgs e)
        {
            if (btnStanica3.Checked) station31.BringToFront();
        }

        private void btnStanica4_CheckedChanged(object sender, EventArgs e)
        {
            if (btnStanica4.Checked) station41.BringToFront();
        }

        private void btnTimePeriod_Click(object sender, EventArgs e)
        {
            if (dtpEnd.Value.CompareTo(dtpStart.Value) < 0)
            {
                MessageBox.Show("Krajnje vreme ne sme da biti ranije od pocetnog! \nIzaberite ponovo", "Greska pri izboru vremena", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (station11.Parent.Controls.GetChildIndex(station11) == 0)
                {
                    DrawGantt();
                }
                else if (station21.Parent.Controls.GetChildIndex(station21) == 0)
                {
                    DrawGantt();
                }
                else if (station31.Parent.Controls.GetChildIndex(station31) == 0)
                {
                    DrawGantt();
                }
                else if(station41.Parent.Controls.GetChildIndex(station41) == 0)
                {
                    DrawGantt();
                }
            }
        }

        public void DrawGantt()
        {
            ganttChart1 = new GanttChart();
            ganttChart1.AllowChange = false;
            ganttChart1.Dock = DockStyle.Fill;
            ganttChart1.FromDate = dtpStart.Value;
            ganttChart1.ToDate = dtpEnd.Value;

            if (station11.Parent.Controls.GetChildIndex(station11) == 0)
            {
                if (cnt1 == 0)
                {
                    station11.tableLayoutPanel1.Controls.Add(ganttChart1, 0, 0);
                    cnt1++;
                }
                else if (cnt1 > 0)
                {
                    station11.tableLayoutPanel1.Controls.Clear();
                    station11.tableLayoutPanel1.RowStyles.Clear();

                    station11.tableLayoutPanel1.Controls.Add(ganttChart1, 0, 0);
                }
            }
            else if (station21.Parent.Controls.GetChildIndex(station21) == 0)
            {
                if (cnt2 == 0)
                {
                    station21.tableLayoutPanel1.Controls.Add(ganttChart1, 0, 0);
                    cnt2++;
                }
                else if (cnt2 > 0)
                {
                    station21.tableLayoutPanel1.Controls.Clear();
                    station21.tableLayoutPanel1.RowStyles.Clear();

                    station21.tableLayoutPanel1.Controls.Add(ganttChart1, 0, 0);
                }
            }
            else if (station31.Parent.Controls.GetChildIndex(station31) == 0)
            {
                if (cnt3 == 0)
                {
                    station31.tableLayoutPanel1.Controls.Add(ganttChart1, 0, 0);
                    cnt3++;
                }
                else if (cnt3 > 0)
                {
                    station31.tableLayoutPanel1.Controls.Clear();
                    station31.tableLayoutPanel1.RowStyles.Clear();

                    station31.tableLayoutPanel1.Controls.Add(ganttChart1, 0, 0);
                }
            }
            else if (station41.Parent.Controls.GetChildIndex(station41) == 0)
            {
                if (cnt4 == 0)
                {
                    station41.tableLayoutPanel1.Controls.Add(ganttChart1, 0, 0);
                    cnt4++;
                }
                else if (cnt4 > 0)
                {
                    station41.tableLayoutPanel1.Controls.Clear();
                    station41.tableLayoutPanel1.RowStyles.Clear();

                    station41.tableLayoutPanel1.Controls.Add(ganttChart1, 0, 0);
                }
            }

            ganttChart1.MouseMove += new MouseEventHandler(ganttChart1.GanttChart_MouseMove);
            //ganttChart1.MouseMove += new MouseEventHandler(GanttChart1_MouseMove);
            ganttChart1.MouseDragged += new MouseEventHandler(ganttChart1.GanttChart_MouseDragged);
            ganttChart1.MouseLeave += new EventHandler(ganttChart1.GanttChart_MouseLeave);
            //ganttChart1.ContextMenuStrip = ContextMenuGanttChart1;

            List<BarInformation> lst1 = new List<BarInformation>();
            List<TwoLists> incoming = Obradjeno(dtpStart.Value, dtpEnd.Value);
            int index1 = 0, index2 = 0, index3 = 0, index4 = 0;

            if (station11.Parent.Controls.GetChildIndex(station11) == 0)
            {
                if (incoming[0].pList.Count != 0)
                {
                    lst1.Add(new BarInformation("Vakum Stanice 1", incoming[0].pList[0], incoming[0].eList[0], Color.Aqua, Color.Khaki, index1));
                    for (int i = 1; i < incoming[0].pList.Count; i++)
                    {
                        lst1.Add(new BarInformation("", incoming[0].pList[i], incoming[0].eList[i], Color.Aqua, Color.Khaki, index1));
                    }
                    index1++;
                }
                if (incoming[1].pList.Count != 0)
                {
                    lst1.Add(new BarInformation("Cilindar izvucen", incoming[1].pList[0], incoming[1].eList[0], Color.Blue, Color.Khaki, index1));
                    for (int i = 1; i < incoming[1].pList.Count; i++)
                    {
                        lst1.Add(new BarInformation("", incoming[1].pList[i], incoming[1].eList[i], Color.Blue, Color.Khaki, index1));
                    }
                    index1++;
                }
                if (incoming[2].pList.Count != 0)
                {
                    lst1.Add(new BarInformation("Cilindar uvucen", incoming[2].pList[0], incoming[2].eList[0], Color.Red, Color.Khaki, index1));
                    for (int i = 1; i < incoming[2].pList.Count; i++)
                    {
                        lst1.Add(new BarInformation("", incoming[2].pList[i], incoming[2].eList[i], Color.Red, Color.Khaki, index1));
                    }
                    index1++;
                }
                if (incoming[3].pList.Count != 0)
                {
                    lst1.Add(new BarInformation("Prazan magacin", incoming[3].pList[0], incoming[3].eList[0], Color.DarkRed, Color.Khaki, index1));
                    for (int i = 1; i < incoming[3].pList.Count; i++)
                    {
                        lst1.Add(new BarInformation("", incoming[3].pList[i], incoming[3].eList[i], Color.DarkRed, Color.Khaki, index1));
                    }
                    index1++;
                }
                if (incoming[4].pList.Count != 0)
                {
                    lst1.Add(new BarInformation("Kran do magacina", incoming[4].pList[0], incoming[4].eList[0], Color.Purple, Color.Khaki, index1));
                    for (int i = 1; i < incoming[4].pList.Count; i++)
                    {
                        lst1.Add(new BarInformation("", incoming[4].pList[i], incoming[4].eList[i], Color.Purple, Color.Khaki, index1));
                    }
                    index1++;
                }
                if (incoming[5].pList.Count != 0)
                {
                    lst1.Add(new BarInformation("Kran do sledece stanice", incoming[5].pList[0], incoming[5].eList[0], Color.Yellow, Color.Khaki, index1));
                    for (int i = 1; i < incoming[5].pList.Count; i++)
                    {
                        lst1.Add(new BarInformation("", incoming[5].pList[i], incoming[5].eList[i], Color.Yellow, Color.Khaki, index1));
                    }
                    index1++;
                }

                if(incoming[1].pList.Count == 1)
                {
                    station11.lblCilindarIzv.Text = incoming[1].pList.Count.ToString() + " put";
                }
                else if(incoming[1].pList.Count > 1)
                {
                    station11.lblCilindarIzv.Text = incoming[1].pList.Count.ToString() + " puta";
                }
                else
                {
                    station11.lblCilindarIzv.Text = "0 puta";
                }

                if (incoming[2].pList.Count == 1)
                {
                    station11.lblCilindarUvu.Text = incoming[2].pList.Count.ToString() + " put";
                }
                else if (incoming[2].pList.Count > 1)
                {
                    station11.lblCilindarUvu.Text = incoming[2].pList.Count.ToString() + " puta";
                }
                else
                {
                    station11.lblCilindarUvu.Text = "0 puta";
                }
                

                TimeSpan vakumStan1 = TimeSpan.Zero, vakumStan2 = TimeSpan.Zero;
                for (int i = 0; i < incoming[0].pList.Count; i++)
                {
                    TimeSpan temp = incoming[0].eList[i].Subtract(incoming[0].pList[i]);
                    vakumStan1 += temp;
                }
                for (int i = 0; i < incoming[6].pList.Count; i++)
                {
                    TimeSpan temp = incoming[6].eList[i].Subtract(incoming[6].pList[i]);
                    vakumStan2 += temp;
                }

                //Vakum 1
                if (vakumStan1.Minutes < 1 && vakumStan1.Hours < 1)
                {
                    station11.lblVakumStan1.Text = vakumStan1.Seconds.ToString() + "s";
                }
                else if (vakumStan1.Minutes > 1 && vakumStan1.Hours < 1)
                {
                    station11.lblVakumStan1.Text = vakumStan1.Minutes.ToString() + "min " + vakumStan1.Seconds.ToString() + "s";
                }
                else
                {
                    station11.lblVakumStan1.Text = vakumStan1.Hours.ToString() + "h " + vakumStan1.Minutes.ToString() + "min " + vakumStan1.Seconds.ToString() + "s";
                }

                //Vakum 2
                if (vakumStan2.Minutes < 1 && vakumStan2.Hours < 1)
                {
                    station11.lblVakumStan2.Text = vakumStan2.Seconds.ToString() + "s";
                }
                else if (vakumStan2.Minutes > 1 && vakumStan2.Hours < 1)
                {
                    station11.lblVakumStan2.Text = vakumStan2.Minutes.ToString() + "min " + vakumStan2.Seconds.ToString() + "s";
                }
                else
                {
                    station11.lblVakumStan2.Text = vakumStan2.Hours.ToString() + "h " + vakumStan2.Minutes.ToString() + "min " + vakumStan2.Seconds.ToString() + "s";
                }

                //cylinder lifespan
                station11.pbAktuatori.Maximum = 100000;
                station11.pbAktuatori.Value = incoming[7].pList.Count + incoming[8].pList.Count;


                //70 l/min nominalni protok vazduha - povuci parametre iz spoljnjeg fajla
                TimeSpan lifeSpan_vakumStan1 = TimeSpan.Zero, lifeSpan_vakumStan2 = TimeSpan.Zero;
                for (int i = 0; i < incoming[9].pList.Count; i++)
                {
                    TimeSpan temp = incoming[9].eList[i].Subtract(incoming[9].pList[i]);
                    lifeSpan_vakumStan1 += temp;
                }
                for (int i = 0; i < incoming[10].pList.Count; i++)
                {
                    TimeSpan temp = incoming[10].eList[i].Subtract(incoming[10].pList[i]);
                    lifeSpan_vakumStan2 += temp;
                }

                int potrosnja = (vakumStan1.Hours * 70 * 60) + (vakumStan1.Minutes * 70) + (vakumStan1.Seconds * 70 / 60) + (vakumStan2.Hours * 70 * 60) + (vakumStan2.Minutes * 70) + (vakumStan2.Seconds * 70 / 60);
                station11.lblPotrosnjaVazduha.Text = potrosnja.ToString() + " l";

                int lifeSpan_potrosnja = (lifeSpan_vakumStan1.Hours * 70 * 60) + (lifeSpan_vakumStan1.Minutes * 70) + (lifeSpan_vakumStan1.Seconds * 70 / 60) + (lifeSpan_vakumStan2.Hours * 70 * 60) + (lifeSpan_vakumStan2.Minutes * 70) + (lifeSpan_vakumStan2.Seconds * 70 / 60);
                station11.pbVazduh.Maximum = 70 * 60 * 10000;
                station11.pbVazduh.Value = lifeSpan_potrosnja;

            }
            else if (station21.Parent.Controls.GetChildIndex(station21) == 0)
            {
                if (incoming[1].pList.Count != 0)
                {
                    for (int i = 0; i < incoming[1].pList.Count; i++)
                    {
                        lst1.Add(new BarInformation("Vakum Stanice 2", incoming[1].pList[i], incoming[1].eList[i], Color.Aqua, Color.Khaki, index2));
                    }
                    index2++;
                }
                if (incoming[2].pList.Count != 0)
                {
                    for (int i = 0; i < incoming[2].pList.Count; i++)
                    {
                        lst1.Add(new BarInformation("Lift gore", incoming[2].pList[i], incoming[2].eList[i], Color.Red, Color.Khaki, index2));
                    }
                    index2++;
                }
                if (incoming[3].pList.Count != 0)
                {
                    for (int i = 0; i < incoming[3].pList.Count; i++)
                    {
                        lst1.Add(new BarInformation("Lift dole", incoming[3].pList[i], incoming[3].eList[i], Color.Blue, Color.Khaki, index2));
                    }
                    index2++;
                }
                if (incoming[4].pList.Count != 0)
                {
                    for (int i = 0; i < incoming[4].pList.Count; i++)
                    {
                        lst1.Add(new BarInformation("Cilindar uvucen", incoming[4].pList[i], incoming[4].eList[i], Color.Khaki, Color.Khaki, index2));
                    }
                    index2++;
                }

                if (incoming[4].pList.Count == 1)
                {
                    station21.lblCilindarUvu.Text = incoming[4].pList.Count.ToString() + " put";
                }
                else if (incoming[4].pList.Count > 1)
                {
                    station21.lblCilindarUvu.Text = incoming[4].pList.Count.ToString() + " puta";
                }
                else
                {
                    station21.lblCilindarUvu.Text = "0 puta";
                }

                if (incoming[2].pList.Count == 1)
                {
                    station21.txtLiftGoreValue.Text = incoming[2].pList.Count.ToString() + " put";
                }
                else if (incoming[2].pList.Count > 1)
                {
                    station21.txtLiftGoreValue.Text = incoming[2].pList.Count.ToString() + " puta";
                }
                else
                {
                    station21.txtLiftGoreValue.Text = "0 puta";
                }

                if (incoming[3].pList.Count == 1)
                {
                    station21.txtLiftDoleValue.Text = incoming[3].pList.Count.ToString() + " put";
                }
                else if (incoming[3].pList.Count > 1)
                {
                    station21.txtLiftDoleValue.Text = incoming[3].pList.Count.ToString() + " puta";
                }
                else
                {
                    station21.txtLiftDoleValue.Text = "0 puta";
                }
                

                TimeSpan vakumStan1 = TimeSpan.Zero, vakumStan2 = TimeSpan.Zero;
                for (int i = 0; i < incoming[0].pList.Count; i++)
                {
                    TimeSpan temp = incoming[0].eList[i].Subtract(incoming[0].pList[i]);
                    vakumStan1 += temp;
                }
                for (int i = 0; i < incoming[1].pList.Count; i++)
                {
                    TimeSpan temp = incoming[1].eList[i].Subtract(incoming[1].pList[i]);
                    vakumStan2 += temp;
                }

                //Vakum 1
                if (vakumStan1.Minutes < 1 && vakumStan1.Hours < 1)
                {
                    station21.lblVakumStan1.Text = vakumStan1.Seconds.ToString() + "s";
                }
                else if (vakumStan1.Minutes > 1 && vakumStan1.Hours < 1)
                {
                    station21.lblVakumStan1.Text = vakumStan1.Minutes.ToString() + "min " + vakumStan1.Seconds.ToString() + "s";
                }
                else
                {
                    station21.lblVakumStan1.Text = vakumStan1.Hours.ToString() + "h " + vakumStan1.Minutes.ToString() + "min " + vakumStan1.Seconds.ToString() + "s";
                }

                //Vakum 2
                if (vakumStan2.Minutes < 1 && vakumStan2.Hours < 1)
                {
                    station21.lblVakumStan2.Text = vakumStan2.Seconds.ToString() + "s";
                }
                else if (vakumStan2.Minutes > 1 && vakumStan2.Hours < 1)
                {
                    station21.lblVakumStan2.Text = vakumStan2.Minutes.ToString() + "min " + vakumStan2.Seconds.ToString() + "s";
                }
                else
                {
                    station21.lblVakumStan2.Text = vakumStan2.Hours.ToString() + "h " + vakumStan2.Minutes.ToString() + "min " + vakumStan2.Seconds.ToString() + "s";
                }

                //Efektivnost
                double ispravni = incoming[8].pList.Count;
                double skart = incoming[9].pList.Count;
                double efektivnost = (ispravni / (ispravni + skart)) * 100;

                station21.siticoneCircleProgressBar1.Value = (int)efektivnost;
                if (efektivnost < 10.0)
                {
                    station21.lblEffProcenti.Text = "  " + (int)efektivnost + "%";
                }
                else if(efektivnost > 9.0 && efektivnost < 100.0)
                {
                    station21.lblEffProcenti.Text = " " + (int)efektivnost + "%";
                }
                else
                {
                    station21.lblEffProcenti.Text = (int)efektivnost + "%";
                }

                //cylinder lifespan
                station21.pbAktuatori.Maximum = 100000;
                station21.pbAktuatori.Value = incoming[5].pList.Count * 2;

                //70 l/min nominalni protok vazduha - povuci parametre iz spoljnjeg fajla
                TimeSpan lifeSpan_vakumStan1 = TimeSpan.Zero, lifeSpan_vakumStan2 = TimeSpan.Zero;
                for (int i = 0; i < incoming[6].pList.Count; i++)
                {
                    TimeSpan temp = incoming[6].eList[i].Subtract(incoming[6].pList[i]);
                    lifeSpan_vakumStan1 += temp;
                }
                for (int i = 0; i < incoming[7].pList.Count; i++)
                {
                    TimeSpan temp = incoming[7].eList[i].Subtract(incoming[7].pList[i]);
                    lifeSpan_vakumStan2 += temp;
                }
                int lifeSpan_potrosnja = (lifeSpan_vakumStan1.Hours * 70 * 60) + (lifeSpan_vakumStan1.Minutes * 70) + (lifeSpan_vakumStan1.Seconds * 70 / 60) + (lifeSpan_vakumStan2.Hours * 70 * 60) + (lifeSpan_vakumStan2.Minutes * 70) + (lifeSpan_vakumStan2.Seconds * 70 / 60);

                int potrosnja = (vakumStan1.Hours * 70 * 60) + (vakumStan1.Minutes * 70) + (vakumStan1.Seconds * 70 / 60) + (vakumStan2.Hours * 70 * 60) + (vakumStan2.Minutes * 70) + (vakumStan2.Seconds * 70 / 60);
                station21.lblPotrosnjaVazduha.Text = potrosnja.ToString() + " l";

                station21.pbVazduh.Maximum = 70 * 60 * 10000;
                station21.pbVazduh.Value = lifeSpan_potrosnja;
            }
            else if (station31.Parent.Controls.GetChildIndex(station31) == 0)
            {
                if (incoming[0].pList.Count != 0)
                {
                    for (int i = 0; i < incoming[0].pList.Count; i++)
                    {
                        lst1.Add(new BarInformation("Prenos u poz. prethodne stanice", incoming[0].pList[i], incoming[0].eList[i], Color.Chocolate, Color.Khaki, index3));
                    }
                    index3++;
                }
                if (incoming[1].pList.Count != 0)
                {
                    for (int i = 0; i < incoming[1].pList.Count; i++)
                    {
                        lst1.Add(new BarInformation("Prenos u srednjoj poziciji", incoming[1].pList[i], incoming[1].eList[i], Color.DarkOliveGreen, Color.Khaki, index3));
                    }
                    index3++;
                }
                if (incoming[2].pList.Count != 0)
                {
                    for (int i = 0; i < incoming[2].pList.Count; i++)
                    {
                        lst1.Add(new BarInformation("Prenos u poz. sledece stanice", incoming[2].pList[i], incoming[2].eList[i], Color.ForestGreen, Color.Khaki, index3));
                    }
                    index3++;
                }
                if (incoming[3].pList.Count != 0)
                {
                    for (int i = 0; i < incoming[3].pList.Count; i++)
                    {
                        lst1.Add(new BarInformation("Hvataljka ispruzena", incoming[3].pList[i], incoming[3].eList[i], Color.White, Color.Khaki, index3));
                    }
                    index3++;
                }
                if (incoming[4].pList.Count != 0)
                {
                    for (int i = 0; i < incoming[4].pList.Count; i++)
                    {
                        lst1.Add(new BarInformation("Hvataljka skupljena", incoming[4].pList[i], incoming[4].eList[i], Color.Black, Color.Honeydew, index3));
                    }
                    index3++;
                }
                if (incoming[5].pList.Count != 0)
                {
                    for (int i = 0; i < incoming[5].pList.Count; i++)
                    {
                        lst1.Add(new BarInformation("Hvataljka otvorena", incoming[5].pList[i], incoming[5].eList[i], Color.Navy, Color.Khaki, index3));
                    }
                    index3++;
                }

                if (incoming[3].pList.Count == 1)
                {
                    station31.lblHvatIspruzena.Text = incoming[3].pList.Count.ToString() + " put";
                }
                else if (incoming[3].pList.Count > 1)
                {
                    station31.lblHvatIspruzena.Text = incoming[3].pList.Count.ToString() + " puta";
                }
                else
                {
                    station31.lblHvatIspruzena.Text = "0 puta";
                }

                if (incoming[4].pList.Count == 1)
                {
                    station31.lblHvatSkupljena.Text = incoming[4].pList.Count.ToString() + " put";
                }
                else if (incoming[4].pList.Count > 1)
                {
                    station31.lblHvatSkupljena.Text = incoming[4].pList.Count.ToString() + " puta";
                }
                else
                {
                    station31.lblHvatSkupljena.Text = "0 puta";
                }

                if (incoming[5].pList.Count == 1)
                {
                    station31.lblHvatOtvorena.Text = incoming[5].pList.Count.ToString() + " put";
                }
                else if (incoming[5].pList.Count > 1)
                {
                    station31.lblHvatOtvorena.Text = incoming[5].pList.Count.ToString() + " puta";
                }
                else
                {
                    station31.lblHvatOtvorena.Text = "0 puta";
                }

                station31.pbCilindarHvataljke.Maximum = 100000;
                station31.pbCilindarHvataljke.Value = incoming[6].pList.Count + incoming[7].pList.Count;

            }
            else if (station41.Parent.Controls.GetChildIndex(station41) == 0)
            {
                if (incoming[0].pList.Count != 0)
                {
                    for (int i = 0; i < incoming[0].pList.Count; i++)
                    {
                        lst1.Add(new BarInformation("Motor trake", incoming[0].pList[i], incoming[0].eList[i], Color.Black, Color.Khaki, index4));
                    }
                    index4++;
                }
                if (incoming[1].pList.Count != 0)
                {
                    for (int i = 0; i < incoming[1].pList.Count; i++)
                    {
                        lst1.Add(new BarInformation("Switch 1 - uvucen", incoming[1].pList[i], incoming[1].eList[i], Color.Red, Color.Khaki, index4));
                    }
                    index4++;
                }
                if (incoming[2].pList.Count != 0)
                {
                    for (int i = 0; i < incoming[2].pList.Count; i++)
                    {
                        lst1.Add(new BarInformation("Switch 1 - izvucen", incoming[2].pList[i], incoming[2].eList[i], Color.Blue, Color.Khaki, index4));
                    }
                    index4++;
                }
                if (incoming[3].pList.Count != 0)
                {
                    for (int i = 0; i < incoming[3].pList.Count; i++)
                    {
                        lst1.Add(new BarInformation("Switch 2 - uvucen", incoming[3].pList[i], incoming[3].eList[i], Color.YellowGreen, Color.Khaki, index4));
                    }
                    index4++;
                }
                if (incoming[4].pList.Count != 0)
                {
                    for (int i = 0; i < incoming[4].pList.Count; i++)
                    {
                        lst1.Add(new BarInformation("Switch 2 - ispruzen", incoming[4].pList[i], incoming[4].eList[i], Color.MediumPurple, Color.Khaki, index4));
                    }
                    index4++;
                }

                TimeSpan motorTrake = TimeSpan.Zero;
                for (int i = 0; i < incoming[0].pList.Count; i++)
                {
                    TimeSpan temp = incoming[0].eList[i].Subtract(incoming[0].pList[i]);
                    motorTrake += temp;
                }
                if (motorTrake.Minutes < 1 && motorTrake.Hours < 1)
                {
                    station41.lblMotorTrake.Text = motorTrake.Seconds.ToString() + "s";
                }
                else if (motorTrake.Minutes > 1 && motorTrake.Hours < 1)
                {
                    station41.lblMotorTrake.Text = motorTrake.Minutes.ToString() + "min " + motorTrake.Seconds.ToString() + "s";
                }
                else
                {
                    station41.lblMotorTrake.Text = motorTrake.Hours.ToString() + "h " + motorTrake.Minutes.ToString() + "min " + motorTrake.Seconds.ToString() + "s";
                }

                if (incoming[2].pList.Count == 1)
                {
                    station41.lblRucica1.Text = incoming[2].pList.Count.ToString() + " put";
                }
                else if (incoming[2].pList.Count > 1)
                {
                    station41.lblRucica1.Text = incoming[2].pList.Count.ToString() + " puta";
                }
                else
                {
                    station41.lblRucica1.Text = "0 puta";
                }

                if (incoming[4].pList.Count == 1)
                {
                    station41.lblRucica2.Text = incoming[4].pList.Count.ToString() + " put";
                }
                else if (incoming[4].pList.Count > 1)
                {
                    station41.lblRucica2.Text = incoming[4].pList.Count.ToString() + " puta";
                }
                else
                {
                    station41.lblRucica2.Text = "0 puta";
                }

                station41.pbCilindar1.Maximum = 100000;
                station41.pbCilindar1.Value = incoming[5].pList.Count + incoming[6].pList.Count;

                station41.pbCilindar2.Maximum = 100000;
                station41.pbCilindar2.Value = incoming[7].pList.Count + incoming[8].pList.Count;

                //Efektivnost
                double ispravni = incoming[9].pList.Count + incoming[10].pList.Count;
                double skart = incoming[11].pList.Count;
                double efektivnost = (ispravni / (ispravni + skart)) * 100;
                station41.gaugeEfektivnost.Value = (int)efektivnost;
                
            }

            foreach (BarInformation bar in lst1)
            {
               ganttChart1.AddChartBar(bar.RowText, bar, bar.FromTime, bar.ToTime, bar.Color, bar.HoverColor, bar.Index);
            }
        }

        /*private void GanttChart1_MouseMove(Object sender, MouseEventArgs e)
        {
            List<string> toolTipText = new List<string>();

            if (ganttChart1.MouseOverRowText.Length > 0)
            {
                BarInformation val = (BarInformation)ganttChart1.MouseOverRowValue;
                toolTipText.Add("[b]Date:");
                toolTipText.Add("From ");
                toolTipText.Add(val.FromTime.ToLongDateString() + " - " + val.FromTime.ToString("HH:mm"));
                toolTipText.Add("To ");
                toolTipText.Add(val.ToTime.ToLongDateString() + " - " + val.ToTime.ToString("HH:mm"));
            }
            else
            {
                toolTipText.Add("");
            }

            ganttChart1.ToolTipTextTitle = ganttChart1.MouseOverRowText;
            ganttChart1.ToolTipText = toolTipText;

        }*/

        public List<TwoLists> Obradjeno(DateTime start, DateTime end)
        {
            byte[] maska_bit1 = new byte[] { 0, 0, 0, 0, 0, 0, 0, 1 };
            byte[] maska_bit2 = new byte[] { 0, 0, 0, 0, 0, 0, 1, 0 };
            byte[] maska_bit3 = new byte[] { 0, 0, 0, 0, 0, 1, 0, 0 };
            byte[] maska_bit4 = new byte[] { 0, 0, 0, 0, 1, 0, 0, 0 };
            byte[] maska_bit5 = new byte[] { 0, 0, 0, 1, 0, 0, 0, 0 };
            byte[] maska_bit6 = new byte[] { 0, 0, 1, 0, 0, 0, 0, 0 };
            byte[] maska_bit7 = new byte[] { 0, 1, 0, 0, 0, 0, 0, 0 };

            // maske za racunanje efikasnosti
            byte[] maska_stan2_ispravan = new byte[] { 0, 0, 0, 0, 0, 0, 1, 1 };
            byte[] maska_stan2_skart = maska_bit3;
            byte[] maska_stan4_ispravan1 = new byte[] { 0, 0, 0, 0, 1, 1, 0, 1};
            byte[] maska_stan4_ispravan2 = new byte[] { 0, 0, 0, 1, 0, 0, 1, 1 };
            byte[] maska_stan4_skart = new byte[] { 0, 0, 0, 0, 1, 0, 1, 1};

            List<TwoLists> lists = new List<TwoLists>();

            if (station11.Parent.Controls.GetChildIndex(station11) == 0)
            {
                TwoLists vakum1 = Obrada("1", maska_bit1, 1, false, start, end);  // incoming[0]
                lists.Add(vakum1);
                TwoLists cilindarIzvucen = Obrada("1", maska_bit2, 2, false, start, end); //incoming[1]
                lists.Add(cilindarIzvucen);
                TwoLists cilindarUvucen = Obrada("1", maska_bit3, 4, false, start, end); //incoming[2]
                lists.Add(cilindarUvucen);
                TwoLists prazanMagacin = Obrada("1", maska_bit4, 8, false, start, end); //incoming[3]
                lists.Add(prazanMagacin);
                TwoLists kranDoMagacina = Obrada("1", maska_bit5, 16, false, start, end); //incoming[4]
                lists.Add(kranDoMagacina);
                TwoLists kranDoStanice = Obrada("1", maska_bit6, 32, false, start, end); //incoming[5]
                lists.Add(kranDoStanice);
                TwoLists vakum2 = Obrada("1", maska_bit1, 1, true, start, end);  //incoming[6]
                lists.Add(vakum2);

                TwoLists lifeSpan_cilindarIzvucen_stanica1 = Obrada("1", maska_bit2, 2, false, new DateTime(2023, 1, 1, 8, 0, 0), DateTime.Now); //incoming[7]
                lists.Add(lifeSpan_cilindarIzvucen_stanica1);
                TwoLists lifeSpan_cilindarUvucen_stanica1 = Obrada("1", maska_bit3, 4, false, new DateTime(2023, 1, 1, 8, 0, 0), DateTime.Now); //incoming[8]
                lists.Add(lifeSpan_cilindarUvucen_stanica1);
                TwoLists lifeSpan_vakum1 = Obrada("1", maska_bit1, 1, false, new DateTime(2023, 1, 1, 8, 0, 0), DateTime.Now);  // incoming[9]
                lists.Add(lifeSpan_vakum1);
                TwoLists lifeSpan_vakum2 = Obrada("1", maska_bit1, 1, true, new DateTime(2023, 1, 1, 8, 0, 0), DateTime.Now);  //incoming[10]
                lists.Add(lifeSpan_vakum2);

            }
            else if (station21.Parent.Controls.GetChildIndex(station21) == 0)
            {
                TwoLists vakum1 = Obrada("1", maska_bit1, 1, false, start, end);  // incoming[0]
                lists.Add(vakum1);
                TwoLists vakum2 = Obrada("1", maska_bit1, 1, true, start, end);  //incoming[1]
                lists.Add(vakum2);
                TwoLists liftGore = Obrada("1", maska_bit2, 2, true, start, end);  //incoming[2]
                lists.Add(liftGore);
                TwoLists liftDole = Obrada("1", maska_bit3, 4, true, start, end);  //incoming[3]
                lists.Add(liftDole);
                TwoLists cilindar2Uvucen = Obrada("1", maska_bit4, 8, true, start, end);  //incoming[4]
                lists.Add(cilindar2Uvucen);

                TwoLists lifeSpan_cilindar2Uvucen_stanica2 = Obrada("1", maska_bit4, 8, true, new DateTime(2023, 1, 1, 8, 0, 0), DateTime.Now);  //incoming[5]
                lists.Add(lifeSpan_cilindar2Uvucen_stanica2);
                TwoLists lifeSpan_vakum1 = Obrada("1", maska_bit1, 1, false, new DateTime(2023, 1, 1, 8, 0, 0), DateTime.Now);  // incoming[6]
                lists.Add(lifeSpan_vakum1);
                TwoLists lifeSpan_vakum2 = Obrada("1", maska_bit1, 1, true, new DateTime(2023, 1, 1, 8, 0, 0), DateTime.Now);  //incoming[7]
                lists.Add(lifeSpan_vakum2);

                TwoLists stanica2_ispravan = Obrada("1", maska_stan2_ispravan, 3, true, start, end); //incoming[8]
                lists.Add(stanica2_ispravan);
                TwoLists stanica2_skart = Obrada("1", maska_stan2_skart, 4, true, start, end); //incoming[9]
                lists.Add(stanica2_skart);

            }
            else if (station31.Parent.Controls.GetChildIndex(station31) == 0)
            {
                TwoLists handlingPrethodna = Obrada("2", maska_bit2, 2, false, start, end);  // incoming[0]
                lists.Add(handlingPrethodna);
                TwoLists handlingSredina = Obrada("2", maska_bit3, 4, false, start, end); //incoming[1]
                lists.Add(handlingSredina);
                TwoLists handlingSledeca = Obrada("2", maska_bit4, 8, false, start, end); //incoming[2]
                lists.Add(handlingSledeca);
                TwoLists hvataljkaIspruzena = Obrada("2", maska_bit5, 16, false, start, end); //incoming[3]
                lists.Add(hvataljkaIspruzena);
                TwoLists hvataljkaSkupljena = Obrada("2", maska_bit6, 32, false, start, end); //incoming[4]
                lists.Add(hvataljkaSkupljena);
                TwoLists hvataljkaOtvorena = Obrada("2", maska_bit7, 64, false, start, end); //incoming[5]
                lists.Add(hvataljkaOtvorena);

                TwoLists lifeSpan_hvataljkaIspruzena = Obrada("2", maska_bit5, 16, false, new DateTime(2023, 1, 1, 8, 0, 0), DateTime.Now); //incoming[6]
                lists.Add(lifeSpan_hvataljkaIspruzena);
                TwoLists lifeSpan_hvataljkaSkupljena = Obrada("2", maska_bit6, 32, false, new DateTime(2023, 1, 1, 8, 0, 0), DateTime.Now); //incoming[7]
                lists.Add(lifeSpan_hvataljkaSkupljena);
            }
            else if (station41.Parent.Controls.GetChildIndex(station41) == 0)
            {
                TwoLists motorTrake = Obrada("2", maska_bit1, 1, true, start, end);  // incoming[16] [0]
                lists.Add(motorTrake);
                TwoLists switch1Uvucen = Obrada("2", maska_bit2, 2, true, start, end); //incoming[17] [1]
                lists.Add(switch1Uvucen);
                TwoLists switch1Ispruzen = Obrada("2", maska_bit3, 4, true, start, end); //incoming[18] [2]
                lists.Add(switch1Ispruzen);
                TwoLists switch2Uvucen = Obrada("2", maska_bit4, 8, true, start, end); //incoming[19] [3]
                lists.Add(switch2Uvucen);
                TwoLists switch2Ispruzen = Obrada("2", maska_bit5, 16, true, start, end); //incoming[20] [4]
                lists.Add(switch2Ispruzen);

                TwoLists lifeSpan_switch1Uvucen = Obrada("2", maska_bit2, 2, true, new DateTime(2023, 1, 1, 8, 0, 0), DateTime.Now); //incoming[5]
                lists.Add(lifeSpan_switch1Uvucen);
                TwoLists lifeSpan_switch1Ispruzen = Obrada("2", maska_bit3, 4, true, new DateTime(2023, 1, 1, 8, 0, 0), DateTime.Now); //incoming[6]
                lists.Add(lifeSpan_switch1Ispruzen);
                TwoLists lifeSpan_switch2Uvucen = Obrada("2", maska_bit4, 8, true, new DateTime(2023, 1, 1, 8, 0, 0), DateTime.Now); //incoming[7]
                lists.Add(lifeSpan_switch2Uvucen);
                TwoLists lifeSpan_switch2Ispruzen = Obrada("2", maska_bit5, 16, true, new DateTime(2023, 1, 1, 8, 0, 0), DateTime.Now); //incoming[8]
                lists.Add(lifeSpan_switch2Ispruzen);

                TwoLists stanica4_ispravan1 = Obrada("2", maska_stan4_ispravan1, 13, true, start, end); //incoming[9]
                lists.Add(stanica4_ispravan1);
                TwoLists stanica4_ispravan2 = Obrada("2", maska_stan4_ispravan2, 19, true, start, end); //incoming[10]
                lists.Add(stanica4_ispravan2);
                TwoLists stanica4_skart = Obrada("2", maska_stan4_skart, 11, true, start, end); //incoming[11]
                lists.Add(stanica4_skart);
            }

            return lists;
        }

        public TwoLists Obrada(string IOmodul, byte[] maska, int vrednostBita, bool brojIzlaza, DateTime start, DateTime end)
        {
            string vod = start.ToString("yyyy-MM-dd");
            string vdo = end.ToString("yyyy-MM-dd");

            string result = OutputHistory(IOmodul, vod, vdo);
            List<Parametar> incoming = new List<Parametar>();
            incoming = JsonConvert.DeserializeObject<List<Parametar>>(result);


            List<bool> onOff = new List<bool>();
            List<DateTime> listaVreme = new List<DateTime>();

            List<DateTime> pocetnaVremena = new List<DateTime>();
            List<DateTime> krajnjaVremena = new List<DateTime>();

            for (int i = 0; i < incoming.Count; i++)
            {
                byte trenutnaVrednost = 0;

                if (brojIzlaza == false)
                {
                    byte[] izlaz_u_bitovima = ValueToBits(incoming[i].izlaz0);
                    byte[] maskiranVakumTest = Masking(izlaz_u_bitovima, maska);
                    trenutnaVrednost = ValueFromBits(maskiranVakumTest);
                }
                else if (brojIzlaza == true)
                {
                    byte[] izlaz_u_bitovima = ValueToBits(incoming[i].izlaz1);
                    byte[] maskiranVakumTest = Masking(izlaz_u_bitovima, maska);
                    trenutnaVrednost = ValueFromBits(maskiranVakumTest);
                }
                listaVreme.Add(incoming[i].time);

                if (trenutnaVrednost == vrednostBita)
                {
                    onOff.Add(true);
                }
                else
                {
                    onOff.Add(false);
                }
            }
            int cnt = 0;

            if (onOff.Count != 0)
            {
                bool tempPos = onOff[0];
                for (int i = 1; i < listaVreme.Count + cnt; i++)
                {
                    if (onOff[i - cnt] == tempPos)
                    {
                        listaVreme.RemoveAt(i - cnt);
                        onOff.RemoveAt(i - cnt);
                        cnt++;
                    }
                    else
                    {
                        tempPos = onOff[i - cnt];
                    }

                }

                for (int i = 0; i < onOff.Count; i++)
                {
                    if (onOff[0] == false)
                    {
                        if (i % 2 == 1) { pocetnaVremena.Add(listaVreme[i]); }
                        if ((i % 2 == 0) && (i != 0)) { krajnjaVremena.Add(listaVreme[i]); }
                        else { continue; }
                    }
                    else
                    {
                        if (i % 2 == 0) { pocetnaVremena.Add(listaVreme[i]); }
                        if (i % 2 == 1) { krajnjaVremena.Add(listaVreme[i]); }
                    }
                }

                if (pocetnaVremena.Count != krajnjaVremena.Count)
                {
                    pocetnaVremena.RemoveAt(pocetnaVremena.Count - 1);
                }

            }

            TwoLists lists = new TwoLists();
            lists.pList = pocetnaVremena;
            lists.eList = krajnjaVremena;

            return lists;
        }

        public static string OutputHistory(string query, string startDate, string endDate)
        {
            bool flagError = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://mehatronika.ddns.net:40001/iot/istorijaizlaz");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            try
            {
                using (var streamWriter = new
                StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(new
                    {
                        idmodula = query,
                        vod = startDate,
                        vdo = endDate
                    });

                    streamWriter.Write(json);
                }
            }
            catch
            {
                if (MessageBox.Show("Da li želite da zatvorite aplikaciju?\nAko želite da nastavite, konektujte se na internet i pritisnite 'No'", "Nemate internet konekciju!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    flagError = true;
                    Application.Exit();
                }
              
            }

            if (flagError == false)
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return result;
                }
            }
            else
            {
                return "[{}]";
            }
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            txtCurrDateStart.Text = dtpStart.Value.ToString("dd-MM-yyyy");
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            txtCurrDateEnd.Text = dtpEnd.Value.ToString("dd-MM-yyyy");
        }

        static byte[] ValueToBits(byte input)
        {
            BitArray ba = new BitArray(new byte[] { input });
            byte[] number = new byte[8];

            for (int i = 0; i < ba.Length; i++)
            {
                if (ba[i])
                {
                    number[7 - i] = 1;
                }
                else
                {
                    number[7 - i] = 0;
                }
            }
            return number;
        }
        static byte[] Masking(byte[] inputArray, byte[] mask)
        {
            byte[] izlaz = new byte[8];

            for (int i = 0; i < izlaz.Length; i++)
            {
                izlaz[i] = (byte)(inputArray[i] & mask[i]);
            }

            return izlaz;
        }
        static byte ValueFromBits(byte[] array)
        {
            byte izlaz = 0;
            byte maxBit = 128;

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] == 1)
                {
                    izlaz += (byte)(maxBit / Math.Pow(2, i));
                }
            }

            return izlaz;
        }


    }
}
