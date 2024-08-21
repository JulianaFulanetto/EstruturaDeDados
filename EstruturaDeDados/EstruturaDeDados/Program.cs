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

        Console.WriteLine();
        Console.WriteLine("Minha  lista de frutas: ");
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
        Console.WriteLine("Minha lista de frutas: ");
        //foreach (string fruta in frutas)
        //{
        //    Console.WriteLine(fruta);
        //}
        frutas.ForEach(Console.WriteLine);

        //apagar todos elementos
        frutas.Clear();

        //trabalhando com dicionario de dados
        Dictionary<int, string> carros = new Dictionary<int, string>();
        //adicionar Ddos a um dicionario
        carros.Add(5, "Corsa");
        carros.Add(10, "Fusca");
        carros.Add(2, "FOrd Ka");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Meu dicionario de Carros ");
        //imprimir um dicionario de dados
        foreach (var carro in carros)
        {
            Console.WriteLine($"{carro.Key} - {carro.Value}");
        }

        Console.WriteLine();
        Console.WriteLine("----------------");

        //trabalhando com fila 
        //criar um fula (Queue) 
        Queue<string> filaBanco = new Queue<string>();

        //adicionando elementos em uma FILA
        filaBanco.Enqueue("André");
        filaBanco.Enqueue("João");
        filaBanco.Enqueue("Maria");
        filaBanco.Enqueue("Bia");

        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        //retirar o primeiro elemento de uma fila
        filaBanco.Dequeue();

        Console.WriteLine();
        Console.WriteLine("===================");
        Console.WriteLine();
        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        //verificar se existe um elemento na fila 

        bool achou = filaBanco.Contains("Bia");

        if (achou)
        {
            Console.WriteLine("A pessoa está na fila");
        }
        else
        {
            Console.WriteLine("A pessoa não está na fila");
        }

        Console.WriteLine();
        Console.WriteLine("===================");
        Console.WriteLine();

        //trabalhando com pilha (STACK)
        //Criando uma pilha 
        Stack<string> livros = new Stack<string>();

        //Adicionar elementos em uma pilha 
        livros.Push("Chapeuzinho Vermelho");
        livros.Push("Branca de Neve");
        livros.Push("Princesa e o Sapo");

        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }
        Console.WriteLine();
        Console.WriteLine("==================");
        Console.WriteLine();

        //remove o primeiro elemento da pilha
        livros.Pop();
        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }

        Console.WriteLine();
        Console.WriteLine("==================");
        Console.WriteLine();
    }
}