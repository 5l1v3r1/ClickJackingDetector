using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace ClickJacking_Detector
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 
        private void owaspDefenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Launch("https://www.owasp.org/index.php/Clickjacking_Defense_Cheat_Sheet");
        }
        public static void Launch(string p)
        {
            try
            {
                System.Diagnostics.Process.Start(p);
            }
            catch { }
        }
        private void wikipediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Launch("https://en.wikipedia.org/wiki/Clickjacking");
        }
        private void labelResult_TextChanged(object sender, EventArgs e)
        {
            labelFinalResult.Text = (((labelXframeValue.Text == "")) ? "" : " Not ") + "vulnerable";
            labelFinalResult.ForeColor = (labelFinalResult.Text.Contains("Not") ? (Color.Green) : (Color.Red));
        }
        private void linkLabelSelectMethod_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSelMethod f = new FrmSelMethod();
            if (f.ShowDialog() != DialogResult.OK)
                return;
            this.textBoxMethod.Text = f.SelectedMethod();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            xFrameOptionsToolStripMenuItem.Visible = currentHeadersToolStripMenuItem.Visible = true;
            this.statue = this.Xframe = this.headers = "";
            headerscount = 0;
            labelXframeValue.Text = "";
            this.succeed = false;
            SendRequest();
            this.Visible = true;





        }
        public bool succeed = false;
        public int headerscount = 0;
        private void SendRequest()
        {
            try
            {
                var req = (HttpWebRequest)WebRequest.Create(url);
                req.UserAgent = "Mozilla/5.0 (Windows NT 6.1; rv:46.0) Gecko/20100101 Firefox/46.0";
                req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                req.Headers.Add("Accept-Language", "en-US,en;q=0.5");
                req.Method=(string.IsNullOrEmpty(textBoxMethod.Text)?"GET":textBoxMethod.Text);
                req.Timeout = 20000;
               
                var resp = (HttpWebResponse)req.GetResponse();
                var m = new StreamReader(resp.GetResponseStream()).ReadToEnd();

                this.Xframe = resp.Headers["X-Frame-Options"];
                if (this.Xframe == "")
                    this.Xframe = resp.Headers["x-frame-options"];

                this.labelXframeValue.Text = Xframe;
                this.requestCompleted = true;
                this.statue =Xframe;

                WebHeaderCollection hd = resp.Headers;
                for (int i = 0; i < hd.Count; i++)
                {
                    string header__ = hd.GetKey(i);
                    string[] values = hd.GetValues(header__);
                    if (values.Length > 0)
                    {
                        for (int j = 0; j < values.Length; j++)
                        {
                            if (!string.IsNullOrEmpty(values[j]))                            
                                this.headers += header__ + ":" + values[j] + "\r\n";
                             
                        }
                    }
                    else
                        this.headers += (header__ + "");
                }
                this.succeed = true;

            }
            catch(Exception s) {
                this.succeed = false;
                requestCompleted = true;
                bool _404 = s.Message.Contains("The remote server returned an error: (404) Not Found");
                MessageBox.Show(s.Message+(_404?"\r\n can not check for headers in 404 response\r\n":""),"error on connection");
            }
            labelFinalResult.Visible = labelXframeValue.Visible = xFrameOptionsToolStripMenuItem.Visible = currentHeadersToolStripMenuItem.Visible = succeed;
            labelerror.Visible = !succeed;

        }
         
        public string Xframe = "";
        public string statue ="";
        public string url = "";
         private void textBoxUrl_TextChanged(object sender, EventArgs e)
        {
            CheckNewURl();
        }

         private void CheckNewURl()
         {
             this.url = textBoxUrl.Text.Trim();
             buttonTest.Enabled = Program.IsUrl(textBoxUrl.Text);
             if (!buttonTest.Enabled  && !url.StartsWith("http"))
             {
                 this.url = "http://" + url;
                 buttonTest.Enabled = Program.IsUrl(url);
             }
         }

         private bool isIP(string url)
         {
             if (url.Contains("."))
             {
                 string[] dots = url.Split('.');
                 // 1.2.3.4
                 if (dots.Length < 4)
                     return false;
                 foreach (string d in dots)
                     if (!isnumber(d))
                         return false;
                 return true;
             }
             else return false;
         }

         private bool isnumber(string d)
         {
             foreach (char c in d)
                 if (c < '0' || c > '9')
                     return false;
             return !string.IsNullOrEmpty(d);
         }
        public bool requestCompleted =false;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(Size.Width+50,this.Size.Height+50);
                this.MinimumSize = this.Size;
            this.textBoxUrl.Text = "http://hackerone.com/";
            CheckNewURl();

        }

         
        public string  headers  ="";
        private void currentHeadersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(headers);
        }

        private void xFrameOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\r\n\"" + (string.IsNullOrEmpty(Xframe) ? "    Empty   " : Xframe) + "\"", "      Value of X-Frame-Options    ");

        }

        private void buttonTest_EnabledChanged(object sender, EventArgs e)
        {
            label3.Visible = !buttonTest.Enabled;
        }

        private void programPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Launch("http://github.com/YasserGersy/ClickJackingDetector");
        }

        private void developerToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            new FormDever().ShowDialog();
        }


    }
}
