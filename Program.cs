using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smathphone Nokia");
Smartphone nokia = new Nokia(numero:"11999999999", modelo:"Nokia 3210", imei: "123456789", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smathphone Iphone");
Smartphone iphone = new Iphone(numero:"73888888888", modelo:"Iphone X", imei: "987654321", memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");