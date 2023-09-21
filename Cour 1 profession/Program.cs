// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//1) demander le nom de l'utilisateur et l'accueilir
//ex : bienvenue Nathan à l'application MonOutil
Console.WriteLine("Quel est votre nom ?");

 string line = Console.ReadLine();

Console.WriteLine($"Bienvenue { line} à l'appliction !");

//2) deamnder l'utilisateur d'entrer une témpérature en Celsius
// convertir la température en Farenheit et mettrele résultat
// dans la console


Console.WriteLine("entrez une température en celsius ?");
double celsius = Convert.ToDouble(Console.ReadLine());
double farenheit = celsius * 9/5 + 32;
Console.WriteLine("The temperature is " + farenheit + " Farenheint.");

