using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class AboutViewModel
    {
        public List<Student> Students { get; set; }
        public List<Group> Groups { get; set; }
    }
}
