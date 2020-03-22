using System;

namespace Events
{

    delegate void tratareEveniment();

    class Eveniment
    {
        //declaram evenimentul
        public event tratareEveniment activat;
        
        //metoda apelata la lansarea evenimentului
        public void Actiune()
        {
            if (activat != null)
            {
                //lansam evenimentul
                activat();
            }
        }
    }

    class Program
    {
        //rutina de tratare
        static void handler()
        {
            Console.WriteLine("Eveniment produs");
        }

        static void Main(string[] args)
        {
            Eveniment ev = new Eveniment();
            Test a = new Test();

            //adaugam rutinele de tratare la lisa de evenimente

            ev.activat += new tratareEveniment(handler);
            ev.activat += new tratareEveniment(a.AHandler);

            ev.Actiune();

        }
    }
}
