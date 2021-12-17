
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
            this.cbxFilterOp = new System.Windows.Forms.ComboBox();
            this.lbxPillen_Aantal = new System.Windows.Forms.ListBox();
            this.btPil_Ingenomen = new System.Windows.Forms.Button();
            this.btPil_Niet_Ingenomen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btOpl = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxSelectPatient_Temp
            // 
            this.cbxSelectPatient_Temp.FormattingEnabled = true;
            this.cbxSelectPatient_Temp.Location = new System.Drawing.Point(6, 28);
            this.cbxSelectPatient_Temp.Name = "cbxSelectPatient_Temp";
            this.cbxSelectPatient_Temp.Size = new System.Drawing.Size(141, 24);
            this.cbxSelectPatient_Temp.TabIndex = 0;
            this.cbxSelectPatient_Temp.SelectedIndexChanged += new System.EventHandler(this.cbxSelectPatient_Temp_SelectedIndexChanged);
            // 
            // cbxFilterOp
            // 
            this.cbxFilterOp.FormattingEnabled = true;
            this.cbxFilterOp.Location = new System.Drawing.Point(166, 92);
            this.cbxFilterOp.Name = "cbxFilterOp";
            this.cbxFilterOp.Size = new System.Drawing.Size(121, 24);
            this.cbxFilterOp.TabIndex = 1;
            this.cbxFilterOp.SelectedIndexChanged += new System.EventHandler(this.cbxFilterOp_SelectedIndexChanged);
            // 
            // lbxPillen_Aantal
            // 
            this.lbxPillen_Aantal.FormattingEnabled = true;
            this.lbxPillen_Aantal.ItemHeight = 16;
            this.lbxPillen_Aantal.Location = new System.Drawing.Point(39, 122);
            this.lbxPillen_Aantal.Name = "lbxPillen_Aantal";
            this.lbxPillen_Aantal.Size = new System.Drawing.Size(248, 292);
            this.lbxPillen_Aantal.TabIndex = 2;
            this.lbxPillen_Aantal.SelectedIndexChanged += new System.EventHandler(this.lbxPillen_Aantal_SelectedIndexChanged);
            // 
            // btPil_Ingenomen
            // 
            this.btPil_Ingenomen.Location = new System.Drawing.Point(39, 420);
            this.btPil_Ingenomen.Name = "btPil_Ingenomen";
            this.btPil_Ingenomen.Size = new System.Drawing.Size(121, 44);
            this.btPil_Ingenomen.TabIndex = 3;
            this.btPil_Ingenomen.Text = "Pil wel ingenomen";
            this.btPil_Ingenomen.UseVisualStyleBackColor = true;
            this.btPil_Ingenomen.Click += new System.EventHandler(this.btPil_Ingenomen_Click);
            // 
            // btPil_Niet_Ingenomen
            // 
            this.btPil_Niet_Ingenomen.Location = new System.Drawing.Point(166, 420);
            this.btPil_Niet_Ingenomen.Name = "btPil_Niet_Ingenomen";
            this.btPil_Niet_Ingenomen.Size = new System.Drawing.Size(121, 44);
            this.btPil_Niet_Ingenomen.TabIndex = 4;
            this.btPil_Niet_Ingenomen.Text = "Pil Niet ingenomen";
            this.btPil_Niet_Ingenomen.UseVisualStyleBackColor = true;
            this.btPil_Niet_Ingenomen.Click += new System.EventHandler(this.btPil_Niet_Ingenomen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.cbxSelectPatient_Temp);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 58);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temp Patient select";
            // 
            // btOpl
            // 
            this.btOpl.Location = new System.Drawing.Point(39, 470);
            this.btOpl.Name = "btOpl";
            this.btOpl.Size = new System.Drawing.Size(121, 44);
            this.btOpl.TabIndex = 6;
            this.btOpl.Text = "Opslaan";
            this.btOpl.UseVisualStyleBackColor = true;
            this.btOpl.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(166, 470);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 44);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nieuwe aantal Pillen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 593);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btOpl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btPil_Niet_Ingenomen);
            this.Controls.Add(this.btPil_Ingenomen);
            this.Controls.Add(this.lbxPillen_Aantal);
            this.Controls.Add(this.cbxFilterOp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSelectPatient_Temp;
        private System.Windows.Forms.ComboBox cbxFilterOp;
        private System.Windows.Forms.ListBox lbxPillen_Aantal;
        private System.Windows.Forms.Button btPil_Ingenomen;
        private System.Windows.Forms.Button btPil_Niet_Ingenomen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btOpl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}

