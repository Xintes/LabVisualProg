using System.Xml.Linq;
namespace MyEvent
{
    public class MushroomField
    {
        public int Count { get; set; }
        private List<MushroomPicker> pickers = new List<MushroomPicker>(); // Список грибников на поляне

        public MushroomField(int count)
        {
            Count = count;
        }
        private void ComingPickerHandler(object sender, EventArgs e)
        {
            MushroomPicker picker = (MushroomPicker)sender;
            ComingPicker(picker);
        }
        
        public void ComingPicker(MushroomPicker picker)
        {
            Console.WriteLine($"На поляну прибыл грибник {picker.Name}. Грибов на поляне: {Count}");
            pickers.Add(picker);
            picker.PickMushroomsEvent += PickMushroomsHandler;
            picker.LeaveEvent += LeaveHandler;
        }
        private void LeaveHandler(object sender, EventArgs e)
        {
            MushroomPicker picker = (MushroomPicker)sender;
            Leave(picker);
        }

        public void Leave(MushroomPicker picker)
        {
            Console.WriteLine($"Грибник {picker.Name} ушёл с поляны. На поляне осталось {Count} грибов");
            pickers.Remove(picker);
            picker.PickMushroomsEvent -= PickMushroomsHandler;
            picker.LeaveEvent -= LeaveHandler;
        }

        private void PickMushroomsHandler(object sender, int pick)
        {
            MushroomPicker picker = (MushroomPicker)sender;
            if (pick >= Count)
            {
                Count = 0;
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

//На защиту: порядок работы с событиями. Продемонстрировать на примере ЛР.+++
//На защиту 2: у поляны добавить событие: выросли грибы. Оповещать всех подписавшихся грибнико
