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
            BattleGround gameBoard = new BattleGround() { Name = "WarI" };

            var board = Activator.CreateInstance(typeof(BattleGround));
            ListMethods(gameBoard.GetType());
            GetPropertyValue(gameBoard);
            RunMethod(gameBoard, "Init");
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

        static void GetPropertyValue(Object obj)
        {
            Type t = obj.GetType();
            var property = t.GetProperty("Name");
            var val = property.GetValue(obj);
            Console.WriteLine("Property Val : {0}", val);
        }

        static void RunMethod(Object obj, string methodName)
        {
            Type t = obj.GetType();
            var method = t.GetMethod(methodName);
            method.Invoke(obj, new Object []{});
        }
    }
}
