namespace Bruh
{
    partial class FRM
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
            this.lbkiiratas = new System.Windows.Forms.Label();
            this.txnev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btgomb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txkaja = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbkiiratas
            // 
            this.lbkiiratas.AutoSize = true;
            this.lbkiiratas.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbkiiratas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbkiiratas.ForeColor = System.Drawing.Color.IndianRed;
            this.lbkiiratas.Location = new System.Drawing.Point(235, 170);
            this.lbkiiratas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbkiiratas.Name = "lbkiiratas";
            this.lbkiiratas.Size = new System.Drawing.Size(39, 20);
            this.lbkiiratas.TabIndex = 0;
            this.lbkiiratas.Text = "Név";
            // 
            // txnev
            // 
            this.txnev.Location = new System.Drawing.Point(239, 57);
            this.txnev.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txnev.Name = "txnev";
            this.txnev.Size = new System.Drawing.Size(123, 20);
            this.txnev.TabIndex = 1;
            this.txnev.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adja meg a nevét!";
            // 
            // btgomb
            // 
            this.btgomb.Location = new System.Drawing.Point(387, 77);
            this.btgomb.Name = "btgomb";
            this.btgomb.Size = new System.Drawing.Size(75, 41);
            this.btgomb.TabIndex = 3;
            this.btgomb.Text = "Mehet";
            this.btgomb.UseVisualStyleBackColor = true;
            this.btgomb.Click += new System.EventHandler(this.btgomb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adja meg a kedvenc ételét!";
            // 
            // txkaja
            // 
            this.txkaja.Location = new System.Drawing.Point(239, 116);
            this.txkaja.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txkaja.Name = "txkaja";
            this.txkaja.Size = new System.Drawing.Size(123, 20);
            this.txkaja.TabIndex = 5;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb2.ForeColor = System.Drawing.Color.IndianRed;
            this.lb2.Location = new System.Drawing.Point(235, 206);
            this.lb2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(41, 20);
            this.lb2.TabIndex = 6;
            this.lb2.Text = "Étel";
            // 
            // FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 260);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.txkaja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btgomb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txnev);
            this.Controls.Add(this.lbkiiratas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FRM";
            this.Text = "ELSO FORM";
            this.Shown += new System.EventHandler(this.FRM_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbkiiratas;
        private System.Windows.Forms.TextBox txnev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btgomb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txkaja;
        private System.Windows.Forms.Label lb2;
    }
}

