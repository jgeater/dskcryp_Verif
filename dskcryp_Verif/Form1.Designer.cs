namespace dskcryp_Verif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tpmRedy = new System.Windows.Forms.Label();
            this.TPM_LockOut = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cur_BLStat = new System.Windows.Forms.Label();
            this.SHO_BL_VER = new System.Windows.Forms.Label();
            this.TPM_Redy_State = new System.Windows.Forms.Label();
            this.TPM_Cur_Lock_Stat = new System.Windows.Forms.Label();
            this.fixIt_Btn = new System.Windows.Forms.Button();
            this.exit_Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cur_RecKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tpmRedy
            // 
            this.tpmRedy.AutoSize = true;
            this.tpmRedy.Location = new System.Drawing.Point(73, 67);
            this.tpmRedy.Name = "tpmRedy";
            this.tpmRedy.Size = new System.Drawing.Size(67, 13);
            this.tpmRedy.TabIndex = 2;
            this.tpmRedy.Text = "TPM Ready:";
            // 
            // TPM_LockOut
            // 
            this.TPM_LockOut.AutoSize = true;
            this.TPM_LockOut.Location = new System.Drawing.Point(272, 67);
            this.TPM_LockOut.Name = "TPM_LockOut";
            this.TPM_LockOut.Size = new System.Drawing.Size(66, 13);
            this.TPM_LockOut.TabIndex = 4;
            this.TPM_LockOut.Text = "Locked Out:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // cur_BLStat
            // 
            this.cur_BLStat.AutoSize = true;
            this.cur_BLStat.BackColor = System.Drawing.Color.Yellow;
            this.cur_BLStat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cur_BLStat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cur_BLStat.Location = new System.Drawing.Point(146, 32);
            this.cur_BLStat.Name = "cur_BLStat";
            this.cur_BLStat.Size = new System.Drawing.Size(55, 15);
            this.cur_BLStat.TabIndex = 6;
            this.cur_BLStat.Text = "Unknown";
            this.cur_BLStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SHO_BL_VER
            // 
            this.SHO_BL_VER.AutoSize = true;
            this.SHO_BL_VER.BackColor = System.Drawing.Color.Yellow;
            this.SHO_BL_VER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SHO_BL_VER.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SHO_BL_VER.Location = new System.Drawing.Point(344, 34);
            this.SHO_BL_VER.Name = "SHO_BL_VER";
            this.SHO_BL_VER.Size = new System.Drawing.Size(55, 15);
            this.SHO_BL_VER.TabIndex = 8;
            this.SHO_BL_VER.Text = "Unknown";
            this.SHO_BL_VER.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TPM_Redy_State
            // 
            this.TPM_Redy_State.AutoSize = true;
            this.TPM_Redy_State.BackColor = System.Drawing.Color.Yellow;
            this.TPM_Redy_State.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TPM_Redy_State.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TPM_Redy_State.Location = new System.Drawing.Point(146, 65);
            this.TPM_Redy_State.Name = "TPM_Redy_State";
            this.TPM_Redy_State.Size = new System.Drawing.Size(55, 15);
            this.TPM_Redy_State.TabIndex = 9;
            this.TPM_Redy_State.Text = "Unknown";
            // 
            // TPM_Cur_Lock_Stat
            // 
            this.TPM_Cur_Lock_Stat.AutoSize = true;
            this.TPM_Cur_Lock_Stat.BackColor = System.Drawing.Color.Yellow;
            this.TPM_Cur_Lock_Stat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TPM_Cur_Lock_Stat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TPM_Cur_Lock_Stat.Location = new System.Drawing.Point(344, 67);
            this.TPM_Cur_Lock_Stat.Name = "TPM_Cur_Lock_Stat";
            this.TPM_Cur_Lock_Stat.Size = new System.Drawing.Size(55, 15);
            this.TPM_Cur_Lock_Stat.TabIndex = 10;
            this.TPM_Cur_Lock_Stat.Text = "Unknown";
            // 
            // fixIt_Btn
            // 
            this.fixIt_Btn.Enabled = false;
            this.fixIt_Btn.Location = new System.Drawing.Point(65, 314);
            this.fixIt_Btn.Name = "fixIt_Btn";
            this.fixIt_Btn.Size = new System.Drawing.Size(114, 56);
            this.fixIt_Btn.TabIndex = 11;
            this.fixIt_Btn.Text = "Fix It";
            this.fixIt_Btn.UseVisualStyleBackColor = true;
            this.fixIt_Btn.Click += new System.EventHandler(this.fixIt_Btn_Click);
            // 
            // exit_Btn
            // 
            this.exit_Btn.Location = new System.Drawing.Point(275, 314);
            this.exit_Btn.Name = "exit_Btn";
            this.exit_Btn.Size = new System.Drawing.Size(114, 56);
            this.exit_Btn.TabIndex = 12;
            this.exit_Btn.Text = "Exit";
            this.exit_Btn.UseVisualStyleBackColor = true;
            this.exit_Btn.Click += new System.EventHandler(this.exit_Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Bitlocker Protection Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Bitlocker Version: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Recovery Key:";
            // 
            // cur_RecKey
            // 
            this.cur_RecKey.AutoSize = true;
            this.cur_RecKey.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cur_RecKey.Location = new System.Drawing.Point(91, 102);
            this.cur_RecKey.Name = "cur_RecKey";
            this.cur_RecKey.Size = new System.Drawing.Size(55, 15);
            this.cur_RecKey.TabIndex = 16;
            this.cur_RecKey.Text = "Unknown";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 458);
            this.Controls.Add(this.cur_RecKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit_Btn);
            this.Controls.Add(this.fixIt_Btn);
            this.Controls.Add(this.TPM_Cur_Lock_Stat);
            this.Controls.Add(this.TPM_Redy_State);
            this.Controls.Add(this.SHO_BL_VER);
            this.Controls.Add(this.cur_BLStat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TPM_LockOut);
            this.Controls.Add(this.tpmRedy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Disk Encryption Verififcation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tpmRedy;
        private System.Windows.Forms.Label TPM_LockOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cur_BLStat;
        private System.Windows.Forms.Label SHO_BL_VER;
        private System.Windows.Forms.Label TPM_Redy_State;
        private System.Windows.Forms.Label TPM_Cur_Lock_Stat;
        private System.Windows.Forms.Button fixIt_Btn;
        private System.Windows.Forms.Button exit_Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cur_RecKey;
    }
}

