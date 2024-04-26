using DesafioPOO.Models;

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia("99999-9999", "NokiaG", "1111111111", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Navegador");

Console.WriteLine();

Console.WriteLine("IPhone:");
Smartphone iphone = new Iphone("88888-8888", "99Plus", "2222222222", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Jogo");
