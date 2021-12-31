using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        DataSlab data;
        String output;

        //int[] ticket = new int[5];

        List<int> ticketList = new List<int>();

        //array spot
        int x;
        int y;
        int size = 0;
        int count = 0;

        int[,] ticketData;


        public Form1()
        {
            InitializeComponent();
            btnProcess.Enabled = false;
            gbxOptions.Enabled = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //Establish File Dialog 
            OpenFileDialog ofdNew = new OpenFileDialog();

            ofdNew.InitialDirectory = "C:\\Users\\Retronet\\source\\repos\\Midas\\WindowsFormsApp2\\input";
            ofdNew.Filter = "Text Files|*.txt";
            ofdNew.Title = "Select a Text File";
            tbxLoad.Text = "";

            //Read and Sanitize input (invest in regex in the future to simplify this)
            if (ofdNew.ShowDialog() == DialogResult.OK)
            {
                //checks for end of file
                Boolean file = true;
                String line;

                var fileStream = ofdNew.OpenFile();

                using (StreamReader sr = new StreamReader(fileStream))
                {
                    while (file == true)
                    {
                        //try block to catch exception which happens at end of file
                        try
                        {
                            //read, clean, split
                            line = sr.ReadLine();
                            line = line.Trim(new char[] { ',', '[', ']' }) + " ";
                            string[] x = line.Split(' ', ',');

                            //convert, process, save
                            foreach (String number in x)
                            {
                                line = number.Trim(new char[] { ' ', '\r', '\n' });
                                if (line != "")
                                {
                                    int value = int.Parse(line);
                                    ticketList.Add(value);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            file = false;
                        }
                    }
                }

                //show they saved for really reals
                //ticketList.ForEach(el => System.Diagnostics.Debug.WriteLine(el));

            }

            size = ticketList.Count / 5;
            ticketData = new int[size, 5];

            //array fun times
            //first we tap on the row (first dimension) of the two dimensional array
            for (y = 0; y < size; y++)
            {
                //then we tap on the column (second dimension) of the two dimensional array
                for (x = 0; x < 5; x++)
                {
                    ticketData[y, x] = ticketList[count];
                    //System.Diagnostics.Debug.WriteLine(ticketData[y, x]);
                    tbxLoad.AppendText(Convert.ToString(ticketData[y, x]) + " ");
                    count++;
                }

                x = 0;
                tbxLoad.AppendText("\n");

            }

            data = new DataSlab(ticketData, size);
            btnProcess.Enabled = true;
            gbxOptions.Enabled = false;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            data.reorganizeData();
            data.modeData();
            data.meanData();
            data.rangeData();
            data.sextileData();
            data.marginData();

            output = data.printData();

            tbxLoad.Text = "";
            tbxLoad.AppendText(output);
            btnProcess.Enabled = false;
            gbxOptions.Enabled = true;
        }

        private void btnGen_Click(object sender, EventArgs e)
        {

            tbxTickets.Text = "";

            try
            {
                int result = Int32.Parse(tbxAmount.Text);

                if (result > 0) {
                    if (rbRandom.Checked)
                    {
                        tbxTickets.AppendText(data.genMachine(result));
                    }
                    else if (rbPool.Checked)
                    {
                        tbxTickets.AppendText(data.genPools(result));
                    }
                    else if (rbAvg.Checked)
                    {
                        tbxTickets.AppendText(data.genAverages(result));
                    }
                    else if (rbStrat.Checked)
                    {
                        tbxTickets.AppendText(data.genStrat(result));
                    }
                    else if (rbRange.Checked)
                    {
                        tbxTickets.AppendText(data.genRange(result));
                    }
                    else if (rbMargin.Checked)
                    {
                        tbxTickets.AppendText(data.genMargins(result));
                    }

                } else
                {
                    lblError.Text = "Please input a value greater than 0.";
                }
            }
            catch (FormatException)
            {
                lblError.Text = "Make sure to input a value for the amount of tickets you want.";
            }
        }
    }
}
