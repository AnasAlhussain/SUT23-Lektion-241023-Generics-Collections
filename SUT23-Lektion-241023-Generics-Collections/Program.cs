namespace SUT23_Lektion_241023_Generics_Collections
{
    internal class Program
    {

        static void Main(string[] args)
        {
           //bool Eq =  cal<int>.CheckEqual<int>(15, 20);
           // if (Eq)
           // {
           //     Console.WriteLine("The Values is Equal ....");
           // }
           // else
           // {
           //     Console.WriteLine("The Values are not Equals .....");
           // }


           // bool Eq2 =cal<string>.CheckEqual<string>("A", "B");
           // if (Eq2)
           // {
           //     Console.WriteLine("The Values is Equal ....");
           // }
           // else
           // {
           //     Console.WriteLine("The Values are not Equals .....");
           // }









            // Collections Generics 
            // 1 List 
            List<int> listint = new List<int>();

            listint.Add(8);
            listint.Add(10);
            listint.Add(12);
            listint.Add(11);



            //listint.Remove(10);
            //listint.RemoveRange(1, 1);

            //listint.RemoveAt(2);


            //int c = listint.Count;

            // Console.WriteLine("The list Count is = {0}", c);



            //int Cap = listint.Capacity;
            // Console.WriteLine("The Capacity is = {0}",Cap);

            //foreach(int item in listint)
            //{
            //    Console.WriteLine(item);
            //}


            // Dictionary<int, string> SUT23Dictionary = new Dictionary<int, string>();

            // SUT23Dictionary.Add(102, "Tobias");
            // SUT23Dictionary.Add(101, "Anas");
            // SUT23Dictionary.Add(103, "Pär");

            // SUT23Dictionary.Remove(101);


            //string s = SUT23Dictionary[102];
            // Console.WriteLine(s);

            // foreach (KeyValuePair<int, string> item in SUT23Dictionary)
            // {
            //     Console.WriteLine("Elements in Our Dictinory ID {0} Name {1}", item.Key, item.Value);
            // }




            //Queue


            //Queue<int> SUT23Queue = new Queue<int>();


            //SUT23Queue.Enqueue(8);
            //SUT23Queue.Enqueue(10);
            //SUT23Queue.Enqueue(12);
            //SUT23Queue.Enqueue(14);



            //SUT23Queue.Dequeue();

            ////int Result =  SUT23Queue.Peek();

            ////Console.WriteLine("Peek Queue : {0}",Result);



            //if (SUT23Queue.Contains(8))
            //{
            //    Console.WriteLine("The Item is exist in the Queue");
            //}
            //foreach(int item in SUT23Queue)
            //{
            //    Console.WriteLine("Elements in The Queue : {0}", item);
            //}



            //Stack 
            //Stack<int> SUT23Stack = new Stack<int>();


            //SUT23Stack.Push(20);
            //SUT23Stack.Push(22);
            //SUT23Stack.Push(24);
            //SUT23Stack.Push(26);

            //int result = SUT23Stack.Peek();
            //Console.WriteLine("Element from Peek Method : {0}", result);



            ////int res = SUT23Stack.Pop();
            ////Console.WriteLine("Element From Pop method : {0}", res);


            //foreach (int item in SUT23Stack)
            //{
            //    Console.WriteLine("Number :{0} ", item);
            //}


            Employee Em1 = new Employee()
            {
                 ID = 111,
                 Name = "Tobias",
                 Salary = 25000
            };

            Employee Em2 = new Employee()
            {
                ID = 112,
                Name = "Anas",
                Salary = 23000
            };
            Employee Em3 = new Employee()
            {
                ID = 120,
                Name = "Elias",
                Salary = 24000
            };


            Employee Em4 = new Employee()
            {
                ID = 130,
                Name = "Sam",
                Salary = 22000
            };


            List<Employee> listEmp = new List<Employee>();

            listEmp.Add(Em1);
            listEmp.Add(Em2);
            listEmp.Add(Em3);

            //Insert
            //listEmp.Insert(1, Em4);

            // Index Of

            //Console.WriteLine(listEmp.IndexOf(Em3));



            //Console.WriteLine("Employee Info");
            //foreach (Employee item in listEmp)
            //{
            //    Console.WriteLine("ID = {0} \nName :{1} \nSalary : {2}",item.ID,item.Name,item.Salary);
            //}


            // Employee result =   listEmp[1];
            //Console.WriteLine("ID = {0} \nName :{1} \nSalary : {2}", result.ID, result.Name, result.Salary);





            //Containes 
            //if (listEmp.Contains(Em3))
            //{
            //    Console.WriteLine("Emplyee 3 objekt exist in the List....");
            //}
            //else
            //{
            //    Console.WriteLine("Emplyee 3 objekt exist Not the List....");
            //}

            //if(listEmp.Exists(e => e.Name.StartsWith("B")))
            //{
            //    Console.WriteLine("Emplyee Start with 'T' is in the List....");
            //}
            //else
            //{
            //    Console.WriteLine("Emplyee Start with 'T' is not in the List....");
            //}


            //Employee result =  listEmp.Find(e => e.Salary == 25000);
            //Console.WriteLine("ID = {0} \nName :{1} \nSalary : {2}", result.ID, result.Name, result.Salary);


            //Employee res = listEmp.FindLast(x => x.Salary < 25000);
            // Console.WriteLine("ID = {0} \nName :{1} \nSalary : {2}", res.ID, res.Name, res.Salary);



          //List<Employee> result =  listEmp.FindAll(e => e.Salary < 25000);

          //  foreach(Employee item in result)
          //  {
          //      Console.WriteLine("ID = {0} \nName :{1} \nSalary : {2}", item.ID, item.Name, item.Salary);
          //  }



           int index = listEmp.FindIndex(e => e.Salary == 25000);
            Console.WriteLine("Index of 25000 : " + index);
            Console.ReadKey();
        }
    }



    public interface Ap<T>
    {

    }
    public class cal<T>
    {
        public static bool CheckEqual<T>(T val1, T val2)
        {
            return val1.Equals(val2);
        }
    }


   
}