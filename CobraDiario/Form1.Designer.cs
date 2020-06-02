namespace CobraDiario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtMoneyCharge = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtSecondName = new System.Windows.Forms.TextBox();
            this.CmbZoneWork = new System.Windows.Forms.ComboBox();
            this.DtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.DtpRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(142, 144);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(100, 20);
            this.TxtFirstName.TabIndex = 0;
            // 
            // TxtMoneyCharge
            // 
            this.TxtMoneyCharge.Location = new System.Drawing.Point(142, 267);
            this.TxtMoneyCharge.Name = "TxtMoneyCharge";
            this.TxtMoneyCharge.Size = new System.Drawing.Size(100, 20);
            this.TxtMoneyCharge.TabIndex = 1;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(142, 226);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(100, 20);
            this.TxtLastName.TabIndex = 2;
            // 
            // TxtSecondName
            // 
            this.TxtSecondName.Location = new System.Drawing.Point(142, 185);
            this.TxtSecondName.Name = "TxtSecondName";
            this.TxtSecondName.Size = new System.Drawing.Size(100, 20);
            this.TxtSecondName.TabIndex = 3;
            // 
            // CmbZoneWork
            // 
            this.CmbZoneWork.FormattingEnabled = true;
            this.CmbZoneWork.Items.AddRange(new object[] {
            "CENTRO",
            "NORTE",
            "SUR",
            "OCCIDENTE",
            "ORIENTE"});
            this.CmbZoneWork.Location = new System.Drawing.Point(142, 308);
            this.CmbZoneWork.Name = "CmbZoneWork";
            this.CmbZoneWork.Size = new System.Drawing.Size(121, 21);
            this.CmbZoneWork.TabIndex = 4;
            // 
            // DtpBirthDate
            // 
            this.DtpBirthDate.Location = new System.Drawing.Point(142, 350);
            this.DtpBirthDate.Name = "DtpBirthDate";
            this.DtpBirthDate.Size = new System.Drawing.Size(200, 20);
            this.DtpBirthDate.TabIndex = 5;
            // 
            // DtpRegistrationDate
            // 
            this.DtpRegistrationDate.Location = new System.Drawing.Point(142, 391);
            this.DtpRegistrationDate.Name = "DtpRegistrationDate";
            this.DtpRegistrationDate.Size = new System.Drawing.Size(200, 20);
            this.DtpRegistrationDate.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Primer Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha de nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Zona ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dinero a Cargo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Segundo Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha de registro";
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(381, 363);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(86, 37);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(139, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "REGISTRO DE COBRADOR\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(105, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "ID";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(142, 100);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 20);
            this.TxtID.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 448);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtpRegistrationDate);
            this.Controls.Add(this.DtpBirthDate);
            this.Controls.Add(this.CmbZoneWork);
            this.Controls.Add(this.TxtSecondName);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtMoneyCharge);
            this.Controls.Add(this.TxtFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtMoneyCharge;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtSecondName;
        private System.Windows.Forms.ComboBox CmbZoneWork;
        private System.Windows.Forms.DateTimePicker DtpBirthDate;
        private System.Windows.Forms.DateTimePicker DtpRegistrationDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtID;
    }
}

