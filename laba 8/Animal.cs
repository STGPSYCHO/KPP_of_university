using System;
using System.Collections.Generic;
using System.Text;

namespace laba_8
{
    abstract class Animal: IVisitor
    {
        public string Name { get; set; }
    }
    class Dog : Animal, ICanPutOnMask
    {
        public bool IsHaveMask { get; set; }
    }
    class Dove : Animal
    {
    }
    class Squirell : Animal 
    {
    }
}
