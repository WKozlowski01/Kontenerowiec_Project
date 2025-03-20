using ConsoleApp1;

var kontener1 = new KontenerChlodniczy(500,100,500,1000.0,30,Products.Butter);
var kontener2 = new KontenerNaGaz(500,100,500,1000);
var kontener3 = new KontenerNaPlyny(500,100,500,1000);
var ship1 = new Ship(100, 15, 10);

kontener1.ZaladujKontener(100.0, Products.Butter);
kontener1.Temperature = 25;
Console.WriteLine("Waga samego kontenera to: "+kontener1.Waga);
kontener1.getInfo();
kontener1.ZaladujKontener(100.0, Products.Butter);
kontener1.getInfo();
kontener1.ZaladujKontener(100.0, Products.Butter);
kontener1.getInfo();


ship1.loadConteners(kontener1);

ship1.getInfo();

kontener2.getInfo();


