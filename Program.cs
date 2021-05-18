using System;
using System.IO;


namespace day13_oop_interfaces_files
{


    interface IZveers
    {
        void saka();
        //int garums(); 
    }


    interface IKazhoks
    {
        void kraasa();
        //int garums(); 
    }




    class Laacis : IZveers, IKazhoks
    {
        public void saka()
        {
            Console.WriteLine("GRRRRRRRR");
        }

        public void kraasa()
        {
            Console.WriteLine("Laacha Kraasa");
        }

    }


    class Vilks : IZveers
    {
        public void saka()
        {
            Console.WriteLine("AUUUUUUU");
        }
    }



    //secīgs skaitļu masīvs ar nosaukumiem !

    enum NedDienas
    {
        Pirmdiena,  //int vertiba 0
        Otrdiena,   //int vertiba 1; 
        Treshdiena = 10, //int vertiba 2; => 11
        Ceturtdiena = 5,//int vertiba 3; => 12
        Piektdiena = 68 , //int vertiba 4; => 13
        Sestdiena = 95,  //int vertiba 5; => 14
        Svetdiena = 13   //int vertiba 6; => 15
    }



    //dienas
    //int[] mas1 ... 

    //datumi
    //int[] mas2 ... 

    //nedeljas
    //int[] mas3 ... 





    class Program
    {




        static void Main(string[] args)
        {

            //IZveers zv = new IZveers();
            Vilks v = new Vilks();
            v.saka();


            Laacis l = new Laacis();
            l.saka();
            l.kraasa();




            NedDienas diena = NedDienas.Pirmdiena;


            




            if (diena == NedDienas.Pirmdiena)
            {
                //kautko dariit

                Console.WriteLine(diena);
                Console.WriteLine((int)diena);
            }


            switch (diena)
            {
                case NedDienas.Pirmdiena: int r = 6;
                    string str = NedDienas.Pirmdiena.ToString();

                    break;
                    //....
            }



            //izrunājiet 5x enumerators

            //uztasiet man enumeratoru, vienalga kāda izmēra - jēgpilnu !


            string teksts = "teksts";

                            //"c:\ceļš\faila_vārds.txt", "teksts"
            File.WriteAllText("fails.txt", teksts);




            //uztaisiet trīs dažādas Jūsu enum instances.
            //izrakstiet šo instanču vērtības failā.



            //kas šeit pietrūkst - pirms nolasīšanas ? tā nav kļūda, bet nepareizs dizains !


            //nolasīsim datus no faila
            //jāpārbauda vai fails eksistē

            if (File.Exists("fails.txt"))
            Console.WriteLine("TEKSTS NO FAILA :" + File.ReadAllText("fails.txt"));



            //Piemērs, kas man nepatīk !
            //1. izveidot sarakstu ar dzēšamajiem failiem

            //...neneoteikti ilgs laiks 

            //2. dzēst failus sarakstā

            //ja ir saraksts ar failiem, kurus dzēst


            //1
            //uztaisa faila kopiju - ar citu nosaukumu
            //File.Copy("oriģināls.txt", "kopija.txt")

            //2.
            //izdzēš oriģinālu.
            //File.Delete("oriģināls.txt")



            //3. izvadīt mapes saturu uz ekrāna ; //string[] faili = Directory.GetFiles("mape");
            //4. Saglabāt šo mapes saturu citā failā



            //Directory.GetCurrentDirectory //=>
            //Directory.Exists




            //File.AppendAllText


            

            string[] faili = Directory.GetFiles(Directory.GetCurrentDirectory());

            string rez = "";


            foreach (string fails in faili)
            {
                rez += fails + "\n";
            }


            Console.WriteLine(rez);

            //saglabā visu failu datus

            File.WriteAllText("mapes-saturs.txt", rez);



        }
    }
}


