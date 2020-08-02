using Piranha.AttributeBuilder;
using Piranha.Models;

namespace cvjetko_sisters.piranha_razor_sqlite.Models
{
    [PageType(Title = "Standard archive", IsArchive = true)]
    public class StandardArchive : Page<StandardArchive>
    {
    }
}