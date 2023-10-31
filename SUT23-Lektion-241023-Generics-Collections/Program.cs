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


            //List<Employee> listEmp = new List<Employee>();

            //listEmp.Add(Em1);
            //listEmp.Add(Em2);
            //listEmp.Add(Em3);

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



            //int index = listEmp.FindIndex(e => e.Salary == 25000);
            // Console.WriteLine("Index of 25000 : " + index);



            //Dictionary<int, Employee> SUT23Dicitinonary = new Dictionary<int, Employee>();

            //SUT23Dicitinonary.Add(Em1.ID, Em1);
            //SUT23Dicitinonary.Add(Em2.ID, Em2);
            //SUT23Dicitinonary.Add(Em3.ID, Em3);
            ////SUT23Dicitinonary.Add(Em4.ID, Em4);


            //Employee em;
            //if(SUT23Dicitinonary.TryGetValue(120, out em))
            //{
            //    Console.WriteLine("Item with ID : {0}", em.ID);
            //}
            //else
            //{
            //    Console.WriteLine("Item Finns ej");
            //}


            //Console.WriteLine("The Number of Items in The Dicitionary : " + SUT23Dicitinonary.Count);


            //Employee[] EmArray = new Employee[4];
            //EmArray[0] = Em1;
            //EmArray[1] = Em2;
            //EmArray[2] = Em3;
            //EmArray[3] = Em4;


            //Dictionary<int,Employee> FromArrayToDici =  EmArray.ToDictionary(y => y.ID  , e => e);

            //  foreach(KeyValuePair<int,Employee> item in FromArrayToDici)
            //  {
            //      Console.WriteLine("The Key is = " + item.Key);

            //      Employee e = item.Value;

            //      Console.WriteLine("ID = {0} Name = {1} Salary = {2}", e.ID, e.Name, e.Salary);


            //  }



            //if(!SUT23Dicitinonary.ContainsKey(Em4.ID))
            // {
            //     SUT23Dicitinonary.Add(Em4.ID, Em4);
            // }


            //foreach(Employee item in SUT23Dicitinonary.Values)
            // {
            //     Console.WriteLine("ID = {0} Name = {1} Salary = {2}", item.ID, item.Name, item.Salary);
            // }


            //Console.WriteLine(SUT23Dicitinonary.Count(e => e.Value.Salary > 24000));





            //Queue 

            //Queue<Employee> SUT23Queue = new Queue<Employee>();


            ////SUT23Queue.Enqueue(Em1);
            //SUT23Queue.Enqueue(Em2);
            //SUT23Queue.Enqueue(Em3);
            //SUT23Queue.Enqueue(Em4);


            //Employee emToDelete = SUT23Queue.Dequeue();
            // Console.WriteLine(emToDelete.ID + " " + emToDelete.Name);


            // Employee emToDelete2 = SUT23Queue.Dequeue();
            // Console.WriteLine(emToDelete2.ID + " " + emToDelete2.Name);


            //Employee peekSUT23 = SUT23Queue.Peek();
            // Console.WriteLine(peekSUT23.ID + " " + peekSUT23.Name);


            // Employee peekSUT232 = SUT23Queue.Peek();
            // Console.WriteLine(peekSUT232.ID + " " + peekSUT232.Name);
            // Console.WriteLine("Items in The Queue = " + SUT23Queue.Count);




           //if(SUT23Queue.Contains(Em1))
           // {
           //     Console.WriteLine("Item finns i Queue");
           // }
           // else
           // {
           //     Console.WriteLine("Item Finns inte i Queue");
           // }

           

           /// Stack
           /// 


            Stack<Employee> SUT23Stack = new Stack<Employee>();

            SUT23Stack.Push(Em1);
            SUT23Stack.Push(Em2);
            SUT23Stack.Push(Em3);
            Queue

            Employee emPop =SUT23Stack.Pop();
            Console.WriteLine("ID = {0}, Name = {1}",emPop.ID,emPop.Name);

            Console.WriteLine("Items in The Stack = " + SUT23Stack.Count);

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