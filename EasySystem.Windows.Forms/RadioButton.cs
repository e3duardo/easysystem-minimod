using System.Drawing;
using System.ComponentModel;

namespace EasySystem.Windows.Forms
{
    [ToolboxBitmap(typeof(System.Windows.Forms.RadioButton))]
    public class RadioButton : System.Windows.Forms.RadioButton, ITabItem
    {

        [Description("Sets TabTip of Component"),
         Category("Extra"),
         DefaultValue(""),
         Browsable(true)]
        public string TabTip { get; set; }
    }
}
