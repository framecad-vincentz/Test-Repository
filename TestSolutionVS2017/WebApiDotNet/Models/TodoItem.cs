using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDotNet.Models
{
    public class TodoItem
    {
        public int Key { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
