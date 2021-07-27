using System;
using System.Reflection;

    /// <summary>
    /// Learning the GetType() method
    /// </summary>
    class Obj
    {
        /// <summary>
        /// Returns the methods and properties of the object
        /// </summary>
        public static void Print(object myObj)
        {
            Console.WriteLine("{0} Properties:", myObj.GetType().Name);
            foreach (PropertyInfo x in myObj.GetType().GetProperties())
            {
                Console.WriteLine(x.Name);
            }
            Console.WriteLine("{0} Methods:", myObj.GetType().Name);
            foreach (MethodInfo x in myObj.GetType().GetMethods())
            {
                Console.WriteLine(x.Name);
            }
        }
    }
