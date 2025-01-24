using DesafioPOO.Models;
using System;


// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "9999", modelo: "Nokia", imei: "1234", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "9999", modelo: "Iphone", imei: "1234", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
