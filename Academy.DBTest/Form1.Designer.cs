namespace Academy.DBTest
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
            this.btn_Clienti = new System.Windows.Forms.Button();
            this.lst_Clienti = new System.Windows.Forms.ListBox();
            this.lst_ContiCorrenti = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Clienti
            // 
            this.btn_Clienti.Location = new System.Drawing.Point(41, 35);
            this.btn_Clienti.Name = "btn_Clienti";
            this.btn_Clienti.Size = new System.Drawing.Size(151, 43);
            this.btn_Clienti.TabIndex = 0;
            this.btn_Clienti.Text = "Clienti";
            this.btn_Clienti.UseVisualStyleBackColor = true;
            // 
            // lst_Clienti
            // 
            this.lst_Clienti.FormattingEnabled = true;
            this.lst_Clienti.ItemHeight = 20;
            this.lst_Clienti.Location = new System.Drawing.Point(41, 122);
            this.lst_Clienti.Name = "lst_Clienti";
            this.lst_Clienti.Size = new System.Drawing.Size(151, 124);
            this.lst_Clienti.TabIndex = 1;
            this.lst_Clienti.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lst_ContiCorrenti
            // 
            this.lst_ContiCorrenti.FormattingEnabled = true;
            this.lst_ContiCorrenti.ItemHeight = 20;
            this.lst_ContiCorrenti.Location = new System.Drawing.Point(274, 122);
            this.lst_ContiCorrenti.Name = "lst_ContiCorrenti";
            this.lst_ContiCorrenti.Size = new System.Drawing.Size(173, 124);
            this.lst_ContiCorrenti.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_ContiCorrenti);
            this.Controls.Add(this.lst_Clienti);
            this.Controls.Add(this.btn_Clienti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Clienti;
        private System.Windows.Forms.ListBox lst_Clienti;
        private System.Windows.Forms.ListBox lst_ContiCorrenti;
    }
}

