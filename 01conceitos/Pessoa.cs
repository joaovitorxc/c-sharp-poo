class Pessoa
{
    //Atributo
    public string? Nome;

    public int Idade;

    //Método de Apresentação
    public void Apresentacao()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}");
    }

    //Método para retornar situação de idade
    public string VerificarIdade()
    {
        return Idade >= 18 ? "Maior de idade" : "Menor de idade";
    }
}