using System;
using System.Collections.Concurrent;

namespace ORM_Dapper
{
	public interface IDepartmentRepository
	{
        public IEnumerable<Department> GetAllDepartments();
    }
}

