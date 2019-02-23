using System.Drawing;
using System.ComponentModel;

namespace EasySystem.Windows.Forms
{
    [ToolboxBitmap(typeof(System.Windows.Forms.Button))]
    public class Button : System.Windows.Forms.Button, ITabItem
    {

        [Description("Sets TabTip of Component"),
         Category("Extra"),
         DefaultValue(""),
         Browsable(true)]
        public string TabTip { get; set; }
    }
}
