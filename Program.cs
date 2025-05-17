using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
var iphone = new Iphone("24900000000", "Iphone 16", "000000000", 128);
var nokia = new Nokia("24900000000", "Tijolinho", "000000000", 2);

iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");

nokia.ReceberLigacao();
nokia.Ligar();
nokia.InstalarAplicativo("Snake");