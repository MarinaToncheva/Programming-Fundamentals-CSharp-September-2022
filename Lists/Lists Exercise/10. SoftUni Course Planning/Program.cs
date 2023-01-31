namespace _10._SoftUni_Course_Planning
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "course start")
            {
                string[] cmdArg = command
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);

                string commandType = cmdArg[0];
                string lessonTitle = cmdArg[1];

                if (commandType=="Add")
                {
                    if (schedule.Contains(lessonTitle))
                    {
                        continue;
                    }
                    else
                    {
                        schedule.Add(lessonTitle);
                    }
                }
                else if (commandType=="Insert")
                {
                    int index = int.Parse(cmdArg[2]);
                    if (schedule.Contains(lessonTitle))
                    {
                        continue;
                    }
                    else
                    {
                        schedule.Insert(index, lessonTitle);
                    }
                }
                else if (commandType=="Remove")
                {
                    string exercise = lessonTitle + "-Exercise";
                    if (schedule.Contains(lessonTitle) && schedule.Contains(exercise))
                    {
                        schedule.Remove(lessonTitle);
                        schedule.Remove(exercise);
                    }
                    else if (schedule.Contains(lessonTitle))
                    {
                        schedule.Remove(lessonTitle);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (commandType=="Swap")
                {
                    string secondLessonTitle = cmdArg[2];

                    if (schedule.Contains(lessonTitle) && schedule.Contains(secondLessonTitle))
                    {
                        int lessonIndex = schedule.FindIndex(a => a.Contains(lessonTitle));
                        int secondLessonIndex = schedule.FindIndex(a => a.Contains(secondLessonTitle));

                        string exercise = lessonTitle + "-Exercise";
                        string exerciseSecondLessonTitle = secondLessonTitle + "-Exercise";
                        int exerciseIndex = schedule.FindIndex(a => a.Contains(exercise));
                        int exerciseSecondIndex = schedule.FindIndex(a => a.Contains(exerciseSecondLessonTitle));

                        if (exerciseIndex != -1 && exerciseSecondIndex != -1) // exercises are present
                        {
                            // swap lessons
                            string tempLesson = schedule[lessonIndex];
                            schedule[lessonIndex] = schedule[secondLessonIndex];
                            schedule[secondLessonIndex] = tempLesson;
                            // swap excercises
                            string temp = schedule[exerciseIndex];
                            schedule[exerciseIndex] = schedule[exerciseSecondIndex];
                            schedule[exerciseSecondIndex] = temp;
                        }
                        else if (exerciseIndex != -1 && exerciseSecondIndex == -1) // only first exercise is present
                        {
                            // swap lessons
                            string tempLesson = schedule[lessonIndex];
                            schedule[lessonIndex] = schedule[secondLessonIndex];
                            schedule[secondLessonIndex] = tempLesson;
                            // move first exercise
                            schedule.Insert(secondLessonIndex + 1, exercise);
                            schedule.RemoveAt(exerciseIndex+1);
                        }
                        else if (exerciseIndex == -1 && exerciseSecondIndex != -1) // only second exercise is present
                        {
                            // swap lessons
                            string tempLesson = schedule[lessonIndex];
                            schedule[lessonIndex] = schedule[secondLessonIndex];
                            schedule[secondLessonIndex] = tempLesson;
                            // move second exercise
                            schedule.RemoveAt(exerciseSecondIndex);
                            schedule.Insert(lessonIndex + 1, exerciseSecondLessonTitle);
                        }
                        else // no exercises present
                        {
                            // swap lessons
                            string tempLesson = schedule[lessonIndex];
                            schedule[lessonIndex] = schedule[secondLessonIndex];
                            schedule[secondLessonIndex] = tempLesson;
                        }
                    }
                    else
                    {
                        continue;
                    }

                }
                else if (commandType=="Exercise")
                {
                    string exercise = lessonTitle + "-Exercise";

                    if (schedule.Contains(lessonTitle) && !schedule.Contains(exercise))
                    {
                        int index = schedule.FindIndex(a => a.Contains(lessonTitle));
                        schedule.Insert(index + 1, exercise);
                    }
                    else if (!schedule.Contains(lessonTitle))
                    {
                        schedule.Add(lessonTitle);
                        schedule.Add(exercise);
                    }
                    else if (schedule.Contains(lessonTitle) && schedule.Contains(exercise))
                    {
                        continue;
                    }
                }
            }
            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine(i + 1 + "." + schedule[i]);
            }
        }
    }
}