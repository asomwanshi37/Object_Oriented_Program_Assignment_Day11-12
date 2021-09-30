using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryDataManagementUC2
{
    public class Rice
    {
        public List<TypesOfRice> TypesOfRice;
        public List<TypesOfPulses> TypesOfPulses;
        public List<TypesOfWheats> TypesOfWheats;
    }

    public class TypesOfRice
    {
        public string name;
        public string weight;
        public int Price;
    }

    public class TypesOfPulses
    {
        public string name;
        public string weight;
        public int Price;
    }
    public class TypeofWheats
    {
        public string name;
        public string weight;
        public int Price;
    }
}
