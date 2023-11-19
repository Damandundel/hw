
namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input;


            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();

                if (command.Contains("Add"))
                {
                    numbers.Add(int.Parse(command[1]));
                }

                else if (command.Contains("Insert"))
                {
                    if (int.Parse(command[2]) > numbers.Count && 1 > numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }

                    else
                    {
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    }
                }

                else if (command.Contains("Remove"))
                {
                    if (int.Parse(command[1]) > numbers.Count && 1 > numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }

                    else
                    {
                        numbers.RemoveAt(int.Parse(command[1]));
                    }
                }

                else if (command.Contains("left"))
                {
                    for (int i = 0; i < int.Parse(command[2]); i++)
                    {
                        numbers.Add(numbers[0]);
                        numbers.RemoveAt(0);
                    }
                }

                else if (command.Contains("right"))
                {
                    for (int i = 0; i < int.Parse(command[2]); i++)
                    {
                        numbers.Insert(0, numbers[numbers.Count - 1]);
                        numbers.RemoveAt(numbers.Count - 1);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

