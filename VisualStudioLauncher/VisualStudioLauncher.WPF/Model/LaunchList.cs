using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudioLauncher.WPF.Model
{
    public class LaunchList
    {
        
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<LaunchItem> LaunchItems { get; set; }
        public string Description { get; set; }
    }
}
