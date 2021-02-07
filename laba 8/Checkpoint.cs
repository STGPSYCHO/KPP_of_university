using System;
using System.Collections.Generic;
using System.Text;

namespace laba_8
{
    class Checkpoint
    {
        public List<IVisitor> VisitorsWantToISIT = new List<IVisitor>();
        public List<IVisitor> VisitorsCanToISIT = new List<IVisitor>();
        
        public int NumMasks = 10;
        public int NumDesinf = 10;        
        public void Check() 
        {
            Console.WriteLine($"Кол-во масок до пропуска:{NumMasks}");
            Console.WriteLine($"Кол-во антисептика до пропуска:{NumDesinf}");
            Console.WriteLine("Список желающих в ИКИТ:");
            foreach (var i in VisitorsWantToISIT)
            {
                
                if (i is Human)
                {
                    string nameH = ((Human)i).Name;
                    Console.WriteLine(nameH);
                }
                else
                {
                    string nameA = ((Animal)i).Name;
                    Console.WriteLine(nameA);
                }
            }
            foreach (var i in VisitorsWantToISIT) 
            {               
                if (i is ICanPutOnMask && i is ICanDisinfectHands)
                {
                    bool HaveMask = ((ICanPutOnMask)i).IsHaveMask;
                    NumDesinf--;                    
                    VisitorsCanToISIT.Add(i);
                    if (HaveMask == true)
                        continue;
                    NumMasks--;
                }
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Кол-во масок после пропуска:{NumMasks}");
            Console.WriteLine($"Кол-во антисептика после пропуска:{NumDesinf}");
            Console.WriteLine("Те кого пропустили:");
            foreach (var i in VisitorsCanToISIT)
            {
                if (i is Human)
                {
                    string nameH = ((Human)i).Name;
                    Console.WriteLine(nameH);
                }
                else
                {
                    string nameA = ((Animal)i).Name;
                    Console.WriteLine(nameA);
                }               
            }
        }
            
    }
}
