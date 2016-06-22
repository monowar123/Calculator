namespace calculator
{
    partial class Converter
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
            this.Temperature = new System.Windows.Forms.RadioButton();
            this.Length = new System.Windows.Forms.RadioButton();
            this.Weight = new System.Windows.Forms.RadioButton();
            this.Area = new System.Windows.Forms.RadioButton();
            this.Volume = new System.Windows.Forms.RadioButton();
            this.Pressure = new System.Windows.Forms.RadioButton();
            this.NumberSystem = new System.Windows.Forms.RadioButton();
            this.Trigonometry = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.input_textBox = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.output_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDegree = new System.Windows.Forms.TextBox();
            this.comboBoxRatio = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Temperature
            // 
            this.Temperature.AutoSize = true;
            this.Temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temperature.Location = new System.Drawing.Point(31, 20);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(119, 21);
            this.Temperature.TabIndex = 0;
            this.Temperature.TabStop = true;
            this.Temperature.Text = "Temperature";
            this.Temperature.CheckedChanged += new System.EventHandler(this.Temperature_CheckedChanged);
            // 
            // Length
            // 
            this.Length.AutoSize = true;
            this.Length.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Length.Location = new System.Drawing.Point(31, 50);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(76, 21);
            this.Length.TabIndex = 1;
            this.Length.TabStop = true;
            this.Length.Text = "Length";
            this.Length.UseVisualStyleBackColor = true;
            this.Length.CheckedChanged += new System.EventHandler(this.Length_CheckedChanged);
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weight.Location = new System.Drawing.Point(31, 80);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(76, 21);
            this.Weight.TabIndex = 2;
            this.Weight.TabStop = true;
            this.Weight.Text = "Weight";
            this.Weight.UseVisualStyleBackColor = true;
            this.Weight.CheckedChanged += new System.EventHandler(this.Weight_CheckedChanged);
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area.Location = new System.Drawing.Point(31, 110);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(60, 21);
            this.Area.TabIndex = 3;
            this.Area.TabStop = true;
            this.Area.Text = "Area";
            this.Area.UseVisualStyleBackColor = true;
            this.Area.CheckedChanged += new System.EventHandler(this.Area_CheckedChanged);
            // 
            // Volume
            // 
            this.Volume.AutoSize = true;
            this.Volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volume.Location = new System.Drawing.Point(31, 140);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(79, 21);
            this.Volume.TabIndex = 4;
            this.Volume.TabStop = true;
            this.Volume.Text = "Volume";
            this.Volume.UseVisualStyleBackColor = true;
            this.Volume.CheckedChanged += new System.EventHandler(this.Volume_CheckedChanged);
            // 
            // Pressure
            // 
            this.Pressure.AutoSize = true;
            this.Pressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pressure.Location = new System.Drawing.Point(31, 170);
            this.Pressure.Name = "Pressure";
            this.Pressure.Size = new System.Drawing.Size(91, 21);
            this.Pressure.TabIndex = 5;
            this.Pressure.TabStop = true;
            this.Pressure.Text = "Pressure";
            this.Pressure.UseVisualStyleBackColor = true;
            this.Pressure.CheckedChanged += new System.EventHandler(this.Pressure_CheckedChanged);
            // 
            // NumberSystem
            // 
            this.NumberSystem.AutoSize = true;
            this.NumberSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberSystem.Location = new System.Drawing.Point(31, 200);
            this.NumberSystem.Name = "NumberSystem";
            this.NumberSystem.Size = new System.Drawing.Size(139, 21);
            this.NumberSystem.TabIndex = 6;
            this.NumberSystem.TabStop = true;
            this.NumberSystem.Text = "Number System";
            this.NumberSystem.UseVisualStyleBackColor = true;
            this.NumberSystem.CheckedChanged += new System.EventHandler(this.NumberSystem_CheckedChanged);
            // 
            // Trigonometry
            // 
            this.Trigonometry.AutoSize = true;
            this.Trigonometry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trigonometry.Location = new System.Drawing.Point(31, 230);
            this.Trigonometry.Name = "Trigonometry";
            this.Trigonometry.Size = new System.Drawing.Size(122, 21);
            this.Trigonometry.TabIndex = 7;
            this.Trigonometry.TabStop = true;
            this.Trigonometry.Text = "Trigonometry";
            this.Trigonometry.UseVisualStyleBackColor = true;
            this.Trigonometry.CheckedChanged += new System.EventHandler(this.Trigonometry_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Select Item";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Item";
            // 
            // input_textBox
            // 
            this.input_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_textBox.Location = new System.Drawing.Point(206, 51);
            this.input_textBox.Multiline = true;
            this.input_textBox.Name = "input_textBox";
            this.input_textBox.Size = new System.Drawing.Size(219, 25);
            this.input_textBox.TabIndex = 10;
            this.input_textBox.TextChanged += new System.EventHandler(this.input_textBox_TextChanged);
            this.input_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_textBox_KeyDown);
            this.input_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_textBox_KeyPress);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(32, 148);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 21);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.Text = "Select Item";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // output_textBox
            // 
            this.output_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_textBox.Location = new System.Drawing.Point(206, 144);
            this.output_textBox.Multiline = true;
            this.output_textBox.Name = "output_textBox";
            this.output_textBox.ReadOnly = true;
            this.output_textBox.Size = new System.Drawing.Size(219, 25);
            this.output_textBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Select Item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Output";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.output_textBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.input_textBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(178, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 273);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxResult);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxDegree);
            this.groupBox2.Controls.Add(this.comboBoxRatio);
            this.groupBox2.Location = new System.Drawing.Point(1, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 273);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trigonometry";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Result";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Input Degree";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(143, 166);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(166, 20);
            this.textBoxResult.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Select Ration";
            // 
            // textBoxDegree
            // 
            this.textBoxDegree.Location = new System.Drawing.Point(255, 61);
            this.textBoxDegree.Name = "textBoxDegree";
            this.textBoxDegree.Size = new System.Drawing.Size(105, 20);
            this.textBoxDegree.TabIndex = 1;
            this.textBoxDegree.TextChanged += new System.EventHandler(this.textBoxDegree_TextChanged);
            // 
            // comboBoxRatio
            // 
            this.comboBoxRatio.FormattingEnabled = true;
            this.comboBoxRatio.Location = new System.Drawing.Point(63, 60);
            this.comboBoxRatio.Name = "comboBoxRatio";
            this.comboBoxRatio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRatio.TabIndex = 0;
            this.comboBoxRatio.Text = "Select Item";
            this.comboBoxRatio.SelectedIndexChanged += new System.EventHandler(this.comboBoxRatio_SelectedIndexChanged);
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(635, 281);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Trigonometry);
            this.Controls.Add(this.NumberSystem);
            this.Controls.Add(this.Pressure);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.Temperature);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Converter";
            this.Text = "Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Temperature;
        private System.Windows.Forms.RadioButton Length;
        private System.Windows.Forms.RadioButton Weight;
        private System.Windows.Forms.RadioButton Area;
        private System.Windows.Forms.RadioButton Volume;
        private System.Windows.Forms.RadioButton Pressure;
        private System.Windows.Forms.RadioButton NumberSystem;
        private System.Windows.Forms.RadioButton Trigonometry;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_textBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox output_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDegree;
        private System.Windows.Forms.ComboBox comboBoxRatio;

    }
}