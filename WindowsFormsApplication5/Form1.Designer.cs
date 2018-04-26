namespace WindowsFormsApplication5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt__units = new System.Windows.Forms.TextBox();
            this.cb_types = new System.Windows.Forms.ComboBox();
            this.btn_cal = new System.Windows.Forms.Button();
            this.btn_ext = new System.Windows.Forms.Button();
            this.lbl_ba = new System.Windows.Forms.Label();
            this.lbl_tax = new System.Windows.Forms.Label();
            this.lbl_ta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Customer Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consumed Units :";
            // 
            // txt__units
            // 
            this.txt__units.Location = new System.Drawing.Point(137, 96);
            this.txt__units.Name = "txt__units";
            this.txt__units.Size = new System.Drawing.Size(167, 20);
            this.txt__units.TabIndex = 2;
            // 
            // cb_types
            // 
            this.cb_types.FormattingEnabled = true;
            this.cb_types.Items.AddRange(new object[] {
            "Domestic",
            "Business"});
            this.cb_types.Location = new System.Drawing.Point(137, 66);
            this.cb_types.Name = "cb_types";
            this.cb_types.Size = new System.Drawing.Size(167, 21);
            this.cb_types.TabIndex = 3;
            this.cb_types.Text = "Select Type";
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(137, 134);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(124, 23);
            this.btn_cal.TabIndex = 4;
            this.btn_cal.Text = "Calculate";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // btn_ext
            // 
            this.btn_ext.Location = new System.Drawing.Point(267, 133);
            this.btn_ext.Name = "btn_ext";
            this.btn_ext.Size = new System.Drawing.Size(36, 23);
            this.btn_ext.TabIndex = 5;
            this.btn_ext.Text = "Exit";
            this.btn_ext.UseVisualStyleBackColor = true;
            this.btn_ext.Click += new System.EventHandler(this.btn_ext_Click);
            // 
            // lbl_ba
            // 
            this.lbl_ba.AutoSize = true;
            this.lbl_ba.Location = new System.Drawing.Point(137, 177);
            this.lbl_ba.Name = "lbl_ba";
            this.lbl_ba.Size = new System.Drawing.Size(10, 13);
            this.lbl_ba.TabIndex = 6;
            this.lbl_ba.Text = " ";
            // 
            // lbl_tax
            // 
            this.lbl_tax.AutoSize = true;
            this.lbl_tax.Location = new System.Drawing.Point(137, 207);
            this.lbl_tax.Name = "lbl_tax";
            this.lbl_tax.Size = new System.Drawing.Size(10, 13);
            this.lbl_tax.TabIndex = 7;
            this.lbl_tax.Text = " ";
            // 
            // lbl_ta
            // 
            this.lbl_ta.AutoSize = true;
            this.lbl_ta.Location = new System.Drawing.Point(137, 239);
            this.lbl_ta.Name = "lbl_ta";
            this.lbl_ta.Size = new System.Drawing.Size(10, 13);
            this.lbl_ta.TabIndex = 8;
            this.lbl_ta.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 273);
            this.Controls.Add(this.lbl_ta);
            this.Controls.Add(this.lbl_tax);
            this.Controls.Add(this.lbl_ba);
            this.Controls.Add(this.btn_ext);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.cb_types);
            this.Controls.Add(this.txt__units);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Electricity Bill Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt__units;
        private System.Windows.Forms.ComboBox cb_types;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Button btn_ext;
        private System.Windows.Forms.Label lbl_ba;
        private System.Windows.Forms.Label lbl_tax;
        private System.Windows.Forms.Label lbl_ta;
    }
}

