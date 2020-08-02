using Piranha.AttributeBuilder;
using Piranha.Models;

namespace cvjetko_sisters.piranha_razor_sqlite.Models
{
    [PostType(Title = "Standard post")]
    public class StandardPost  : Post<StandardPost>
    {
    }
}