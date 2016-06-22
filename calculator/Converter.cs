using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace calculator
{
    public partial class Converter : Form
    {
        private string[] temp= { "Celcious", "Fahrenheit", "Kelvin", "Rankine" };
        private string[] length = { "Mile", "Kilo-Metre", "Yard", "Metre", "Foot", "Centi-Metre", "Inch" };
        private string[] weight = { "Pound", "Kilo", "Carat", "Gram", "Ounce", "Stone", "Troy az" };
        private string[] area = { "Square Foot", "Square Metre", "Square Inch", "Square CM", "Square Yard", "Square Mile", "Square KM", "Acre", "Hectare" };
        private string[] volume = { "V Inch", "V CM", "V Foot", "V Metre", "V Yard", "Gallon", "Litre" };
        private string[] pressure = { "atm", "Pa", "mmHg" };
        private string[] numberSystem = { "Binary", "Decimal", "Octal", "Hexadecimal" };
        private string[] trigonometry = { "Sin", "Cos", "Tan", "Sec", "Cosec", "Cot" };

        public delegate string functionDelegate(string input, string output, string inputTextBoxValue);
        functionDelegate function;
        MyClass ConverterObj = new MyClass();

        public Converter()
        {
            InitializeComponent();
        }

        private void CommonFunction()
        {
            groupBox2.Visible = false;
            groupBox1.Visible = true;
            input_textBox.Text = string.Empty;
            output_textBox.Text = string.Empty;
            comboBox1.Items.Clear();
            comboBox1.Text = "Select Item";
            comboBox2.Items.Clear();
            comboBox2.Text = "Select Item";
        }

        private void Temperature_CheckedChanged(object sender, EventArgs e)
        {
            CommonFunction();
            groupBox1.Text = "Temperature"; 
          
            comboBox1.Items.AddRange(temp); 
            comboBox2.Items.AddRange(temp);

            function = new functionDelegate(ConverterObj.TemperatureFunc);
        }

        private void Length_CheckedChanged(object sender, EventArgs e)
        {
            CommonFunction();
            groupBox1.Text = "Length";

            comboBox1.Items.AddRange(length);
            comboBox2.Items.AddRange(length);

            function = new functionDelegate(ConverterObj.LengthFunc);
        }

        private void Weight_CheckedChanged(object sender, EventArgs e)
        {
            CommonFunction();
            groupBox1.Text = "Weight";

            comboBox1.Items.AddRange(weight);
            comboBox2.Items.AddRange(weight);

            function = new functionDelegate(ConverterObj.WeightFunc);
        }

        private void Area_CheckedChanged(object sender, EventArgs e)
        {
            CommonFunction();
            groupBox1.Text = "Area";

            comboBox1.Items.AddRange(area);
            comboBox2.Items.AddRange(area);

            function = new functionDelegate(ConverterObj.AreaFunc);
        }

        private void Volume_CheckedChanged(object sender, EventArgs e)
        {
            CommonFunction();
            groupBox1.Text = "Volume";

            comboBox1.Items.AddRange(volume);
            comboBox2.Items.AddRange(volume);

            function = new functionDelegate(ConverterObj.VolumeFunc);
        }

        private void Pressure_CheckedChanged(object sender, EventArgs e)
        {
            CommonFunction();
            groupBox1.Text = "Pressure";

            comboBox1.Items.AddRange(pressure);
            comboBox2.Items.AddRange(pressure);

            function = new functionDelegate(ConverterObj.PressureFunc);
        }

        private void NumberSystem_CheckedChanged(object sender, EventArgs e)
        {
            CommonFunction();
            groupBox1.Text = "Number System";

            comboBox1.Items.AddRange(numberSystem);
            comboBox2.Items.AddRange(numberSystem);

            function = new functionDelegate(ConverterObj.NumberSystemFunc);
        }

        private void Trigonometry_CheckedChanged(object sender, EventArgs e)
        {
            //groupBox1.Visible = false;
            groupBox2.Visible = true;
            comboBoxRatio.Items.Clear();
            textBoxDegree.Text = string.Empty;
            textBoxResult.Text = string.Empty;

            comboBoxRatio.Items.AddRange(trigonometry);
        }

        private void input_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            //{
            //    e.Handled = true;
            //}
        }

        private void input_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            //e.SuppressKeyPress = (e.KeyCode == Keys.A);
            //if ((e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) && e.KeyCode != Keys.Back)
            //    e.Handled = true;
        }

        private void input_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(input_textBox.Text))
                    output_textBox.Text = null;
                else
                    output_textBox.Text = function(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), input_textBox.Text);
            }
            catch
            {
                output_textBox.Text = "Invalid Input or Invalid Selection.";
                return;
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                output_textBox.Text = function(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), input_textBox.Text);
            }
            catch
            {
                return;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                output_textBox.Text = function(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), input_textBox.Text);
            }
            catch
            {
                return;
            }
        }

        private bool validateInput(string input, string expression, string message)
        {
            bool valid = Regex.Match(input, expression).Success;
            if (!valid)
            {
                MessageBox.Show(message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return valid;
        }

        private void comboBoxRatio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxResult.Text = ConverterObj.TrigonometryFunc(comboBoxRatio.SelectedItem.ToString(), textBoxDegree.Text);
            }
            catch
            {
                return;
            }
        }

        private void textBoxDegree_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDegree.Text == "")
                    textBoxResult.Text = null;
                else
                    textBoxResult.Text = ConverterObj.TrigonometryFunc(comboBoxRatio.SelectedItem.ToString(), textBoxDegree.Text); 
            }
            catch
            {
                textBoxResult.Text = "Invalid Input or Invalid Selection.";
                return;
            }
        }
    }
}
