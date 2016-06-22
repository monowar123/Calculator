namespace calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteCtrlPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heltTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.output = new System.Windows.Forms.TextBox();
            this.equal_button = new System.Windows.Forms.Button();
            this.button_MM = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.plus_or_minus_button = new System.Windows.Forms.Button();
            this.dot_button = new System.Windows.Forms.Button();
            this.plus_button = new System.Windows.Forms.Button();
            this.multiplication_button = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_MR = new System.Windows.Forms.Button();
            this.persent_button = new System.Windows.Forms.Button();
            this.divition_button = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_MC = new System.Windows.Forms.Button();
            this.Sqrt_button = new System.Windows.Forms.Button();
            this.minus_button = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_MS = new System.Windows.Forms.Button();
            this.invers_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.button_CE = new System.Windows.Forms.Button();
            this.button_c = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelM = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(290, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyCToolStripMenuItem,
            this.pasteCtrlPToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyCToolStripMenuItem
            // 
            this.copyCToolStripMenuItem.Name = "copyCToolStripMenuItem";
            this.copyCToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.copyCToolStripMenuItem.Text = "Copy Ctrl+C";
            // 
            // pasteCtrlPToolStripMenuItem
            // 
            this.pasteCtrlPToolStripMenuItem.Name = "pasteCtrlPToolStripMenuItem";
            this.pasteCtrlPToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.pasteCtrlPToolStripMenuItem.Text = "Paste Ctrl+P";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Checked = true;
            this.viewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.viewToolStripMenuItem.Text = "Converter";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heltTToolStripMenuItem,
            this.aboutCalculatorToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // heltTToolStripMenuItem
            // 
            this.heltTToolStripMenuItem.Name = "heltTToolStripMenuItem";
            this.heltTToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.heltTToolStripMenuItem.Text = "Help Topics";
            // 
            // aboutCalculatorToolStripMenuItem
            // 
            this.aboutCalculatorToolStripMenuItem.Name = "aboutCalculatorToolStripMenuItem";
            this.aboutCalculatorToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.aboutCalculatorToolStripMenuItem.Text = "About Calculator";
            this.aboutCalculatorToolStripMenuItem.Click += new System.EventHandler(this.aboutCalculatorToolStripMenuItem_Click);
            // 
            // output
            // 
            this.output.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.ImeMode = System.Windows.Forms.ImeMode.On;
            this.output.Location = new System.Drawing.Point(12, 30);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.output.Size = new System.Drawing.Size(268, 25);
            this.output.TabIndex = 1;
            this.output.Tag = "";
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.output.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.output_KeyPress);
            // 
            // equal_button
            // 
            this.equal_button.ForeColor = System.Drawing.Color.Red;
            this.equal_button.Location = new System.Drawing.Point(242, 226);
            this.equal_button.Name = "equal_button";
            this.equal_button.Size = new System.Drawing.Size(38, 28);
            this.equal_button.TabIndex = 3;
            this.equal_button.Text = "=";
            this.equal_button.UseVisualStyleBackColor = true;
            this.equal_button.Click += new System.EventHandler(this.equal_button_Click);
            // 
            // button_MM
            // 
            this.button_MM.ForeColor = System.Drawing.Color.Red;
            this.button_MM.Location = new System.Drawing.Point(12, 226);
            this.button_MM.Name = "button_MM";
            this.button_MM.Size = new System.Drawing.Size(38, 28);
            this.button_MM.TabIndex = 4;
            this.button_MM.Text = "M+";
            this.button_MM.UseVisualStyleBackColor = true;
            this.button_MM.Click += new System.EventHandler(this.button_MM_Click);
            // 
            // button_0
            // 
            this.button_0.ForeColor = System.Drawing.Color.Blue;
            this.button_0.Location = new System.Drawing.Point(66, 226);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(38, 28);
            this.button_0.TabIndex = 5;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // plus_or_minus_button
            // 
            this.plus_or_minus_button.ForeColor = System.Drawing.Color.Blue;
            this.plus_or_minus_button.Location = new System.Drawing.Point(110, 226);
            this.plus_or_minus_button.Name = "plus_or_minus_button";
            this.plus_or_minus_button.Size = new System.Drawing.Size(38, 28);
            this.plus_or_minus_button.TabIndex = 6;
            this.plus_or_minus_button.Text = "+/-";
            this.plus_or_minus_button.UseVisualStyleBackColor = true;
            this.plus_or_minus_button.Click += new System.EventHandler(this.plus_or_minus_button_Click);
            // 
            // dot_button
            // 
            this.dot_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.dot_button.ForeColor = System.Drawing.Color.Blue;
            this.dot_button.Location = new System.Drawing.Point(154, 226);
            this.dot_button.Name = "dot_button";
            this.dot_button.Size = new System.Drawing.Size(38, 28);
            this.dot_button.TabIndex = 7;
            this.dot_button.Text = ".";
            this.dot_button.UseVisualStyleBackColor = true;
            this.dot_button.Click += new System.EventHandler(this.dot_button_Click);
            // 
            // plus_button
            // 
            this.plus_button.ForeColor = System.Drawing.Color.Red;
            this.plus_button.Location = new System.Drawing.Point(198, 226);
            this.plus_button.Name = "plus_button";
            this.plus_button.Size = new System.Drawing.Size(38, 28);
            this.plus_button.TabIndex = 8;
            this.plus_button.Text = "+";
            this.plus_button.UseVisualStyleBackColor = true;
            this.plus_button.Click += new System.EventHandler(this.plus_button_Click);
            // 
            // multiplication_button
            // 
            this.multiplication_button.ForeColor = System.Drawing.Color.Red;
            this.multiplication_button.Location = new System.Drawing.Point(198, 148);
            this.multiplication_button.Name = "multiplication_button";
            this.multiplication_button.Size = new System.Drawing.Size(38, 28);
            this.multiplication_button.TabIndex = 14;
            this.multiplication_button.Text = "*";
            this.multiplication_button.UseVisualStyleBackColor = true;
            this.multiplication_button.Click += new System.EventHandler(this.multiplication_button_Click);
            // 
            // button_6
            // 
            this.button_6.ForeColor = System.Drawing.Color.Blue;
            this.button_6.Location = new System.Drawing.Point(154, 148);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(38, 28);
            this.button_6.TabIndex = 13;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_5
            // 
            this.button_5.ForeColor = System.Drawing.Color.Blue;
            this.button_5.Location = new System.Drawing.Point(110, 148);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(38, 28);
            this.button_5.TabIndex = 12;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_4
            // 
            this.button_4.ForeColor = System.Drawing.Color.Blue;
            this.button_4.Location = new System.Drawing.Point(66, 148);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(38, 28);
            this.button_4.TabIndex = 11;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_MR
            // 
            this.button_MR.ForeColor = System.Drawing.Color.Red;
            this.button_MR.Location = new System.Drawing.Point(12, 148);
            this.button_MR.Name = "button_MR";
            this.button_MR.Size = new System.Drawing.Size(38, 28);
            this.button_MR.TabIndex = 10;
            this.button_MR.Text = "MR";
            this.button_MR.UseVisualStyleBackColor = true;
            this.button_MR.Click += new System.EventHandler(this.button_MR_Click);
            // 
            // persent_button
            // 
            this.persent_button.ForeColor = System.Drawing.Color.Blue;
            this.persent_button.Location = new System.Drawing.Point(242, 148);
            this.persent_button.Name = "persent_button";
            this.persent_button.Size = new System.Drawing.Size(38, 28);
            this.persent_button.TabIndex = 9;
            this.persent_button.Text = "%";
            this.persent_button.UseVisualStyleBackColor = true;
            this.persent_button.Click += new System.EventHandler(this.persent_button_Click);
            // 
            // divition_button
            // 
            this.divition_button.ForeColor = System.Drawing.Color.Red;
            this.divition_button.Location = new System.Drawing.Point(198, 109);
            this.divition_button.Name = "divition_button";
            this.divition_button.Size = new System.Drawing.Size(38, 28);
            this.divition_button.TabIndex = 20;
            this.divition_button.Text = "/";
            this.divition_button.UseVisualStyleBackColor = true;
            this.divition_button.Click += new System.EventHandler(this.divition_button_Click);
            // 
            // button_9
            // 
            this.button_9.ForeColor = System.Drawing.Color.Blue;
            this.button_9.Location = new System.Drawing.Point(154, 109);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(38, 28);
            this.button_9.TabIndex = 19;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_8
            // 
            this.button_8.ForeColor = System.Drawing.Color.Blue;
            this.button_8.Location = new System.Drawing.Point(110, 109);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(38, 28);
            this.button_8.TabIndex = 18;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_7
            // 
            this.button_7.ForeColor = System.Drawing.Color.Blue;
            this.button_7.Location = new System.Drawing.Point(66, 109);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(38, 28);
            this.button_7.TabIndex = 17;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_MC
            // 
            this.button_MC.ForeColor = System.Drawing.Color.Red;
            this.button_MC.Location = new System.Drawing.Point(12, 109);
            this.button_MC.Name = "button_MC";
            this.button_MC.Size = new System.Drawing.Size(38, 28);
            this.button_MC.TabIndex = 16;
            this.button_MC.Text = "MC";
            this.button_MC.UseVisualStyleBackColor = true;
            this.button_MC.Click += new System.EventHandler(this.button_MC_Click);
            // 
            // Sqrt_button
            // 
            this.Sqrt_button.ForeColor = System.Drawing.Color.Blue;
            this.Sqrt_button.Location = new System.Drawing.Point(242, 109);
            this.Sqrt_button.Name = "Sqrt_button";
            this.Sqrt_button.Size = new System.Drawing.Size(38, 28);
            this.Sqrt_button.TabIndex = 15;
            this.Sqrt_button.Text = "sqrt";
            this.Sqrt_button.UseVisualStyleBackColor = true;
            this.Sqrt_button.Click += new System.EventHandler(this.Sqrt_button_Click);
            // 
            // minus_button
            // 
            this.minus_button.ForeColor = System.Drawing.Color.Red;
            this.minus_button.Location = new System.Drawing.Point(198, 187);
            this.minus_button.Name = "minus_button";
            this.minus_button.Size = new System.Drawing.Size(38, 28);
            this.minus_button.TabIndex = 26;
            this.minus_button.Text = "---";
            this.minus_button.UseVisualStyleBackColor = true;
            this.minus_button.Click += new System.EventHandler(this.minus_button_Click);
            // 
            // button_3
            // 
            this.button_3.ForeColor = System.Drawing.Color.Blue;
            this.button_3.Location = new System.Drawing.Point(154, 187);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(38, 28);
            this.button_3.TabIndex = 25;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_2
            // 
            this.button_2.ForeColor = System.Drawing.Color.Blue;
            this.button_2.Location = new System.Drawing.Point(110, 187);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(38, 28);
            this.button_2.TabIndex = 24;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_1
            // 
            this.button_1.ForeColor = System.Drawing.Color.Blue;
            this.button_1.Location = new System.Drawing.Point(66, 187);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(38, 28);
            this.button_1.TabIndex = 23;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_MS
            // 
            this.button_MS.ForeColor = System.Drawing.Color.Red;
            this.button_MS.Location = new System.Drawing.Point(12, 187);
            this.button_MS.Name = "button_MS";
            this.button_MS.Size = new System.Drawing.Size(38, 28);
            this.button_MS.TabIndex = 22;
            this.button_MS.Text = "MS";
            this.button_MS.UseVisualStyleBackColor = true;
            this.button_MS.Click += new System.EventHandler(this.button_MS_Click);
            // 
            // invers_button
            // 
            this.invers_button.ForeColor = System.Drawing.Color.Blue;
            this.invers_button.Location = new System.Drawing.Point(242, 187);
            this.invers_button.Name = "invers_button";
            this.invers_button.Size = new System.Drawing.Size(38, 28);
            this.invers_button.TabIndex = 21;
            this.invers_button.Text = "1/x";
            this.invers_button.UseVisualStyleBackColor = true;
            this.invers_button.Click += new System.EventHandler(this.invers_button_Click);
            // 
            // back_button
            // 
            this.back_button.ForeColor = System.Drawing.Color.Red;
            this.back_button.Location = new System.Drawing.Point(64, 66);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(68, 28);
            this.back_button.TabIndex = 30;
            this.back_button.Text = "Backspace";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // button_CE
            // 
            this.button_CE.ForeColor = System.Drawing.Color.Red;
            this.button_CE.Location = new System.Drawing.Point(138, 66);
            this.button_CE.Name = "button_CE";
            this.button_CE.Size = new System.Drawing.Size(68, 28);
            this.button_CE.TabIndex = 31;
            this.button_CE.Text = "CE";
            this.button_CE.UseVisualStyleBackColor = true;
            this.button_CE.Click += new System.EventHandler(this.button_CE_Click);
            // 
            // button_c
            // 
            this.button_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_c.ForeColor = System.Drawing.Color.Red;
            this.button_c.Location = new System.Drawing.Point(212, 66);
            this.button_c.Name = "button_c";
            this.button_c.Size = new System.Drawing.Size(68, 28);
            this.button_c.TabIndex = 32;
            this.button_c.Text = "C";
            this.button_c.UseVisualStyleBackColor = true;
            this.button_c.Click += new System.EventHandler(this.button_c_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labelM);
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(38, 34);
            this.panel1.TabIndex = 33;
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelM.Location = new System.Drawing.Point(8, 9);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(17, 13);
            this.labelM.TabIndex = 0;
            this.labelM.Text = "M";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_c);
            this.Controls.Add(this.button_CE);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.minus_button);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_MS);
            this.Controls.Add(this.invers_button);
            this.Controls.Add(this.divition_button);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_MC);
            this.Controls.Add(this.Sqrt_button);
            this.Controls.Add(this.multiplication_button);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_MR);
            this.Controls.Add(this.persent_button);
            this.Controls.Add(this.plus_button);
            this.Controls.Add(this.dot_button);
            this.Controls.Add(this.plus_or_minus_button);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_MM);
            this.Controls.Add(this.equal_button);
            this.Controls.Add(this.output);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteCtrlPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heltTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutCalculatorToolStripMenuItem;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button equal_button;
        private System.Windows.Forms.Button button_MM;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button plus_or_minus_button;
        private System.Windows.Forms.Button dot_button;
        private System.Windows.Forms.Button plus_button;
        private System.Windows.Forms.Button multiplication_button;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_MR;
        private System.Windows.Forms.Button persent_button;
        private System.Windows.Forms.Button divition_button;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_MC;
        private System.Windows.Forms.Button Sqrt_button;
        private System.Windows.Forms.Button minus_button;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_MS;
        private System.Windows.Forms.Button invers_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button button_CE;
        private System.Windows.Forms.Button button_c;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelM;

    }
}

