using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.Domain.Entities
{
    public class Author : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        public double Rating { get; set; }
    }
}
