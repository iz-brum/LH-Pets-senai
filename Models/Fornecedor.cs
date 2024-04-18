namespace LHPet.Models;
public class Fornecedor
{
    /* No trecho de código a seguir são criados os 
    atributos de Fornecedor e seus getters e setters
    correspondentes. */
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cnpj { get; set; }
    public string Email { get; set; }

    /* Nesse trecho do código, é criado o Construtor do 
    model Fornecedor e determinado quais parâmetros são 
    necessários na criação das instâncias. */
    public Fornecedor(int id, string nome, string cnpj,
    string email)
    {
        this.Id = id;
        this.Nome = nome;
        this.Cnpj = cnpj;
        this.Email = email;
    }
}
