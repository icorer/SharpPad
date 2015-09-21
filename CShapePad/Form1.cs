using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using System.Threading;


namespace CShapePad
{
    public partial class Form1 : Skin_Metro
    {
        int status = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Web_Loaded(object sender, Awesomium.Core.FrameEventArgs e)
        {
          //  webControl1.Visible = true;
          //  js();
          //  status = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Loading...";
            this.BackColor = Color.FromArgb(255, 0, 34, 51);
           // this.InnerBorderColor = Color.FromArgb(255, 0, 34, 51);
           // this.EffectBack = Color.FromArgb(255, 0, 34, 51);
            webControl1.BackColor = Color.FromArgb(255, 0, 34, 51);
        //    webControl1.LoadHTML("<html><body bgcolor=\"red\"></body></html>");
           // webControl1.Source = new Uri("http://csharppad.com/");
          //  webControl1.Enabled = true;
            webControl1.Visible = false;

        }


        private void Web_Load(object sender, Awesomium.Core.LoadingFrameEventArgs e)
        {
            webControl1.BackColor = Color.FromArgb(255, 0, 34, 51);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          //  webControl1.Stop();
          //  webControl1.
            timer1.Stop();
            if (status == 0)
                this.Text = "Time Out";
            js();
        }


        private void js() {
            String js = "var obj=document.getElementsByClassName(\"pad-theme-dark\")[0];";
            js += "document.body.removeChild(obj);";
            js += "var obj2=document.getElementsByClassName(\"ui-dialog ui-widget ui-widget-content ui-corner-all ui-front ui-draggable ui-resizable\")[0];";
            //  js+="obj2.style.marginTop=\"40px\"";

           // js += "var js_tag=document.getElementsByTagName(\"script\");";
           // js += "document.body.removeChild(js_tag[23]);";
            webControl1.ExecuteJavascript(js);
           
           
            if (status == 0)
            {
                status = 1;
                webControl1.Reload(false);
              //  webControl1.Visible = false;
            }
            else
            {
                webControl1.Visible = true;
                this.Text = "C Sharp Pad";
            }
            
          ///  MessageBox.Show(status.ToString());
        }

        private void webSource_Loader(object sender, Awesomium.Core.DocumentReadyEventArgs e)
        {
           // MessageBox.Show("ok");
           
           // MessageBox.Show(  );


            js();
            //webControl1.Reload(false);
           // js();

          //  webControl1.Visible = true;

          //  webControl1
            }
    }
}
