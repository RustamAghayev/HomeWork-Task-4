#region Task 1
//int num1;
//l1:
//Console.WriteLine("ededi daxil edin");
//string mainNumber = Console.ReadLine();

//if (!int.TryParse(mainNumber, out  num1))
//{
//    Console.WriteLine("duzgun ededi daxil edin");
//    goto l1;
//}
//if (num1 % 2 ==0)
//{
//    Console.WriteLine("eded cutdur");
//}
//else
//{
//    Console.WriteLine("eded tekdir");
//}
/*
  1) verilmish ededin tek ve ya cut eded oldugunu yoxla
 */
#endregion
#region Task 2
//int num1;
//l1:
//Console.WriteLine("1ci ededi daxil edin: ");
//string mainNumber1 = Console.ReadLine();

//if (!int.TryParse(mainNumber1, out num1))
//{
//    Console.WriteLine("duzgun ededi daxil edin");
//    goto l1;
//}
//int num2;
//l2:
//Console.WriteLine("2ci ededi daxil edin: ");
//string mainNumber2 = Console.ReadLine();

//if (!int.TryParse(mainNumber2, out num2))
//{
//    Console.WriteLine("duzgun ededi daxil edin");
//    goto l2;
//}


//int result = num1 / num2;
//if (num1 % num2 == 0)
//{
//    Console.WriteLine($"daxil edilen {num1} ededi {num2} ededine tam  bolunur\nNetice:{result}");
//}

//else
//{
//    Console.WriteLine("bolunur");
//}


/*
 2) 2 eded verilib. Eger I eded II edede tam bolunurse o zaman cavabi cixart.
    Eks halda  "bolunmur" sozunu cap et

 */
#endregion
#region Task 3
//int num1;
//l1:
//Console.WriteLine("ededi daxil edin: ");
//string mainNumber1 = Console.ReadLine();

//if (!int.TryParse(mainNumber1, out num1))
//{
//    Console.WriteLine("duzgun ededi daxil edin");
//    goto l1;
//}
//if (num1 % 10 == 7) 
//{
//    Console.WriteLine("Beli");
//}
//else
//{
//    Console.WriteLine("Xeyr");
//}
/*
 3) Verilmish ededdin sonuncu reqemi 7 ile qurtarirmi? Beli ve Xeyr cavabini yaz ekrana
 */
#endregion
#region Task 4
//int num1;
//l1:
//Console.WriteLine("2 reqemli ededi daxil edin: ");
//string mainNumber1 = Console.ReadLine();

//if (!int.TryParse(mainNumber1, out num1))
//{
//    Console.WriteLine("duzgun ededi daxil edin");
//    goto l1;
//}
//int number = (int)Math.Log10(num1) + 1;
//if (number != 2)
//{
//    goto l1;
//}
//int remainderOne = num1 / 10;
//int remainderTwo = num1 % 10;
//if (remainderOne == remainderTwo)
//{
//    Console.WriteLine("Ededler bir birine beraberdirmi? Beli");
//}
//else
//{
//    Console.WriteLine("Ededler bir birine beraberdirmi? Xeyr");
//}

/*
 4) Verilmihs 2 reqemli ededin reqemleri eynidirmi?   Beli ve Xeyr cavabini yaz ekrana
 */
#endregion
#region Task 5
//int num1;
//l1:
//Console.WriteLine("2 reqemli ededi daxil edin: ");
//string mainNumber1 = Console.ReadLine();

//if (!int.TryParse(mainNumber1, out num1))
//{
//    Console.WriteLine("duzgun ededi daxil edin");
//    goto l1;
//}
//int number = (int)Math.Log10(num1) + 1;
//if (number != 2)
//{
//    goto l1;
//}
//int remainderOne = num1 / 10;
//int remainderTwo = num1 % 10;
//int sum = remainderOne + remainderTwo;
//int sum2;
//if (sum%2==0)
//{
//    sum2 = remainderOne * remainderTwo;
//    Console.WriteLine($"Ededler bir birine beraberdirmi? Beli Netice:{sum2}");

//}
//else
//{
//    Console.WriteLine("Ededler bir birine beraberdirmi? Xeyr");
//}
/*
 5) Verilmish 2 reqemli ededdin reqemleri cemi cut ededdirse o zaman
    hemin 2 reqemli ededdin reqemlerinin hasilini ekrana cixart.
 */
#endregion
#region Task 6
//int num1;
//l1:
//Console.WriteLine("3 reqemli ededi daxil edin: ");
//string mainNumber1 = Console.ReadLine();

//if (!int.TryParse(mainNumber1, out num1))
//{
//    Console.WriteLine("duzgun ededi daxil edin");
//    goto l1;
//}
//int number = (int)Math.Log10(num1) + 1;
//if (number != 3)
//{
//    goto l1;
//}
//int remainderOne = num1 / 100;
//int remainderTwo = num1 / 10 % 10;
//int remainderThree = num1 % 10;
//int sum = remainderOne + remainderThree;
//if (sum == remainderTwo)
//{

//    Console.WriteLine("Beli");

//}
//else
//{
//    Console.WriteLine("Xeyr");
//}
/*
 6) Verilmish 3 reqemli ededdin I ve III reqemlerinin cemi II reqeme beraberdirmi?  Beli ve Xeyr cavabini yaz ekrana
 */
#endregion
#region Task 7
//int num1;
//l1:
//Console.WriteLine("3 reqemli ededi daxil edin: ");
//string mainNumber1 = Console.ReadLine();

//if (!int.TryParse(mainNumber1, out num1))
//{
//    Console.WriteLine("duzgun ededi daxil edin");
//    goto l1;
//}
//int number = (int)Math.Log10(num1) + 1;
//if (number != 3)
//{
//    goto l1;
//}
//int remainderOne = num1 / 100;
//int remainderTwo = (num1 / 10) % 10;
//int remainderThree = num1 % 10;
//int sum = remainderOne + remainderTwo + remainderThree;

//int sum2 = (int)Math.Pow(remainderOne, 2);
//if (sum==sum2)
//{

//    Console.WriteLine("Beli");

//}
//else
//{
//    Console.WriteLine("Xeyr");
//}
/*
  7) Verilmish 3 reqemli ededdin reqemleri cemi I reqemin kvadratina beraberdirmi?  Beli ve Xeyr cavabini yaz ekrana
 */
#endregion
#region Task 8
//int num1;
//l1:
//Console.WriteLine("ededi daxil edin: ");
//string mainNumber1 = Console.ReadLine();

//if (!int.TryParse(mainNumber1, out num1))
//{
//    Console.WriteLine("duzgun ededi daxil edin");
//    goto l1;
//}
//int sum = num1 % 10;
//string final;


//switch (sum)
//{
//    case 1:
//        final = "I gun";
//        break;
//    case 2:
//        final = "II gun";
//        break;
//    case 3:
//        final = "III gun";
//        break;
//    case 4:
//        final = "IV gun";
//        break;
//    case 5:
//        final = "V gun";
//        break;
//    case 6:
//        final = "VI gun";
//        break;
//    case 7:
//        final = "VII gun";
//        break;
//    default:
//        final = "Daxil edilen eded yanlisdir! sonuncu reqem 1-7 araliqinda olmalidir";
//        break;
//}

//Console.WriteLine(final);
/*
 8) SWITCH operatoru ile yoxla.
   Verilmish ededdin sonuncu reqemi
                 1 olarsa-"I gun" sozunu
                2 olarsa-"II gun" sozunu
                ...
                7 olarsa-"VI gun" sozunu yaz
 */
#endregion
#region Task 9
//int num1;
//l1:
//Console.WriteLine("ededi daxil edin: ");
//string mainNumber1 = Console.ReadLine();

//if (!int.TryParse(mainNumber1, out num1))
//{
//    Console.WriteLine("duzgun ededi daxil edin");
//    goto l1;
//}

//if (num1 < 1 || num1 > 12)
//{
//    Console.WriteLine("ededi duzgun daxil edin");
//    goto l1;
//}


//switch (num1)
//{
//    case 1:
//        Console.WriteLine("Yanvar");
//        break;
//    case 2:
//        Console.WriteLine("Fevral");
//        break;
//    case 3:
//        Console.WriteLine("Mart");
//        break;
//    case 4:
//        Console.WriteLine("Aprel");
//        break;
//    case 5:
//        Console.WriteLine("May");
//        break;
//    case 6:
//        Console.WriteLine("Iyun");
//        break;
//    case 7:
//        Console.WriteLine("Iyul");
//        break;
//    case 8:
//        Console.WriteLine("Avqust");
//        break;
//    case 9:
//        Console.WriteLine("Sentyabr");
//        break;
//    case 10:
//        Console.WriteLine("Oktyabr");
//        break;
//    case 11:
//        Console.WriteLine("Noyabr");
//        break;
//    case 12:
//        Console.WriteLine("Dekabr");
//        break;
//}
/*
 9) SWITCH operatoru ile yoxla.
   Verilmish ededdin 1-ile 12 arasinda olugunu yoxla.(1 ve 12 ozude daxil olmaq sherti ile)
   Eger bu eded
                 1 olarsa-"Yanvar" sozunu
                2 olarsa-"Fevral" sozunu
                ...
                12 olarsa-"Dekabr" sozunu yaz
 */
#endregion
#region Task 10
//int num1,num2,num3,num4,num5,num6;
//l1:
//Console.WriteLine("1ci ededi daxil edin: ");
//string mainNumber1 = Console.ReadLine();

//if (!int.TryParse(mainNumber1, out num1))
//{
//    Console.WriteLine("1ci ededi duzgun daxil etmediniz");
//    goto l1;
//}

//l2:
//Console.WriteLine("2ci ededi daxil edin: ");
//string mainNumber2 = Console.ReadLine();

//if (!int.TryParse(mainNumber2, out num2))
//{
//    Console.WriteLine("2ci ededi duzgun daxil etmediniz");
//    goto l2;
//}

//l3:
//Console.WriteLine("3cu ededi daxil edin: ");
//string mainNumber3 = Console.ReadLine();

//if (!int.TryParse(mainNumber3, out num3))
//{
//    Console.WriteLine("3cu ededi duzgun daxil etmediniz");
//    goto l3;
//}

//l4:
//Console.WriteLine("4cu ededi daxil edin: ");
//string mainNumber4 = Console.ReadLine();

//if (!int.TryParse(mainNumber4, out num4))
//{
//    Console.WriteLine("4cu ededi duzgun daxil etmediniz");
//    goto l4;
//}

//l5:
//Console.WriteLine("5ci ededi daxil edin: ");
//string mainNumber5 = Console.ReadLine();

//if (!int.TryParse(mainNumber5, out num5))
//{
//    Console.WriteLine("5ci ededi duzgun daxil etmediniz");
//    goto l5;
//}

//l6:
//Console.WriteLine("6ci ededi daxil edin: ");
//string mainNumber6 = Console.ReadLine();
//int max = num1;
//if (!int.TryParse(mainNumber6, out num6))
//{
//    Console.WriteLine("6ci ededi duzgun daxil etmediniz");
//    goto l6;
//}
//if (num1 > max)
//{
//    max = num1;

//}
//if (num2 > max)
//{
//    max = num2;

//}

//if (num3 > max)
//{
//    max = num3;
//}

//if (num4 > max)
//{
//    max = num4;
//}

//if (num5 > max)
//{
//    max = num5;
//}

//if (num6 > max)
//{
//    max = num6;
//}
//Console.WriteLine($"en boyuk eded {max} secildi");
/*
 10) IF operatoru ile yoxla.
   6 dene eded verilib. Bu ededlerden hansi en boyukdur.
 */
#endregion
#region Task 11
//int num1;
//l1:
//Console.WriteLine("6 reqemli ededi daxil edin: ");
//string mainNumber1 = Console.ReadLine();

//if (!int.TryParse(mainNumber1, out num1))
//{
//    Console.WriteLine("duzgun ededi daxil edin");
//    goto l1;
//}
//int number = (int)Math.Log10(num1) + 1;
//if (number != 6)
//{
//    goto l1;
//}

//int sum1 = (num1 / 100000) + (num1 / 10000 % 10) + (num1 / 1000 % 10);
//int sum2 = (num1 % 1000 / 100) + (num1 % 1000 % 100 / 10) + (num1 % 10);
//int sum3;
//int sum4;
//int sum5;
//int sum6;
//int sum7;
//int sum8;
//int sum9;
//if (sum1==sum2)
//{
//    sum3 = num1 / 10000;
//    sum4 = num1 % 100;
//    sum5 = sum3 * 100;
//    sum6 = sum5 + sum4;

//    sum7 = num1 / 1000 % 10;
//    sum8 = sum6 * 10;
//    Console.WriteLine(sum8);
//    sum9 = sum8 + sum7;
//    Console.WriteLine(sum9);
//}
//else
//{
//    Console.WriteLine("eded beraber deyil");
//}
/*
 11) Verilmish 6 reqemli ededin ilk 3 reqeminin cemi son 3 reqeminin cemine beraberdirse
    o zaman
        bu ededdin ilk 2 reqemini son 2 reqemine yapishdir.
        Neticenin ustune ortaya dushen 2 reqemini gel.
 */
#endregion


#region Task 15
//int num1;
//l1:
//Console.WriteLine("1-365 arasi reqem daxil edin!");
//string mainNumber = Console.ReadLine();

//if (!int.TryParse(mainNumber, out num1))
//{
//    Console.WriteLine("duzgun eded daxil etmediniz");
//    goto l1;
//}
//DateTime Date = new DateTime(2023, 1, 1);

//Date = Date.AddDays(num1 - 1);

//Console.WriteLine(Date.Month);

///*
// 15) IF operatoru ile yoxla.
//    Verilmish ededdin 1-ile 365 arasinda olugunu yoxla (1 ve 365 ozude daxil olmaq sherti ile)
//    Ededin ilin hansi ayina dushduyunu tap. Ve hemin ay ve gune uygun hansi burc oldugunu goster
// */
#endregion