namespace Homework10
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
            this.oilLubeGroupBox = new System.Windows.Forms.GroupBox();
            this.lubeCheckBox = new System.Windows.Forms.CheckBox();
            this.oilCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.transmissionCheckBox = new System.Windows.Forms.CheckBox();
            this.radiatorCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.laborTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rotationCheckBox = new System.Windows.Forms.CheckBox();
            this.mufflerCheckBox = new System.Windows.Forms.CheckBox();
            this.inspectionCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.servicesLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.oilLubeGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // oilLubeGroupBox
            // 
            this.oilLubeGroupBox.BackColor = System.Drawing.Color.DarkRed;
            this.oilLubeGroupBox.Controls.Add(this.lubeCheckBox);
            this.oilLubeGroupBox.Controls.Add(this.oilCheckBox);
            this.oilLubeGroupBox.Font = new System.Drawing.Font("Adobe Gothic Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.oilLubeGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.oilLubeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.oilLubeGroupBox.Name = "oilLubeGroupBox";
            this.oilLubeGroupBox.Size = new System.Drawing.Size(204, 100);
            this.oilLubeGroupBox.TabIndex = 0;
            this.oilLubeGroupBox.TabStop = false;
            this.oilLubeGroupBox.Text = "Oil and Lube";
            // 
            // lubeCheckBox
            // 
            this.lubeCheckBox.AutoSize = true;
            this.lubeCheckBox.Location = new System.Drawing.Point(19, 58);
            this.lubeCheckBox.Name = "lubeCheckBox";
            this.lubeCheckBox.Size = new System.Drawing.Size(131, 20);
            this.lubeCheckBox.TabIndex = 1;
            this.lubeCheckBox.Text = "Lube Job ($18.00)";
            this.lubeCheckBox.UseVisualStyleBackColor = true;
            // 
            // oilCheckBox
            // 
            this.oilCheckBox.AutoSize = true;
            this.oilCheckBox.Location = new System.Drawing.Point(19, 32);
            this.oilCheckBox.Name = "oilCheckBox";
            this.oilCheckBox.Size = new System.Drawing.Size(143, 20);
            this.oilCheckBox.TabIndex = 0;
            this.oilCheckBox.Text = "Oil Change ($26.00)";
            this.oilCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Controls.Add(this.transmissionCheckBox);
            this.groupBox2.Controls.Add(this.radiatorCheckBox);
            this.groupBox2.Font = new System.Drawing.Font("Adobe Gothic Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(230, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flushes";
            // 
            // transmissionCheckBox
            // 
            this.transmissionCheckBox.AutoSize = true;
            this.transmissionCheckBox.Location = new System.Drawing.Point(24, 52);
            this.transmissionCheckBox.Name = "transmissionCheckBox";
            this.transmissionCheckBox.Size = new System.Drawing.Size(144, 36);
            this.transmissionCheckBox.TabIndex = 3;
            this.transmissionCheckBox.Text = "Transmission Flush\r\n     ($80.00)";
            this.transmissionCheckBox.UseVisualStyleBackColor = true;
            // 
            // radiatorCheckBox
            // 
            this.radiatorCheckBox.AutoSize = true;
            this.radiatorCheckBox.Location = new System.Drawing.Point(24, 27);
            this.radiatorCheckBox.Name = "radiatorCheckBox";
            this.radiatorCheckBox.Size = new System.Drawing.Size(165, 20);
            this.radiatorCheckBox.TabIndex = 2;
            this.radiatorCheckBox.Text = "Radiator Flush ($30.00)";
            this.radiatorCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Orange;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.partsTextBox);
            this.groupBox3.Controls.Add(this.laborTextBox);
            this.groupBox3.Font = new System.Drawing.Font("Adobe Gothic Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(231, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parts and Labor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Labor ($)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parts";
            // 
            // partsTextBox
            // 
            this.partsTextBox.Font = new System.Drawing.Font("Adobe Gothic Std B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.partsTextBox.Location = new System.Drawing.Point(85, 61);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(100, 31);
            this.partsTextBox.TabIndex = 1;
            // 
            // laborTextBox
            // 
            this.laborTextBox.Font = new System.Drawing.Font("Adobe Gothic Std B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.laborTextBox.Location = new System.Drawing.Point(85, 22);
            this.laborTextBox.Name = "laborTextBox";
            this.laborTextBox.Size = new System.Drawing.Size(100, 31);
            this.laborTextBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Indigo;
            this.groupBox4.Controls.Add(this.rotationCheckBox);
            this.groupBox4.Controls.Add(this.mufflerCheckBox);
            this.groupBox4.Controls.Add(this.inspectionCheckBox);
            this.groupBox4.Font = new System.Drawing.Font("Adobe Gothic Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(12, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(204, 100);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Misc";
            // 
            // rotationCheckBox
            // 
            this.rotationCheckBox.AutoSize = true;
            this.rotationCheckBox.Font = new System.Drawing.Font("Adobe Gothic Std B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rotationCheckBox.Location = new System.Drawing.Point(19, 66);
            this.rotationCheckBox.Name = "rotationCheckBox";
            this.rotationCheckBox.Size = new System.Drawing.Size(148, 19);
            this.rotationCheckBox.TabIndex = 2;
            this.rotationCheckBox.Text = "Tire Rotation ($20.00)";
            this.rotationCheckBox.UseVisualStyleBackColor = true;
            // 
            // mufflerCheckBox
            // 
            this.mufflerCheckBox.AutoSize = true;
            this.mufflerCheckBox.Font = new System.Drawing.Font("Adobe Gothic Std B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mufflerCheckBox.Location = new System.Drawing.Point(19, 43);
            this.mufflerCheckBox.Name = "mufflerCheckBox";
            this.mufflerCheckBox.Size = new System.Drawing.Size(169, 19);
            this.mufflerCheckBox.TabIndex = 1;
            this.mufflerCheckBox.Text = "Replace Muffler ($100.00)";
            this.mufflerCheckBox.UseVisualStyleBackColor = true;
            // 
            // inspectionCheckBox
            // 
            this.inspectionCheckBox.AutoSize = true;
            this.inspectionCheckBox.Font = new System.Drawing.Font("Adobe Gothic Std B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inspectionCheckBox.Location = new System.Drawing.Point(19, 20);
            this.inspectionCheckBox.Name = "inspectionCheckBox";
            this.inspectionCheckBox.Size = new System.Drawing.Size(133, 19);
            this.inspectionCheckBox.TabIndex = 0;
            this.inspectionCheckBox.Text = "Inspection ($15.00)";
            this.inspectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Lime;
            this.groupBox5.Controls.Add(this.totalLabel);
            this.groupBox5.Controls.Add(this.taxLabel);
            this.groupBox5.Controls.Add(this.partsLabel);
            this.groupBox5.Controls.Add(this.servicesLabel);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Font = new System.Drawing.Font("Adobe Gothic Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 224);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(422, 152);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Summary";
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.SystemColors.Control;
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalLabel.Location = new System.Drawing.Point(169, 114);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(100, 23);
            this.totalLabel.TabIndex = 11;
            // 
            // taxLabel
            // 
            this.taxLabel.BackColor = System.Drawing.SystemColors.Control;
            this.taxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taxLabel.Location = new System.Drawing.Point(169, 85);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(100, 23);
            this.taxLabel.TabIndex = 10;
            // 
            // partsLabel
            // 
            this.partsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.partsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.partsLabel.Location = new System.Drawing.Point(169, 55);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(100, 23);
            this.partsLabel.TabIndex = 9;
            // 
            // servicesLabel
            // 
            this.servicesLabel.BackColor = System.Drawing.SystemColors.Control;
            this.servicesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.servicesLabel.Location = new System.Drawing.Point(169, 25);
            this.servicesLabel.Name = "servicesLabel";
            this.servicesLabel.Size = new System.Drawing.Size(100, 23);
            this.servicesLabel.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Parts";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total Fees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Services and Labor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tax (on Parts)";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(12, 383);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(175, 42);
            this.calcButton.TabIndex = 0;
            this.calcButton.Text = "Calculate Total";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(230, 383);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(138, 42);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(374, 383);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(60, 42);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 435);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.oilLubeGroupBox);
            this.Name = "Form1";
            this.Text = " ";
            this.oilLubeGroupBox.ResumeLayout(false);
            this.oilLubeGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox oilLubeGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox laborTextBox;
        private System.Windows.Forms.TextBox partsTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.CheckBox lubeCheckBox;
        private System.Windows.Forms.CheckBox oilCheckBox;
        private System.Windows.Forms.CheckBox transmissionCheckBox;
        private System.Windows.Forms.CheckBox radiatorCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox rotationCheckBox;
        private System.Windows.Forms.CheckBox mufflerCheckBox;
        private System.Windows.Forms.CheckBox inspectionCheckBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label servicesLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

