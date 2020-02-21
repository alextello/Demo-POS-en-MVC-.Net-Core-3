using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VentaPieMVC.Models;

namespace VentaPieMVC.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}
