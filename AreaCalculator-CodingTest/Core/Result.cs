using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator_CodingTest.Core
{
    public class Result
    {
        public string ShapeName { get; set; } = string.Empty;
        public double Area { get; set; }

        public override string ToString()
        {
            return $"{ShapeName.ToLower()} {Area}";
        }
    }
}
