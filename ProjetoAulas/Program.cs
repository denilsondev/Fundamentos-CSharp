// See https://aka.ms/new-console-template for more information
using System.Collections;




// int idade = 33;
// System.Console.WriteLine(idade);

// string nomePessoa = "Denilson";
// System.Console.WriteLine(nomePessoa);

// decimal valor = 200.39m;
// System.Console.WriteLine(valor);



// var arrayList = new ArrayList();

// arrayList.Add("aaa");

// arrayList.Add(1);

// arrayList.Add(true);

// foreach(var item in arrayList)
// {
//     System.Console.WriteLine(item);
// }

// var arrayTipadoNumero = new int[3] {1, 2, 3};

// foreach(var item in arrayTipadoNumero)
// {
//     System.Console.WriteLine(item);
// }

// var lista = new List<string>(10);
// lista.Add("w");

// lista.RemoveAt(0);

// var dicionario = new Dictionary<int, string>();

// dicionario.Add(1, "d");

// var nome = dicionario[1];
// System.Console.WriteLine(nome);

var queue = new Queue<string>();
queue.Enqueue("Denilson");
queue.Enqueue("Carvalho");

foreach(var item in queue)
{
    System.Console.WriteLine(item);
}

var stck = new Stack<string>();
stck.Push("Denilson");
stck.Push("Carvalho");

foreach(var item in stck)
{
    System.Console.WriteLine(item);
}