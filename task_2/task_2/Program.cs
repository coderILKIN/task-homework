using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Qrupunuzu daxil edin: 2 boyuk heri 3 reqem olmalidir:");
            //string _groupNO = Console.ReadLine();
            //while (!(_groupNO.Length == 5 && char.IsUpper(_groupNO[0]) && char.IsUpper(_groupNO[1]) && char.IsDigit(_groupNO[2]) && char.IsDigit(_groupNO[3]) && char.IsDigit(_groupNO[4])))
            //{
            //    Console.WriteLine("Qrupunuzu daxil edin: 2 boyuk heri 3 reqem olmalidir:");
            //    _groupNO = Console.ReadLine();
            //}

            //Console.WriteLine("Qrupa daxil olan max telebe sayini daxil edin:");

            //int StudentLimit = Convert.ToInt32(Console.ReadLine());

            //while (!(StudentLimit > 0 && StudentLimit < 20))
            //{
            //    Console.WriteLine("Qrupa daxil olan max telebe sayi 0-20 arasidir:");
            //    StudentLimit = Convert.ToInt32(Console.ReadLine());
            //}


            int section;

            do
            {
                Console.WriteLine("1.Telebe elave et");
                Console.WriteLine("2.Bütün telebelere bax");
                Console.WriteLine("3.Telebeler üzre axtarış et");
                Console.WriteLine("0.Proqramı bitir");

                Console.WriteLine("Bir reqem daxil edin:");
                section = Convert.ToInt32(Console.ReadLine());

                if (section==1)
                {
                    Console.WriteLine($"Mualimatlari daxil edin");
                    Console.ReadLine();
                    break;
                }


               
            } while (!(section==0));


        }
    }
}
