namespace EasySystem.Mod.Shared.Views
{
    partial class CfgCliente
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new EasySystem.Windows.Forms.GroupBox();
            this.checkBox2 = new EasySystem.Windows.Forms.CheckBox();
            this.checkBox1 = new EasySystem.Windows.Forms.CheckBox();
            this.checkBox3 = new EasySystem.Windows.Forms.CheckBox();
            this.label1 = new EasySystem.Windows.Forms.Label();
            this.label2 = new EasySystem.Windows.Forms.Label();
            this.textBox1 = new EasySystem.Windows.Forms.TextBox();
            this.button1 = new EasySystem.Windows.Forms.Button();
            this.checkBox4 = new EasySystem.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario de cadastro";
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(6, 44);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(382, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.TabTip = null;
            this.checkBox2.Text = "Salvar automaticamente o cliente atual ao fechar.";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(6, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(382, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.TabTip = null;
            this.checkBox1.Text = "Mostrar lista de clientes e campos  de pesquisa. ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Location = new System.Drawing.Point(9, 134);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(382, 17);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.TabTip = null;
            this.checkBox3.Text = "Salvar cadastro do cliente em arquivo de texto enquanto digita.";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prevenção de perda de dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Local:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TabTip = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.TabTip = null;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.Location = new System.Drawing.Point(6, 67);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(382, 17);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.TabTip = null;
            this.checkBox4.Text = "Permitir cadastro com CPF duplicado.";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // CfgCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CfgCliente";
            this.Size = new System.Drawing.Size(400, 300);
            this.Load += new System.EventHandler(this.CfgCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EasySystem.Windows.Forms.GroupBox groupBox1;
        private EasySystem.Windows.Forms.CheckBox checkBox2;
        private EasySystem.Windows.Forms.CheckBox checkBox1;
        private EasySystem.Windows.Forms.CheckBox checkBox3;
        private EasySystem.Windows.Forms.Label label1;
        private EasySystem.Windows.Forms.Label label2;
        private EasySystem.Windows.Forms.TextBox textBox1;
        private EasySystem.Windows.Forms.Button button1;
        private Windows.Forms.CheckBox checkBox4;
    }
}
