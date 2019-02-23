using System.Drawing;
using System.ComponentModel;

namespace EasySystem.Windows.Forms
{
    [ToolboxBitmap(typeof(System.Windows.Forms.TextBox))]
    public class TextBox : System.Windows.Forms.TextBox, ITabItem
    {

        [Description("Sets TabTip of Component"),
         Category("Extra"),
         DefaultValue(""),
         Browsable(true)]
        public string TabTip { get; set; }
    }
}
