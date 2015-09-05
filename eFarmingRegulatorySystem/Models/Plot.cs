using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eFarmingRegulatorySystem.Models
{
    public class Plot
    {
        [Display(Name = "Plot #")]
        public int PlotNo { get; set; }

        [Display(Name="Total Plot Area")]
        public string PlotArea { get; set; }

        [Display(Name = "Map Picture of Plot")]
        public string PlotMapPicture { get; set; }

        [Display(Name = "Real Picture of Plot")]
        public string PlotActualPicture { get; set; }

        [Display(Name = "Additional Information")]
        public string Comment { get; set; }
    }
}