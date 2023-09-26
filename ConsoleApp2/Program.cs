//int age = 18;
//string gender = "kishi";
//if(age>=18)
//{
//    if(gender=="qadin")
//    {
//        Console.WriteLine("ise qebul olundunuz");

//    }
//    else
//    {
//        Console.WriteLine("qadin olanda gel");
//    }
//}
//else 
//{
//    Console.WriteLine("yashiniz catmir");
//}


//if(selectNumber==1)
//{
//    Console.WriteLine("Azerbaycan dili secilmisdir");
//}
//else if(selectNumber==2)
//{
//    Console.WriteLine("Rus dili secilmisdir");
//}
//else if(selectNumber==0)
//{
//    Console.WriteLine("Operatora baglan");
//}
//else
//{
//    Console.WriteLine("bele bir secim movcud deyildir");
//}

int selectNumber = 1;


switch (selectNumber)
{
    case 1 or 2: 
   
        Console.WriteLine("Rus dili secilmisdir");
        break ;
    case 0:
        Console.WriteLine("Operatora baglanir");
        break;
    default:
        Console.WriteLine("Bele bir secim movcud deyildir");
        break;

}




