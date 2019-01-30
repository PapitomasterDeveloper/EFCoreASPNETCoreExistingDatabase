using System;
using System.Collections.Generic;

namespace EFCoreASPNETExistingDatabase.Models
{
    //Entity classes that represent the data you will be querying and saving
    public partial class Post
    {
        public int PostId { get; set; }
        public int BlogId { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
