//  Console.WriteLine("**************First Program************");

//  Car myCar = new() { Brand = "Toyota", Speed = 180, NumberOfDoors = 4 };
//         myCar.DisplayInfo();
//         Console.WriteLine($"Number of Doors: {myCar.NumberOfDoors}");

//         Console.WriteLine();

//         Bike myBike = new() { Brand = "Yamaha", Speed = 120, HasGear = true };
//         myBike.DisplayInfo();
//         Console.WriteLine($"Has Gear: {myBike.HasGear}");

//  Console.WriteLine("**************Overriding Program************");

//  Console.Write("Enter car brand :");
//  string carBrand = Console.ReadLine();

//  Console.Write("Enter Car Speed");
//  int carSpeed = int.Parse(Console.ReadLine());

//         Console.Write("Enter Number of Doors: ");
//         int numberOfDoors = int.Parse(Console.ReadLine());

//         Car1 myCar1 = new() { Brand = carBrand, Speed = carSpeed, NumberOfDoors = numberOfDoors };

//         Console.WriteLine("\nCar Details:");
//         myCar.DisplayInfo(); // Calls overridden method in Car

//         Console.WriteLine("\n--------------------------------\n");

//         // Taking input dynamically for Bike
//         Console.Write("Enter Bike Brand: ");
//         string bikeBrand = Console.ReadLine();

//         Console.Write("Enter Bike Speed: ");
//         int bikeSpeed = int.Parse(Console.ReadLine());

//         Console.Write("Does the bike have gears? (true/false): ");
//         bool hasGear = bool.Parse(Console.ReadLine());

//         Bike myBike1 = new() { Brand = bikeBrand, Speed = bikeSpeed, HasGear = hasGear };

//         Console.WriteLine("\nBike Details:");
//         myBike.DisplayInfo(); // Calls overridden method in Bike




// Console.WriteLine("*****************Third program*************************");

// Console.WriteLine("3.Employee Program");
// Employee emp = new Employee("Hari", 50000);
// Console.WriteLine("\nEmployee Details:");
// emp.DisplayInfo();

// Manager mgr = new Manager("Harik", 80000, 10000);
// Console.WriteLine("\nManager Details:");
// mgr.DisplayInfo();

// Console.WriteLine("4.Animal Program");
// Dog myDog = new Dog("Puppy");
// myDog.DisplayInfo();
// myDog.MakeSound();

// Console.WriteLine();

// Cat myCat = new Cat("kitty");
// myCat.DisplayInfo();
// myCat.MakeSound();

// Console.WriteLine("5.MovableMachine program");
// Robot myrobot = new Robot();
// myrobot.Start();
// myrobot.Move();
// Console.WriteLine("---------------------------------");


// Console.WriteLine("---------------------------6.Banking System---------------------------");

// SavingsAccount mySavings = new SavingsAccount(5000, 5);
// Console.WriteLine("Savings Account Details:");
// mySavings.CalculateInterest();

// Console.WriteLine("---------------------------seventh Program--------------------------");

// Duck myDuck = new Duck();
// myDuck.Fly();  
// myDuck.Swim();


Console.WriteLine("---------------------------Eighth Program--------------------------");
Student student = new Student { Name = "Harika", Age = 21, StudentID = 6232 };
// Upcast Student to Person
Person person = student;
person.DisplayInfo();
// Downcast Person back to Student
Student downcastedStudent = (Student)person;
downcastedStudent.DisplayStudentInfo();
Console.WriteLine();

Console.WriteLine("-------------------------------9.Product Discount System-------------------------------------");
ElectronicProduct laptop = new ElectronicProduct("Laptop", 1200);
ClothingProduct tshirt = new ClothingProduct("T-Shirt", 50);
laptop.DisplayProductInfo();
tshirt.DisplayProductInfo();
Console.WriteLine("---------------------------------");

Console.WriteLine("-----------------------------------10.Security System Demo-----------------------------------------");
SecuritySystem system = new SecuritySystem();
system.AuthenticateUser();