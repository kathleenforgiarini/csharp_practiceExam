using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testtestsection3
{
    internal class ConvertArea
    {
        // private field
        private double metricArea;

        // public property
        public double MetricArea
        {
            get
            {
                return metricArea;
            }
            set
            {
                metricArea = value;
            }
        }

        // default constructor
        public ConvertArea()
        {
            this.MetricArea = 0;
        }
        public double cmToIn()
        {
            return metricArea * 0.1550;
        }

        public double mToYd()
        {
            return metricArea * 1.1960;
        }

        public double haToAcres()
        {
            return metricArea * 2.4711;
        }
        public double kmToMile()
        {
            return metricArea * 0.3861;
        }
    }
}
