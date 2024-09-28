
using System.Runtime.InteropServices;
using System;

public class Job
{ 
   public Job(){} // special constructor ? 
   public void Display()
   {
      Console.WriteLine($"{_jobTitle}, {_totalCompensation}, {_startYear} to {_endYear}");
   }
   public string _jobTitle;
   public int _totalCompensation;
   public string _company;

   public int _startYear;

   public int _endYear;
}