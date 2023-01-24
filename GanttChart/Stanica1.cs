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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GanttChart
{
    public partial class Stanica1 : Form
    {
        GanttChart ganttChart1;
        public static Stanica1 instance;

        public DateTime pocetno;
        public DateTime krajnje;

        public string vakumStanica1;
        public string vakumStanica2;
        public string potrosnjaVazduha;
        public string cilindarUvucen;
        public string cilindarIzvucen;


        public Stanica1()
        {
            InitializeComponent();
            instance = this;
        }

        public struct TwoLists
        {
            public List<DateTime> pList;
            public List<DateTime> eList;
        }

        private void Stanica1_Load(object sender, EventArgs e)
        {

            ganttChart1 = new GanttChart();
            ganttChart1.AllowChange = false;
            ganttChart1.Dock = DockStyle.Fill;
            ganttChart1.FromDate = pocetno;
            ganttChart1.ToDate = krajnje;
            tableLayoutPanel1.Controls.Add(ganttChart1, 0, 1);

            ganttChart1.MouseMove += new MouseEventHandler(ganttChart1.GanttChart_MouseMove);
            ganttChart1.MouseMove += new MouseEventHandler(GanttChart1_MouseMove);
            ganttChart1.MouseDragged += new MouseEventHandler(ganttChart1.GanttChart_MouseDragged);
            ganttChart1.MouseLeave += new EventHandler(ganttChart1.GanttChart_MouseLeave);
            ganttChart1.ContextMenuStrip = ContextMenuGanttChart1;

            List<BarInformation> lst1 = new List<BarInformation>();
            List <TwoLists> incoming = Obradjeno();
            int index1 = 0;

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

            foreach (BarInformation bar in lst1)
            {
                ganttChart1.AddChartBar(bar.RowText, bar, bar.FromTime, bar.ToTime, bar.Color, bar.HoverColor, bar.Index);
            }

            lblCilindarIzv.Text = incoming[1].pList.Count.ToString() + " puta";
            lblCilindarUvu.Text = incoming[2].pList.Count.ToString() + " puta";

            TimeSpan vakumStan1 = TimeSpan.Zero, vakumStan2 = TimeSpan.Zero;
            for(int i = 0; i < incoming[0].pList.Count; i++)
            {
                TimeSpan temp = incoming[0].eList[i].Subtract(incoming[0].pList[i]);
                vakumStan1 += temp;
            }
            for(int i = 0; i < incoming[6].pList.Count; i++)
            {
                TimeSpan temp = incoming[6].eList[i].Subtract(incoming[6].pList[i]);
                vakumStan2 += temp;
            }

            //Vakum 1
            if(vakumStan1.Minutes < 1 && vakumStan1.Hours < 1)
            {
                lblVakumStan1.Text = vakumStan1.Seconds.ToString() + "s";
            } 
            else if(vakumStan1.Minutes > 1 && vakumStan1.Hours < 1)
            {
                lblVakumStan1.Text = vakumStan1.Minutes.ToString() + "min " + vakumStan1.Seconds.ToString() + "s";
            }
            else
            {
                lblVakumStan1.Text = vakumStan1.Hours.ToString() + "h " + vakumStan1.Minutes.ToString() + "min " + vakumStan1.Seconds.ToString() + "s";
            }

            //Vakum 2
            if (vakumStan2.Minutes < 1 && vakumStan2.Hours < 1)
            {
                lblVakumStan2.Text = vakumStan2.Seconds.ToString() + "s";
            }
            else if (vakumStan2.Minutes > 1 && vakumStan2.Hours < 1)
            {
                lblVakumStan2.Text = vakumStan2.Minutes.ToString() + "min " + vakumStan2.Seconds.ToString() + "s";
            }
            else
            {
                lblVakumStan2.Text = vakumStan2.Hours.ToString() + "h " + vakumStan2.Minutes.ToString() + "min " + vakumStan2.Seconds.ToString() + "s";
            }

            //70 l/min nominalni protok vazduha
            int potrosnja = (vakumStan1.Hours * 70 * 60) + (vakumStan1.Minutes * 70) + (vakumStan1.Seconds * 70 / 60) + (vakumStan2.Hours * 70 * 60) + (vakumStan2.Minutes * 70) + (vakumStan2.Seconds * 70 / 60);
            lblPotrosnjaVazduha.Text = potrosnja.ToString() + " l/min";

            pbVazuh.Maximum = 70 * 60 * 8000;
            pbVazuh.Value = potrosnja;
        }

        public List<TwoLists> Obradjeno()
        {
            byte[] maska_bit1 = new byte[] { 0, 0, 0, 0, 0, 0, 0, 1 };
            byte[] maska_bit2 = new byte[] { 0, 0, 0, 0, 0, 0, 1, 0 };
            byte[] maska_bit3 = new byte[] { 0, 0, 0, 0, 0, 1, 0, 0 };
            byte[] maska_bit4 = new byte[] { 0, 0, 0, 0, 1, 0, 0, 0 };
            byte[] maska_bit5 = new byte[] { 0, 0, 0, 1, 0, 0, 0, 0 };
            byte[] maska_bit6 = new byte[] { 0, 0, 1, 0, 0, 0, 0, 0 };

            List<TwoLists> lists = new List<TwoLists>();

            //**************** STANICA 1 *********************//
            TwoLists vakum1 = Obrada("1", maska_bit1, 1, false);  // incoming[0]
            lists.Add(vakum1);
            TwoLists cilindarIzvucen = Obrada("1", maska_bit2, 2, false); //incoming[1]
            lists.Add(cilindarIzvucen);
            TwoLists cilindarUvucen = Obrada("1", maska_bit3, 4, false); //incoming[2]
            lists.Add(cilindarUvucen);
            TwoLists prazanMagacin = Obrada("1", maska_bit4, 8, false); //incoming[3]
            lists.Add(prazanMagacin);
            TwoLists kranDoMagacina = Obrada("1", maska_bit5, 16, false); //incoming[4]
            lists.Add(kranDoMagacina);
            TwoLists kranDoStanice = Obrada("1", maska_bit6, 32, false); //incoming[5]
            lists.Add(kranDoStanice);

            TwoLists vakum2 = Obrada("1", maska_bit1, 1, true); //incoming[6]
            lists.Add(vakum2);

            return lists;
        }

        public TwoLists Obrada(string IOmodul, byte[] maska, int vrednostBita, bool brojIzlaza)
        {
            string vod = pocetno.ToString("yyyy-MM-dd");
            string vdo = krajnje.ToString("yyyy-MM-dd");

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
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://mehatronika.ddns.net:40001/iot/istorijaizlaz");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
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
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                return result;
            }
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

        private void GanttChart1_MouseMove(Object sender, MouseEventArgs e)
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu strt = new StartMenu();
            strt.FormClosed += (s, args) => this.Close();
            strt.Show();
        }
    }
}
