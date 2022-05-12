using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExamples
{
    public class Liskov
    {
    }

    public abstract class Duck
    {
        public virtual void Swim()
        {

        }
    }

    public class Pachyanas : Duck
    {

    }

    public class Tadoma : Duck
    {

    }

    public class Toy : Duck
    {
        public bool IsOn { get; set; }

        public override void Swim()
        {
            if (!IsOn)
            {
                throw new InvalidOperationException("The duck needs to be on before swimming");
            }

            base.Swim();
        }
    }

    public class ClientLiskov
    {
        private readonly Duck duck;

        public ClientLiskov(Duck duck)
        {
            this.duck = duck;
        }

        public void DoSomething()
        {
            duck.Swim();
        }
    }
}
