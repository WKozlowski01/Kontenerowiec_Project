namespace ConsoleApp1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var kontener1 = new KontenerChlodniczy(200, 100, 500, 3000.0, 20, Products.Banana);
            var kontener2 = new KontenerNaGaz(200, 100, 400, 2000);
            var kontener3 = new KontenerNaPlyny(300, 100, 300, 1000);
            var kontener4 = new KontenerNaPlyny(300, 100, 300, 1000);
            var kontener5 = new KontenerNaGaz(300, 100, 300, 1000);
            var kontener6 = new KontenerChlodniczy(300, 100, 300, 1000,15,Products.Banana);
            var kontener7 = new KontenerNaPlyny(300, 100, 300, 1000);
            var kontener8 = new KontenerNaPlyny(300, 100, 300, 2000);
            
            var ship1 = new Ship(10, 15, 10);
            var ship2 = new Ship(20, 10, 7);

           kontener1.ZaladujKontener(1000,Products.Banana);
           kontener1.ZaladujKontener(1000, Products.Butter);
           
           kontener1.getInfo();
           
           kontener2.ZaladujKontener(1500);
           kontener2.getInfo();
           kontener2.OproznijLadunek();
           kontener2.getInfo();
           
           kontener3.ZaladujKontener(600,true);
           kontener4.ZaladujKontener(950,false);
           kontener3.getInfo();
           kontener4.getInfo();
           
           List<Contener> Conteners = new List<Contener>();
           Conteners.Add(kontener4);
           Conteners.Add(kontener5);
           Conteners.Add(kontener6);
           
           ship1.loadConteners(Conteners);
           ship2.loadConteners(kontener2);
           
           ship1.getInfo();
           ship1.getContenerInfo();
           
           Console.WriteLine();
           
           ship2.getInfo();
           ship2.getContenerInfo();
           
           moveContener(ship1,ship2,kontener4);
           moveContener(ship1,ship2,kontener2);
           
           ship1.getContenerInfo();
           ship2.getContenerInfo();
           
           kontener7.ZaladujKontener(700,false);
           ship1.loadConteners(kontener7);
           ship1.getContenerInfo();
           
           replaceContener(ship1,kontener7.getId(),kontener8);
           ship1.getContenerInfo();
        }

        private static void moveContener(Ship shipA, Ship shipB,Contener contener) {
            if(shipA.Conteners.Contains(contener)) {
                shipA.removeContener(contener);
                shipB.loadConteners(contener);
            }
            else
            {
                Console.WriteLine("Statek nie zawiera takiego kontenera!\n");
            }

        }

        public static void replaceContener(Ship ship, string numerSeryjny, Contener contener)
        {
            foreach (var c in ship.Conteners)
            {
                string name = c.getId();
                if (name== numerSeryjny)
                {
                    ship.removeContener(c);
                    ship.loadConteners(contener);
                    break;
                }
            }
            
        }

    }

}
