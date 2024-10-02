using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoMonkeyShop.src.model
{
    internal class MFornecedores
    {
        private int id_fornecedor;
        private string nome_fantasia_fornecedor;
        private string cnpj_fornecedor;
        private string produto_fornecedor;
        private string telefone_fornecedor;
        private string celular_fornecedor;
        private string email_fornecedor;
        private string nome_contato_fornecedor;
        private string cep_fornecedor;
        private string logradouro_fornecedor;
        private int numero_logradouro_fornecedor;
        private string complemento_logradouro_fornecedor;
        private string bairro_fornecedor;
        private string cidade_fornecedor;
        private string uf_fornecedor;
        private string info_important_fornecedor;

        // Getters dos atributos
        public int getIdFornecedor()
        {
            return id_fornecedor;
        }

        public string getNomeFantasiaFornecedor()
        {
            return nome_fantasia_fornecedor;
        }

        public string getCnpjFornecedor()
        {
            return cnpj_fornecedor;
        }

        public string getProdutoFornecedor()
        {
            return produto_fornecedor;
        }

        public string getTelefoneFornecedor()
        {
            return telefone_fornecedor;
        }

        public string getCelularFornecedor()
        {
            return celular_fornecedor;
        }

        public string getEmailFornecedor()
        {
            return email_fornecedor;
        }

        public string getNomeContatoFornecedor()
        {
            return nome_contato_fornecedor;
        }

        public string getCepFornecedor()
        {
            return cep_fornecedor;
        }

        public string getLogradouroFornecedor()
        {
            return logradouro_fornecedor;
        }

        public int getNumeroLogradouroFornecedor()
        {
            return numero_logradouro_fornecedor;
        }

        public string getComplementoLogradouroFornecedor()
        {
            return complemento_logradouro_fornecedor;
        }

        public string getBairroFornecedor()
        {
            return bairro_fornecedor;
        }

        public string getCidadeFornecedor()
        {
            return cidade_fornecedor;
        }

        public string getUfFornecedor()
        {
            return uf_fornecedor;
        }

        public string getInfoImportantFornecedor()
        {
            return info_important_fornecedor;
        }

        // Setters dos atributos
        public void setIdFornecedor(int id_fornecedor)
        {
            this.id_fornecedor = id_fornecedor;
        }

        public void setNomeFantasiaFornecedor(string nome_fantasia_fornecedor)
        {
            this.nome_fantasia_fornecedor = nome_fantasia_fornecedor;
        }

        public void setCnpjFornecedor(string cnpj_fornecedor)
        {
            this.cnpj_fornecedor = cnpj_fornecedor;
        }

        public void setProdutoFornecedor(string produto_fornecedor)
        {
            this.produto_fornecedor = produto_fornecedor;
        }

        public void setTelefoneFornecedor(string telefone_fornecedor)
        {
            this.telefone_fornecedor = telefone_fornecedor;
        }

        public void setCelularFornecedor(string celular_fornecedor)
        {
            this.celular_fornecedor = celular_fornecedor;
        }

        public void setEmailFornecedor(string email_fornecedor)
        {
            this.email_fornecedor = email_fornecedor;
        }

        public void setNomeContatoFornecedor(string nome_contato_fornecedor)
        {
            this.nome_contato_fornecedor = nome_contato_fornecedor;
        }

        public void setCepFornecedor(string cep_fornecedor)
        {
            this.cep_fornecedor = cep_fornecedor;
        }

        public void setLogradouroFornecedor(string logradouro_fornecedor)
        {
            this.logradouro_fornecedor = logradouro_fornecedor;
        }

        public void setNumeroLogradouroFornecedor(int numero_logradouro_fornecedor)
        {
            this.numero_logradouro_fornecedor = numero_logradouro_fornecedor;
        }

        public void setComplementoLogradouroFornecedor(string complemento_logradouro_fornecedor)
        {
            this.complemento_logradouro_fornecedor = complemento_logradouro_fornecedor;
        }

        public void setBairroFornecedor(string bairro_fornecedor)
        {
            this.bairro_fornecedor = bairro_fornecedor;
        }

        public void setCidadeFornecedor(string cidade_fornecedor)
        {
            this.cidade_fornecedor = cidade_fornecedor;
        }

        public void setUfFornecedor(string uf_fornecedor)
        {
            this.uf_fornecedor = uf_fornecedor;
        }

        public void setInfoImportantFornecedor(string info_important_fornecedor)
        {
            this.info_important_fornecedor = info_important_fornecedor;
        }
    }
}
