using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEvent
{
    public class MushroomField
    {
        Random rand = new Random();
        public int Count { get; set; }
        private List<MushroomPicker> pickers = new List<MushroomPicker>(); // Список грибников на поляне

        public MushroomField(int count)
        {
            Count = count;
        }

        public void ComingPicker(MushroomPicker picker)
        {
            Console.WriteLine($"На поляну прибыл грибник {picker.Name}. Грибов на поляне: {Count}");
            pickers.Add(picker);
        }
        public void Leave(MushroomPicker picker)
        {
            Console.WriteLine($"Грибник {picker.Name} ушёл с поляны. На поляне осталось {this.Count} грибов");
            pickers.Remove(picker);
        }
        public void PickMushrooms(MushroomPicker picker, int pick)
        {
            if (pick >= Count)
            {
                Count -= Count;
                Console.WriteLine($"Грибник {picker.Name} собрал все оставшиеся грибы. На поляне осталось {Count} грибов");
                for (int i = pickers.Count - 1; i >= 0; i--)
                {
                    Leave(pickers[i]);
                }

            }
            else if (pick < Count)
            {
                Count -= pick;
                Console.WriteLine($"Грибник {picker.Name} собрал {pick} гриб. На поляне осталось {Count} грибов");
            }
        }
    }
}
