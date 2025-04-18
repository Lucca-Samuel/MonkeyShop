﻿using projetoMonkeyShop.src.controller;
using projetoMonkeyShop.src.dao;
using projetoMonkeyShop.src.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoMonkeyShop.src.view.admView.fornecedores
{
    public partial class FrmCadastroFornecedores : Form
    {
        CFornecedores cFornecedor = new CFornecedores();
        MFornecedores mFornecedor = new MFornecedores();
        //FornecedoresInitial fornecedoresInitial = new FornecedoresInitial();

        private FornecedoresInitial fornecedoresInitial;

        public FrmCadastroFornecedores(FornecedoresInitial fornecedoresInitial)
        {
            this.fornecedoresInitial = fornecedoresInitial; // Atribui a instância passada
            InitializeComponent();
            tbxIdFornecedor.Enabled = false;
        }

        public string salvarAlterar;

        public FrmCadastroFornecedores()
        {
            InitializeComponent();
            tbxIdFornecedor.Enabled = false;
        }

        private void btnSalvarFornecedor_Click(object sender, EventArgs e)
        {
            if (salvarAlterar == "alterar")
            {
                this.AlterarFornecedor();
            }else if(salvarAlterar == "salvar")
            {
            this.SalvarFornecedor();
            }
        }

        private void btnCancelarFornecedor_Click(object sender, EventArgs e)
        {
            DialogResult confirmacao = MessageBox.Show(this, "Tem certeza que deseja cancelar o cadastro?", "Confirmação", MessageBoxButtons.YesNo);

            if (confirmacao == DialogResult.Yes)
            {
                this.LimparCampos();
            }
        }

        private void LimparCampos()
        {
            tbxNomeFor.Text = ("");
            tbxCNPJ.Text = ("");
            tbxProdutoFor.Text = ("");
            tbxTelefone.Text = ("");
            tbxCelular.Text = ("");
            tbxEmail.Text = ("");
            tbxContato.Text = ("");
            tbxCEP.Text = ("");
            tbxLogradouro.Text = ("");
            tbxNumero.Text = ("");
            tbxBairro.Text = ("");
            tbxCidade.Text = ("");
            tbxEstado.Text = ("");
            tbxLogradouro.Text = ("");
            tbxFornecedorInfos.Text = ("");
            tbxComplemento.Text = ("");
        }

        private void SalvarFornecedor()
        {
            mFornecedor.setNomeFantasiaFornecedor(this.tbxNomeFor.Text);
            mFornecedor.setCnpjFornecedor(this.tbxCNPJ.Text);
            mFornecedor.setProdutoFornecedor(this.tbxProdutoFor.Text);
            mFornecedor.setTelefoneFornecedor(this.tbxTelefone.Text);
            mFornecedor.setCelularFornecedor(this.tbxCelular.Text);
            mFornecedor.setEmailFornecedor(this.tbxEmail.Text);
            mFornecedor.setNomeContatoFornecedor(this.tbxContato.Text);
            mFornecedor.setCepFornecedor(this.tbxCEP.Text);
            mFornecedor.setLogradouroFornecedor(this.tbxLogradouro.Text);
            mFornecedor.setNumeroLogradouroFornecedor(int.Parse(this.tbxNumero.Text));
            mFornecedor.setBairroFornecedor(this.tbxBairro.Text);
            mFornecedor.setCidadeFornecedor(this.tbxCidade.Text);
            mFornecedor.setUfFornecedor(this.tbxEstado.Text);
            mFornecedor.setComplementoLogradouroFornecedor(this.tbxLogradouro.Text);
            mFornecedor.setInfoImportantFornecedor(this.tbxFornecedorInfos.Text);

            try
            {
                if (cFornecedor.salvarProdutoC(mFornecedor) > 0)
                {
                    MessageBox.Show("Fornecedor cadastrado com sucesso cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LimparCampos();

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Fornecedor", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }

        public void AlterarFornecedor()
        {
            mFornecedor.setIdFornecedor(int.Parse(this.tbxIdFornecedor.Text));
            mFornecedor.setNomeFantasiaFornecedor(this.tbxNomeFor.Text);
            mFornecedor.setCnpjFornecedor(this.tbxCNPJ.Text);
            mFornecedor.setProdutoFornecedor(this.tbxProdutoFor.Text);
            mFornecedor.setTelefoneFornecedor(this.tbxTelefone.Text);
            mFornecedor.setCelularFornecedor(this.tbxCelular.Text);
            mFornecedor.setEmailFornecedor(this.tbxEmail.Text);
            mFornecedor.setNomeContatoFornecedor(this.tbxContato.Text);
            mFornecedor.setCepFornecedor(this.tbxCEP.Text);
            mFornecedor.setLogradouroFornecedor(this.tbxLogradouro.Text);
            mFornecedor.setNumeroLogradouroFornecedor(int.Parse(this.tbxNumero.Text));
            mFornecedor.setBairroFornecedor(this.tbxBairro.Text);
            mFornecedor.setCidadeFornecedor(this.tbxCidade.Text);
            mFornecedor.setUfFornecedor(this.tbxEstado.Text);
            mFornecedor.setComplementoLogradouroFornecedor(this.tbxLogradouro.Text);
            mFornecedor.setInfoImportantFornecedor(this.tbxFornecedorInfos.Text);
            
            if(cFornecedor.AlterarFornecedor(mFornecedor))
            {
                MessageBox.Show("Dados Alterados com sucesso com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao alterar os dados", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void FrmCadastroFornecedores_Load(object sender, EventArgs e)
        {
        }

        public void loadFornecedores(DataGridViewRow selectedRow)
        {
            try
            {
                tbxIdFornecedor.Text = selectedRow.Cells[0].Value.ToString();
                tbxNomeFor.Text = selectedRow.Cells[1].Value.ToString();
                tbxCNPJ.Text = selectedRow.Cells[2].Value.ToString();
                tbxProdutoFor.Text = selectedRow.Cells[3].Value.ToString();
                tbxTelefone.Text = selectedRow.Cells[4].Value.ToString();
                tbxCelular.Text = selectedRow.Cells[5].Value.ToString();
                tbxEmail.Text = selectedRow.Cells[6].Value.ToString();
                tbxContato.Text = selectedRow.Cells[7].Value.ToString();
                tbxCEP.Text = selectedRow.Cells[8].Value.ToString();
                tbxLogradouro.Text = selectedRow.Cells[9].Value.ToString();
                tbxNumero.Text = selectedRow.Cells[10].Value.ToString();
                tbxComplemento.Text = selectedRow.Cells[11].Value.ToString();
                tbxBairro.Text = selectedRow.Cells[12].Value.ToString();
                tbxCidade.Text = selectedRow.Cells[13].Value.ToString();
                tbxEstado.Text = selectedRow.Cells[14].Value.ToString();
                tbxFornecedorInfos.Text = selectedRow.Cells[15].Value.ToString();

                tbxIdFornecedor.Enabled = false;

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show(this, "Código invalido ou Registro não selecionado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
