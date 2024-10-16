using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoMonkeyShop.src.model
{
    internal class MClientes
    {
        private int idCliente;
        private string name;
        private string sobrenome;
        private string telefone;
        private string celular; //whatsapp
        private string email;
        private DateTime dataNascimento;
        private string rg;
        private string cpf;
        private string tipoClie;

        private string cep;
        private string logradouro;
        private int numeroLog;
        private string bairro;
        private string complemento;
        private string cidade;
        private string uf;
        private string pais;

        public int GetIdCliente()
        {
            return idCliente;
        }

        public void SetIdCliente(int value)
        {
            idCliente = value;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        public string GetSobrenome()
        {
            return sobrenome;
        }

        public void SetSobrenome(string value)
        {
            sobrenome = value;
        }

        public string GetTelefone()
        {
            return telefone;
        }

        public void SetTelefone(string value)
        {
            telefone = value;
        }

        public string GetCelular()
        {
            return celular;
        }

        public void SetCelular(string value)
        {
            celular = value;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string value)
        {
            email = value;
        }

        public DateTime GetDataNascimento()
        {
            return dataNascimento;
        }

        public void SetDataNascimento(DateTime value)
        {
            dataNascimento = value;
        }

        public string GetRg()
        {
            return rg;
        }

        public void SetRg(string value)
        {
            rg = value;
        }

        public string GetCpf()
        {
            return cpf;
        }

        public void SetCpf(string value)
        {
            cpf = value;
        }

        public string GetTipoClie()
        {
            return tipoClie;
        }

        public void SetTipoClie(string value)
        {
            tipoClie = value;
        }

        public string GetCep()
        {
            return cep;
        }

        public void SetCep(string value)
        {
            cep = value;
        }

        public string GetLogradouro()
        {
            return logradouro;
        }

        public void SetLogradouro(string value)
        {
            logradouro = value;
        }

        public int GetNumeroLog()
        {
            return numeroLog;
        }

        public void SetNumeroLog(int value)
        {
            numeroLog = value;
        }

        public string GetBairro()
        {
            return bairro;
        }

        public void SetBairro(string value)
        {
            bairro = value;
        }

        public string GetComplemento()
        {
            return complemento;
        }

        public void SetComplemento(string value)
        {
            complemento = value;
        }

        public string GetCidade()
        {
            return cidade;
        }

        public void SetCidade(string value)
        {
            cidade = value;
        }

        public string GetUf()
        {
            return uf;
        }

        public void SetUf(string value)
        {
            uf = value;
        }

        public string GetPais()
        {
            return pais;
        }

        public void SetPais(string value)
        {
            pais = value;
        }
    }
}
