using ConsoleApp1;

var kontener1 = new KontenerChlodniczy(500,100,500,1000.0,5,Products.Butter);
var kontener2 = new KontenerNaGaz(500,100,500,1000);
var kontener3 = new KontenerNaPlyny(500,100,500,1000);

kontener1.ZaladujKontener(100.0, Products.Butter);
kontener1.Temperature = 25;
kontener1.getInfo();
kontener1.ZaladujKontener(100.0, Products.Butter);
kontener1.getInfo();
kontener1.ZaladujKontener(100.0, Products.Butter);
kontener1.getInfo();
kontener1.OproznijLadunek();
kontener1.getInfo();
