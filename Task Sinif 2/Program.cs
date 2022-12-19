using Task_Sinif_2;

#region Colculator

//Colculate();

//static void Colculate()
//{
//    Calculator calculator = new Calculator();

//    Console.WriteLine("Birinci Ededi daxil edin :");
//Number1: string number1 = Console.ReadLine();
//    int checkedNum1;
//    bool isParseNum1 = int.TryParse(number1, out checkedNum1);


//    if (!isParseNum1)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Xais olunur duzgun reqem daxil edin");
//        Console.ResetColor();
//        goto Number1;
//    }

//    Console.WriteLine("Isareni daxil edin :");
//    string operation = Console.ReadLine();


//    Console.WriteLine("Ikinci Ededi daxil edin :");
//Number2: string number2 = Console.ReadLine();
//    int checkedNum2;
//    bool isParseNum2 = int.TryParse(number2, out checkedNum2);

//    if (!isParseNum2)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Xais olunur duzgun reqem daxil edin");
//        Console.ResetColor();
//        goto Number2;
//    }

//    if (checkedNum2 == 0 && operation == "/")
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Sifra bolunmur");
//        Console.ResetColor();
//        goto Number2;
//    }


//    var result = calculator.Calculation(checkedNum1, checkedNum2, operation);
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine("Result =" + result);
//    Console.ResetColor();




#endregion

#region Order Class Task(ozum yazdigim)




//Order order = new Order()
//{
//    Time = new DateTime(2022, 12, 24),
//    Price = 250,
//    Name = "Kanfet",

//};

//Order order2 = new Order()
//{
//    Time = new DateTime(2022, 12, 20),
//    Price = 350,
//    Name = "Corek"


//};

//Order order3 = new Order()
//{
//    Time = new DateTime(2022, 12, 25),
//    Price = 400,
//    Name = "Pesox"

//};

//Order order4 = new Order()
//{
//    Time = new DateTime(2022, 12, 19),
//    Price = 300,
//    Name = "Sirniyyat"
//};


//DateTime time = DateTime.Now.AddDays(1);
//int numsPrice = 260;

//Order[] people = { order, order2, order3, order4 };

//static void OrderList(Order[] people, int numsPrice, DateTime time)
//{
//    foreach (var item in people)
//    {
//        if (item.Price > numsPrice && item.Time < time)
//        {
//            Console.WriteLine($"{item.Name} -- {item.Price} -- {item.Time}");
//        }
//    }

//}

//OrderList(people, numsPrice, time);




#endregion


#region Order Class Task(Mellim yazdigi)
//static Order_Task_class[] Getorders()
//{
//    var order1 = new Order_Task_class(new DateTime(2022, 12, 18), 500);
//    var order2 = new Order_Task_class(new DateTime(2022, 12, 19), 300);
//    var order3 = new Order_Task_class(new DateTime(2022, 12, 19), 250);
//    var order4 = new Order_Task_class(new DateTime(2022, 12, 20), 1500);
//    var order5 = new Order_Task_class(new DateTime(2022, 12, 22), 1500);
//    var order6 = new Order_Task_class(new DateTime(2022, 12, 28), 500);

//    return new Order_Task_class[] { order1, order2, order3, order4, order5, order6 };




//}


//DateTime filteredDate = DateTime.Now.AddDays(1);
//double filteredPrice = 300;

//GetFilteredOrdes(filteredDate, filteredPrice);

//static void GetFilteredOrdes(DateTime date, double price)
//{
//    var orders = Getorders();

//    foreach (var item in orders)
//    {
//        if (item.Price > price && item.Date <= date)
//        {
//            Console.WriteLine(item.Date.ToString("MM.dd.yyyy") + "-:" + item.Price);
//        }
//    }
//}





#endregion


#region Barcode Praktika

//Barcod barcod = new Barcod()
//{
//    Cofe = 10,
//    Cay = 5,
//    Yemek = 8,
//    Sirniyyat = 11,
//    Name = "Barcod"

//};
//Barcod barcod2 = new Barcod()
//{
//    Cofe = 10,
//    Cay = 2,
//    Yemek = 6,
//    Sirniyyat = 11,
//    Name = "Barcod2"

//};
//Barcod barcod3 = new Barcod()
//{
//    Cofe = 10,
//    Cay = 2,
//    Yemek = 6,
//    Sirniyyat = 12,
//    Name = "Barcod3"

//};

//Barcod barcod4 = new Barcod()
//{
//    Cofe = 10,
//    Cay = 3,
//    Yemek = 4,
//    Sirniyyat = 11,
//    Name = "Barcod4"

//};

//Barcod[] list = { barcod, barcod2, barcod3, barcod4 };


//int cayPrice = 2;
//int yemekPrice = 6;


//BarcodList(list, cayPrice, yemekPrice);
//static void BarcodList(Barcod[] list, int cayPrice, int yemekPrice)
//{
//    foreach (var item in list)
//    {
//        if (item.Cay == cayPrice && item.Yemek == yemekPrice)
//        {
//            Console.WriteLine(item.Name + "  Cay " + item.Cay + " yemek" + item.Yemek);


//        }
//    }

//}



#endregion


#region Class Task(Ismarried)

//static Person[] List()
//{

//    Person person = new Person("Cahandar", "Velibeyli", 26, false);
//    Person person2 = new Person("Ceyhun", "Bayramov", 24, true);
//    Person person3 = new Person("Nurlan", "Mecidli", 28, false);
//    Person person4 = new Person("Ismayil", "Humbetov", 18, false);
//    Person person5 = new Person("Abbas", "Bagirov", 23, true);

//    Person[] persons = new Person[] { person, person2, person3, person4, person5 };


//    return new Person[] { person, person2, person3, person4, person5 };

//}

//var personInfo = List();

//int age = 20;

//static void PersonList(Person[] persons, int age)
//{
//    int count = 0;
//    foreach (var item in persons)
//    {
//        if (item.Age > 20 && item.Ismarried)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);

//}

//PersonList(personInfo, age);




#endregion

