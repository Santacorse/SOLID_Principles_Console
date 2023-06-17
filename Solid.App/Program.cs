//using Solid.App.OCPGood2;
//SalaryCalculator salaryCalculator = new SalaryCalculator();
////Bad Way (OCP)

//Console.WriteLine($"Low Salary:{salaryCalculator.Calculate(1000, SalaryType.Low)}");
//Console.WriteLine($"Low Salary:{salaryCalculator.Calculate(1000, SalaryType.Middle)}");
//Console.WriteLine($"Low Salary:{salaryCalculator.Calculate(1000, SalaryType.High)}");

//Good Way (OCP)

//Console.WriteLine($"Low Salary:{salaryCalculator.Calculate(1000, new LowSalaryCalculate())}");
//Console.WriteLine($"Middle Salary:{salaryCalculator.Calculate(1000, new MiddleSalaryCalculate())}");
//Console.WriteLine($"High Salary:{salaryCalculator.Calculate(1000, new HighSalaryCalculate())}");
//Console.WriteLine($"Manager Salary:{salaryCalculator.Calculate(1000, new ManagerSalaryCalculate())}");

//Good Way 2 (OCP)

//Console.WriteLine($"Low Salary:{salaryCalculator.Calculate(1000, new LowSalaryCalculate().Calculate)}");
//Console.WriteLine($"Middle Salary:{salaryCalculator.Calculate(1000, new MiddleSalaryCalculate().Calculate)}");
//Console.WriteLine($"High Salary:{salaryCalculator.Calculate(1000, new HighSalaryCalculate().Calculate)}");
//Console.WriteLine($"Manager Salary:{salaryCalculator.Calculate(1000, new ManagerSalaryCalculate().Calculate)}");


//Bad Way(LSP)

//using Solid.App.LSPBad;

//Console.WriteLine("Hello,World!");

//BasePhone phone = new BasePhone.IPhone();
//phone.Call();
//phone.TakePhoto();

//phone = new BasePhone.Nokia3310();
//phone.Call();
//phone.TakePhoto();

//Good Way(LSP)

//using Solid.App.LSPGood;

//Console.WriteLine("Hello,World!");

//BasePhone phone = new IPhone();
//phone.Call();
//((ITakePhoto)phone).TakePhoto();

//phone = new Nokia3310();
//phone.Call();

//using Solid.App.DIPGoodAndBad;


//var ProductService = new ProductService(new ProductRepositoryFromOracle());

//ProductService.GetAll().ForEach(x=> Console.WriteLine(x));