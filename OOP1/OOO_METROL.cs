using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    abstract class OOO_METROL: Object
    {
        public uint workers = 70;
        public uint director = 1;
        public uint machine_tool = 8;
        public uint track = 2;

        public Boolean Create_a_device(Object unit)
        {
            return true;
        }
        public string Create()
        {
            return "создание нового устройства";
        }

    }
}
