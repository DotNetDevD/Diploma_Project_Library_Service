using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAggregator.DataLayer.Entities
{
    public class Country
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int LibraryId { get; set; }
        [ForeignKey("LibraryId")]
        public virtual Library? Library { get; set; }
    }
}
