using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song_Lyric_Application
{
    public class Song
    {
        // Properties that will store data from Song csv
        public int Id { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
    }

    public class Lyrics
    {
        public int Id {get; set;}
        public string Result { get; set; }
    }
}
