using System.Security.Cryptography.X509Certificates;

namespace Labb_8_Generic_Collections
{
    internal class Program //Gustav Lind .Net 23
    {
        // stack = LIFO data structure. Last-In First-Out
        //               stores objects into a sort of "vertical tower"
        //               push() to add objects to the top
        //               pop() to remove objects from the top
        static void Main(string[] args)
        {    
            // Creating employee objects
            Employee employee1 = new Employee(id: 101, name: "Gustav", gender: "Male", salary: 35000);
            Employee employee2 = new Employee(id: 102, name: "Elsa", gender: "Female", salary: 30000);
            Employee employee3 = new Employee(id: 103, name: "Kalle", gender: "Male", salary: 45000);
            Employee employee4 = new Employee(id: 104, name: "Ada", gender: "Female", salary: 25500);
            Employee employee5 = new Employee(id: 105, name: "Elina", gender: "Female", salary: 18000);
          
            // Creating a stack and pushing employee objects onto it
            Stack<Employee> myStack = new Stack<Employee>();  
            myStack.Push(employee1);
            myStack.Push(employee2);
            myStack.Push(employee3);
            myStack.Push(employee4);
            myStack.Push(employee5);

            // Iterating through the stack and printing employee details without removing them
            foreach (Employee item in myStack)//print stack but dont remove.
            {
                Console.WriteLine(item);
                Console.WriteLine("Number of objects in the stack:" + myStack.Count);
            }
            Console.WriteLine("----------------------------------------------------------------------------------");

            // Removing employee objects from the stack using the Pop method
            Console.WriteLine("Retrive Using Pop Method"); //Remove from the stack
            while (myStack.Count > 0)
            {
                Employee poppedEmployee = myStack.Pop();
                Console.WriteLine($"Popped: {poppedEmployee}");
                Console.WriteLine($"Number of objects in the stack: {myStack.Count}");
            }
            Console.WriteLine("----------------------------------------------------------------------------------");

            Console.WriteLine("Retrive Using Peek Method");// Peeking at the first two objects in the stack without removing them
            myStack.Push(employee5);
            myStack.Push(employee4);
            myStack.Push(employee3);
            myStack.Push(employee2);
            myStack.Push(employee1);
            Console.WriteLine(myStack.Peek());
            Console.WriteLine("Number of objects in the stack:" + myStack.Count());
            Console.WriteLine(myStack.Peek());
            Console.WriteLine("Number of objects in the stack:" + myStack.Count());
            Console.WriteLine("----------------------------------------------------------------------------------");

            if (myStack.Contains(employee3)) //Check if object 3 is in the stack
            {
                Console.WriteLine("object 3 is in stack!");
            }
            else//incase object 3 is not in the stack.
            {
                Console.WriteLine("object 3 is not in the stack!");
            }
            Console.WriteLine("----------------------------------------------------------------------------------");

            List<Employee> myList = new List<Employee>();     // Creating a list and adding employee objects to it
            Employee employee6 = new Employee(id: 106, name: "Ulf", gender: "Male", salary: 100000, role: "Marketing");//Add employee object
            Employee employee7 = new Employee(id: 107, name: "Åland", gender: "Male", salary: 29500, role: "Security");//Add employee object
            Employee employee8 = new Employee(id: 108, name: "Eva", gender: "Female", salary: 34500, role: "HR");//Add employee object
            myList.Add(employee6);//add object to the list
            myList.Add(employee7);//add object to the list
            myList.Add(employee8);//add object to the list
            
            if (myList.Contains(employee2)) //Check if list contains empoyee2
            {
                Console.WriteLine("Employee2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list");
            }
            Console.WriteLine("----------------------------------------------------------------------------------");

            Employee maleEmployee = myList.Find(employee => employee.Gender == "Male"); //Find first employee in the list that is male
            if (maleEmployee != null)
            {
                Console.WriteLine("First male employee in the list is: " + maleEmployee.Name + "and his salary is: " + maleEmployee.Salary + "SEK");
            }
            else
            {
                Console.WriteLine("No male employees found in the list");
            }
            Console.WriteLine("----------------------------------------------------------------------------------");

            List<Employee> allMales = myList.FindAll(employee => employee.Gender == "Male"); // Finding all male employees in the list and printing their details
            Console.WriteLine("All male employees in the list:");
            if (allMales.Count > 0) 
            {
                foreach (var employee in allMales)
                {
                    Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary}, SEK");
                }
            }
            else
            {
                Console.WriteLine("No male employees found in the list");
             }
            Console.WriteLine("----------------------------------------------------------------------------------");

        }
    }
}