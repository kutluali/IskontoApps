namespace IskontoHesaplamaUyg
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnIskontolu = new Button();
            txtListe = new TextBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtIsk3 = new TextBox();
            label3 = new Label();
            txtIsk2 = new TextBox();
            label2 = new Label();
            txtIsk1 = new TextBox();
            groupBox2 = new GroupBox();
            cbKdv = new ComboBox();
            label5 = new Label();
            label8 = new Label();
            txtIskontolu = new TextBox();
            btKdvli = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 51);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Liste Fiyatı";
            // 
            // btnIskontolu
            // 
            btnIskontolu.Location = new Point(87, 259);
            btnIskontolu.Name = "btnIskontolu";
            btnIskontolu.Size = new Size(102, 50);
            btnIskontolu.TabIndex = 1;
            btnIskontolu.Text = "İSKONTOLO FİYAT";
            btnIskontolu.UseVisualStyleBackColor = true;
            btnIskontolu.Click += btnIskontolu_Click;
            // 
            // txtListe
            // 
            txtListe.Location = new Point(124, 48);
            txtListe.Name = "txtListe";
            txtListe.Size = new Size(128, 23);
            txtListe.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtIsk3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtIsk2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtIsk1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtListe);
            groupBox1.Controls.Add(btnIskontolu);
            groupBox1.Location = new Point(39, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(275, 354);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "İSKONTO";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 198);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 9;
            label4.Text = "3. İskonto Oranı";
            // 
            // txtIsk3
            // 
            txtIsk3.Location = new Point(124, 195);
            txtIsk3.Name = "txtIsk3";
            txtIsk3.Size = new Size(128, 23);
            txtIsk3.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 154);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 7;
            label3.Text = "2. İskonto Oranı";
            // 
            // txtIsk2
            // 
            txtIsk2.Location = new Point(124, 151);
            txtIsk2.Name = "txtIsk2";
            txtIsk2.Size = new Size(128, 23);
            txtIsk2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 111);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 3;
            label2.Text = "1. İskonto Oranı";
            // 
            // txtIsk1
            // 
            txtIsk1.Location = new Point(124, 108);
            txtIsk1.Name = "txtIsk1";
            txtIsk1.Size = new Size(128, 23);
            txtIsk1.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbKdv);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtIskontolu);
            groupBox2.Controls.Add(btKdvli);
            groupBox2.Location = new Point(369, 54);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(275, 326);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "İSKONTO";
            // 
            // cbKdv
            // 
            cbKdv.FormattingEnabled = true;
            cbKdv.Location = new Point(119, 148);
            cbKdv.Name = "cbKdv";
            cbKdv.Size = new Size(128, 23);
            cbKdv.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 151);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 3;
            label5.Text = "KDV Oranı";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 94);
            label8.Name = "label8";
            label8.Size = new Size(87, 15);
            label8.TabIndex = 0;
            label8.Text = "İskontolu Fiyatı";
            // 
            // txtIskontolu
            // 
            txtIskontolu.Location = new Point(119, 91);
            txtIskontolu.Name = "txtIskontolu";
            txtIskontolu.Size = new Size(128, 23);
            txtIskontolu.TabIndex = 2;
            // 
            // btKdvli
            // 
            btKdvli.Location = new Point(99, 231);
            btKdvli.Name = "btKdvli";
            btKdvli.Size = new Size(102, 50);
            btKdvli.TabIndex = 1;
            btKdvli.Text = "KDV'li FİYATI";
            btKdvli.UseVisualStyleBackColor = true;
            btKdvli.Click += btKdvli_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "IskontoApp";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnIskontolu;
        private TextBox txtListe;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtIsk3;
        private Label label3;
        private TextBox txtIsk2;
        private Label label2;
        private TextBox txtIsk1;
        private GroupBox groupBox2;
        private Label label8;
        private TextBox txtIskontolu;
        private Button btKdvli;
        private ComboBox cbKdv;
        private Label label5;
    }
}
