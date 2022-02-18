using System.Text;

namespace Filippenko_CSharp_AQA_TEST_Trainee_
{
    class InputLogic
    {
        public int inputNumber()
        {
            int inputNumber = 0;
            Console.Write("Input number: ");

            if (int.TryParse(Console.ReadLine(), out inputNumber))
            {
                return inputNumber;
            }
            else
            {
                return inputNumber;
            }
        }
        public string inputName()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var enc1251 = Encoding.GetEncoding(1251);
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.InputEncoding = enc1251;

            Console.Write("Input name: ");
            string? InputString = Console.ReadLine();

            if (!string.IsNullOrEmpty(InputString))
            {
                return InputString;
            }
            else
            {
                return String.Empty;
            }
        }
        public Array inputArray()
        {
            int _size = 0;
            int _methodOfArrayInitialization;

            Console.Write("Input Length array: ");

            if (int.TryParse(Console.ReadLine(), out _size))
            {
                Console.WriteLine("1. Input from keyboard");
                Console.WriteLine("2. Fill random numbers between 0 and 100");
                Console.Write("Your choise: ");
                bool succes = int.TryParse(Console.ReadLine(), out _methodOfArrayInitialization);

                if (succes)
                {
                    switch (_methodOfArrayInitialization)
                    {
                        case 1:

                            Array arrayFromKeyboard = Array.CreateInstance(typeof(int), _size);

                            for (int i = 0; i < arrayFromKeyboard.Length; i++)
                            {
                                int numToset = 0;

                                Console.Write($"Element [{i+1}]=> ");

                                if (int.TryParse(Console.ReadLine(), out numToset))
                                {
                                    arrayFromKeyboard.SetValue(numToset, i);
                                }
                                else
                                {
                                    Console.WriteLine("Please enter an integer from the keyboard");
                                    i--;
                                    continue;
                                }
                            }
                            Console.Clear();
                            return arrayFromKeyboard;

                        case 2:

                            var random = new Random();
                            Array arrayRandom = Array.CreateInstance(typeof(int), _size);

                            for (int i = 0; i < arrayRandom.Length; i++)
                            {
                                arrayRandom.SetValue(random.Next(101), i);
                            }

                            return arrayRandom;
                    }
                }
                else
                {
                    Console.WriteLine("Your select is incorrect");
                    return Array.Empty<int>();
                }
            }
            else
            {
                Console.WriteLine("Your input not correct need int number for size array!");
            }
            return Array.Empty<int>();
        }
    }
}
