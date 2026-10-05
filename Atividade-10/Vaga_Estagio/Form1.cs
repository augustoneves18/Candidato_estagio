using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vaga_Estagio
{
    // Cria um objeto da classe Candidato
    Candidato candidato = new Candidato();
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(
                    "Informe o nome do candidato.",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            Txb_Candidato.Focus();
            return;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verifica se o nome foi preenchido
            if (string.IsNullOrWhiteSpace(Txb_Candidato.Text))
            {
                MessageBox.Show(
                    "Informe o nome do candidato.",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Txb_Candidato.Focus();
                return;
            }

            // Verifica se a data foi preenchida
            if (string.IsNullOrWhiteSpace(Txb_Data.Text) ||
                string.IsNullOrWhiteSpace(Txb_Mes.Text) ||
                string.IsNullOrWhiteSpace(Txb_Ano.Text))
            {
                MessageBox.Show(
                    "Informe a data de nascimento.",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Txb_Data.Focus();
                return;
            }

            // Converte os TextBox para números
            int dia = int.Parse(Txb_Data.Text);
            int mes = int.Parse(Txb_Mes.Text);
            int ano = int.Parse(Txb_Ano.Text);

            // Guarda os dados no objeto Candidato
            candidato.Nome = Txb_Candidato.Text;
            candidato.Dia = dia;
            candidato.Mes = mes;
            candidato.Ano = ano;

            // Área de atuação
            if (radioButton1.Checked)
            {
                candidato.AreaAtuacao = "Informática";
            }
            else if (radioButton2.Checked)
            {
                candidato.AreaAtuacao = "Administração";
            }
            else if (radioButton3.Checked)
            {
                candidato.AreaAtuacao = "Engenharia";
            }
            else if (radioButton4.Checked)
            {
                candidato.AreaAtuacao = "Enfermagem";
            }

            // Turnos disponíveis
            Candidato.Matutino = checkBox1.Checked;
            candidato.Vespertino = checkBox2.Checked;
            candidato.Noturno = checkBox3.Checked;

            // Escolaridade
            candidato.Escolaridade = comboBox1.Text;

            // Mostra os dados cadastrados
            MessageBox.Show(
                candidato.ToString(),
                "Candidato cadastrado com sucesso!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Txb_Candidato.Clear();
            Txb_Data.Clear();
            Txb_Mes.Clear();
            Txb_Ano.Clear();
            Txb_Idade.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

            comboBox1.SelectedIndex = -1;

            Txb_Candidato.Focus();
        }

        private void Txb_Candidato_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txb_Calcular_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(Txb_Data.Text);
            int mes = int.Parse(Txb_Mes.Text);
            int ano = int.Parse(Txb_Ano.Text);

            DateTime nascimento = new DateTime(ano, mes, dia);

            DateTime hoje = DateTime.Today;

            int idade = hoje.Year - nascimento.Year;

            if (nascimento > hoje.AddYears(-idade))
            {
                idade--;
            }

            Txb_Idade.Text = idade.ToString();
        }
    }
}
