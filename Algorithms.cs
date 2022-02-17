namespace Filippenko_CSharp_AQA_TEST_Trainee_
{
    public class Algorithms
    {
        private int _num;
        private string _name;
        private Array _array;
        public Algorithms(int num)
        {
            _num = num;
            withNumber();
        }

        public Algorithms(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                _name = name;
                withName();
            }
            else
            {
                Console.WriteLine("String is null or empty!");
            }
        }

        public Algorithms(Array array)
        {
            _array = array;

            if (_array.Length != 0)
            {
                withArray();
            }
            else
            {
                Console.WriteLine("Array is empty!");
            }
        }

        private void withNumber()
        {
            if (_num > 7)
            {
                Console.WriteLine("Hello");
            }
        }

        private void withName()
        {
            string _correctNameEng = "Vyacheslav";
            string _correctNameRus = "Вячеслав";

            if (_name == _correctNameEng)
            {
                Console.WriteLine($"Hi, {_name}");
            }
            else if (_name == _correctNameRus)
            {
                Console.WriteLine($"Привет, {_name}");
            }
            else
            {
                Console.WriteLine("No such name");
            }
        }

        private void withArray()
        {
            findNumbersDivisibleBy3();

            void findNumbersDivisibleBy3()
            {
                int ctr = 0;
                System.Collections.IEnumerator enumeratorForFind = _array.GetEnumerator();
                Console.Clear();
                while (enumeratorForFind.MoveNext())
                {
                    ctr++;
                    if ((int)enumeratorForFind.Current % 3 == 0 && (int)enumeratorForFind.Current != 0)
                    {
                        Console.WriteLine($"Element # [{ctr,3}] Value =>{enumeratorForFind.Current,3}");
                    }
                }
            }
        }
    }
}
