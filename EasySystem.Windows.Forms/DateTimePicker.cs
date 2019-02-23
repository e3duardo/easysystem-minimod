using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EasySystem.Windows.Forms
{
    [ToolboxBitmap(typeof(System.Windows.Forms.DateTimePicker))]
    public partial class DateTimePicker : System.Windows.Forms.DateTimePicker, ITabItem
    {

        [Description("Sets TabTip of Component"),
         Category("Extra"),
         DefaultValue(""),
         Browsable(true)]
        public string TabTip { get; set; }
    }
}
