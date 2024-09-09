class Department
{
    public int DeptID { get; set; }
    public List<Employee> Employees { get; set; }

    public Department(){
        Employees = new List<Employee>();
        Employees.Add(new Employee{ID=101,Name="Abhishek",Salary=2500});
        Employees.Add(new Employee{ID=102,Name="Abhish",Salary=2500});
        Employees.Add(new Employee{ID=103,Name="Abhi",Salary=2500});
        Employees.Add(new Employee{ID=104,Name="Ab",Salary=2500});
    }

    public string this[int id]{
        get{
            return Employees.FirstOrDefault(emp => emp.ID == id).Name;
        }
        set{
            Employees.FirstOrDefault(emp => emp.ID == id).Name = value;
        }

    }
    public int this[string str]{
        get{
            return Employees.FirstOrDefault(emp => emp.Name.ToLower() == str.ToLower()).ID;
        }
        set{
            Employees.FirstOrDefault(emp => emp.Name.ToLower() == str.ToLower()).ID = value;
        }

    }
}