namespace EasySystem.Mod.Shared
{
    partial class ConfiguracaoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new EasySystem.Windows.Forms.TabControl();
            this.buttonAplicar = new EasySystem.Windows.Forms.Button();
            this.buttonCancelar = new EasySystem.Windows.Forms.Button();
            this.buttonOK = new EasySystem.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(5, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(408, 326);
            this.tabControl1.TabIndex = 0;
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(338, 335);
            this.buttonAplicar.Name = "buttonAplicar";
            this.buttonAplicar.Size = new System.Drawing.Size(75, 23);
            this.buttonAplicar.TabIndex = 1;
            this.buttonAplicar.TabTip = null;
            this.buttonAplicar.Text = "Aplicar";
            this.buttonAplicar.UseVisualStyleBackColor = true;
            this.buttonAplicar.Click += new System.EventHandler(this.buttonAplicar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(257, 335);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 2;
            this.buttonCancelar.TabTip = null;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(176, 335);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.TabTip = null;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // ConfiguracaoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 369);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAplicar);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfiguracaoView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuração";
            this.Load += new System.EventHandler(this.Configuracao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private EasySystem.Windows.Forms.TabControl tabControl1;
        private EasySystem.Windows.Forms.Button buttonAplicar;
        private EasySystem.Windows.Forms.Button buttonCancelar;
        private EasySystem.Windows.Forms.Button buttonOK;
    }
}