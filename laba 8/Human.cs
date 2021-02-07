using System;
using System.Collections.Generic;
using System.Text;

namespace laba_8
{
    abstract class Human: IVisitor
    {
        public string Name { get; set; }
    }
    class Enrollee : Human, ICanPutOnMask, ICanDisinfectHands
    {
        public bool IsHaveMask { get; set; }        
    }
    class Teacher : Human, ICanPutOnMask, ICanDisinfectHands
    {
        public bool IsHaveMask { get; set; }
    }
    class Student : Human, ICanPutOnMask, ICanDisinfectHands
    {
        public bool IsHaveMask { get; set; }
    }
}
