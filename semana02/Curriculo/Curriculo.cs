public class Curriculo
{
    public string _nome;
    public List<Emprego> _empregos = new List<Emprego>();

    public void Exibir()
    {
        Console.WriteLine(" ");
        Console.WriteLine($"Nome: {_nome}");
        Console.WriteLine("Empregos:");
        
        foreach (var emprego in _empregos)
        {
            emprego.Exibir();
        }
    }
}