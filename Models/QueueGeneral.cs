using System;

namespace Sharp.Models
{
    public class Queue<T>
    {
        private const int DEFAULTQUEUESIZE = 100;
        private T[] data = new T[DEFAULTQUEUESIZE];
        // public Queue()
        // {
        //     this.data = new int[DEFAULTQUEUESIZE];
        // }

        public object Length() => data.Length;
    } 
    
}