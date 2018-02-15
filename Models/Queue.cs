using System;

namespace Sharp.Models
{
    public class Queue
    {
        private const int DEFAULTQUEUESIZE = 100;
        private int[] data = new int[DEFAULTQUEUESIZE];
        // public Queue()
        // {
        //     this.data = new int[DEFAULTQUEUESIZE];
        // }

        public object Length() => data.Length;
    } 
    
}