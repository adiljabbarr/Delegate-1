using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Delegate_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1: Konsola mesaj çap etmək üçün bir Action delegatı yaradın.
            //Action<string> goblin = Bank;
            //goblin("Goblin love you <333");
            #endregion

            #region task2: Bir ədədin kvadratını hesablamak üçün Func delegatı yaradın.
            //Func<int,int> side = SquareArea;
            //Console.WriteLine(side (10));
            #endregion

            #region task3: Bir şərt əsasında ədədlər siyahısını filter etmek üçün Predicate delegatı yaradın, məsələn, yalnız cüt ədədləri goturun.            
            #endregion

             

        }
        static void Bank(string goblin)
        {
            Console.WriteLine(goblin);
        }

        static int SquareArea(int side)
        {
            return side * side;
        }

        


    }
    

}
