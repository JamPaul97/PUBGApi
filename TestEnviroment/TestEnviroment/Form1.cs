using System;
using System.Drawing;
using PUGBApi;
using PUGBApi.Tempates;
using System.Windows.Forms;

namespace TestEnviroment
{
    public partial class Form1 : Form
    {
        int max = 100;
        int value = 0;
        Connector cn = new Connector("eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJqdGkiOiI4NGFjNDgwMC1kZDU4LTAxMzYtOTRmZi0xZDg1OGQxMzk3ZGMiLCJpc3MiOiJnYW1lbG9ja2VyIiwiaWF0IjoxNTQ0MzAyMDk5LCJwdWIiOiJibHVlaG9sZSIsInRpdGxlIjoicHViZyIsImFwcCI6InB1Z2ItbmV0In0.xIdyJslEYHq_WLL_TjrjfQJ177GcDD9BoPM9SoNntcw", Connector.Shards.steam, Connector.Regions.eu);
        public Form1()
        {
            InitializeComponent();
            //cn.UpdateProgress += updateProgress;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            backgroundWorker1.RunWorkerAsync();
            
        }
        public void updateProgress(int value, bool isMax)
        {
            if(isMax)
            {
                progressBar1.Maximum = value;
            }
            else
            {
                label1.Text = string.Format("Items {0} / {1}", value, progressBar1.Maximum);
                progressBar1.Value = value;
            }

        }
        public class DateStamp
        {
            public int Year = 0;
            public int Month = 0;
            public int Day = 0;
            public int Hour = 0;
            public int Minute = 0;
            public int Second = 0;
            public int Miliseconds = 0;
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

            
            
            
            
            //List<Match> matches = cn.GetMatchesByPlayer(pr);
            //Telemetry match = cn.GetTelemetry(matches[0]);

        }
        static void bubbleSort(float[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i] 
                        float temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Status st = cn.GetStatus();
            if (st.active)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = Color.Red;
            }
            this.Text = Convert.ToString(st.responseTime);
        }
    }
}
