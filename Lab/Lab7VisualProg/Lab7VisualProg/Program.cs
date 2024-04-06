using System;
using System.Collections.Generic;

namespace MyEvent
{

    class Program
    {
        static void Main()
        {
            MushroomField field = new MushroomField(100);

            MushroomPicker picker1 = new MushroomPicker("Егор");
            MushroomPicker picker2 = new MushroomPicker("Артём");

            field.ComingPicker(picker1);
            field.ComingPicker(picker2);

            picker1.PickMushrooms(50);
            picker2.PickMushrooms(30);
            picker2.PickMushrooms(30);

        }
    }
    

    
}