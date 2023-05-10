namespace NLayeredArchitecture
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
            this.TxtID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnLIST = new System.Windows.Forms.Button();
            this.TxtNAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSURNAME = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCITY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTASK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSALARY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnADD = new System.Windows.Forms.Button();
            this.BtnDELETE = new System.Windows.Forms.Button();
            this.BtnUPDATE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(138, 24);
            this.TxtID.Margin = new System.Windows.Forms.Padding(4);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(148, 30);
            this.TxtID.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(762, 282);
            this.dataGridView1.TabIndex = 3;
            // 
            // BtnLIST
            // 
            this.BtnLIST.BackColor = System.Drawing.Color.Silver;
            this.BtnLIST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLIST.Location = new System.Drawing.Point(606, 21);
            this.BtnLIST.Name = "BtnLIST";
            this.BtnLIST.Size = new System.Drawing.Size(148, 32);
            this.BtnLIST.TabIndex = 4;
            this.BtnLIST.Text = "LIST";
            this.BtnLIST.UseVisualStyleBackColor = false;
            this.BtnLIST.Click += new System.EventHandler(this.BtnLIST_Click);
            // 
            // TxtNAME
            // 
            this.TxtNAME.Location = new System.Drawing.Point(138, 62);
            this.TxtNAME.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNAME.Name = "TxtNAME";
            this.TxtNAME.Size = new System.Drawing.Size(148, 30);
            this.TxtNAME.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "NAME:";
            // 
            // TxtSURNAME
            // 
            this.TxtSURNAME.Location = new System.Drawing.Point(138, 100);
            this.TxtSURNAME.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSURNAME.Name = "TxtSURNAME";
            this.TxtSURNAME.Size = new System.Drawing.Size(148, 30);
            this.TxtSURNAME.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "SURNAME:";
            // 
            // TxtCITY
            // 
            this.TxtCITY.Location = new System.Drawing.Point(416, 24);
            this.TxtCITY.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCITY.Name = "TxtCITY";
            this.TxtCITY.Size = new System.Drawing.Size(148, 30);
            this.TxtCITY.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "CITY:";
            // 
            // TxtTASK
            // 
            this.TxtTASK.Location = new System.Drawing.Point(416, 60);
            this.TxtTASK.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTASK.Name = "TxtTASK";
            this.TxtTASK.Size = new System.Drawing.Size(148, 30);
            this.TxtTASK.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "TASK:";
            // 
            // TxtSALARY
            // 
            this.TxtSALARY.Location = new System.Drawing.Point(416, 98);
            this.TxtSALARY.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSALARY.Name = "TxtSALARY";
            this.TxtSALARY.Size = new System.Drawing.Size(148, 30);
            this.TxtSALARY.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "SALARY:";
            // 
            // BtnADD
            // 
            this.BtnADD.BackColor = System.Drawing.Color.Silver;
            this.BtnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnADD.Location = new System.Drawing.Point(606, 59);
            this.BtnADD.Name = "BtnADD";
            this.BtnADD.Size = new System.Drawing.Size(148, 32);
            this.BtnADD.TabIndex = 15;
            this.BtnADD.Text = "ADD";
            this.BtnADD.UseVisualStyleBackColor = false;
            this.BtnADD.Click += new System.EventHandler(this.BtnADD_Click);
            // 
            // BtnDELETE
            // 
            this.BtnDELETE.BackColor = System.Drawing.Color.Silver;
            this.BtnDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDELETE.Location = new System.Drawing.Point(606, 97);
            this.BtnDELETE.Name = "BtnDELETE";
            this.BtnDELETE.Size = new System.Drawing.Size(148, 32);
            this.BtnDELETE.TabIndex = 16;
            this.BtnDELETE.Text = "DELETE";
            this.BtnDELETE.UseVisualStyleBackColor = false;
            this.BtnDELETE.Click += new System.EventHandler(this.BtnDELETE_Click);
            // 
            // BtnUPDATE
            // 
            this.BtnUPDATE.BackColor = System.Drawing.Color.Silver;
            this.BtnUPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUPDATE.Location = new System.Drawing.Point(606, 135);
            this.BtnUPDATE.Name = "BtnUPDATE";
            this.BtnUPDATE.Size = new System.Drawing.Size(148, 32);
            this.BtnUPDATE.TabIndex = 17;
            this.BtnUPDATE.Text = "UPDATE";
            this.BtnUPDATE.UseVisualStyleBackColor = false;
            this.BtnUPDATE.Click += new System.EventHandler(this.BtnUPDATE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 456);
            this.Controls.Add(this.BtnUPDATE);
            this.Controls.Add(this.BtnDELETE);
            this.Controls.Add(this.BtnADD);
            this.Controls.Add(this.TxtSALARY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtTASK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCITY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSURNAME);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnLIST);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnLIST;
        private System.Windows.Forms.TextBox TxtNAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSURNAME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCITY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTASK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSALARY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnADD;
        private System.Windows.Forms.Button BtnDELETE;
        private System.Windows.Forms.Button BtnUPDATE;
    }
}

