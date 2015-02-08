using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspnetmvc_mvaintro.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }

        public string Name { get; set; }

        public List<Album> Albums { get; set; }
    }
}