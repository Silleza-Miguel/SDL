using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp4.Views.RoomNav;

namespace WpfApp4.Models
{
    public static class FloorAssign
    {
        public static Dictionary<string, UserControl> myDictionary = new Dictionary<string, UserControl>() 
        {
            {"Resources\\OZfloor\\OZ1.jpg", new OZFloor1() },
            {"Resources\\OZfloor\\OZ2.jpg", new OZFloor2() },
            {"Resources\\OZfloor\\OZ3.jpg", new OZFloor3() },
            {"Resources\\OZfloor\\OZ4.jpg", new OZFloor4() },

            {"Resources\\STfloor\\ST1.jpg", new STFloor1() },
            {"Resources\\STfloor\\ST2.jpg", new STFloor2() },
            {"Resources\\STfloor\\ST3.jpg", new STFloor3() },
            {"Resources\\STfloor\\ST4.jpg", new STFloor4() },

            {"Resources\\CTfloor\\CTGF.jpg", new CTFloor1() },
            {"Resources\\CTfloor\\CT2.jpg", new CTFloor2() },
            {"Resources\\CTfloor\\CT3.jpg", new CTFloor3() },
            {"Resources\\CTfloor\\CT4.jpg", new CTFloor4() },
            {"Resources\\CTfloor\\CT5.jpg", new CTFloor5() },
            {"Resources\\CTfloor\\CT6.jpg", new CTFloor6() },
            {"Resources\\CTfloor\\CT7.jpg", new CTFloor7() },
            {"Resources\\CTfloor\\CT8.jpg", new CTFloor8() },

        };
    }
}
