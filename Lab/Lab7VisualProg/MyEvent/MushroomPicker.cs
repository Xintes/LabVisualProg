namespace MyEvent
{
    public class MushroomPicker
    {
        public string Name { get; private set; }
        public event EventHandler<int> PickMushroomsEvent;
        public event EventHandler LeaveEvent;
        public event EventHandler ComingPicker;

        public MushroomPicker(string name)
        {
            Name = name;
        }

        public void Coming()
        {
            ComingPicker?.Invoke(this, EventArgs.Empty);
        }

        public void PickMushrooms(int pick)
        {
            PickMushroomsEvent?.Invoke(this, pick);
        }

        public void Leave()
        {
            LeaveEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}

//На защиту: порядок работы с событиями. Продемонстрировать на примере ЛР.
//На защиту 2: у поляны добавить событие: выросли грибы. Оповещать всех подписавшихся грибнико
