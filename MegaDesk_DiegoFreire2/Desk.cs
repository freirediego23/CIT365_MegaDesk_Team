using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MegaDesk_DiegoFreire2
{

    enum DesktopMaterial { Oak, Laminate, Pine, Rosewood, Veneer }

    

    //List<DesktopMaterial> matdfdf = new List<DesktopMaterial>();

   

    class Desk
    {

        public List<DesktopMaterial> materialsDesk = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();

        

        //public int Width { get; set; }

        //Desk Constraints
        public const int MinWidth = 24;
        public const int MaxWidth = 96;
        public const int MinDepth = 12;
        public const int MaxDepth = 48;
    }
}
