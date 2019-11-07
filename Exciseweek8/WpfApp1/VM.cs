using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class VM
    {
        const int COLOR = 0;
        const int COOKMOD = 1;
        const int NAME = 2;
       public BindingList<Egg> Eggs { get; set; } = new BindingList<Egg>();
        public VM()
        {
           string allText= File.ReadAllText("input.txt");
           string[] lines = allText.Split(new char[] { '\n','\r' },StringSplitOptions.RemoveEmptyEntries);

            foreach(string line in lines)
            {
                Egg egg = new Egg();
                string[] element = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                egg.Color = element[COLOR].Trim();
                egg.CookingMode = element[COOKMOD];
                egg.Name = element[NAME].Trim();

            }
        }
    }
}
