using System.Xml.Linq;
namespace MyEvent
{
    public delegate void MyEventHandler();

    public class Event
    {
        public event MyEventHandler OnSomeEvent;
        public void SomeEvent() => OnSomeEvent?.Invoke();
        public static void SecondDemo()
        {
            Event evt = new Event();

            // Создание экземпляра поля
            MushroomField field = new MushroomField(10);
            // Создаем экземпляры грибников
            MushroomPicker picker1 = new MushroomPicker("Егор");
            evt.OnSomeEvent += () => field.ComingPicker(picker1);

            MushroomPicker picker2 = new MushroomPicker("Артём");
            evt.OnSomeEvent += () => field.ComingPicker(picker2);

            // Подписываем грибников на событие
            evt.OnSomeEvent += () => field.PickMushrooms(picker1, 4);
            evt.OnSomeEvent += () => field.PickMushrooms(picker2, 10);
           

            // Симулируем событие сбора грибов
            evt.SomeEvent();

            // Обработчик события, вызывается, когда все грибы собраны
            
        }
    }
   
    
}
