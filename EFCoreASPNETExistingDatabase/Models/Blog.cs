using System;
using System.Collections.Generic;

namespace EFCoreASPNETExistingDatabase.Models
{
    //Entity classes that represent the data you will be querying and saving
    public partial class Blog
    {
        public Blog()
        {
            Post = new HashSet<Post>();
        }

        public int BlogId { get; set; }
        public string Url { get; set; }

        public virtual ICollection<Post> Post { get; set; }
    }
}
