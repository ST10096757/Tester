using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Class1
    {
        private void ArrayMethod()
        {
            var myArray = new int[5];

            int[] myArray2 = new[] { 1, 2, 3, 4, 5};

            Array.Clear(myArray, 0, myArray.Length);
            //I blacked out. I have no idea what this does.

            //Capital Array is a class
            //the other is a value/reference type thingy
            //I'm killing it with these notes.

            var myTypeArray = new StudentClass[5];//this references code that I have not typed yet
            //this "<>" is generic
            //...which means something
            //that I forgot
            //But I think it could potentially be important.

            var st.StudentClass = myTypeArray[0].StudentClass;
            //can access objects in like, a class thing.
            //like accessing "student name" from the class "student class"

            foreach(StudentClass studentObject in myTypeArray)
            {
                studentObject.StudentName;
            }

            //we declared a student class
            //then we make objects
            //then we make an array to store the class, then that make the array 
            //- populate it with the objects
        }
    }
}
