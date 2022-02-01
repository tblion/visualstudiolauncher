using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudioLauncher.WPF.Model
{
    public class LaunchItem
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Arguments { get; set; }
        [Required]
        public  ProgramItem ProgramItem { get; set; }

        public List<LaunchList> LaunchLists { get; set; }
    }
}
