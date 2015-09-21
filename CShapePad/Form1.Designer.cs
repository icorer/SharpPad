namespace CShapePad
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webControl1 = new Awesomium.Windows.Forms.WebControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // webControl1
            // 
            this.webControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(51)))));
            this.webControl1.Location = new System.Drawing.Point(6, 36);
            this.webControl1.Size = new System.Drawing.Size(466, 410);
            this.webControl1.Source = new System.Uri("http://csharppad.com/", System.UriKind.Absolute);
            this.webControl1.TabIndex = 0;
            this.webControl1.DocumentReady += new Awesomium.Core.DocumentReadyEventHandler(this.webSource_Loader);
            this.webControl1.LoadingFrame += new Awesomium.Core.LoadingFrameEventHandler(this.Web_Load);
            this.webControl1.LoadingFrameComplete += new Awesomium.Core.FrameEventHandler(this.Web_Loaded);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(51)))));
            this.BackLayout = false;
            this.CanResize = false;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientSize = new System.Drawing.Size(478, 455);
            this.Controls.Add(this.webControl1);
            this.EffectBack = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.InheritBack = true;
            this.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(51)))));
            this.InternalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(51)))));
            this.InternalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(51)))));
            this.MaximizeBox = false;
            this.MdiAutoScroll = false;
            this.Name = "Form1";
            this.Radius = 2;
            this.SkinOpacity = 0.9D;
            this.Text = "C Sharp Pad";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Awesomium.Windows.Forms.WebControl webControl1;
        private System.Windows.Forms.Timer timer1;

    }
}

