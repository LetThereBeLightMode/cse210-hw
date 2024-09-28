using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        
        job1._jobTitle="Super Senior Manager";
        job1._company="Beeg Business";
        job1._totalCompensation = 1000;
        job1._startYear = 2024; 
        job1._endYear = 2028;

        
        Job job2 = new Job();
        
        job2._jobTitle="Super Duper Senior Manager";
        job2._company="Beeger Business";
        job2._totalCompensation = 1001;

        job2._startYear = 2023; 
        job2._endYear = 2022;

        job2.Display();
        job1.Display();

        Resume resume1 = new Resume();

        resume1._EmployeeName = "Bossman Jimmy"; 
        resume1._Jobs.Add(job1);
        resume1._Jobs.Add(job2);

        resume1.Display();
        



    }
}
