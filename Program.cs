using DesafioPOO.Models;

Iphone iphone = new Iphone("19 1234-9876", "Iphone Pro Max", "2222222222", 128);
Nokia nokia = new Nokia("19 9876-1234", "Lumia", "1111111111", 64);

Console.WriteLine($"Nokia ligando para: {iphone.Numero}");
nokia.Ligar();

Console.WriteLine($"Iphone recebendo ligação de: {nokia.Numero}");
iphone.ReceberLigacao();


iphone.InstalarAplicativo("WhatsApp");
nokia.InstalarAplicativo("Minecraft");