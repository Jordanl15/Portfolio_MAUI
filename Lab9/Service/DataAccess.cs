using System;
using SQLite;
using Lab9.Model;


namespace Lab9.Service
{
	public class DataAccess
	{
		private readonly SQLiteConnection db;

		public DataAccess()
		{
			db = new SQLiteConnection(DataConstants.PATH, DataConstants.FLAGS);
			db.CreateTable<Employee>();
			SeedRecords();
			
		}

		public int Add(Employee employee)
			=> db.Insert(employee);

		public int Update(Employee employee)
			=> db.Update(employee);

		public int Delete(int id)
			=> db.Table<Employee>().Delete(e => e.ID == id);

		public List<Employee> GetEmployees()
			=> db.Table<Employee>().ToList();

		private void SeedRecords()
		{
			db.DropTable<Employee>();
            db.CreateTable<Employee>();
            var e1 = new Employee() { SIN = "111111111", FullName = "Jordan L", HireDate = DateTime.Now };
            var e2 = new Employee() { SIN = "222222222", FullName = "Jordan M", HireDate = DateTime.Now };
            var e3 = new Employee() { SIN = "333333333", FullName = "Jordan N", HireDate = DateTime.Now };
            var e4 = new Employee() { SIN = "444444444", FullName = "Jordan O", HireDate = DateTime.Now };
            var e5 = new Employee() { SIN = "555555555", FullName = "Jordan P", HireDate = DateTime.Now };
			db.Insert(e1);
            db.Insert(e2);
            db.Insert(e3);
            db.Insert(e4);
            db.Insert(e5);
        }

		
	}
}

