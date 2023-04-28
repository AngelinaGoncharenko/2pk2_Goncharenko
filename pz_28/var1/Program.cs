using System;
using System.Diagnostics.Metrics;

public delegate void Delegate();

namespace pz_28.var1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter b = new Counter(1);
            b.Numbers();
        }
    }
}