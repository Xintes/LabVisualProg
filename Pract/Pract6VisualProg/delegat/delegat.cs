namespace VP_Pract6
{
    public class Delegates
    {
        public static void DelegAction(Action<Func<bool>, double, double> actionDelegate)
        {
            double num = 1241241.2222222;
            double weight = 66.6;
            bool flag = true;
            actionDelegate(() => true, num, weight);
        }

        public static bool DelegFunc<T>(Func<Action<T>, float, float> funcDelegate, T obj)
        {
            float result = funcDelegate(action => Console.WriteLine($"Вызываем  {action}"), 1.23f);
            Console.WriteLine($"Результат: {result}");
            return true;
        }
    }
}


