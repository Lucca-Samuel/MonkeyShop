using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoMonkeyShop.src.dao
{
    internal class DaoProdutos
    {
        private const string INSERT_SQL = "INSERT INTO produtos (pro_nome, pro_valor, pro_estoque) VALUES (@nome, @valor, @estoque); SELECT SCOPE_IDENTITY();";
        private const string DELETE_SQL = "DELETE FROM tbl_produtos WHERE id_produto = @idProduto";
        private const string UPDATE_SQL = "UPDATE tbl_produtos SET pro_nome = @nome, pro_valor = @valor, pro_estoque = @estoque WHERE id_produto = @idProduto";
        private const string SELECT_BY_ID_SQL = "SELECT id_produto, pro_nome, pro_valor, pro_estoque FROM tbl_produtos WHERE id_produto = @idProduto";
        private const string SELECT_ALL_SQL = "SELECT id_produto, pro_nome, pro_valor, pro_estoque FROM tbl_produtos";
    }
}
