internal class Program
{
    private static void Main(string[] args)
    {
        // TRABALHADO COM ELEMENTO (LIST)
        //Criando uma lista 
        List<string> frutas = new List<string>();

        //Adicionar itens na lista
        frutas.Add("Morango");
        frutas.Add("Manga");
        frutas.Add("Goiaba");
        frutas.Add("Uva");

        //Imprimindo os itens da lista
        //Console.WriteLine("Minhas lista de frutas: ");
        //foreach (string fruta in frutas)
        //{
        //    Console.WriteLine(fruta);
        //}
        frutas.ForEach(Console.WriteLine);

        Console.WriteLine();
        //Imprimir elemento na indice especifica
        Console.WriteLine("Fruta na indice 2: " + frutas[2]);

        //inserir um elemneto no indice especifico
        frutas.Insert(1, "Maracuja");

        //imprimir a alista novamente 
        Console.WriteLine();

        //Console.WriteLine("Minhas lista de frutas: ");
        //foreach (string fruta in frutas)
        //{
        //    Console.WriteLine(fruta);
        //}
        frutas.ForEach(Console.WriteLine);

        //Alterar um elemento no indice especifico
        frutas[4] = "Pêra";
        //Console.WriteLine("Minha  lista de frutas: ");
        //foreach (string fruta in frutas)
        //{
        //    Console.WriteLine(fruta);
        //}
        frutas.ForEach(Console.WriteLine);
        //remover elementos da lista no indice especifico 
        frutas.RemoveAt(3);

        //Remover elementos pell valor do conteúdo
        frutas.Remove("Morango");

        //Imprimindo a lista novamente 
        Console.WriteLine();
        //Console.WriteLine("Minha lista de frutas: ");
        //foreach (string fruta in frutas)
        //{
        //    Console.WriteLine(fruta);
        //}
        frutas.ForEach(Console.WriteLine);

    }
}