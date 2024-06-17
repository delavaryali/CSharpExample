using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class IndexInitializers
{
    enum USState { California, NorthDakota }

    public void run()
    {

        //Collection Initializer
        var AreaCodeUSState = new Dictionary<string, USState>
        {
            {"408", USState.California},
            {"701", USState.NorthDakota}
        };

        //Index Initializer
        var AreaCodeUSState2 = new Dictionary<string, USState>
        {
            ["408"] = USState.California,
            ["701"] = USState.NorthDakota,
        };


    }
}

