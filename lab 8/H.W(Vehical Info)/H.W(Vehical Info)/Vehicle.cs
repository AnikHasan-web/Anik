using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace H.W_Vehical_Info_
{
    [Serializable]
    public class Vehicle
    {
        public string Name, Reg;
        //public double Speed;
        public List<double> Speed = new List<double>();
        
        public double GetMaxSpeed()
        {
            double max = Speed.Max();
            return max;
        }
        public double GetMinSpeed()
        {
            double min = Speed.Min();
            return min;
        }
        public double GetAvgSpeed()
        {

            double avg = Speed.Average();
            return avg;
        }
        
    }
}