namespace _10._LadyBugs
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            //Solution of the task -> made by lector Kristiyan Ivanov

            // --1. Initialize empty field

            int n = int.Parse(Console.ReadLine());     //field size
            int[] field = new int[n];                  //Създаваме празен масив - самото поле, без стойности

            //--2. Spawn ladybugs on the valid index

            int[] initialIndexes = Console.ReadLine()   //this collection remains unchanged
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            foreach (int index in initialIndexes)
            {
                if (index>=0 && index < field.Length)
                {
                    //valid index=> Initialize ladybug on this index
                    field[index] = 1; //1, където има калинка
                }
            }

            //--3. Proceed game moves(start game)

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int ladybugIndex = int.Parse(cmdArgs[0]);
                string direction = cmdArgs[1];
                int flyLength = int.Parse(cmdArgs[2]);

            //--3.1 Validate ladybugIndex is inside the field

                if (ladybugIndex < 0 || ladybugIndex >= field.Length)
                {
                    //Invalid index =>Nothing happens
                    continue;
                }

            //--3.2 Validate ladybugIndex contains ladybug

                if (field[ladybugIndex] == 0)
                {
                    //There is no ladybug there=>Nothing happens
                    continue;
                }

                //--3.3 Try to proceed move

                //Right -> Ladybug+flyLength
                //Left -> ladybugIndex-flyLenth
                //First-> Our ladybug starts flying=>It removes from the field, it is in the air

                field[ladybugIndex] = 0;
                if (direction == "left")
                {
                    flyLength *= -1; //1=>-1
                }

                //right 1=0+1=1
                //1 left => 1+(-1)=0
                int nextIndex = ladybugIndex + flyLength;
                while (nextIndex >= 0 && nextIndex < field.Length && field[nextIndex] == 1)
                {
                    nextIndex += flyLength;
                }
                //There are two possibilities:
                //Variant a: nextIndex is calculated somewhere in the field
                //Variant b: nextIndex cannot be calculated in the field

                if (nextIndex < 0 || nextIndex >= field.Length)
                {
                    //Variant b - outside the field
                    continue;
                }
                //variant a - land the ladybug on the valid next index
                field[nextIndex] = 1;
            }
             Console.WriteLine(string.Join(" ", field));
        }
    }
}
