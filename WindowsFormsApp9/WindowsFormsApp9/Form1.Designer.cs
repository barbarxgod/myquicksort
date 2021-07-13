namespace WindowsFormsApp9
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PVss = new System.Windows.Forms.Label();
            this.PivotTxt = new System.Windows.Forms.Label();
            this.InputTxt = new System.Windows.Forms.TextBox();
            this.combosecim = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.OutputTxt = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.myquicksort1 = new WindowsFormsApp9.myquicksort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(72, 30);
            this.label1.MaximumSize = new System.Drawing.Size(500, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "MY QUICK SORT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(52, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "INPUT:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(52, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "ORDER:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(52, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "OUTPUT:";
            // 
            // PVss
            // 
            this.PVss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PVss.Location = new System.Drawing.Point(52, 375);
            this.PVss.Name = "PVss";
            this.PVss.Size = new System.Drawing.Size(100, 23);
            this.PVss.TabIndex = 4;
            this.PVss.Text = "PIVOT:";
            // 
            // PivotTxt
            // 
            this.PivotTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PivotTxt.Location = new System.Drawing.Point(105, 375);
            this.PivotTxt.Name = "PivotTxt";
            this.PivotTxt.Size = new System.Drawing.Size(100, 23);
            this.PivotTxt.TabIndex = 5;
            // 
            // InputTxt
            // 
            this.InputTxt.Location = new System.Drawing.Point(108, 127);
            this.InputTxt.Name = "InputTxt";
            this.InputTxt.Size = new System.Drawing.Size(220, 20);
            this.InputTxt.TabIndex = 7;
            this.InputTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // combosecim
            // 
            this.combosecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combosecim.FormattingEnabled = true;
            this.combosecim.Items.AddRange(new object[] {
            "KUCUKTEN BUYUGE",
            "BUYUKTEN KUCUGE"});
            this.combosecim.Location = new System.Drawing.Point(108, 166);
            this.combosecim.Name = "combosecim";
            this.combosecim.Size = new System.Drawing.Size(121, 21);
            this.combosecim.TabIndex = 9;
            this.combosecim.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(154, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "YENILE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(235, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "ÇIKIŞ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // OutputTxt
            // 
            this.OutputTxt.FormattingEnabled = true;
            this.OutputTxt.Location = new System.Drawing.Point(123, 235);
            this.OutputTxt.Name = "OutputTxt";
            this.OutputTxt.Size = new System.Drawing.Size(144, 134);
            this.OutputTxt.TabIndex = 12;
            this.OutputTxt.SelectedIndexChanged += new System.EventHandler(this.OutputTxt_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(334, 127);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 20);
            this.button4.TabIndex = 13;
            this.button4.Text = "TEMİZLE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // myquicksort1
            // 
            this.myquicksort1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.myquicksort1.Location = new System.Drawing.Point(253, 166);
            this.myquicksort1.Name = "myquicksort1";
            this.myquicksort1.Size = new System.Drawing.Size(105, 23);
            this.myquicksort1.TabIndex = 14;
            this.myquicksort1.Text = "myquicksort1";
            this.myquicksort1.UseVisualStyleBackColor = true;
            this.myquicksort1.Click += new System.EventHandler(this.myquicksort1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(478, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 10);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.myquicksort1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.OutputTxt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.combosecim);
            this.Controls.Add(this.InputTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PivotTxt);
            this.Controls.Add(this.PVss);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PVss;
        private System.Windows.Forms.Label PivotTxt;
        private System.Windows.Forms.TextBox InputTxt;
        private System.Windows.Forms.ComboBox combosecim;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListBox OutputTxt;
        private System.Windows.Forms.Button button4;
        private myquicksort myquicksort1;
        private System.Windows.Forms.Button button1;
    }
}

