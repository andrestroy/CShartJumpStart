using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexTypes
{
    enum Dogs { Lassie, Snoopy, Yeller}
    public struct Cat  
    {
        public string Name { get; set; }
    }

    public class Trainer
    {
        public void Operate()
        {
            Dog dog = new Dog();
            dog.HasSpoken += dog_HasSpoken;
        }

        void dog_HasSpoken(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
    public partial class Dog
    {
        public event EventHandler HasSpoken;

        public void Speak(string what = "bark")
        {
            // TODO
            if (HasSpoken != null)
            {
                HasSpoken(this, EventArgs.Empty);
            }
        }

        public void MakeFunnySound(int times, bool highest = false, string sound = "warf")
        {
            // TODO
            for (int i = 0, j = 0; i < 10; i++, j++)
            {
                
            }

        }
    }
}
