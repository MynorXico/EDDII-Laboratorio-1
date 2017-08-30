using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1_MynorXico
{
    public class Song
    {
        public string Name { get; set; }
        public double Length { get; set; }
        // In case the song has to be playable.
        public string Path { get; set; }
        // public string Artist { get; set; }
        public Song(string Name, double Length, string Path)
        {
            this.Name = Name;
            this.Length = Length;
            this.Path = Path;
        }
    }
}
