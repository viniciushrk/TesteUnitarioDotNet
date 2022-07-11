using TesteUnitario;

var adicionarCarro = new AdicionarCarroService();

var result = adicionarCarro.Executar("Unicónio");

//Console.WriteLine(result);
Console.WriteLine("Carro: " + result.Name);

Console.ReadLine();