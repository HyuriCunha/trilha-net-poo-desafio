using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123245", modelo: "Modelo 1", imei: "121112222111", memoria: 250);
nokia.Ligar();
nokia.InstalarAplicativo("DIO");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "55556666", modelo: "Modelo 2", imei: "555555552222", memoria: 250);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("X");