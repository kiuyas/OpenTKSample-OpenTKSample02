namespace OpenTKSample02
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.glControl1 = new OpenTK.GLControl();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTargetY = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.trbTargetY = new System.Windows.Forms.TrackBar();
            this.lblTargetX = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.trbTargetX = new System.Windows.Forms.TrackBar();
            this.lblEyeZ = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trbEyeZ = new System.Windows.Forms.TrackBar();
            this.lblEyeY = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trbEyeY = new System.Windows.Forms.TrackBar();
            this.lblEyeX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trbEyeX = new System.Windows.Forms.TrackBar();
            this.lblBeta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trbBeta = new System.Windows.Forms.TrackBar();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trbAlpha = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trbTargetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTargetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEyeZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEyeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEyeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbAlpha)).BeginInit();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glControl1.AutoSize = true;
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(0, 0);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(624, 376);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.SizeChanged += new System.EventHandler(this.glControl1_SizeChanged);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            this.glControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseDown);
            this.glControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseMove);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(544, 448);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 60;
            this.btnReset.Text = "リセット";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTargetY
            // 
            this.lblTargetY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTargetY.Location = new System.Drawing.Point(384, 400);
            this.lblTargetY.Name = "lblTargetY";
            this.lblTargetY.Size = new System.Drawing.Size(32, 24);
            this.lblTargetY.TabIndex = 53;
            this.lblTargetY.Text = "000";
            this.lblTargetY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.Location = new System.Drawing.Point(208, 400);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 24);
            this.label16.TabIndex = 52;
            this.label16.Text = "TargetY";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbTargetY
            // 
            this.trbTargetY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbTargetY.AutoSize = false;
            this.trbTargetY.Location = new System.Drawing.Point(256, 400);
            this.trbTargetY.Maximum = 1000;
            this.trbTargetY.Minimum = -1000;
            this.trbTargetY.Name = "trbTargetY";
            this.trbTargetY.Size = new System.Drawing.Size(128, 24);
            this.trbTargetY.TabIndex = 51;
            this.trbTargetY.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbTargetY.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // lblTargetX
            // 
            this.lblTargetX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTargetX.Location = new System.Drawing.Point(384, 376);
            this.lblTargetX.Name = "lblTargetX";
            this.lblTargetX.Size = new System.Drawing.Size(32, 24);
            this.lblTargetX.TabIndex = 50;
            this.lblTargetX.Text = "000";
            this.lblTargetX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.Location = new System.Drawing.Point(208, 376);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 24);
            this.label18.TabIndex = 49;
            this.label18.Text = "TargetX";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbTargetX
            // 
            this.trbTargetX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbTargetX.AutoSize = false;
            this.trbTargetX.Location = new System.Drawing.Point(256, 376);
            this.trbTargetX.Maximum = 1000;
            this.trbTargetX.Minimum = -1000;
            this.trbTargetX.Name = "trbTargetX";
            this.trbTargetX.Size = new System.Drawing.Size(128, 24);
            this.trbTargetX.TabIndex = 48;
            this.trbTargetX.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbTargetX.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // lblEyeZ
            // 
            this.lblEyeZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEyeZ.Location = new System.Drawing.Point(168, 424);
            this.lblEyeZ.Name = "lblEyeZ";
            this.lblEyeZ.Size = new System.Drawing.Size(32, 24);
            this.lblEyeZ.TabIndex = 41;
            this.lblEyeZ.Text = "000";
            this.lblEyeZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.Location = new System.Drawing.Point(0, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 24);
            this.label6.TabIndex = 40;
            this.label6.Text = "EyeZ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbEyeZ
            // 
            this.trbEyeZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbEyeZ.AutoSize = false;
            this.trbEyeZ.Location = new System.Drawing.Point(40, 424);
            this.trbEyeZ.Maximum = 1000;
            this.trbEyeZ.Minimum = -1000;
            this.trbEyeZ.Name = "trbEyeZ";
            this.trbEyeZ.Size = new System.Drawing.Size(128, 24);
            this.trbEyeZ.TabIndex = 39;
            this.trbEyeZ.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbEyeZ.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // lblEyeY
            // 
            this.lblEyeY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEyeY.Location = new System.Drawing.Point(168, 400);
            this.lblEyeY.Name = "lblEyeY";
            this.lblEyeY.Size = new System.Drawing.Size(32, 24);
            this.lblEyeY.TabIndex = 38;
            this.lblEyeY.Text = "000";
            this.lblEyeY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Location = new System.Drawing.Point(0, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "EyeY";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbEyeY
            // 
            this.trbEyeY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbEyeY.AutoSize = false;
            this.trbEyeY.Location = new System.Drawing.Point(40, 400);
            this.trbEyeY.Maximum = 1000;
            this.trbEyeY.Minimum = -1000;
            this.trbEyeY.Name = "trbEyeY";
            this.trbEyeY.Size = new System.Drawing.Size(128, 24);
            this.trbEyeY.TabIndex = 36;
            this.trbEyeY.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbEyeY.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // lblEyeX
            // 
            this.lblEyeX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEyeX.Location = new System.Drawing.Point(168, 376);
            this.lblEyeX.Name = "lblEyeX";
            this.lblEyeX.Size = new System.Drawing.Size(32, 24);
            this.lblEyeX.TabIndex = 35;
            this.lblEyeX.Text = "000";
            this.lblEyeX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(0, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "EyeX";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbEyeX
            // 
            this.trbEyeX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbEyeX.AutoSize = false;
            this.trbEyeX.Location = new System.Drawing.Point(40, 376);
            this.trbEyeX.Maximum = 1000;
            this.trbEyeX.Minimum = -1000;
            this.trbEyeX.Name = "trbEyeX";
            this.trbEyeX.Size = new System.Drawing.Size(128, 24);
            this.trbEyeX.TabIndex = 33;
            this.trbEyeX.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbEyeX.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // lblBeta
            // 
            this.lblBeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBeta.Location = new System.Drawing.Point(384, 448);
            this.lblBeta.Name = "lblBeta";
            this.lblBeta.Size = new System.Drawing.Size(32, 24);
            this.lblBeta.TabIndex = 66;
            this.lblBeta.Text = "000";
            this.lblBeta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Location = new System.Drawing.Point(208, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 65;
            this.label3.Text = "β";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbBeta
            // 
            this.trbBeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbBeta.AutoSize = false;
            this.trbBeta.Location = new System.Drawing.Point(256, 448);
            this.trbBeta.Maximum = 1000;
            this.trbBeta.Minimum = -1000;
            this.trbBeta.Name = "trbBeta";
            this.trbBeta.Size = new System.Drawing.Size(128, 24);
            this.trbBeta.TabIndex = 64;
            this.trbBeta.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbBeta.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // lblAlpha
            // 
            this.lblAlpha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAlpha.Location = new System.Drawing.Point(168, 448);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(32, 24);
            this.lblAlpha.TabIndex = 63;
            this.lblAlpha.Text = "000";
            this.lblAlpha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.Location = new System.Drawing.Point(0, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 24);
            this.label7.TabIndex = 62;
            this.label7.Text = "α";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbAlpha
            // 
            this.trbAlpha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbAlpha.AutoSize = false;
            this.trbAlpha.Location = new System.Drawing.Point(40, 448);
            this.trbAlpha.Maximum = 1000;
            this.trbAlpha.Minimum = -1000;
            this.trbAlpha.Name = "trbAlpha";
            this.trbAlpha.Size = new System.Drawing.Size(128, 24);
            this.trbAlpha.TabIndex = 61;
            this.trbAlpha.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbAlpha.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 475);
            this.Controls.Add(this.lblBeta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trbBeta);
            this.Controls.Add(this.lblAlpha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trbAlpha);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblTargetY);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.trbTargetY);
            this.Controls.Add(this.lblTargetX);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.trbTargetX);
            this.Controls.Add(this.lblEyeZ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trbEyeZ);
            this.Controls.Add(this.lblEyeY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trbEyeY);
            this.Controls.Add(this.lblEyeX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trbEyeX);
            this.Controls.Add(this.glControl1);
            this.Name = "Form1";
            this.Text = "OpenTKSample02";
            ((System.ComponentModel.ISupportInitialize)(this.trbTargetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTargetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEyeZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEyeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEyeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbAlpha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTargetY;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TrackBar trbTargetY;
        private System.Windows.Forms.Label lblTargetX;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TrackBar trbTargetX;
        private System.Windows.Forms.Label lblEyeZ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trbEyeZ;
        private System.Windows.Forms.Label lblEyeY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trbEyeY;
        private System.Windows.Forms.Label lblEyeX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trbEyeX;
        private System.Windows.Forms.Label lblBeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trbBeta;
        private System.Windows.Forms.Label lblAlpha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trbAlpha;
    }
}

