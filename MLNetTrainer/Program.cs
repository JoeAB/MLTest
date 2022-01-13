using System;
using MLNetTestCore; 

namespace MLNetTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            MLNetTestCore.ModelCreator.Run(args[0]);
        }
    }
}
