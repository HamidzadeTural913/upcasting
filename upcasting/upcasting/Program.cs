using System;

namespace upcasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
           MainPrintFile word = new Word();
            word.Print();

            MainPrintFile excel = new Excel();
            excel.Print();
           
            MainPrintFile pdf = new PDF();
            pdf.Print();
        }


        class Word : MainPrintFile
        {
            public override void Print()
            {
                Console.WriteLine("Word fayl elave olundu");
            }
               
                
        }
        class Excel:MainPrintFile
        {
            public override void Print()
            {
                Console.WriteLine("Excel fayl elave olundu");
            }

        }
         
        class PDF : MainPrintFile
        {
            public override void Print()
            {
                Console.WriteLine("PDF fayl elave olundu");
            }

        }

        class MainPrintFile:Iprintable
        {
            public virtual void Print()
            {
         
            }

           
          
        }
    }
}
