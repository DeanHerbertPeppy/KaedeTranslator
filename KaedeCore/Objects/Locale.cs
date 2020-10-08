using System;
using System.Collections.Generic;
using System.IO;

namespace KaedeCore.Objects
{
    public class Locale
    {
        public int Id;
        public string Code;
        public string LocalisedName;
        public List<LocaleString> Strings = new List<LocaleString>();

        public void ToBinaryWriter(BinaryWriter b)
        {
            b.Write(Id); // locale id
            b.Write(Code); // locale code
            b.Write(LocalisedName); // locale localised name
            b.Write(Strings.Count); // how many strings are there?

            foreach(LocaleString s in Strings)
            {
                s.ToBinaryWriter(b);
            }
        }

        public static Locale FromBinaryReader(BinaryReader b)
        {
            Locale l = new Locale();

            l.Id = b.ReadInt32();
            l.Code = b.ReadString();
            l.LocalisedName = b.ReadString();

            int strCnt = b.ReadInt32();
            if(strCnt < 0)
            {
                throw new Exception("Invalid string count!");
            }

            for(int i = 0; i < strCnt; i++)
            {
                l.Strings.Add(LocaleString.FromBinaryReader(b));
            }

            return l;
        }
    }
}
