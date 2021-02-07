using System;
using System.Collections.Generic;
using System.Text;

namespace laba_8
{
    interface ICanPutOnMask
    {
        public bool IsHaveMask { get; set; }
    }
    interface IVisitor
    {
        public string Name { get; set; }
    }
    interface ICanDisinfectHands
    {
    }
}
