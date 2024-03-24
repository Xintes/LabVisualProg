using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEvent
{
    // Класс, представляющий грибника
    public class MushroomPicker
    {
        public string Name { get; private set; }
        public MushroomPicker(string name)
        {
            Name = name;
        }

    }
}
