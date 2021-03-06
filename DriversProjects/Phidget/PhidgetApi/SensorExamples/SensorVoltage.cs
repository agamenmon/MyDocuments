using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;


namespace Phidget21Api
{
    public partial class SensorVoltage : BaseSensor
    {
        public override double changeDisplay(int val, out string str)
        {
            double tmp = (val * 0.0313);
            str = tmp.ToString("0.####") + "volt";
            return tmp;
        }

    }
}
