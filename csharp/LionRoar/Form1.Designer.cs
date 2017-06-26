namespace LionRoar
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mConsoleText = new System.Windows.Forms.ListView();
            this.mColHdr1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mColHdr2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mColHdr3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mSelSerial = new System.Windows.Forms.ComboBox();
            this.mBtnStart = new System.Windows.Forms.Button();
            this.mLblDelay = new System.Windows.Forms.Label();
            this.mTxtDelay = new System.Windows.Forms.TextBox();
            this.mLblUnits = new System.Windows.Forms.Label();
            this.mLblLastTime = new System.Windows.Forms.Label();
            this.mTxtLastTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mConsoleText
            // 
            this.mConsoleText.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mColHdr1,
            this.mColHdr2,
            this.mColHdr3});
            this.mConsoleText.Location = new System.Drawing.Point(12, 93);
            this.mConsoleText.Name = "mConsoleText";
            this.mConsoleText.Size = new System.Drawing.Size(359, 277);
            this.mConsoleText.TabIndex = 0;
            this.mConsoleText.UseCompatibleStateImageBehavior = false;
            this.mConsoleText.View = System.Windows.Forms.View.Details;
            // 
            // mColHdr1
            // 
            this.mColHdr1.Text = "Time";
            this.mColHdr1.Width = 100;
            // 
            // mColHdr2
            // 
            this.mColHdr2.Text = "Text";
            this.mColHdr2.Width = 192;
            // 
            // mColHdr3
            // 
            this.mColHdr3.Text = "Roar";
            // 
            // mSelSerial
            // 
            this.mSelSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mSelSerial.FormattingEnabled = true;
            this.mSelSerial.Location = new System.Drawing.Point(12, 12);
            this.mSelSerial.Name = "mSelSerial";
            this.mSelSerial.Size = new System.Drawing.Size(121, 21);
            this.mSelSerial.TabIndex = 1;
            // 
            // mBtnStart
            // 
            this.mBtnStart.Location = new System.Drawing.Point(139, 10);
            this.mBtnStart.Name = "mBtnStart";
            this.mBtnStart.Size = new System.Drawing.Size(75, 23);
            this.mBtnStart.TabIndex = 2;
            this.mBtnStart.Text = "Start";
            this.mBtnStart.UseVisualStyleBackColor = true;
            this.mBtnStart.Click += new System.EventHandler(this.mBtnStart_Click);
            // 
            // mLblDelay
            // 
            this.mLblDelay.AutoSize = true;
            this.mLblDelay.Location = new System.Drawing.Point(12, 45);
            this.mLblDelay.Name = "mLblDelay";
            this.mLblDelay.Size = new System.Drawing.Size(63, 13);
            this.mLblDelay.TabIndex = 3;
            this.mLblDelay.Text = "Time Delay:";
            // 
            // mTxtDelay
            // 
            this.mTxtDelay.Location = new System.Drawing.Point(82, 41);
            this.mTxtDelay.Name = "mTxtDelay";
            this.mTxtDelay.Size = new System.Drawing.Size(57, 20);
            this.mTxtDelay.TabIndex = 4;
            this.mTxtDelay.Text = "300";
            this.mTxtDelay.TextChanged += new System.EventHandler(this.mTxtDelay_TextChanged);
            // 
            // mLblUnits
            // 
            this.mLblUnits.AutoSize = true;
            this.mLblUnits.Location = new System.Drawing.Point(145, 44);
            this.mLblUnits.Name = "mLblUnits";
            this.mLblUnits.Size = new System.Drawing.Size(47, 13);
            this.mLblUnits.TabIndex = 5;
            this.mLblUnits.Text = "seconds";
            // 
            // mLblLastTime
            // 
            this.mLblLastTime.AutoSize = true;
            this.mLblLastTime.Location = new System.Drawing.Point(12, 67);
            this.mLblLastTime.Name = "mLblLastTime";
            this.mLblLastTime.Size = new System.Drawing.Size(56, 13);
            this.mLblLastTime.TabIndex = 6;
            this.mLblLastTime.Text = "Last Roar:";
            // 
            // mTxtLastTime
            // 
            this.mTxtLastTime.Location = new System.Drawing.Point(82, 67);
            this.mTxtLastTime.Name = "mTxtLastTime";
            this.mTxtLastTime.Size = new System.Drawing.Size(57, 20);
            this.mTxtLastTime.TabIndex = 7;
            this.mTxtLastTime.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 382);
            this.Controls.Add(this.mTxtLastTime);
            this.Controls.Add(this.mLblLastTime);
            this.Controls.Add(this.mLblUnits);
            this.Controls.Add(this.mTxtDelay);
            this.Controls.Add(this.mLblDelay);
            this.Controls.Add(this.mBtnStart);
            this.Controls.Add(this.mSelSerial);
            this.Controls.Add(this.mConsoleText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView mConsoleText;
        private System.Windows.Forms.ColumnHeader mColHdr1;
        private System.Windows.Forms.ColumnHeader mColHdr2;
        private System.Windows.Forms.ComboBox mSelSerial;
        private System.Windows.Forms.Button mBtnStart;
        private System.Windows.Forms.Label mLblDelay;
        private System.Windows.Forms.TextBox mTxtDelay;
        private System.Windows.Forms.Label mLblUnits;
        private System.Windows.Forms.Label mLblLastTime;
        private System.Windows.Forms.TextBox mTxtLastTime;
        private System.Windows.Forms.ColumnHeader mColHdr3;
    }
}

