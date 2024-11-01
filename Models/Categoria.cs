namespace LojaProdutos.Models
{
    public class Categoria
    {
        public int Id { get; set; }  // Chave primária
        public string Nome { get; set; }  // Nome da categoria
        public string Descricao { get; set; }  // Descrição da categoria

        // Relacionamento 1:N com Produtos
        public List<Produto> Produtos { get; set; }
    }
}