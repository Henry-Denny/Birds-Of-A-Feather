using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace Birds_Of_A_Feather
{
    class CustomTrackbar : TrackBar
    {
        [Category("Custom")]
        [Browsable(true)]
        public double Increment { get; set; } = 0.01f;

        public new double Maximum
        {
            get { return Math.Round((base.Maximum * Increment), 3); }
            set { base.Maximum = Convert.ToInt16(value / Increment); }
        }
        public new double Minimum
        {
            get { return Math.Round((base.Minimum * Increment), 3); }
            set { base.Minimum = Convert.ToInt16(value / Increment); }
        }
        public new double SmallChange
        {
            get { return Math.Round((base.SmallChange * Increment), 3); }
            set { base.SmallChange = Convert.ToInt16(value / Increment); }
        }
        public new double LargeChange
        {
            get { return Math.Round((base.LargeChange * Increment), 3); }
            set { base.LargeChange = Convert.ToInt16(value / Increment); }
        }
        public new double Value
        {
            get { return Math.Round((base.Value * Increment), 3); }
            set { base.Value = Convert.ToInt16(value / Increment); }
        }
    }
}
