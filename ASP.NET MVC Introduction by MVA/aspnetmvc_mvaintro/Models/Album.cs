using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aspnetmvc_mvaintro.Models
{
    public class Album
    {
        public int AlbumId { get; set; }

        public string Title { get; set; }

        public Artist Artist { get; set; }

        // It allows the Entity Framework to create a proxy 
        // around the virtual property so that the property can support lazy loading and more efficient change tracking.
        public virtual List<Review> Review { get; set; }
    }
}
