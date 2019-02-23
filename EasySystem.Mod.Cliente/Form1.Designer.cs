namespace EasySystem.Mod.Cliente
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new EasySystem.Windows.Forms.Label();
            this.statusStrip1 = new EasySystem.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new EasySystem.Windows.Forms.ToolStripStatusLabel();
            this.textBoxFiltroCpf = new EasySystem.Windows.Forms.TextBox();
            this.label4 = new EasySystem.Windows.Forms.Label();
            this.textBoxFiltroNome = new EasySystem.Windows.Forms.TextBox();
            this.label3 = new EasySystem.Windows.Forms.Label();
            this.dataGridView1 = new EasySystem.Windows.Forms.DataGridView();
            this.Column1 = new EasySystem.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new EasySystem.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new EasySystem.Windows.Forms.Label();
            this.panel3 = new EasySystem.Windows.Forms.Panel();
            this.panel2 = new EasySystem.Windows.Forms.Panel();
            this.buttonNovo = new EasySystem.Windows.Forms.Button();
            this.buttonEditar = new EasySystem.Windows.Forms.Button();
            this.buttonCancelar = new EasySystem.Windows.Forms.Button();
            this.buttonSalvar = new EasySystem.Windows.Forms.Button();
            this.buttonExcluir = new EasySystem.Windows.Forms.Button();
            this.label1 = new EasySystem.Windows.Forms.Label();
            this.splitContainer1 = new EasySystem.Windows.Forms.SplitContainer();
            this.clientePessoaFisicaView1 = new EasySystem.Mod.Cliente.Views.ClientePessoaFisicaView();
            this.label6 = new EasySystem.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Filtros:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 650);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(894, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(70, 17);
            this.toolStripStatusLabel1.Text = "Bem-Vindo!";
            // 
            // textBoxFiltroCpf
            // 
            this.textBoxFiltroCpf.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFiltroCpf.Location = new System.Drawing.Point(4, 101);
            this.textBoxFiltroCpf.Name = "textBoxFiltroCpf";
            this.textBoxFiltroCpf.Size = new System.Drawing.Size(186, 22);
            this.textBoxFiltroCpf.TabIndex = 10;
            this.textBoxFiltroCpf.TabTip = null;
            this.textBoxFiltroCpf.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxFiltroCpf_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "CPF:";
            // 
            // textBoxFiltroNome
            // 
            this.textBoxFiltroNome.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFiltroNome.Location = new System.Drawing.Point(4, 62);
            this.textBoxFiltroNome.Name = "textBoxFiltroNome";
            this.textBoxFiltroNome.Size = new System.Drawing.Size(186, 22);
            this.textBoxFiltroNome.TabIndex = 8;
            this.textBoxFiltroNome.TabTip = null;
            this.textBoxFiltroNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxFiltroNome_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cod./Nome";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(4, 127);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(186, 345);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.TabTip = null;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Cod.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Nome";
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "(Pessoa Física)";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Location = new System.Drawing.Point(12, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(870, 4);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.buttonNovo);
            this.panel2.Controls.Add(this.buttonEditar);
            this.panel2.Controls.Add(this.buttonCancelar);
            this.panel2.Controls.Add(this.buttonSalvar);
            this.panel2.Controls.Add(this.buttonExcluir);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 64);
            this.panel2.TabIndex = 2;
            // 
            // buttonNovo
            // 
            this.buttonNovo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovo.Image = global::EasySystem.Mod.Cliente.Properties.Resources.button_novo;
            this.buttonNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonNovo.Location = new System.Drawing.Point(3, 2);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(60, 60);
            this.buttonNovo.TabIndex = 0;
            this.buttonNovo.TabTip = null;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Image = global::EasySystem.Mod.Cliente.Properties.Resources.button_editar;
            this.buttonEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEditar.Location = new System.Drawing.Point(69, 2);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(60, 60);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.TabTip = null;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = global::EasySystem.Mod.Cliente.Properties.Resources.button_cancelar;
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCancelar.Location = new System.Drawing.Point(135, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(60, 60);
            this.buttonCancelar.TabIndex = 2;
            this.buttonCancelar.TabTip = null;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Image = global::EasySystem.Mod.Cliente.Properties.Resources.button_salvar;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSalvar.Location = new System.Drawing.Point(201, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(60, 60);
            this.buttonSalvar.TabIndex = 3;
            this.buttonSalvar.TabTip = null;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.Image = global::EasySystem.Mod.Cliente.Properties.Resources.button_excluir;
            this.buttonExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExcluir.Location = new System.Drawing.Point(267, 2);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(60, 60);
            this.buttonExcluir.TabIndex = 4;
            this.buttonExcluir.TabTip = null;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 151);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.clientePessoaFisicaView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxFiltroNome);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxFiltroCpf);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Size = new System.Drawing.Size(870, 496);
            this.splitContainer1.SplitterDistance = 672;
            this.splitContainer1.TabIndex = 13;
            this.splitContainer1.TabTip = null;
            // 
            // clientePessoaFisicaView1
            // 
            this.clientePessoaFisicaView1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientePessoaFisicaView1.Location = new System.Drawing.Point(1, 3);
            this.clientePessoaFisicaView1.Name = "clientePessoaFisicaView1";
            this.clientePessoaFisicaView1.PrevTabTip = null;
            this.clientePessoaFisicaView1.ReadOnly = false;
            this.clientePessoaFisicaView1.Size = new System.Drawing.Size(670, 490);
            this.clientePessoaFisicaView1.TabIndex = 4;
            this.clientePessoaFisicaView1.TabTip = null;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(5, 475);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(185, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "label6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(894, 672);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cliente (Pessoa Física)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Views.ClientePessoaFisicaView clientePessoaFisicaView1;
        private EasySystem.Windows.Forms.Button buttonNovo;
        private EasySystem.Windows.Forms.Button buttonEditar;
        private EasySystem.Windows.Forms.Button buttonCancelar;
        private EasySystem.Windows.Forms.Button buttonSalvar;
        private EasySystem.Windows.Forms.Button buttonExcluir;
        private EasySystem.Windows.Forms.Label label1;
        private EasySystem.Windows.Forms.Panel panel2;
        private EasySystem.Windows.Forms.Panel panel3;
        private EasySystem.Windows.Forms.Label label2;
        private EasySystem.Windows.Forms.DataGridView dataGridView1;
        private EasySystem.Windows.Forms.Label label3;
        private EasySystem.Windows.Forms.TextBox textBoxFiltroNome;
        private EasySystem.Windows.Forms.TextBox textBoxFiltroCpf;
        private EasySystem.Windows.Forms.Label label4;
        private EasySystem.Windows.Forms.StatusStrip statusStrip1;
        private EasySystem.Windows.Forms.Label label5;
        private EasySystem.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private EasySystem.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private EasySystem.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Timer timer1;
        private Windows.Forms.SplitContainer splitContainer1;
        private Windows.Forms.Label label6;

    }
}