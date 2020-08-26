using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Uno.Models.Home
{
    public class Metrica
    {
        public string NamespaceProyect { get; set; }
        public int MetricMaintainabilityIndex { get; set; }
        public int MetricCyclomaticComplexity { get; set; }
        public int MetricClassCoupling { get; set; }
        public int MetricDepthOfInheritance { get; set; }
        public int MetricSourceLines { get; set; }
        public int MetricExecutableLines { get; set; }
        public string NamedTypeClass { get; set; }
        public string MethodName { get; set; }
        public string MethodClass { get; set; }
        public string MethodLine { get; set; }
    }
}
