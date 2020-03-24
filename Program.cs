using System;

namespace Lesson_num2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            int num = 5;
            Console.WriteLine(str.GetType()); //-->System.String
            Console.WriteLine(num.GetType()); //-->System.Int32

            // ------ Convert from string to number ------- ////

            string threeStr = "3";

            int threeNum = Convert.ToInt32(threeStr);

            double numDouble = Convert.ToDouble("7.6");


            Console.ReadKey();

            // ----- Numeric --------

            // byte - 1 byte in memory 
            byte b = 12;

            // int - 4 byte in memory

            int i = 12;

            // long - 8 byte in memory

            long l = 12;

            // ----- float --------

            double d = 12.44;
            float f = 12.44f;
            decimal dm = 12.44m;


            //castings //
            // ----- המרה מרומזת --------
            //המרה מרומזת תתבצע כאשר נשים משתנה מטיפוס אחד למשתנה מטיפוס אחר//
            //כל עוד אין חשש שנאבד במהלך ההמרה שום מידע //


            // byte to int :
            i = b;
            // byte to long :
            l = b;

            //byte to double:
            d = b;


            // ----- int --------

            // int to float
            f = i;

            //int to double
            d = i;

            //int to long 
            l = i;

            // ----- המרה מפורשת --------
            //המרה מרומזת תתבצע כאשר נשים משתנה מטיפוס אחד למשתנה מטיפוס אחר//
            //יש חשש שנאבד במהלך ההמרה שום מידע //


            //int to byte ;

            b = (byte)i;

            //long to byte : 

            b = (byte)l;

            //long to byte : 

            i = (int)f;


            //String interpolation:
            // interpolation - שרבוב או קריאת ביניים

            string str1 = "Hello";

            Console.WriteLine($"msg is : {str1}"); //--> msg is :hello



            // arrays in c#

            //new is saved word ,that creates an object of array.
            // ---------01 way to create array : -------

            // דרך ראשונה : ע"י ציון מספר התאים שיש לאותו מערך
            // ללא צורך לתת ערכי התאים בשורת האתחול
            int[] arr1 = new int[3];

            arr1[0] = 2;
            arr1[1] = 4;
            arr1[2] = 8;

            // ---------02 way to create array : -------

            // דרך שנייה : ע"י ציון מספר התאים שיש לאותו מערך
            // והשמת ערכי התאים בשורת האתחול 

            int[] arr2 = new int[3] { 2, 4, 8 };

            // ---------03 way to create array : -------

            // דרך שלישית : ע"י השמת ערכי התאים בשורת האתחול
            // ללא צורך בציון מספר התאים שיש לאותו מערך.
            // מספר התאים ייקבע לפי מספר הערכים שניתנו באתחול

            int[] arr3 = new int[] { 2, 4, 8 };


        }
    }
}
