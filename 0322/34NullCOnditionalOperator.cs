using System;

namespace Basic
{
    class NullCOnditionalOperator
    {
        static void Main(string[] args)
        {
            string animal = null;
            //참조형 변수의 속성을 사용하려고 하면그 변수는 null이 아니어야 된다.
                        Console.WriteLine("4글자 이상인 동물의 이름만 출력합니다.");
            do
            {
                LongNameAnimal(animal);
                Console.Write("동물이름: ");
            } while ((animal = Console.ReadLine()) != "");
        }
        private static void LongNameAnimal(string animal)
        {
            if (animal.Length >= 4)
                Console.WriteLine(animal + " : " + animal.Length);
        }
    }
}

