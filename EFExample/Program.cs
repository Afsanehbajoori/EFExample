using EFExample.Data_Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using Context myContext = new Context();



            /* myContext.Student.Add(new Student()
             {
                 StudentName = "Allan",
                 StudentAge = 20,
                 ClassList=new List<Class>()
                 {
                     new Class()
                     {
                         Name="EnglishClass",
                         MaxClassSize=25,
                         ClassLanguage=Enums.Language.English
                     },

                     new Class()
                     {
                         Name = "FrenchClass",
                         MaxClassSize = 30,
                         ClassLanguage = Enums.Language.French
                     }
                 }


                 });

             myContext.Student.Add(new Student()
             {
                 StudentName = "Adrian",
                 StudentAge = 18,
                 ClassList = new List<Class>()
                 {
                     new Class()
                     {
                         Name="SpanishClass",
                         MaxClassSize=30,
                         ClassLanguage=Enums.Language.Spanish
                     },

                     new Class()
                     {
                         Name = "RussianClass",
                         MaxClassSize = 20,
                         ClassLanguage = Enums.Language.Russian
                     },

                     new Class()
                     {
                         Name="EnglishClass",
                         MaxClassSize=25,
                         ClassLanguage=Enums.Language.English
                     }
                 }


             });*/

            /* var myClass = myContext.Class.FirstOrDefault(x => x.MaxClassSize > 20);
             myClass.Name = "change Name";
             myClass.MaxClassSize = 50;*/

            //vi kunne ikke slette en student, da er en FK studentId i Class table.
            /*var myDelete = myContext.Student.FirstOrDefault(x => x.StudentId == 2);
            myContext.Remove(myDelete);*/

            //var myClassDelete = myContext.Class.FirstOrDefault(x => x.Name == "RussianClass");
            //myContext.Remove(myClassDelete);

            /*var NameUpdate = myContext.Student.FirstOrDefault(x => x.StudentId == 2);
            NameUpdate.StudentName = "Anna";
            myContext.Update<Student>(NameUpdate);*/

            var studentAdd = new Student()
            {
                StudentName = "Bill",
                StudentAge = 21,
                ClassList = new List<Class>()
                {
                    new Class()
                    {
                        Name="FrenchClass",
                        MaxClassSize=30,
                        ClassLanguage=Enums.Language.French
                    }
                }

            };
            myContext.Student.Add(studentAdd);
           
            

            

            myContext.SaveChanges();
        }
    }
}
