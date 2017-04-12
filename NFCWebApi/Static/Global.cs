using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NFCWebApi.Static
{
    public class Global {
        private static string[] TagIds = new string[] {
            "04-4A-98-DA-99-3D-80",
            "04-1D-B7-4A-A3-40-80",
            "04-25-BE-4A-A3-40-81",
            "04-84-B0-4A-A3-40-80",
            "04-33-AE-DA-99-3D-80"
        };

        public static IEnumerable<string> Log = new List<string>();

        public static List<Tag> Tags = new List<Tag>();

        public static void FillTags() {
            for(int i = 0; i < TagIds.Length; i++) {
                Tags.Add(new Tag(TagIds[i]));
            }
        }
    }
}
