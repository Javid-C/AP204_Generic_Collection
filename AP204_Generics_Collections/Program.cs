using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AP204_Generics_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Worst case
            //Item item = new Item(90);
            //Console.WriteLine(item.Quality);

            //Item item1 = new Item("Awesome");

            //Console.WriteLine(item1._Quality);

            //Item item2 = new Item('A');
            //Console.WriteLine(item2.Quality);
            #endregion

            #region Generics
            //Item<int> item = new Item<int>(1000);
            //Console.WriteLine(item.Quality);

            //Item<string> item1 = new Item<string>("Awesome");
            //Console.WriteLine(item1.Quality);

            //Item<char> item2 = new Item<char>('A');

            //Console.WriteLine(item2.Quality);

            //Item<double> item3 = new Item<double>(100.99d);
            //Console.WriteLine(item3.Quality);

            //IntList intList = new IntList();
            //intList.Add(5);
            //intList.Add(25);
            //intList.Add(15);


            //Console.WriteLine("Intlist count: " + intList.Count);

            //foreach (int num in intList.GetArray())
            //{
            //    Console.WriteLine(num);
            //}

            //StringList stringList = new StringList();
            //stringList.Add("Shemsi");
            //stringList.Add("Islam");
            //stringList.Add("Kamal");
            //stringList.Add("Safiyya");

            //Console.WriteLine("\n StringList count: " + stringList.Count);

            //foreach (string item in stringList.GetArray())
            //{
            //    Console.WriteLine(item);
            //}

            Computer computer = new Computer("MSI", 16, "1TB");
            Computer computer1 = new Computer("Lenova", 16, "2TB");
            Computer computer2 = new Computer("ASUS", 8, "512GB");
            Computer computer3 = new Computer("ACER", 16, "256GB");


            //ComputerList computerList = new ComputerList();
            //computerList.Add(computer);
            //computerList.Add(computer1);
            //computerList.Add(computer2);
            //computerList.Add(computer3);
            //Console.WriteLine("\n Computer list count: " + computerList.Count);

            //foreach (Computer item in computerList.GetArray())
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("\n");
            //Console.WriteLine("Generic type Custom List");
            //CustomList<int> customList = new CustomList<int>();

            //customList.Add(1);
            //customList.Add(2);
            //customList.Add(3);

            //Console.WriteLine("Count int list :" + customList.Count);


            //CustomList<string> customString = new CustomList<string>();

            //customString.Add("Fatima");
            //customString.Add("Fatima");
            //customString.Add("Fatima");
            //customString.Add("Fatima");
            //customString.Add("Fatima");

            //Console.WriteLine("Custom string count: " + customString.Count);

            //CustomList<Computer> customComp = new CustomList<Computer>();

            //customComp.Add(computer);
            //customComp.Add(computer1);
            //customComp.Add(computer2);
            //customComp.Add(computer3);
            //Console.WriteLine("Custom comp list count: " + customComp.Count);

            //foreach (Computer comp in customComp.GetArray())
            //{
            //    Console.WriteLine(comp);
            //}

            //SuperMarket<int, char> superMarket = new SuperMarket<int, char>();

            //superMarket.Add(100,'A');
            //superMarket.Add(200,'B');
            //superMarket.Add(300,'C');

            //int total=0;

            //foreach (var item in superMarket.GetProducts())
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (int item in superMarket.Prices)
            //{
            //    total += item;
            //}

            //Console.WriteLine(total);


            //SuperMarket<double, string> superMarket1 = new SuperMarket<double, string>();

            //superMarket1.Add(10.5d, "Milk");
            //superMarket1.Add(3.05d, "Tea");
            //superMarket1.Add(5.5d, "Coffee");
            //superMarket1.Add(1.5d, "Water");

            //for (int i = 0; i < superMarket1.GetProducts().Length; i++)
            //{
            //    Console.WriteLine($"{superMarket1.GetProducts()[i]}: {superMarket1.GetPrices()[i]}");
            //}
            #endregion

            #region Collections
            //ArrayList arrayList = new ArrayList();

            //arrayList.Add("Shemsi");
            //arrayList.Add('A');
            //arrayList.Add(100);
            //arrayList.Add(100.5d);
            //arrayList.Add(computer);



            //foreach (object item in arrayList)
            //{
            //    if(item is Computer)
            //    {
            //        Computer comp = (Computer)item;
            //        comp.Test();
            //    }
            //    Console.WriteLine(item);
            //}

            //ArrayList arrayList1 = new ArrayList();

            //arrayList1.Add("Rashid");
            //arrayList1.Add('B');
            //arrayList1.Add(100);
            //arrayList1.Add(computer1);

            //arrayList.AddRange(arrayList1);

            //Console.WriteLine("After add range");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //arrayList.Remove(computer);

            //Console.WriteLine("After delete \n");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("After remove at \n");
            //arrayList.RemoveAt(2);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //arrayList.RemoveRange(3,2);
            //Console.WriteLine("After remove range\n");

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}


            //SortedList sortedList = new SortedList();

            //sortedList.Add(1,"Fatima");
            //sortedList.Add(3,"Ilkin");
            //sortedList.Add(2,"Vahid");
            //sortedList.Add(4,"Rashid");

            ////sortedList.RemoveAt(2);

            //foreach (DictionaryEntry item in sortedList)
            //{
            //    Console.WriteLine(item.Value);
            //}


            //Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

            ////keyValuePairs.Add('c',"Fazil");
            ////keyValuePairs.Add('a',"Malik");
            ////keyValuePairs.Add('b',"Tural");

            //keyValuePairs.Add("USA","Kentucky, Alaska, Texas, California, Los Angeles");
            //keyValuePairs.Add("Germany","Frankfurt, Berlin, Koln");
            //keyValuePairs.Add("Turkey","Istanbul, Izmir, Bursa, Ankara, Urfa");
            //keyValuePairs.Add("Azerbaijan","Kurdemir, Agcebedi, Zig, Saatli, Zenguzar");
            //bool result  = keyValuePairs.TryAdd("Azerbaycan","Kurdemir, Agcebedi, Zig, Saatli, Zenguzar");

            //if (result)
            //{
            //    Console.WriteLine("Zenguzar azad edildi");
            //}
            //else
            //{
            //    Console.WriteLine("Bele bir sey yoxdu");
            //}

            //keyValuePairs.Clear();

            //foreach (var item in keyValuePairs)
            //{
            //    Console.WriteLine(item.Value);
            //}


            //Queue<string> queue = new Queue<string>();

            //queue.Enqueue("Baxsheli");
            //queue.Enqueue("Murad");
            //queue.Enqueue("Ali");

            //Console.WriteLine("Novbe: " + queue.Dequeue()); 
            //Console.WriteLine("Novbe: " + queue.Dequeue()); 
            //Console.WriteLine("Novbe: " + queue.Dequeue());
            //string name;
            //Console.WriteLine("Novbe: " + queue.TryDequeue(out name)); 
            //Console.WriteLine("Hazirlashin: " + queue.TryPeek(out name));


            //Console.WriteLine("Novbedekiler");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}


            //Stack<string> stack = new Stack<string>();

            //stack.Push("Shemsi");
            //stack.Push("Fatima");
            //stack.Push("Islam");

            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine("Novbe: " + stack.Peek());

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}


            //List<int> list = new List<int>();

            //list.Add(6);
            //list.Add(3);
            //list.Add(1);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Before new List");
            //List<int> vs = new List<int>();
            //vs.Add(5);
            //vs.Add(2);
            //vs.Add(4);
            //list.AddRange(vs);


            //Console.WriteLine("After add range");

            //list.Sort();
            //list.Clear();

            //list.Remove(5);
            //list.Remove(2);
            //list.RemoveAt(2);

            //list.RemoveRange(2, 2);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //int number = list.Find(x=>x==5);

            //bool result = list.Contains(7);

            //Console.WriteLine(result);
            //Console.WriteLine(number);

            //Console.WriteLine(list[8]);

            //List<Student> students = new List<Student>();

            //Student student1 = new Student();
            //student1.GroupNo = "Test";
            //students.Add(student1);

            //students.Add(new Student()
            //{
            //    GroupNo = "AP204"
            //});
            //students.Add(new Student()
            //{
            //    GroupNo = "AP205"
            //});
            //students.Add(new Student()
            //{
            //    GroupNo = "AP206"
            //});

            //foreach (Student student in students)
            //{
            //    Console.WriteLine(student.GroupNo);
            //}

            //Products products = new Products();

            //products.Add("Milk");
            //products.Add("Tea");
            //products.Add("Cola");

            //foreach (var item in products.GetElements())
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(products[3]);


            string word = "bes yuzelli";

            Console.WriteLine(word.customContains("s y"));
            #endregion


        }
    }


    static class Extension
    {
        public static bool customContains(this string word, string search)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i <= word.Length - search.Length; i++)
            {
                for (int j = i; j < search.Length + i; j++)
                {
                    stringBuilder.Append(word[j]);
                }

                if (stringBuilder.ToString().ToLower() == search.ToLower())
                {
                    return true;
                }
                stringBuilder.Clear();
            }
            return false;
        }
    }

    class Student
    {
        public string GroupNo;

        
    }

    class Products
    {
        private string[] arr;

        public Products()
        {
            arr = new string[0];
        }

        public string this[int index]
        {
            get
            {
                if(index<0 || arr.Length >= index)
                {
                    throw new IndexOutOfRangeException("Product index");
                }
                return arr[index];
            }
            set
            {
                if (index > 0)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = value;
                }
            }
        }


        public void Add(string product)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length-1] = product;
        }


        public string[] GetElements()
        {
            return arr;
        }

    }
}
