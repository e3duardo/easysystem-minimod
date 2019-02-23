using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using EasySystem.Windows.Forms;
using EasySystem.Mod.Shared.Views;

namespace EasySystem.Mod.Shared
{
    public partial class ConfiguracaoView : Form
    {
        public bool IsChanged {get; set;}
        private CfgCliente cfgcl { get; set; }

        public ConfiguracaoView()
        {
            InitializeComponent();
        }

        private void Configuracao_Load(object sender, EventArgs e)
        {
            cfgcl = new CfgCliente();

            //making on edit can aplly
            for (int i = 0; i < cfgcl.Controls.Count; i++)
            {
                //controls dentro de groupbox
                if (cfgcl.Controls[i].GetType() == typeof(EasySystem.Windows.Forms.GroupBox))
                {
                    for (int j = 0; j < cfgcl.Controls[i].Controls.Count; j++)
                    {
                        if (cfgcl.Controls[i].Controls[j].GetType() == typeof(EasySystem.Windows.Forms.CheckBox))
                        {
                            EasySystem.Windows.Forms.CheckBox check = (EasySystem.Windows.Forms.CheckBox)cfgcl.Controls[i].Controls[j];
                            check.CheckedChanged += new EventHandler(tb_Change);
                        }
                        if (cfgcl.Controls[i].Controls[j].GetType() == typeof(EasySystem.Windows.Forms.TextBox))
                        {
                            EasySystem.Windows.Forms.TextBox check = (EasySystem.Windows.Forms.TextBox)cfgcl.Controls[i].Controls[j];
                            check.TextChanged += new EventHandler(tb_Change);
                        }
                    }
                }
                else if (cfgcl.Controls[i].GetType() == typeof(EasySystem.Windows.Forms.CheckBox))
                {
                    EasySystem.Windows.Forms.CheckBox check = (EasySystem.Windows.Forms.CheckBox)cfgcl.Controls[i];
                    check.CheckedChanged += new EventHandler(tb_Change);
                }
                else if (cfgcl.Controls[i].GetType() == typeof(EasySystem.Windows.Forms.TextBox))
                {
                    EasySystem.Windows.Forms.TextBox check = (EasySystem.Windows.Forms.TextBox)cfgcl.Controls[i];
                    check.TextChanged += new EventHandler(tb_Change);
                }
            }

            TabPage tp = new TabPage();
            tp.Text = "Cliente";
            tp.Controls.Add(cfgcl);


            tabControl1.Controls.Add(tp);

            IsChanged = false;
            buttonAplicar.Enabled = IsChanged;
        }

        private void tb_Change(object sender, EventArgs e)
        {
            try
            {
                IsChanged = true;
                buttonAplicar.Enabled = IsChanged;
            }
            catch (Exception ex)
            {
                Console.WriteLine("erro lostfocus" + ex);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (IsChanged)
                buttonAplicar.PerformClick();

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void buttonAplicar_Click(object sender, EventArgs e)
        {
            cfgcl.Save();

            IsChanged = false;
            buttonAplicar.Enabled = IsChanged;
        }
    }
}
