using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;

namespace IPScanner
{
    public partial class Form1: Form
    {
        public Form1() { 
            InitializeComponent();
        }
        bool port(string host, int port = 1000) { return new TcpClient().ConnectAsync(host, port).Wait(2000); }
        string IP, PS3;
        int start, end;
        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread t = new Thread(() =>
            {
                try
                {
                    for (int i = start; i < end+1; i++)
                    {
                        if (port($"{IP}{i}"))
                        {
                            Clipboard.SetText($"{IP}{i}");
                            Console.WriteLine($"Connected at {IP}{i}");
                            PS3 = $"{IP}{i}";
                            bgWorker.ReportProgress(100);
                            break;
                        }
                        bgWorker.ReportProgress(i);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Clipboard.GetText());
                    Console.WriteLine(ex.Message);
                }
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
        }
        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            bool done = e.ProgressPercentage == 100;
            pBar.Value = done ? pBar.Maximum : e.ProgressPercentage;
            status.Text = done ? $"Connected to PS3 at {PS3}" : $"Scanning | {IP}{e.ProgressPercentage}...";
            if (done)
            {
                startPoint.Enabled = true;
                endPoint.Enabled = true;
                scanBtn.Enabled = true;
            }
        }
        private void scanBtn_Click(object sender, EventArgs e)
        {
            IP = $"{startPoint.Text.Split('.')[0]}.{startPoint.Text.Split('.')[1]}.{startPoint.Text.Split('.')[2]}.";
            start = Convert.ToInt32(startPoint.Text.Split('.')[3]);
            end = Convert.ToInt32(endPoint.Text.Split('.')[3]);
            pBar.Minimum = start;
            pBar.Maximum = end;
            startPoint.Enabled = false;
            endPoint.Enabled = false;
            scanBtn.Enabled = false;
            bgWorker.RunWorkerAsync();
        }
    }
}