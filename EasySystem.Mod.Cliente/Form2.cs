using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EasySystem.Mod.Cliente.Domain;
using EasySystem.Mod.Shared.Domain;
using EasySystem.Mod.Cliente.Repositories;

namespace EasySystem.Mod.Cliente
{
    public partial class Form2 : Form
    {
        private IClientePessoaFisicaRepository repository;
        private IConfiguracaoRepository cfgrepository;
        private ICollection<ClientePessoaFisica> Clientes;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            repository = new ClientePessoaFisicaRepository();
            Clientes = repository.GetAll();

            dataGridView1.DataSource = this.Clientes;

            label6.Text = string.Format("{0} linhas.", Clientes.Count);
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            timerUpKey.Start();
            currenttime = 0;
            funcao = 1;
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            timerUpKey.Start();
            currenttime = 0;
            funcao = 2;
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            timerUpKey.Start();
            currenttime = 0;
            funcao = 3;
        }

        public void FindById()
        {
            textBox2.Text = "";
            textBox3.Text = "";

            long tempid = 0;
            long.TryParse(textBox1.Text, out tempid);

            if (tempid != 0)
            {
                ICollection<ClientePessoaFisica> templist = new List<ClientePessoaFisica>();
                templist.Add(repository.GetById(tempid));
                Clientes = templist;
            }
            else
                Clientes = repository.GetAll();

            dataGridView1.DataSource = this.Clientes;
            label6.Text = string.Format("{0} linhas.", Clientes.Count);
            this.Cursor = Cursors.Default;
        }
        public void FindByNome()
        {
            textBox1.Text = "";
            textBox3.Text = "";

            Clientes = repository.GetByNome(textBox2.Text);

            dataGridView1.DataSource = this.Clientes;
            label6.Text = string.Format("{0} linhas.", Clientes.Count);
            this.Cursor = Cursors.Default;
        }
        public void FindByCpf()
        {
            textBox1.Text = "";
            textBox2.Text = "";

            Clientes = repository.GetByCpf(textBox3.Text);

            dataGridView1.DataSource = this.Clientes;
            label6.Text = string.Format("{0} linhas.", Clientes.Count);
            this.Cursor = Cursors.Default;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            toolStripStatusLabel1.Text = "Erro ao carregar lista de objetos.";
        }

        private void timerUpKey_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(currenttime);
            if (currenttime == stoptime)
            {
                timerUpKey.Stop();

                switch (funcao)
                {
                    case 1:
                        FindById();
                        break;
                    case 2:
                        FindByNome();
                        break;
                    case 3:
                        FindByCpf();
                        break;
                }
            }
            currenttime++;
        }

        int currenttime = 0;
        int stoptime = 1;
        int funcao = 0;

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClientePessoaFisica cpf = repository.GetById((long)dataGridView1[0, e.RowIndex].Value);
            Form1 form = new Form1();

            form.IsCollapsed = true;
            form.IsAddingOrEditing = true;
            form.Cliente = cpf;
            form.ShowDialog();
            //resfresh all and select id edited
            Clientes = repository.GetAll();

            dataGridView1.DataSource = this.Clientes;
            this.label6.Text = string.Format("{0} linhas.", Clientes.Count);

            foreach (DataGridViewRow t in dataGridView1.Rows)
            {
                if ((long)t.Cells[0].Value == cpf.Id)
                {
                    t.Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = t.Index;
                    break;
                }
            }
        }

    }
}
