using System;
using SQLite;

namespace Lab9.Service
{
	public static class DataConstants
	{
		public const string DBNAME = "Employees.db";

		public const SQLiteOpenFlags FLAGS =
			SQLiteOpenFlags.ReadWrite |
			SQLiteOpenFlags.Create |
			SQLiteOpenFlags.SharedCache;

		public readonly static string PATH =
			Path.Combine(FileSystem.AppDataDirectory, DBNAME);
	}
}

