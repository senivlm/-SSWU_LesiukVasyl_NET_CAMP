using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice_2
{
    class Store
    {
        private string name;
        private List<Department> departments;

        public Store(string name)
        {
            this.name = name;
            this.departments = new List<Department>();
        }

        public string Name { get { return name; } }

        public void AddDepartment(Department department)
        {
            departments.Add(department);
        }

        public List<Department> GetDepartments()
        {
            return departments;
        }
    }
}
