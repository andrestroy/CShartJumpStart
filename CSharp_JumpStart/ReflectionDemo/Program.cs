using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BattleGround gameBoard = new BattleGround();
            ListMethods(gameBoard.GetType());
        }

        static void ListMethods(Type t)
        {
            Console.WriteLine("============= Methods ===========");
            MethodInfo[] mi = t.GetMethods();
            foreach (var item in mi)
            {
                Console.WriteLine("->{0}", item.Name);
            }
            Console.WriteLine();
        }
    }
}
