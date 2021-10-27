using EFExample.Data_Model;
using System;
using System.Collections.Generic;

namespace EFExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using Context myContext = new Context();

            /*myContext.Class.Add(new Class()
            {
                Name = "EnglishClass",
                MaxClassSize = 25,
                ClassLanguage = Enums.Language.English,
                

            });

            myContext.Class.Add(new Class()
            {
                Name = "FrenchClass",
                MaxClassSize = 30,
                ClassLanguage = Enums.Language.French

            });*/




            myContext.Student.Add(new Student()
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


            });


            myContext.SaveChanges();
        }
    }
}
