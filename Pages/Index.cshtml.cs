using System;
using System.Text;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Sharp.Models;
using Sharp.Services;

namespace Sharp.Pages
{


    public class IndexModel : PageModel
    {
        public int[] q;
        enum Season : byte { Spring, Summer, Fall, Autumn = Fall, Winter };
        enum Month : byte
        {
            January, February, March, April,
            May, June, July, August,
            September, October, November, December
        };

        struct Date
        {
            private int year;
            private Month month;
            private int day;
            public Date(int ccyy, Month mm, int dd)
            {
                this.year = ccyy - 1900;
                this.month = mm;
                this.day = dd - 1;
            }
            public override string ToString()
            {
                return $"{this.month} {this.day + 1} {this.year + 1900}";
            }
        }

        Date[] dar = { new Date(), new Date() };

        public void ArrMethod(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]++;
            }
        }

        public string ArrList(int[] arr)
        {
            string outString = string.Empty;
            foreach (int item in arr)
            {
                outString += item + "; ";
            }
            return outString;
        }

        class Mammal
        {

        }

        class Horse: Mammal
        {
            public override string ToString()
            {
                return "OK";
            }
            
        }
        class Whale: Mammal
        {
            
        }
        enum EmpType: byte
        {
            Manager = 10,
            Grunt = 1,
            Contractor = 100, 
            VicePresident = 99
        }
        public void OnGet()
        {
            EmpType emp = EmpType.Manager;
            string str1 = "Flip";
            string str2 = "Flop";

            void Swap(ref string s1, ref string s2)
            {
                string temp = s1;
                s1 = s2;
                s2 = temp;
            }
            Array enumData = Enum.GetValues(emp.GetType());
            Swap(ref str1, ref str2);

            q = new int[50];

            DrawClass dc = new DrawClass();
            if (dc is IDraw)
            {
                IDraw idr = dc;
                idr.Meth();
            }
            Horse myHorse = new Horse();
            Mammal myMammal = myHorse;
            Horse myHorseAgain = myMammal as Horse;
            Whale myWhale = new Whale();
            myMammal = myWhale;
            myHorseAgain = myMammal as Horse;

            var names = new[] { new { Name = "John" }, new { Name = "Tilda" } };
            int[] intArr = { 1, 5, 9, 45, 6 };
            ArrMethod(intArr);
            int[] newArr = new int[1];
            Array.Copy(intArr, newArr, newArr.Length);
            // intArr.CopyTo(newArr, 0);
            // Season cold = Season.Winter;
            Month last = Month.December;
            last++;

            int? i = null;

            if (i.HasValue)
            {
                int? k = i.Value;
            }

            Point origin = new Point();
            Point bottomRight = new Point(1366, 768);
            double distance = origin.DistanceTo(bottomRight);
            var myAnonymousObject = new { Name = "John", Age = 47 };

            var d = new Date(1985, Month.December, 5);
            // Date defaultDay = new  Date();
            DateTime dt = new DateTime(1985, 5, 16);
            StringBuilder sb = new StringBuilder("*****OPa*****");
            ViewData["Message"] = $"{emp}";
        }

    }
}