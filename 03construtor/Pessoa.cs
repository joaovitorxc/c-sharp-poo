class Pessoa 
{
    //1° construtor
    public Pessoa()
    {
        Console.WriteLine("Hello Word!");
    }

    //2° construtor
    public Pessoa(string nome)
    {
        Console.WriteLine($"Olá {nome}");
    }
    //3° construtor 
    public Pessoa(string nome, int idade)
    {
        Console.WriteLine($"Olá {nome} você tem {idade} anos.");
    }
}