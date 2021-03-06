﻿using System;
using System.Collections.Generic;
namespace hiest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dictionary<string, string>> listOfTeamMembers = new List<Dictionary<string, string>>();


            Console.WriteLine("Plan your Hiest!");
            Console.WriteLine("What is the Difficulty Level of the bank from 1-100");
            string difficultLevel = Console.ReadLine();
            int difficultLevelInt = int.Parse(difficultLevel);

            while (true)
            {
                Dictionary<string, string> teamMember = new Dictionary<string, string>();


                Console.WriteLine("Please enter your team members name");
                string memberName = Console.ReadLine();
                teamMember.Add("name", memberName);
                if (memberName != "")
                {
                    Console.WriteLine($"Please enter a skill level from 1-50 for {teamMember["name"]}");


                    string memberSkillLevel = Console.ReadLine();
                    // int memberSkillLevelInt = int.Parse(memberSkillLevel);
                    teamMember.Add("skill level", memberSkillLevel);



                    Console.WriteLine($"Please enter a courage level from 0-2.0 for {teamMember["name"]}");
                    string memberCourageLevel = Console.ReadLine();
                    teamMember.Add("courage level", memberCourageLevel);
                    Console.WriteLine($"Your team member is  {teamMember["name"]} and she has a skill level of {teamMember["skill level"]} and a courage level of {teamMember["courage level"]}");
                    listOfTeamMembers.Add(teamMember);
                }
                else
                {
                    Console.WriteLine("How many trial runs on robbing the bank would you like to run?");
                    string numTrials = Console.ReadLine();
                    int numTrailsInt = int.Parse(numTrials);
                    int totalSuccess = 0;
                    int totalFailure = 0;

                    for (int i = 0; i < numTrailsInt; i++)
                    {


                        int combinedSkillLevel = 0;
                        foreach (Dictionary<string, string> member in listOfTeamMembers)
                        {
                            string skillLevel = member["skill level"];
                            int skillLevelInt = int.Parse(skillLevel);
                            combinedSkillLevel += skillLevelInt;

                        }

                        Random rand = new Random();
                        int luckValue = rand.Next(-10, 11);
                        int diffPlusLuck = difficultLevelInt + luckValue;

                        Console.WriteLine($"Your teams combined skill level is {combinedSkillLevel}");
                        Console.WriteLine($"The Bank's difficulty level is {diffPlusLuck}");


                        if (combinedSkillLevel >= diffPlusLuck)
                        {

                            totalSuccess++;



                            Console.WriteLine("You could pull off this heist!");

                        }
                        else
                        {
                            totalFailure++;
                            Console.WriteLine("Not a chance. Recruit some more and try again.");
                        }


                    }
                    Console.WriteLine($"You succeeded {totalSuccess} times and failed {totalFailure} times");



                    break;
                }

            }
        }
    }
}

