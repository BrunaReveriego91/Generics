// See https://aka.ms/new-console-template for more information

using Generics;

class Program
{
    static void Main()
    {
        Console.WriteLine(AreEqual("oi", "oi"));
        int[] array = { 3, 4, 2, 1, 5, 6, 7, 8, 9, 2, 2, 2, 1, 23, 3 };
        string[] srtArray = { "Bruna", "Gabriel", "Lucas" };

        string[] sortedStrArray = Sort(srtArray);
        int[] sortedArray = Sort(array);

        Console.WriteLine(String.Join(", ", sortedArray));
        Console.WriteLine(String.Join(", ", sortedStrArray));

        Person p1 = new Person() { Age = 10 };
        Person p2 = new Person() { Age = 15 };

        Console.WriteLine("P1 equal to P2: " + AreEqual(p1, p2));

        var teste = p1.CompareTo(p2);
        Console.WriteLine(teste);
    }

    private static T[] Sort<T>(T[] array) where T : IComparable<T>
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i].CompareTo(array[j]) > 0)
                {
                    T temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }

            }
        }

        return array;

    }

    public static bool AreEqual<T>(T num1, T num2) where T : IComparable<T>
    {
        return (num1.CompareTo(num2) == 0);
    }


    public static int[] SortInt(int[] array)
    {


        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i].CompareTo(array[j]) > 0)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }

            }
        }

        return array;

    }


}
