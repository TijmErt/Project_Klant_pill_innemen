
namespace Pil_ingenomen
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
            this.cbxSelectPatient_Temp = new System.Windows.Forms.ComboBox();
            this.lbxDate = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btOpl = new System.Windows.Forms.Button();
            this.lbxMedicijn = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbmedicineName = new System.Windows.Forms.Label();
            this.lbdose = new System.Windows.Forms.Label();
            this.lbingenomen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbwijzeInname = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxSelectPatient_Temp
            // 
            this.cbxSelectPatient_Temp.FormattingEnabled = true;
            this.cbxSelectPatient_Temp.Location = new System.Drawing.Point(6, 28);
            this.cbxSelectPatient_Temp.Name = "cbxSelectPatient_Temp";
            this.cbxSelectPatient_Temp.Size = new System.Drawing.Size(148, 24);
            this.cbxSelectPatient_Temp.TabIndex = 0;
            this.cbxSelectPatient_Temp.SelectedIndexChanged += new System.EventHandler(this.cbxSelectPatient_Temp_SelectedIndexChanged);
            // 
            // lbxDate
            // 
            this.lbxDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxDate.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbxDate.FormattingEnabled = true;
            this.lbxDate.ItemHeight = 15;
            this.lbxDate.Location = new System.Drawing.Point(12, 76);
            this.lbxDate.Name = "lbxDate";
            this.lbxDate.Size = new System.Drawing.Size(160, 62);
            this.lbxDate.TabIndex = 2;
            this.lbxDate.SelectedIndexChanged += new System.EventHandler(this.lbxPillen_Aantal_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.cbxSelectPatient_Temp);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 58);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temp Patient select";
            // 
            // btOpl
            // 
            this.btOpl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpl.Location = new System.Drawing.Point(6, 126);
            this.btOpl.Name = "btOpl";
            this.btOpl.Size = new System.Drawing.Size(68, 26);
            this.btOpl.TabIndex = 6;
            this.btOpl.Text = "Opslaan";
            this.btOpl.UseVisualStyleBackColor = true;
            this.btOpl.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbxMedicijn
            // 
            this.lbxMedicijn.FormattingEnabled = true;
            this.lbxMedicijn.ItemHeight = 16;
            this.lbxMedicijn.Location = new System.Drawing.Point(12, 144);
            this.lbxMedicijn.Name = "lbxMedicijn";
            this.lbxMedicijn.Size = new System.Drawing.Size(160, 68);
            this.lbxMedicijn.TabIndex = 8;
            this.lbxMedicijn.SelectedIndexChanged += new System.EventHandler(this.lbxMedicijn_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.lbwijzeInname);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lbingenomen);
            this.groupBox3.Controls.Add(this.lbdose);
            this.groupBox3.Controls.Add(this.lbmedicineName);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btOpl);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(179, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 158);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prescriptie Medicijn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Wijze inname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dose:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Medicijn:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbmedicineName
            // 
            this.lbmedicineName.AutoSize = true;
            this.lbmedicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmedicineName.Location = new System.Drawing.Point(70, 42);
            this.lbmedicineName.Name = "lbmedicineName";
            this.lbmedicineName.Size = new System.Drawing.Size(11, 13);
            this.lbmedicineName.TabIndex = 9;
            this.lbmedicineName.Text = "-";
            // 
            // lbdose
            // 
            this.lbdose.AutoSize = true;
            this.lbdose.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdose.Location = new System.Drawing.Point(48, 58);
            this.lbdose.Name = "lbdose";
            this.lbdose.Size = new System.Drawing.Size(11, 13);
            this.lbdose.TabIndex = 10;
            this.lbdose.Text = "-";
            // 
            // lbingenomen
            // 
            this.lbingenomen.AutoSize = true;
            this.lbingenomen.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbingenomen.Location = new System.Drawing.Point(80, 136);
            this.lbingenomen.Name = "lbingenomen";
            this.lbingenomen.Size = new System.Drawing.Size(11, 13);
            this.lbingenomen.TabIndex = 11;
            this.lbingenomen.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "ingenomen:";
            // 
            // lbwijzeInname
            // 
            this.lbwijzeInname.AutoSize = true;
            this.lbwijzeInname.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbwijzeInname.Location = new System.Drawing.Point(89, 72);
            this.lbwijzeInname.Name = "lbwijzeInname";
            this.lbwijzeInname.Size = new System.Drawing.Size(11, 13);
            this.lbwijzeInname.TabIndex = 13;
            this.lbwijzeInname.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(341, 430);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbxMedicijn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbxDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSelectPatient_Temp;
        private System.Windows.Forms.ListBox lbxDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btOpl;
        private System.Windows.Forms.ListBox lbxMedicijn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbingenomen;
        private System.Windows.Forms.Label lbdose;
        private System.Windows.Forms.Label lbmedicineName;
        private System.Windows.Forms.Label lbwijzeInname;
    }
}

