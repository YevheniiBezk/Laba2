using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class Computer
    {
    
    public string Brand;
        public string Model;
        public string Processor;
        public int RAM;
        public int Storage;
        public double Price;
        public bool HasDedicatedGPU;
        public bool HasTouchscreen;
        public int NumberOfCores;

        public double GetPricePerGB()
        {
            return Price / (RAM + Storage);
        }
        public double GetPricePerCore()
        {
            return Price / NumberOfCores;
        }
        public double PricePerCore
        {
            get
            {
                return GetPricePerCore();
            }
        }
    }
} 


