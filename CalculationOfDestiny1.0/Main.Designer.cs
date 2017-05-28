namespace CalculationOfDesnsityBeta
{
    partial class Main
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTemp = new System.Windows.Forms.TextBox();
            this.tbPressure = new System.Windows.Forms.TextBox();
            this.tbDensity = new System.Windows.Forms.TextBox();
            this.cbTypeLiquid = new System.Windows.Forms.ComboBox();
            this.cbMeter = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNewTemp = new System.Windows.Forms.TextBox();
            this.tbNewPressure = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(552, 340);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(197, 69);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Пересчитать >>";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbTemp);
            this.groupBox1.Controls.Add(this.tbPressure);
            this.groupBox1.Controls.Add(this.tbDensity);
            this.groupBox1.Controls.Add(this.cbTypeLiquid);
            this.groupBox1.Controls.Add(this.cbMeter);
            this.groupBox1.Location = new System.Drawing.Point(45, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 282);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Измеряемые данные";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Температура (С):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Давление (МПа):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Плотность (кг/м3):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип жидкости:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Прибор:";
            // 
            // tbTemp
            // 
            this.tbTemp.Location = new System.Drawing.Point(229, 238);
            this.tbTemp.Name = "tbTemp";
            this.tbTemp.Size = new System.Drawing.Size(315, 31);
            this.tbTemp.TabIndex = 4;
            // 
            // tbPressure
            // 
            this.tbPressure.Location = new System.Drawing.Point(229, 192);
            this.tbPressure.Name = "tbPressure";
            this.tbPressure.Size = new System.Drawing.Size(315, 31);
            this.tbPressure.TabIndex = 3;
            // 
            // tbDensity
            // 
            this.tbDensity.Location = new System.Drawing.Point(229, 145);
            this.tbDensity.Name = "tbDensity";
            this.tbDensity.Size = new System.Drawing.Size(315, 31);
            this.tbDensity.TabIndex = 2;
            // 
            // cbTypeLiquid
            // 
            this.cbTypeLiquid.FormattingEnabled = true;
            this.cbTypeLiquid.Items.AddRange(new object[] {
            "Нефть",
            "Нефтепродукт",
            "Масло"});
            this.cbTypeLiquid.Location = new System.Drawing.Point(229, 95);
            this.cbTypeLiquid.Name = "cbTypeLiquid";
            this.cbTypeLiquid.Size = new System.Drawing.Size(315, 33);
            this.cbTypeLiquid.TabIndex = 1;
            // 
            // cbMeter
            // 
            this.cbMeter.FormattingEnabled = true;
            this.cbMeter.Items.AddRange(new object[] {
            "Плотномер <0,5",
            "Плотномер 0,5-1",
            "Ареометр 15С",
            "Ареометр 20С"});
            this.cbMeter.Location = new System.Drawing.Point(229, 46);
            this.cbMeter.Name = "cbMeter";
            this.cbMeter.Size = new System.Drawing.Size(315, 33);
            this.cbMeter.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbNewTemp);
            this.groupBox3.Controls.Add(this.tbNewPressure);
            this.groupBox3.Location = new System.Drawing.Point(643, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(571, 185);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Расчетные значения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Температура (С):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Давление (МПа):";
            // 
            // tbNewTemp
            // 
            this.tbNewTemp.Location = new System.Drawing.Point(233, 89);
            this.tbNewTemp.Name = "tbNewTemp";
            this.tbNewTemp.Size = new System.Drawing.Size(315, 31);
            this.tbNewTemp.TabIndex = 6;
            // 
            // tbNewPressure
            // 
            this.tbNewPressure.Location = new System.Drawing.Point(233, 43);
            this.tbNewPressure.Name = "tbNewPressure";
            this.tbNewPressure.Size = new System.Drawing.Size(315, 31);
            this.tbNewPressure.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbResult);
            this.groupBox4.Location = new System.Drawing.Point(45, 415);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1146, 163);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Результат";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(20, 56);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 25);
            this.lbResult.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 590);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "Расчет плотности по  ГОСТ Р 50.2.076-2010 ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTemp;
        private System.Windows.Forms.TextBox tbPressure;
        private System.Windows.Forms.TextBox tbDensity;
        private System.Windows.Forms.ComboBox cbTypeLiquid;
        private System.Windows.Forms.ComboBox cbMeter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNewTemp;
        private System.Windows.Forms.TextBox tbNewPressure;
        private System.Windows.Forms.Label lbResult;
    }
}

