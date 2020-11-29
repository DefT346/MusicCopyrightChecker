using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCE
{
    public static class MusicChecker
    {
        public static Composition GetCompositionData(string path, int sec = 5)
        {
           
            //AudioController.TrimAndWrite(path, sec);
            var json = Requests.AudD(path);
            var parsedJson = JsonHelper.FormatJson(json);
            var comp = new Composition(JObject.Parse(parsedJson));
            Console.WriteLine(comp);
            return comp;
        }

    }
}
