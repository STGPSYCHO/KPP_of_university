using System;

namespace laba_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher() { IsHaveMask = true , Name = "teacher with mask"};
            Enrollee  enrollee  = new Enrollee () { Name = "enrollee without mask" };
            Student  student  = new Student () { Name = "student without mask" };
            Squirell  squirell  = new Squirell () { Name = "squirel" };
            Dog dog  = new Dog() { IsHaveMask = true, Name = "dog" };
            Dove  dove  = new Dove () { Name = "dove" };



            Checkpoint checkpoint = new Checkpoint();
            checkpoint.VisitorsWantToISIT.Add(teacher);
            checkpoint.VisitorsWantToISIT.Add(enrollee );
            checkpoint.VisitorsWantToISIT.Add(squirell );
            checkpoint.VisitorsWantToISIT.Add(student );
            checkpoint.VisitorsWantToISIT.Add(dog );
            checkpoint.VisitorsWantToISIT.Add(dove );

            checkpoint.Check();

        }
    }
}
