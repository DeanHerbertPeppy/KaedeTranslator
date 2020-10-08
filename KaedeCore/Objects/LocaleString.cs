using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace KaedeCore.Objects
{
    public class LocaleString
    {
        public string Name;
        public string Value;

        public void ToBinaryWriter(BinaryWriter b)
        {
            b.Write(Name); // write the fuckin name
            b.Write(Value); // write the fuckin value.
            // done ez.
        }

        public static LocaleString FromBinaryReader(BinaryReader b)
        {
            return new LocaleString()
            {
                Name = b.ReadString(),
                Value = b.ReadString()
            };
        }
    }
}
