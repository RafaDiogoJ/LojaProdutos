
using System.ComponentModel.DataAnnotations;

namespace LojaProdutos.Models
{
    public class Produto
    {
        public int Id { get; set; }  // Chave primária
        public string Nome { get; set; }  // Nome do produto
        
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }  // Preço do produto
        public string Descricao { get; set; }  // Descrição do produto

        // Chave estrangeira para Categoria
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }  // Relacionamento com Categoria
    }
}