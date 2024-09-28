using System.ComponentModel.DataAnnotations;

public class Resume
{
   public string _EmployeeName;
   public List<Job> _Jobs;

   public Resume()
   {
    _Jobs = new List<Job>();
   }
   
   public void Display(){
      
   Console.WriteLine($"Employee: {_EmployeeName}");
        foreach (var job in _Jobs)
        {
            job.Display();
        }
        
   }
}