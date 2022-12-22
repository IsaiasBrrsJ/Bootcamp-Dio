using DesafioPOO.Models;

Console.Clear();
Console.WriteLine("--------------------\nNokia");
Smartphone nokia = new Nokia(numero: "32142323", modelo: "Mx32r", imei: "123123123", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");
nokia.ReceberLigacao();

Console.WriteLine("--------------------\nIphone");
Smartphone iphone = new Iphone(numero: "321223", modelo: "Iphone 6s", imei: "12111123", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");
iphone.ReceberLigacao();