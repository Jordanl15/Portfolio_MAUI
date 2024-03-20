using System;
using SQLite;
namespace Lab9.Model
{
    [Table("Employee")]
	public class Employee
	{
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }

        [NotNull,MaxLength(9)]
		public string SIN { get; set; }
        public string FullName { get; set; }
        public DateTime HireDate { get; set; }

        public string DateFormat => HireDate.ToLongDateString();
        public string SINFormat
        {
            get
            {
                if (!string.IsNullOrEmpty(SIN) && SIN.Length >= 9)
                {
                    return $"{SIN.AsSpan(0, 3)} {SIN.AsSpan(3, 3)} {SIN.AsSpan(6, 3)}";
                }
                else
                {
                    
                    return string.Empty; 
                }
            }
        }


        
        public override string ToString()
            => $"SIN: {SINFormat}\nName: {FullName}\nHire Date: {HireDate}";

        public Employee()
        {
           ID = -1;
           
        }
            
    }
}

