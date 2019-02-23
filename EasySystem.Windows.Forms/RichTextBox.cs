using System.Drawing;
using System.ComponentModel;

namespace EasySystem.Windows.Forms
{
    [ToolboxBitmap(typeof(System.Windows.Forms.RichTextBox))]
    public class RichTextBox : System.Windows.Forms.RichTextBox, ITabItem
    {

        [Description("Sets TabTip of Component"),
         Category("Extra"),
         DefaultValue(""),
         Browsable(true)]
        public string TabTip { get; set; }
    }
}
