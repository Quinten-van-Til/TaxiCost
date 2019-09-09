namespace Taxikosten_2
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.TimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.Kilometers = new System.Windows.Forms.TextBox();
            this.Prijs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimePicker2
            // 
            this.TimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker2.Location = new System.Drawing.Point(449, 249);
            this.TimePicker2.Name = "TimePicker2";
            this.TimePicker2.ShowUpDown = true;
            this.TimePicker2.Size = new System.Drawing.Size(200, 20);
            this.TimePicker2.TabIndex = 1;
            this.TimePicker2.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.TimePicker2.ValueChanged += new System.EventHandler(this.DateTimePicker2_ValueChanged);
            // 
            // TimePicker1
            // 
            this.TimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker1.Location = new System.Drawing.Point(449, 223);
            this.TimePicker1.Name = "TimePicker1";
            this.TimePicker1.ShowUpDown = true;
            this.TimePicker1.Size = new System.Drawing.Size(200, 20);
            this.TimePicker1.TabIndex = 2;
            this.TimePicker1.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.TimePicker1.ValueChanged += new System.EventHandler(this.TimePicker1_ValueChanged);
            // 
            // DatePicker
            // 
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(449, 275);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 20);
            this.DatePicker.TabIndex = 3;
            this.DatePicker.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.DatePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // Kilometers
            // 
            this.Kilometers.Location = new System.Drawing.Point(449, 197);
            this.Kilometers.Name = "Kilometers";
            this.Kilometers.Size = new System.Drawing.Size(200, 20);
            this.Kilometers.TabIndex = 4;
            this.Kilometers.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Prijs
            // 
            this.Prijs.BackColor = System.Drawing.SystemColors.Window;
            this.Prijs.Location = new System.Drawing.Point(449, 321);
            this.Prijs.Name = "Prijs";
            this.Prijs.ReadOnly = true;
            this.Prijs.Size = new System.Drawing.Size(200, 20);
            this.Prijs.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Aantal gereden kilometers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Begin tijd:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Eind tijd:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Datum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Totale kosten rit:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prijs);
            this.Controls.Add(this.Kilometers);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.TimePicker1);
            this.Controls.Add(this.TimePicker2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker TimePicker2;
        private System.Windows.Forms.DateTimePicker TimePicker1;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.TextBox Kilometers;
        private System.Windows.Forms.TextBox Prijs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

