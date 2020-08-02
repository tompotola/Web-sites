using Piranha.AttributeBuilder;
using Piranha.Models;

namespace cvjetko_sisters.piranha_mvc_sqlite.Models
{
    [PageType(Title = "Standard archive", IsArchive = true)]
    public class StandardArchive : Page<StandardArchive>
    {
        /// <summary>
        /// The currently loaded post archive.
        /// </summary>
        public PostArchive<PostInfo> Archive { get; set; }
    }
}