namespace lab2bb
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
            this.buttCalculate = new System.Windows.Forms.Button();
            this.buttClear = new System.Windows.Forms.Button();
            this.buttExit = new System.Windows.Forms.Button();
            this.HairDresser = new System.Windows.Forms.GroupBox();
            this.rbLaura = new System.Windows.Forms.RadioButton();
            this.rbSue = new System.Windows.Forms.RadioButton();
            this.rbRon = new System.Windows.Forms.RadioButton();
            this.rbPat = new System.Windows.Forms.RadioButton();
            this.rbJane = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkExtension = new System.Windows.Forms.CheckBox();
            this.ChkHightlights = new System.Windows.Forms.CheckBox();
            this.chkColour = new System.Windows.Forms.CheckBox();
            this.chkHaircut = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbSenior = new System.Windows.Forms.RadioButton();
            this.rbstudent = new System.Windows.Forms.RadioButton();
            this.rbChild = new System.Windows.Forms.RadioButton();
            this.rbAdult = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBoxNoVisits = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HairDresser.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttCalculate
            // 
            this.buttCalculate.Location = new System.Drawing.Point(82, 622);
            this.buttCalculate.Name = "buttCalculate";
            this.buttCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttCalculate.TabIndex = 0;
            this.buttCalculate.Text = "Calculate";
            this.buttCalculate.UseVisualStyleBackColor = true;
            this.buttCalculate.Click += new System.EventHandler(this.buttCalculate_Click);
            // 
            // buttClear
            // 
            this.buttClear.Location = new System.Drawing.Point(288, 622);
            this.buttClear.Name = "buttClear";
            this.buttClear.Size = new System.Drawing.Size(75, 23);
            this.buttClear.TabIndex = 1;
            this.buttClear.Text = "Clear";
            this.buttClear.UseVisualStyleBackColor = true;
            this.buttClear.Click += new System.EventHandler(this.buttClear_Click);
            // 
            // buttExit
            // 
            this.buttExit.Location = new System.Drawing.Point(480, 622);
            this.buttExit.Name = "buttExit";
            this.buttExit.Size = new System.Drawing.Size(75, 23);
            this.buttExit.TabIndex = 2;
            this.buttExit.Text = "Exit";
            this.buttExit.UseVisualStyleBackColor = true;
            // 
            // HairDresser
            // 
            this.HairDresser.Controls.Add(this.rbLaura);
            this.HairDresser.Controls.Add(this.rbSue);
            this.HairDresser.Controls.Add(this.rbRon);
            this.HairDresser.Controls.Add(this.rbPat);
            this.HairDresser.Controls.Add(this.rbJane);
            this.HairDresser.Location = new System.Drawing.Point(82, 54);
            this.HairDresser.Name = "HairDresser";
            this.HairDresser.Size = new System.Drawing.Size(142, 224);
            this.HairDresser.TabIndex = 3;
            this.HairDresser.TabStop = false;
            this.HairDresser.Text = "Hair Dresser";
            // 
            // rbLaura
            // 
            this.rbLaura.AutoSize = true;
            this.rbLaura.Location = new System.Drawing.Point(17, 183);
            this.rbLaura.Name = "rbLaura";
            this.rbLaura.Size = new System.Drawing.Size(52, 17);
            this.rbLaura.TabIndex = 0;
            this.rbLaura.TabStop = true;
            this.rbLaura.Text = "Laura";
            this.rbLaura.UseVisualStyleBackColor = true;
            // 
            // rbSue
            // 
            this.rbSue.AutoSize = true;
            this.rbSue.Location = new System.Drawing.Point(17, 140);
            this.rbSue.Name = "rbSue";
            this.rbSue.Size = new System.Drawing.Size(44, 17);
            this.rbSue.TabIndex = 0;
            this.rbSue.TabStop = true;
            this.rbSue.Text = "Sue";
            this.rbSue.UseVisualStyleBackColor = true;
            // 
            // rbRon
            // 
            this.rbRon.AutoSize = true;
            this.rbRon.Location = new System.Drawing.Point(16, 102);
            this.rbRon.Name = "rbRon";
            this.rbRon.Size = new System.Drawing.Size(45, 17);
            this.rbRon.TabIndex = 0;
            this.rbRon.TabStop = true;
            this.rbRon.Text = "Ron";
            this.rbRon.UseVisualStyleBackColor = true;
            // 
            // rbPat
            // 
            this.rbPat.AutoSize = true;
            this.rbPat.Location = new System.Drawing.Point(16, 64);
            this.rbPat.Name = "rbPat";
            this.rbPat.Size = new System.Drawing.Size(41, 17);
            this.rbPat.TabIndex = 0;
            this.rbPat.TabStop = true;
            this.rbPat.Text = "Pat";
            this.rbPat.UseVisualStyleBackColor = true;
            // 
            // rbJane
            // 
            this.rbJane.AutoSize = true;
            this.rbJane.Location = new System.Drawing.Point(17, 29);
            this.rbJane.Name = "rbJane";
            this.rbJane.Size = new System.Drawing.Size(48, 17);
            this.rbJane.TabIndex = 0;
            this.rbJane.TabStop = true;
            this.rbJane.Text = "Jane";
            this.rbJane.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkExtension);
            this.groupBox2.Controls.Add(this.ChkHightlights);
            this.groupBox2.Controls.Add(this.chkColour);
            this.groupBox2.Controls.Add(this.chkHaircut);
            this.groupBox2.Location = new System.Drawing.Point(323, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 224);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Services";
            // 
            // chkExtension
            // 
            this.chkExtension.AutoSize = true;
            this.chkExtension.Location = new System.Drawing.Point(39, 183);
            this.chkExtension.Name = "chkExtension";
            this.chkExtension.Size = new System.Drawing.Size(72, 17);
            this.chkExtension.TabIndex = 3;
            this.chkExtension.Text = "Extension";
            this.chkExtension.UseVisualStyleBackColor = true;
            // 
            // ChkHightlights
            // 
            this.ChkHightlights.AutoSize = true;
            this.ChkHightlights.Location = new System.Drawing.Point(39, 129);
            this.ChkHightlights.Name = "ChkHightlights";
            this.ChkHightlights.Size = new System.Drawing.Size(72, 17);
            this.ChkHightlights.TabIndex = 2;
            this.ChkHightlights.Text = "Highlights";
            this.ChkHightlights.UseVisualStyleBackColor = true;
            // 
            // chkColour
            // 
            this.chkColour.AutoSize = true;
            this.chkColour.Location = new System.Drawing.Point(39, 79);
            this.chkColour.Name = "chkColour";
            this.chkColour.Size = new System.Drawing.Size(56, 17);
            this.chkColour.TabIndex = 1;
            this.chkColour.Text = "Colour";
            this.chkColour.UseVisualStyleBackColor = true;
            // 
            // chkHaircut
            // 
            this.chkHaircut.AutoSize = true;
            this.chkHaircut.Location = new System.Drawing.Point(39, 29);
            this.chkHaircut.Name = "chkHaircut";
            this.chkHaircut.Size = new System.Drawing.Size(61, 17);
            this.chkHaircut.TabIndex = 0;
            this.chkHaircut.Text = "HairCut";
            this.chkHaircut.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbSenior);
            this.groupBox3.Controls.Add(this.rbstudent);
            this.groupBox3.Controls.Add(this.rbChild);
            this.groupBox3.Controls.Add(this.rbAdult);
            this.groupBox3.Location = new System.Drawing.Point(82, 330);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 198);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Client Types";
            // 
            // rbSenior
            // 
            this.rbSenior.AutoSize = true;
            this.rbSenior.Location = new System.Drawing.Point(12, 150);
            this.rbSenior.Name = "rbSenior";
            this.rbSenior.Size = new System.Drawing.Size(55, 17);
            this.rbSenior.TabIndex = 3;
            this.rbSenior.TabStop = true;
            this.rbSenior.Text = "Senior";
            this.rbSenior.UseVisualStyleBackColor = true;
            // 
            // rbstudent
            // 
            this.rbstudent.AutoSize = true;
            this.rbstudent.Location = new System.Drawing.Point(12, 107);
            this.rbstudent.Name = "rbstudent";
            this.rbstudent.Size = new System.Drawing.Size(62, 17);
            this.rbstudent.TabIndex = 2;
            this.rbstudent.TabStop = true;
            this.rbstudent.Text = "Student";
            this.rbstudent.UseVisualStyleBackColor = true;
            // 
            // rbChild
            // 
            this.rbChild.AutoSize = true;
            this.rbChild.Location = new System.Drawing.Point(12, 74);
            this.rbChild.Name = "rbChild";
            this.rbChild.Size = new System.Drawing.Size(48, 17);
            this.rbChild.TabIndex = 1;
            this.rbChild.TabStop = true;
            this.rbChild.Text = "Child";
            this.rbChild.UseVisualStyleBackColor = true;
            // 
            // rbAdult
            // 
            this.rbAdult.AutoSize = true;
            this.rbAdult.Location = new System.Drawing.Point(12, 37);
            this.rbAdult.Name = "rbAdult";
            this.rbAdult.Size = new System.Drawing.Size(49, 17);
            this.rbAdult.TabIndex = 0;
            this.rbAdult.TabStop = true;
            this.rbAdult.Text = "Adult";
            this.rbAdult.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBoxNoVisits);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(323, 330);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 198);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Clients Visits";
            // 
            // txtBoxNoVisits
            // 
            this.txtBoxNoVisits.Location = new System.Drawing.Point(26, 74);
            this.txtBoxNoVisits.Name = "txtBoxNoVisits";
            this.txtBoxNoVisits.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNoVisits.TabIndex = 1;
            this.txtBoxNoVisits.TextChanged += new System.EventHandler(this.txtBoxNoVisits_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of Vistis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 569);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total Price: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.HairDresser);
            this.Controls.Add(this.buttExit);
            this.Controls.Add(this.buttClear);
            this.Controls.Add(this.buttCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.HairDresser.ResumeLayout(false);
            this.HairDresser.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttCalculate;
        private System.Windows.Forms.Button buttClear;
        private System.Windows.Forms.Button buttExit;
        private System.Windows.Forms.GroupBox HairDresser;
        private System.Windows.Forms.RadioButton rbLaura;
        private System.Windows.Forms.RadioButton rbSue;
        private System.Windows.Forms.RadioButton rbRon;
        private System.Windows.Forms.RadioButton rbPat;
        private System.Windows.Forms.RadioButton rbJane;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkExtension;
        private System.Windows.Forms.CheckBox ChkHightlights;
        private System.Windows.Forms.CheckBox chkColour;
        private System.Windows.Forms.CheckBox chkHaircut;
        private System.Windows.Forms.RadioButton rbSenior;
        private System.Windows.Forms.RadioButton rbstudent;
        private System.Windows.Forms.RadioButton rbChild;
        private System.Windows.Forms.RadioButton rbAdult;
        private System.Windows.Forms.TextBox txtBoxNoVisits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

