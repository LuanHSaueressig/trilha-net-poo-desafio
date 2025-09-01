using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "4002", modelo: "Modelo 14", imei: "111111", memoria: 32);
iphone.Ligar();
iphone.InstalarAplicativo("Pinterest");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "8922", modelo: "Modelo 123", imei: "2222222", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");
