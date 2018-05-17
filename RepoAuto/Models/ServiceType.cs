using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoAuto.Models
{
    public class ServiceType
    {
        public int Id { get; set; }

        [Requiered]
        public string Name { get; set; }
    }
}
