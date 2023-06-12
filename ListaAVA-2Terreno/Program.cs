Console.Write("Informe a largura do terreno: ");
double largura = Convert.ToDouble(Console.ReadLine());
Console.Write("Informe o comprimento do terreno: ");
double comprimento = Convert.ToDouble(Console.ReadLine());
Terreno t = new Terreno(largura,comprimento);

Console.WriteLine($"A area do terreno é: {t.Area(largura,comprimento)} metros² ");

Console.WriteLine("\n\nQual o valor do metro² ?");
double metro = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"\nValor do terreno: {t.Valor(metro, largura, comprimento).ToString("C2")}");

Console.ReadKey();