using System;

namespace Sharp.Models
{
    public class Employee
    {
        int _id;

        public Employee(int x)
        {
            Id = x;
        }

        public int Id
        {
            get{return this._id;}
            set{this._id = value < 10 && value > 0 ? value : 0;}
        }
    } 
    
}