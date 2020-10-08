using KaedeCore.Objects;
using System.Collections.Generic;
using System.IO;

namespace KaedeCore
{
    public class Kaede
    {
        public List<Locale> Locales = new List<Locale>();
        public string TranslationFilePath;
        public static int Version = 1;
        public Locale FallbackLocale;

        public void SaveTranslationFile()
        {
            if (TranslationFilePath == null) throw new System.Exception("TranslationFilePath not provided!");

            BinaryWriter b = new BinaryWriter(File.Open(TranslationFilePath, FileMode.Create));

            b.Write("KAEDE!".ToCharArray()); // header
            b.Write(Version); // write version
            b.Write(FallbackLocale != null ? FallbackLocale.Id : 0); // write fallback locale id
            b.Write(Locales.Count); // how many locales are in this file?
            foreach(Locale locale in Locales)
            {
                locale.ToBinaryWriter(b);
            }

            b.Close();
        }

        public Locale FindLocale(string LocaleCode)
        {
            foreach(Locale l in Locales)
            {
                if (string.Compare(l.Code, LocaleCode) == 0) return l;
            }

            return null;
        }

        public string GetString(string LocaleCode, string StringName)
        {
            Locale l = FindLocale(LocaleCode);

            if (l == null) return StringName;

            foreach(LocaleString s in l.Strings)
            {
                if (string.Compare(s.Name, StringName) == 0) return s.Value;
            }

            return StringName;
        }

        public int GetStringIndex(string LocaleCode, string StringName)
        {
            Locale l = FindLocale(LocaleCode);

            if (l == null) return -1;

            int i = 0;

            foreach (LocaleString s in l.Strings)
            {
                if (string.Compare(s.Name, StringName) == 0) return i;
                i++;
            }

            return -1;
        }

        public static Kaede FromFile(string Path)
        {
            Kaede instance = new Kaede();

            BinaryReader b = new BinaryReader(File.Open(Path, FileMode.Open));

            if (string.Compare(new string(b.ReadChars(6)), "KAEDE!") != 0) // check for the header
            {
                b.Close();
                throw new System.Exception("Invalid Kaede Translation file!");
            }

            int ver = b.ReadInt32(); // get teh version
            int fbLocaleID = b.ReadInt32(); // get the fall back locale id

            if (ver != Version) // version checks pls
            {
                b.Close();
                throw new System.Exception(string.Format("This Kaede Translation file was designed to be used with v{0}, tho I'm running v{1}.", ver, Version));
            }

            int cntLocales = b.ReadInt32(); // get how many locales are there

            if(cntLocales < 0) // if negative(wtf?)
            {
                b.Close();
                throw new System.Exception("Invalid structure!");
            }

            for(int i = 0; i < cntLocales; i++) // import em.
            {
                Locale l = Locale.FromBinaryReader(b);

                if(l.Id == fbLocaleID && instance.FallbackLocale == null)
                {
                    instance.FallbackLocale = l;
                }

                instance.Locales.Add(l);
            }

            b.Close();
            instance.TranslationFilePath = Path;

            return instance;
        }
    }
}
