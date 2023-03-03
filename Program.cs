using System;
using System.Collections.Generic;

namespace BankHeist
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Plan your heist!");
      Dictionary<string, TeamMember> TheSquad = new();
      while (true)
      {
        TeamMember TeamMember = new();
        System.Console.WriteLine("What's your team member's name?");
        string givenName = Console.ReadLine();
        TeamMember.Name = givenName;
        if (givenName == "")
        {
          break;
        }
        System.Console.WriteLine("What's your team member's skill level? Must be a positive integer less than or equal to 25.");
        string MemberSkillLevel = Console.ReadLine();
        int MemberSkillInt = int.Parse(MemberSkillLevel);
        while (MemberSkillInt < 0 || MemberSkillInt > 25)
        {
          System.Console.WriteLine("Invalid input, please try again.");
          MemberSkillLevel = Console.ReadLine();
          MemberSkillInt = int.Parse(MemberSkillLevel);
        }
        TeamMember.SkillLevel = MemberSkillInt;
        System.Console.WriteLine("What's your team leader's courage factor? Must be a decimal between 0.0 and 2.0");
        string MemberCourageFactor = Console.ReadLine();
        float MemberCourageFloat = float.Parse(MemberCourageFactor);
        while (MemberCourageFloat < 0.0 || MemberCourageFloat > 2.0)
        {
          System.Console.WriteLine("Invalid input, please try again");
          MemberCourageFactor = Console.ReadLine();
          MemberCourageFloat = float.Parse(MemberCourageFactor);
        }
        TeamMember.CourageFactor = MemberCourageFloat;
        TheSquad.Add(givenName, TeamMember);
        // System.Console.WriteLine($"Your esteemed team leader, {TeamMember.Name}, has a skill level of {TeamMember.SkillLevel} and a courage factor of {TeamMember.CourageFactor}");


      }
      int bankDifficulty = 100;

      Random r = new Random();
      int luckValue = r.Next(-10, 11);
      bankDifficulty += luckValue;
      
      int teamSkillLevel = 0;

      foreach (KeyValuePair<string, TeamMember> member in TheSquad)
      {
        teamSkillLevel += member.Value.SkillLevel;
      }

      System.Console.WriteLine($"Your team's skill level is {teamSkillLevel}. The bank's difficulty level is {bankDifficulty}.");

      if (teamSkillLevel >= bankDifficulty)
      {
        System.Console.WriteLine("we're rich!");
      }
      else
      {
        System.Console.WriteLine("W A S T E D");
      }
    }
  }
}