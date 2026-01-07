class Pessoa
{
    //atributos
    private string? _nome;

    private int _idade;

    //construtor
    public Pessoa(string nome, int idade)
    {
        _nome = nome;
        _idade = idade;
    }

    //metodo pra apresentar os dados

    protected void ApresentarPessoa()
    {
        Console.WriteLine($"Nome: {_nome}");
        Console.WriteLine($"Idade: {_idade}");
    }
}