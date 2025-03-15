string cebola;
Console.Clear();
Console.Write("Escreva sua frase bacana e top :");
cebola = Console.ReadLine()!
.Replace("r","l")
.Replace("R","L");

Console.WriteLine($"Cebolinha responde : {cebola}");

