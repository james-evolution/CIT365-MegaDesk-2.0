using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* /* customer full name
size of desk in width (minimum 24 inches and maximum 96 inches)
size of the desk in depth (minimum 12 inches and maximum of 48 inches)
number of drawers ( zero to seven drawers maximum)
desktop surface material (laminate, oak, rosewood, veneer, or pine)
rush order options of 3, 5, or 7 days. The normal production time is 14 days.
*/

/*
 * Naming conventions for C#:
 * Private fields: _lowerCamelCase
 * Public fields: UpperCamelCase
 * Protected fields: UpperCamelCase
 * Property: UpperCamelCase
 * Method: UpperCamelCase
 * Class: UpperCamelCase
 * Interface: IUpperCamelCase
 * Local variable: lowerCamelCase
 * Parameter: lowerCamelCase
 * */
namespace MegaDesk2
{
    class Desk
    {
        // Desk Variable Declarations
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public SurfaceMaterial DeskMaterial { get; set; }

        // Desk Constraints
        public const int MINWIDTH = 24; // 24 inches.
        public const int MAXWIDTH = 96; // 96 inches.
        public const int MINDEPTH = 12; // 12 inches.
        public const int MAXDEPTH = 48; // 48 inches.
        public const int MINDRAWERS = 0;
        public const int MAXDRAWERS = 7;
    }

    enum SurfaceMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    };
}
