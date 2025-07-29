using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "2660 Flip", iMEI: "111111111111", memoria: 64);
nokia.ApresentarModelo();
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "654321", modelo: "Iphone 15", iMEI: "222222222", memoria: 128);
iphone.ApresentarModelo();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

// TODO: Realizar os testes com as classes Nokia e Iphone