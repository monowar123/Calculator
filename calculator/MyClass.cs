using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculator
{
    public class MyClass
    {
        public string TemperatureFunc(string input, string output, string inputTextBoxValue)
        {
            double value = Convert.ToDouble(inputTextBoxValue);
            switch (input)
            {
                case "Celcious":
                    switch (output)
                    {
                        case "Celcious": return inputTextBoxValue;
                        case "Fahrenheit": return Convert.ToString(1.8 * value + 32);
                        case "Kelvin": return Convert.ToString(value + 273);
                        case "Rankine": return Convert.ToString((value * 1.8) + 492);
                        default: break;
                    }
                    break;
                case "Fahrenheit":
                    switch (output)
                    {
                        case "Celcious": return Convert.ToString((value - 32) / 1.8);
                        case "Fahrenheit": return inputTextBoxValue;
                        case "Kelvin": return Convert.ToString((value - 32) / 1.8 + 273);
                        case "Rankine": return Convert.ToString(value + 460);
                        default: break;
                    }
                    break;
                case "Kelvin":
                    switch (output)
                    {
                        case "Celcious": return Convert.ToString(value - 273);
                        case "Fahrenheit": return Convert.ToString((value - 273) * 1.8 + 32);
                        case "Kelvin": return inputTextBoxValue;
                        case "Rankine": return Convert.ToString((value - 273) * 1.8 + 492);
                        default: break;
                    }
                    break;
                case "Rankine":
                    switch (output)
                    {
                        case "Celcious": return Convert.ToString((value - 492) / 1.8);
                        case "Fahrenheit": return Convert.ToString(value - 460);
                        case "Kelvin": return Convert.ToString((value - 492) / 1.8 + 273);
                        case "Rankine": return inputTextBoxValue;
                        default: break;
                    }
                    break;
                default: break;
            }
            return null;
        }

        public string LengthFunc(string input, string output, string inputTextBoxValue)
        {
            double value = Convert.ToDouble(inputTextBoxValue);
            switch (input)
            {
                case "Mile":
                    switch (output)
                    {
                        case "Mile": return inputTextBoxValue;
                        case "Kilo-Metre": return Convert.ToString(value * 1.609);
                        case "Yard": return Convert.ToString(value * 1760);
                        case "Metre": return Convert.ToString(value * 1609.334);
                        case "Foot": return Convert.ToString(value * 5280);
                        case "Centi-Metre": return Convert.ToString(value * 16934.4);
                        case "Inch": return Convert.ToString(value * 63360);
                        default: break;
                    }
                    break;
                case "Kilo-Metre":
                    switch (output)
                    {
                        case "Mile": return Convert.ToString(value * 0.621504);
                        case "Kilo-Metre": return inputTextBoxValue;
                        case "Yard": return Convert.ToString(value * 1093.6132);
                        case "Metre": return Convert.ToString(value * 1000);
                        case "Foot": return Convert.ToString(value * 3280.84);
                        case "Centi-Metre": return Convert.ToString(value * 100000);
                        case "Inch": return Convert.ToString(value * 39370.07874);
                        default: break;
                    }
                    break;
                case "Yard":
                    switch (output)
                    {
                        case "Mile": return Convert.ToString(value * .000568181);
                        case "Kilo-Metre": return Convert.ToString(value * 0.0009144);
                        case "Yard": return inputTextBoxValue;
                        case "Metre": return Convert.ToString(value * .9144);
                        case "Foot": return Convert.ToString(value * 3);
                        case "Centi-Metre": return Convert.ToString(value * 91.44);
                        case "Inch": return Convert.ToString(value * 36);
                        default: break;
                    }
                    break;
                case "Metre":
                    switch (output)
                    {
                        case "Mile": return Convert.ToString(value * 0.000621375);
                        case "Kilo-Metre": return Convert.ToString(value * 0.001);
                        case "Yard": return Convert.ToString(value * 1.0936133);
                        case "Metre": return inputTextBoxValue;
                        case "Foot": return Convert.ToString(value * 3.2808399);
                        case "Centi-Metre": return Convert.ToString(value * 100);
                        case "Inch": return Convert.ToString(value * 39.37);
                        default: break;
                    }
                    break;
                case "Foot":
                    switch (output)
                    {
                        case "Mile": return Convert.ToString(value * .000189393939);
                        case "Kilo-Metre": return Convert.ToString(value * .0003048);
                        case "Yard": return Convert.ToString(value * .333333333);
                        case "Metre": return Convert.ToString(value * .3048);
                        case "Foot": return inputTextBoxValue;
                        case "Centi-Metre": return Convert.ToString(value * 30.48);
                        case "Inch": return Convert.ToString(value * 12);
                        default: break;
                    }
                    break;
                case "Centi-Metre":
                    switch (output)
                    {
                        case "Mile": return Convert.ToString(value * .00000621371192);
                        case "Kilo-Metre": return Convert.ToString(value * .00001);
                        case "Yard": return Convert.ToString(value * .0109936133);
                        case "Metre": return Convert.ToString(value * .01);
                        case "Foot": return Convert.ToString(value * .0328084);
                        case "Centi-Metre": return inputTextBoxValue;
                        case "Inch": return Convert.ToString(value * .3937008);
                        default: break;
                    }
                    break;
                case "Inch":
                    switch (output)
                    {
                        case "Mile": return Convert.ToString(value * .00001578282);
                        case "Kilo-Metre": return Convert.ToString(value * .0000254);
                        case "Yard": return Convert.ToString(value * .0277777778);
                        case "Metre": return Convert.ToString(value * .0254);
                        case "Foot": return Convert.ToString(value * .083333333333);
                        case "Centi-Metre": return Convert.ToString(value * 2.54);
                        case "Inch": return inputTextBoxValue;
                        default: break;
                    }
                    break;
                default:
                    break;
            }
            return null;
        }

        public string WeightFunc(string input, string output, string inputTextBoxValue)
        {
            double value = Convert.ToDouble(inputTextBoxValue);
            switch (input)
            {
                case "Pound":
                    switch (output)
                    {
                        case "Pound": return inputTextBoxValue;
                        case "Kilo": return Convert.ToString(value * .4536);
                        case "Carat": return Convert.ToString(value * 2267.96185);
                        case "Gram": return Convert.ToString(value * 453.59237);
                        case "Ounce": return Convert.ToString(value * 16);
                        case "Stone": return Convert.ToString(value * .0714285714);
                        case "Troy az":
                        default: break;
                    }
                    break;
                case "Kilo":
                    switch (output)
                    {
                        case "Pound": return Convert.ToString(value * 2.2045955);
                        case "Kilo": return inputTextBoxValue;
                        case "Carat": return Convert.ToString(value * 5000);
                        case "Gram": return Convert.ToString(value * 1000);
                        case "Ounce": return Convert.ToString(value * 35.2739619);
                        case "Stone": return Convert.ToString(value * .157473);
                        case "Troy az":
                        default: break;
                    }
                    break;
                case "Carat":
                    switch (output)
                    {
                        case "Pound": return Convert.ToString(value * .000440924524);
                        case "Kilo": return Convert.ToString(value * .0002);
                        case "Carat": return inputTextBoxValue;
                        case "Gram": return Convert.ToString(value * .2);
                        case "Ounce": return Convert.ToString(value * .00705479239);
                        case "Stone": return Convert.ToString(value * .0000314946089);
                        case "Troy az":
                        default: break;
                    }
                    break;
                case "Gram":
                    switch (output)
                    {
                        case "Pound": return Convert.ToString(value * .00220462262);
                        case "Kilo": return Convert.ToString(value * .001);
                        case "Carat": return Convert.ToString(value * 5);
                        case "Gram": return inputTextBoxValue;
                        case "Ounce": return Convert.ToString(value * .0352734);
                        case "Stone": return Convert.ToString(value * .000157473044);
                        case "Troy az": return Convert.ToString(value * .0321507);
                        default: break;
                    }
                    break;
                case "Ounce":
                    switch (output)
                    {
                        case "Pound": return Convert.ToString(value * .0625);
                        case "Kilo": return Convert.ToString(value * .0283495231);
                        case "Carat": return Convert.ToString(value * 141.747616);
                        case "Gram": return Convert.ToString(value * 28.35);
                        case "Ounce": return inputTextBoxValue;
                        case "Stone": return Convert.ToString(value * .00446428571);
                        case "Troy az":
                        default: break;
                    }
                    break;
                case "Stone":
                    switch (output)
                    {
                        case "Pound": return Convert.ToString(value * 14);
                        case "Kilo": return Convert.ToString(value * 6.3502932);
                        case "Carat": return Convert.ToString(value * 31751.4659);
                        case "Gram": return Convert.ToString(value * 6350.29318);
                        case "Ounce": return Convert.ToString(value * 224);
                        case "Stone": return inputTextBoxValue;
                        case "Troy az":
                        default: break;
                    }
                    break;
                case "Troy az":
                    switch (output)
                    {
                        case "Pound":
                        case "Kilo":
                        case "Carat":
                        case "Gram": return Convert.ToString(value * 31.103477);
                        case "Ounce":
                        case "Stone":
                        case "Troy az": return inputTextBoxValue;
                        default: break;
                    }
                    break;
                default: break;
            }
            return null;
        }

        public string AreaFunc(string input, string output, string inputTextBoxValue)
        {
            double value = Convert.ToDouble(inputTextBoxValue);
            switch (input)
            {
                case "Square Foot":
                    switch (output)
                    {
                        case "Square Foot": return inputTextBoxValue;
                        case "Square Metre": return Convert.ToString(value * .0929);
                        case "Square Inch":
                        case "Square CM":
                        case "Square Yard":
                        case "Square Mile":
                        case "Square KM":
                        case "Acre":
                        case "Hectare":
                        default: break;
                    }
                    break;
                case "Square Metre":
                    switch (output)
                    {
                        case "Square Foot": return Convert.ToString(value * 10.764263);
                        case "Square Metre": return inputTextBoxValue;
                        case "Square Inch":
                        case "Square CM":
                        case "Square Yard": return Convert.ToString(value * 1.19599);
                        case "Square Mile":
                        case "Square KM":
                        case "Acre":
                        case "Hectare":
                        default: break;
                    }
                    break;
                case "Square Inch":
                    switch (output)
                    {
                        case "Square Foot": return Convert.ToString(value * 0.00694444444);
                        case "Square Metre": return Convert.ToString(value * 0.00064516);
                        case "Square Inch": return inputTextBoxValue;
                        case "Square CM": return Convert.ToString(value * 6.4516);
                        case "Square Yard": return Convert.ToString(value * 0.000771604938);
                        case "Square Mile": return Convert.ToString(value * 2.4909 * Math.Pow(10, -10));
                        case "Square KM": return Convert.ToString(value * 6.4516 * Math.Pow(10, -10));
                        case "Acre":
                        case "Hectare":
                        default: break;
                    }
                    break;
                case "Square CM":
                    switch (output)
                    {
                        case "Square Foot":
                        case "Square Metre":
                        case "Square Inch": return Convert.ToString(value * 0.1550003);
                        case "Square CM": return inputTextBoxValue;
                        case "Square Yard":
                        case "Square Mile":
                        case "Square KM":
                        case "Acre":
                        case "Hectare":
                        default: break;
                    }
                    break;
                case "Square Yard":
                    switch (output)
                    {
                        case "Square Foot": return Convert.ToString(value * 9);
                        case "Square Metre": return Convert.ToString(value * .8361274);
                        case "Square Inch": return Convert.ToString(value * 1296);
                        case "Square CM": return Convert.ToString(value * 8361.2736);
                        case "Square Yard": return inputTextBoxValue;
                        case "Square Mile": return Convert.ToString(value * 3.2283 * Math.Pow(10, -7));
                        case "Square KM": return Convert.ToString(value * 8.36127 * Math.Pow(10, -7));
                        case "Acre":
                        case "Hectare":
                        default: break;
                    }
                    break;
                case "Square Mile":
                    switch (output)
                    {
                        case "Square Foot":
                        case "Square Metre":
                        case "Square Inch":
                        case "Square CM":
                        case "Square Yard":
                        case "Square Mile": return inputTextBoxValue;
                        case "Square KM": return Convert.ToString(value * 2.59);
                        case "Acre":
                        case "Hectare":
                        default: break;
                    }
                    break;
                case "Square KM":
                    switch (output)
                    {
                        case "Square Foot": return Convert.ToString(value * 10763910.4);
                        case "Square Metre": return Convert.ToString(value * 1000000);
                        case "Square Inch": return Convert.ToString(value * 1.550003 * Math.Pow(10, 9));
                        case "Square CM":
                        case "Square Yard": return Convert.ToString(value * 1195990.05);
                        case "Square Mile": return Convert.ToString(value * 0.3861004);
                        case "Square KM": return inputTextBoxValue;
                        case "Acre":
                        case "Hectare":
                        default: break;
                    }
                    break;
                case "Acre":
                    switch (output)
                    {
                        case "Square Foot":
                        case "Square Metre":
                        case "Square Inch":
                        case "Square CM":
                        case "Square Yard":
                        case "Square Mile":
                        case "Square KM":
                        case "Acre": return inputTextBoxValue;
                        case "Hectare": return Convert.ToString(value * 0.4047);
                        default: break;
                    }
                    break;
                case "Hectare":
                    switch (output)
                    {
                        case "Square Foot":
                        case "Square Metre":
                        case "Square Inch":
                        case "Square CM":
                        case "Square Yard":
                        case "Square Mile":
                        case "Square KM":
                        case "Acre": return Convert.ToString(value * 2.4709661);
                        case "Hectare": return inputTextBoxValue;
                        default: break;
                    }
                    break;
                default: break;
            }
            return null;
        }

        public string VolumeFunc(string input, string output, string inputTextBoxValue)
        {
            double value = Convert.ToDouble(inputTextBoxValue);
            switch (input)
            {
                case "V Inch":
                    switch (output)
                    {
                        case "V Inch": return inputTextBoxValue;
                        case "V CM": return Convert.ToString(value * 16.387064);
                        case "V Foot":
                        case "V Metre":
                        case "V Yard":
                        case "Gallon":
                        case "Litre":
                        default: break;
                    }
                    break;
                case "V CM":
                    switch (output)
                    {
                        case "V Inch": return Convert.ToString(value * .0610237);
                        case "V CM": return inputTextBoxValue;
                        case "V Foot":
                        case "V Metre":
                        case "V Yard":
                        case "Gallon":
                        case "Litre":
                        default: break;
                    }
                    break;
                case "V Foot":
                    switch (output)
                    {
                        case "V Inch":
                        case "V CM":
                        case "V Foot": return inputTextBoxValue;
                        case "V Metre": return Convert.ToString(value * .0283168);
                        case "V Yard":
                        case "Gallon":
                        case "Litre":
                        default: break;
                    }
                    break;
                case "V Metre":
                    switch (output)
                    {
                        case "V Inch":
                        case "V CM":
                        case "V Foot": return Convert.ToString(value * 35.314667);
                        case "V Metre": return inputTextBoxValue;
                        case "V Yard": return Convert.ToString(value * 1.3079505);
                        case "Gallon":
                        case "Litre":
                        default: break;
                    }
                    break;
                case "V Yard":
                    switch (output)
                    {
                        case "V Inch":
                        case "V CM":
                        case "V Foot":
                        case "V Metre": return Convert.ToString(value * .7645549);
                        case "V Yard": return inputTextBoxValue;
                        case "Gallon":
                        case "Litre":
                        default: break;
                    }
                    break;
                case "Gallon":
                    switch (output)
                    {
                        case "V Inch":
                        case "V CM":
                        case "V Foot":
                        case "V Metre":
                        case "V Yard":
                        case "Gallon": return inputTextBoxValue;
                        case "Litre": return Convert.ToString(value * 3.78541);
                        default: break;
                    }
                    break;
                case "Litre":
                    switch (output)
                    {
                        case "V Inch":
                        case "V CM":
                        case "V Foot":
                        case "V Metre":
                        case "V Yard":
                        case "Gallon": return Convert.ToString(value * 0.2641722);
                        case "Litre": return inputTextBoxValue;
                        default: break;
                    }
                    break;
                default: break;
            }
            return null;
        }

        public string PressureFunc(string input, string output, string inputTextBoxValue)
        {
            double value = Convert.ToDouble(inputTextBoxValue);
            switch (input)
            {
                case "atm":
                    switch (output)
                    {
                        case "atm": return inputTextBoxValue;
                        case "Pa": return Convert.ToString(value * 101325);
                        case "mmHg": return Convert.ToString(value * 760);
                        default: break;
                    }
                    break;
                case "Pa":
                    switch (output)
                    {
                        case "atm": return Convert.ToString(value * .0000098923267);
                        case "Pa": return inputTextBoxValue;
                        case "mmHg": return Convert.ToString(value * .0075006);
                        default: break;
                    }
                    break;
                case "mmHg":
                    switch (output)
                    {
                        case "atm": return Convert.ToString(value * .00131578947);
                        case "Pa": return Convert.ToString(value * 133.322);
                        case "mmHg": return inputTextBoxValue;
                        default: break;
                    }
                    break;
                default: break;
            }
            return null;
        }

        public string NumberSystemFunc(string input, string output, string inputTextBoxValue)
        {            
            switch (input)
            {
                case "Binary":
                    switch (output)
                    {
                        case "Binary": return NumberSystem.Convert(2, 2, inputTextBoxValue);
                        case "Decimal": return NumberSystem.Convert(2, 10, inputTextBoxValue);
                        case "Octal": return NumberSystem.Convert(2, 8, inputTextBoxValue);
                        case "Hexadecimal": return NumberSystem.Convert(2, 16, inputTextBoxValue);
                        default: break;
                    }
                    break;
                case "Decimal":
                    switch (output)
                    {
                        case "Binary": return NumberSystem.Convert(10, 2, inputTextBoxValue);
                        case "Decimal": return NumberSystem.Convert(10, 10, inputTextBoxValue);
                        case "Octal": return NumberSystem.Convert(10, 8, inputTextBoxValue);
                        case "Hexadecimal": return NumberSystem.Convert(10, 16, inputTextBoxValue);
                        default: break;
                    }
                    break;
                case "Octal":
                    switch (output)
                    {
                        case "Binary": return NumberSystem.Convert(8, 2, inputTextBoxValue);
                        case "Decimal": return NumberSystem.Convert(8, 10, inputTextBoxValue);
                        case "Octal": return NumberSystem.Convert(8, 8, inputTextBoxValue);
                        case "Hexadecimal": return NumberSystem.Convert(8, 16, inputTextBoxValue);
                        default: break;
                    }
                    break;
                case "Hexadecimal":
                    switch (output)
                    {
                        case "Binary": return NumberSystem.Convert(16, 2, inputTextBoxValue);
                        case "Decimal": return NumberSystem.Convert(16, 10, inputTextBoxValue);
                        case "Octal": return NumberSystem.Convert(16, 8, inputTextBoxValue);
                        case "Hexadecimal": return NumberSystem.Convert(16, 16, inputTextBoxValue);
                        default: break;
                    }
                    break;
                default: break;
            }
            return null;
        }

        public string TrigonometryFunc(string comboxItem, string input)
        {
            double value=Convert.ToDouble(input);
            value = value * Math.PI / 180;   //the value should be in radian
            switch (comboxItem)
            {
                case "Sin":
                    return(Math.Sin(value).ToString());
                case "Cos":
                    return(Math.Cos(value).ToString());
                case "Tan":
                    return(Math.Tan(value).ToString());
                case "Sec":
                    return ((1 / Math.Cos(value)).ToString());
                case "Cosec":
                    return ((1 / Math.Sin(value)).ToString());
                case "Cot":
                    return ((1 / Math.Tan(value)).ToString());
                default:
                    break;
            }
            return null;
        }
    }
}
