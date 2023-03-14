#region Task 1
//    int num;
//L1:
//    Console.Write("Ededi daxil edin: ");
//    string strNum = Console.ReadLine();
//    if (!int.TryParse(strNum, out num))
//    {
//        goto L1;
//    }
//    if (num % 2 == 0)
//    {
//        Console.WriteLine("Verilmis eded cutdur");
//    }
//    else
//    {
//        Console.WriteLine("Verilmis eded tekdir");
//    }
#endregion
#region Task 2
//    int result, num1, num2;
//L1:
//    Console.Write("1. ededi daxil edin: ");
//    string strNum1 = Console.ReadLine();
//    if (!int.TryParse(strNum1, out num1))
//    {
//        goto L1;
//    }
//L2:
//    Console.Write("2. ededi daxil edin: ");
//    string strNum2 = Console.ReadLine();
//    if (!int.TryParse(strNum2, out num2))
//    {
//        goto L2;
//    }
//    result = num1 / num2;
//    if (num1 % num2 == 0)
//    {
//        Console.WriteLine($"Netice: {result}");
//    }
//    else
//    {
//        Console.WriteLine("Bolunmur.");
//    }
#endregion
#region Task 3
//    int num;
//L1:
//    Console.Write("Ededi daxil edin: ");
//    string strNum = Console.ReadLine();
//    if (!int.TryParse(strNum, out num))
//    {
//        goto L1;
//    }
//    if (num % 10 == 7)
//    {
//        Console.WriteLine("Verilmis ededin sonuncu reqemi 7 ile qurtarirmi: Beli");
//    }
//    else
//    {
//        Console.WriteLine("Verilmis ededin sonuncu reqemi 7 ile qurtarirmi: Xeyr");
//    }
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
#region task 12
//int num1;
//l1:
//Console.WriteLine("6 reqemli ededi daxil edin");
//string mainNumber = Console.ReadLine();

//if (!int.TryParse(mainNumber, out num1))
//{
//    Console.WriteLine("duzgun ededi daxil edin");
//    goto l1;
//}
//int number = (int)Math.Log10(num1) + 1;
//if (number != 6)
//{
//    goto l1;
//}

//int sum1 = num1 + 8000000;
//int sum2 = sum1 * 10 + 8;

//int sum3 = sum2 / 10000;
//int sum4 = sum2 % 10000 * 10000 + sum3;
//Console.WriteLine(sum4);
//int sum10 = 0;
//int sum11 = 0;
//while (sum4 > 0)
//{
//    int faiz = sum4 % 10;
//    sum4 /= 100;

//    sum10 = sum10 * 100 + faiz * 10;
//}
//while (sum10 > 0)
//{
//    int faiz = sum10 % 10;
//    sum10 /= 10;
//    sum11 = sum11 * 10 + faiz;
//}
////Console.WriteLine(sum10);
//Console.WriteLine(sum11);
/*
12) Verilmihs 6 reqemli ededdin evveline ve axirina 8 artir.
    Alinan neticenin ilk 4 reqemi ile son 4 reqeminin yerini deyish
    Neticenin tek yerde dayanan reqemlerini 0 reqemi ile evez et.
 */
#endregion
#region Task 13
//int value;
//l1:
//Console.WriteLine("7 reqemli ededi daxil edin: ");
//string mainNumber1 = Console.ReadLine();

//if (!int.TryParse(mainNumber1, out value))
//{
//    Console.WriteLine("duzgun ededi daxil edin");
//    goto l1;
//}
//int number = (int)Math.Log10(value) + 1;
//if (number != 7)
//{
//    goto l1;
//}
//int sum = 0;
//int temp = value;

//while (temp > 0)
//{
//    int faiz = temp % 10;
//    temp /= 10;
//    sum = sum * 10 + faiz;
//}
//if (value == sum)
//{
//    int sum2 = 0;
//    while (value > 0)
//    {
//        int faiz1 = value % 10;
//        value /= 10;
//        if (faiz1 == 0)
//        {
//            sum2++;
//        }

//    }
//    Console.WriteLine(sum2);
//}

/*
 13) Verilmish 7 reqemli eded polindromdursa
 o zaman onun daxilnde nece dene 0 reqemi oldugunu tap?
 */
#endregion
#region Task 14
//int value;
//l1:
//Console.WriteLine("ededi daxil edin");


//if (!int.TryParse(Console.ReadLine(), out value) || !(1 <= value && value < 100000000))
//{
//    Console.WriteLine("duzgun ededi daxil edin");
//    goto l1;
//}

//int temp = value;
//int sum = 0;
//while (temp > 0)
//{
//    int percent1 = temp % 10;

//    temp /= 10;
//    sum = sum * 10 + percent1;
//}

//int sum2 = sum * 10 + 1;
//int sum3 = 0;
//while (sum2 > 0)
//{
//    int percent2 = sum2 % 10;
//    sum2 /= 10;
//    sum3 = sum3 * 10 + percent2;
//}
//Console.WriteLine(sum3);
/*
 14) Bir eded daxil et. Bu eded maksimum 8 reqemli ola biler( bu o demekdirki 1,2,3,4,5,6,7 reqemlide ola biler)
    Bu ededin evvelin 1 reqemini artir.
 */
#endregion
#region Task 14 (V2)
//int num, numDigit, power, newNum;
//string strNum;
//L1:
//Console.Write("1-8 araliqinda eded daxil edin: ");
//strNum = Console.ReadLine();
//if (!int.TryParse(strNum, out num))
//{
//    goto L1;
//}
//numDigit = (int)Math.Log10(num) + 1;
//if (numDigit > 8)
//{
//    goto L1;
//}
//power = (int)Math.Pow(10, numDigit);
//newNum = power + num;
//Console.WriteLine(newNum);

/*
 14) Bir eded daxil et. Bu eded maksimum 8 reqemli ola biler( bu o demekdirki 1,2,3,4,5,6,7 reqemlide ola biler)
    Bu ededin evvelin 1 reqemini artir.
 */
#endregion
#region Task 15
//int value;
//l1:
//Console.WriteLine("1-365 arasi reqem daxil edin!");
//string mainNumber;

//if (!int.TryParse(Console.ReadLine(), out value) || !(1 <= value && value <= 365))
//{
//    Console.WriteLine("duzgun eded daxil etmediniz");
//    goto l1;
//}
//if (1 <= value && value <= 31)
//{
//    Console.WriteLine("Ay: Yanvar");
//}
//else if (32 <= value && value <= 59)
//{
//    Console.WriteLine("Ay: Fevral");
//}
//else if (60 <= value && value <= 90)
//{
//    Console.WriteLine("Ay: Mart");
//}
//else if (91 <= value && value <= 120)
//{
//    Console.WriteLine("Ay: Aprel");
//}
//else if (121 <= value && value <= 151)
//{
//    Console.WriteLine("Ay: May");
//}
//else if (152 <= value && value <= 181)
//{
//    Console.WriteLine("Ay: Iyun");
//}
//else if (182 <= value & value <= 212)
//{
//    Console.WriteLine("Ay: Iyul");
//}
//else if (213 <= value && value <= 243)
//{
//    Console.WriteLine("Ay: Avqust");
//}
//else if (244 <= value && value <= 273)
//{
//    Console.WriteLine("Ay: Sentyabr");
//}
//else if (274 <= value && value <= 304)
//{
//    Console.WriteLine("Ay: Oktyabr");
//}
//else if (305 <= value & value <= 334)
//{
//    Console.WriteLine("Ay: Noyabr");
//}
//else
//{
//    Console.WriteLine("Ay: Dekabr");
//}

////--------------------------------------------------------------------------------

//if (1 <= value && value <= 19 || 355 <= value && value <= 365)
//{
//    Console.WriteLine("Burc: Oglaq");
//}
//else if (20 <= value && value <= 49)
//{
//    Console.WriteLine("Burc: Dolca");
//}
//else if (50 <= value && value <= 79)
//{
//    Console.WriteLine("Burc: Baliq");
//}
//else if (80 <= value && value <= 109)
//{
//    Console.WriteLine("Burc: Qoc");
//}
//else if (110 <= value && value <= 140)
//{
//    Console.WriteLine("Burc: Buga");
//}
//else if (141 <= value && value <= 171)
//{
//    Console.WriteLine("Burc: Ekizler");
//}
//else if (172 <= value && value <= 203)
//{
//    Console.WriteLine("Burc: Xerceng");
//}
//else if (204 <= value && value <= 234)
//{
//    Console.WriteLine("Burc: Sir");
//}
//else if (236 <= value && value <= 265)
//{
//    Console.WriteLine("Burc: Qiz");
//}
//else if (266 <= value && value <= 296)
//{
//    Console.WriteLine("Burc: Terezi");
//}
//else if (297 <= value && value <= 325)
//{
//    Console.WriteLine("Burc: Eqreb");
//}
//else
//{
//    Console.WriteLine("Burc: Dolca");
//}



//New Add



//DateTime Date = new DateTime(2023, 1, 1);

//Date = Date.AddDays(value - 1);

//Console.WriteLine(Date.Month);

//*
// 15) IF operatoru ile yoxla.
//    Verilmish ededdin 1-ile 365 arasinda olugunu yoxla (1 ve 365 ozude daxil olmaq sherti ile)
//    Ededin ilin hansi ayina dushduyunu tap. Ve hemin ay ve gune uygun hansi burc oldugunu goster
// */
#endregion
#region Task 16
//int num, numDigit, remainder, size;
//string strNum;
//L1:
//Console.Write("6 reqemli ededi daxil edin: ");
//strNum = Console.ReadLine();
//if (!int.TryParse(strNum, out num))
//{
//    goto L1;
//}
//numDigit = (int)Math.Log10(num) + 1;
//if (numDigit > 8)
//{
//    goto L1;
//}
//int[] nums = new int[0];
//while (num > 0)
//{
//    remainder = num % 10;
//    num /= 10;

//    if (Array.IndexOf(nums, remainder) == -1)
//    {
//        size = nums.Length;
//        Array.Resize(ref nums, size + 1);
//        nums[size] = remainder;
//    }
//}
//Console.WriteLine($"tapilan tekrar reqemler {nums.Length}");
//foreach (var count in nums)
//{
//    Console.Write($" {count}, ");
//}

/*
  Verilmish 6 reqemli ededde nece unikal reqem var ?
( UNIKAL- Ededin daxilde her reqemden bir numayende secilecek. Yekunda nece numayende olacaq?)
 */
#endregion