using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("SmartPhone Nokia: ");
Smartphone nokia = new Nokia("998562789", "Nokia Tijolo", "15555555", 2);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WormGame");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone Iphone: ");
Smartphone iphone = new Iphone("97548723", "Iphone 12", "17777777", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");