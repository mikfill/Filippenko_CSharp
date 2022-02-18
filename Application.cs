namespace Filippenko_CSharp_AQA_TEST_Trainee_
{
    class Application
    {
        delegate void method();
        public void ShowMenu()
        {
            string[] items = {  "1. Input int number if is greater than 7, then print \"Hello\"",
                                "2. Input string if name matches Vyacheslav, then display \"Hi, Vyacheslav\", else \"No such name\"",
                                "3. Input int array with the custom size, if element of arr is divide by 3 print his index and value",
                                "Exit" };

            method[] methods = new method[] { Method1, Method2, Method3, Exit };
            ConsoleMenu menu = new ConsoleMenu(items);
            
            int menuResult;
            do
            {
                menuResult = menu.PrintMenu();
                methods[menuResult]();
                Console.WriteLine("Press any button to continue");
                Console.ReadKey();
            } while (menuResult != items.Length - 1);
        }

        static void Method1()
        {
            InputLogic inputLogic = new InputLogic();
            int number = inputLogic.InputNumber();

            if (number != 0)
            {
                _ = new Algorithms(number);
            }
            else
            {
                Console.WriteLine("Incorect input");
            }
        }
        static void Method2()
        {
            InputLogic inputLogic = new InputLogic();
            string name = inputLogic.InputName();

            if (!string.IsNullOrEmpty(name))
            {
                _ = new Algorithms(name);
            }
            else
            {
                Console.WriteLine("Input is null or empty");
            }
        }
        static void Method3()
        {
            InputLogic inputLogic = new InputLogic();
            Array array = inputLogic.InputArray();

            if (array.Length != 0)
            {
                _ = new Algorithms(array);
            }
            else
            {
                Console.WriteLine("Incorect input");
            }
        }
        static void Exit()
        {
            Console.WriteLine("Application completed!");
        }
    }
}
