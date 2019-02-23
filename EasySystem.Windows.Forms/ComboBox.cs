using System.Drawing;
using System.ComponentModel;

namespace EasySystem.Windows.Forms
{
    [ToolboxBitmap(typeof(System.Windows.Forms.ComboBox))]
    public class ComboBox : System.Windows.Forms.ComboBox, ITabItem
    {

        [Description("Sets TabTip of Component"),
         Category("Extra"),
         DefaultValue(""),
         Browsable(true)]
        public string TabTip { get; set; }
    }
}
