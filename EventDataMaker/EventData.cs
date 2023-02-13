using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventDataMaker
{
    public class EventData
    {
        [Name("Area de énfasis")]
        public string AreaDeEnfasis { get; set; }
        [Name("Logro del més")]
        public string LogroDelMes { get; set; } = string.Empty;
        public string Acumulado { get; set; } = string.Empty;
    }
}