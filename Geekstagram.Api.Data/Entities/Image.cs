using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geekstagram.Api.Data.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }

    }
}
