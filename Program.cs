using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Iphone: ");
Iphone i = new Iphone("45678", "15 pro MAX", "45454545", 128);
i.Ligar();
i.ReceberLigacao();
i.InstalarAplicativo("Minecraft");

Console.WriteLine("\n");

Console.WriteLine("Nokia: ");
Nokia n = new Nokia("12345", "5I", "2134567", 64);
i.Ligar();
i.ReceberLigacao();
i.InstalarAplicativo("Roblox");