



//task1
#region Heap-steak





//task1-1

//static void Test()

//{
//    Console.WriteLine("P135");
//}
//Test();




//namespace Heap_Steakstatic

//{

//       internal class Class1
//{
//    static void Test()
//    {
//        Console.WriteLine("Bosh");
//    }

//    static void Test(int n)
//    {
//            Console.WriteLine(n);
//    }


//    static void Test(string n)
//    {
//            Console.WriteLine(n);
//    }

//    static void Test(string n, int m)
//    {
//            Console.WriteLine(n + m);
//    }

//}


//}


//int a = 5;

//Console.WriteLine(a);

///////////////////


//int a = 5;
//int b = a;
// b = 10;

//Console.WriteLine(b);   

////////////

//int a = 5;
//int b = a;
//b = 10;

//Console.WriteLine(b);
//Console.WriteLine(a);
////////////////////////
///

//int[] arr1 = { 1, 2, 3 };

//Console.WriteLine(arr1[0]);
/////////////////////////////

// int[] arr1 = { 1, 2, 3 };

//int[] arr2 = arr1;


//Console.WriteLine(arr2[0]);
//Console.WriteLine(arr1[0]);
/////////////

//int[] arr1 = { 1, 2, 3 };

//int[] arr2 = arr1;

//arr2[0] = 100;

//Console.WriteLine(arr2[0]);
//Console.WriteLine(arr1[0]);
//////////////////////////////////

//int[] arr1 = { 1, 2, 3 };

//int[] arr2 = arr1;

//arr2[0] = 100;

//Console.WriteLine(arr2[0]);
//Console.WriteLine(arr1[0]);
////////////////////////////int[] arr1 = { 1, 2, 3 };

//int[] arr1 = { 1, 2, 3, };
//int[] arr2 = { 4, 5, 6 };

//arr2[0] = 100;

//Console.WriteLine(arr2[0]);
//Console.WriteLine(arr1[0]);
//////////////////////////////////


//int[] arr1 = { 1, 2, 3, };
//int[] arr2 = { 4, 5, 6 };

//arr2[0] = arr1[0];

//Console.WriteLine(arr2[0]);
//Console.WriteLine(arr1[0]);
///////////////////////////////

//int n = 5;

//Console.WriteLine(n);

//static void Test(int n)
//{
//    n = 100;
//    Console.WriteLine(n);
//}
////////////////////////////////

//int n = 5;

//Test(n);

//Console.WriteLine(n);

//static void Test(int n)
//{
//    n = 100;
//    Console.WriteLine(n);
//}

//int[] arr = { 2, 3,4, 5 };

//Test2(arr);

//static void Test2(int[] arr)
//{
//    Console.WriteLine(arr[0]);
//}

///////////////////\

//int[] arr = { 2, 3, 4, 5 };

//Test2(arr);

//static void Test2(int[] arr)
//{
//    arr[0] = 200;

//    Console.WriteLine(arr[0]);
//}
/////////////////

//int[] arr = { 2, 3, 4, 5 };

//Test2(arr);

//Console.WriteLine(arr[0]);
//static void Test2(int[] arr)
//{
//    arr[0] = 200;

//    Console.WriteLine(arr[0]);
//}
///////////////////////////

//Reff


//int n = 5;

//Test(ref n);

//Console.WriteLine(n);



//static void Test(ref int n)
//{
//    n = 100;
//    Console.WriteLine(n);
//}
////////////////////////////////



//int n ;

//Test(out n);

//Console.WriteLine(n);



//static void Test(out int n)
//{
//    n = 2;
//    Console.WriteLine(n);
//}
////////////////////

//int n = 100;

//Test(out n);

//Console.WriteLine(n);

//static void Test(out int n)
//{
//    n = 2;
//    Console.WriteLine(n);
//}



//string name = "Pervin";

//    string name2 = name;

//Console.WriteLine(name);
//Console.WriteLine(name2)
/////////////////
///
//    string name = "Pervin";

//string name2 = name;

//name2 = "cavid";

//Console.WriteLine(name);
//Console.WriteLine(name2);
//////////////////

//string address = "Ehmedli";

//Console.WriteLine(address.Length);
////////////////

//string address = "Ehmedli";

//int result = address.Length -1;

//Console.WriteLine(result);

////////////////////////

//string address = "Ehmedli";

//Console.WriteLine(address.StartsWith("e"));
///////////////////////


//string address = "Ehmedli";

//Console.WriteLine(address.EndsWith("i"));
///////////////


//string address = "Ehmedli";
//if  (address.EndsWith("i"))
//{
//    Console.WriteLine("yes");
//}
//else
//{
//    Console.WriteLine("no");
//}
/////////////////////////////


//string address = "Ehmedli";

//if (address.Contains("i"))
//{
//    Console.WriteLine("yes");
//}
//else
//{
//    Console.WriteLine("no");
//}

///////////////////////////


//string address = "Ehmedli";

//var res = address.Split();
//Console.WriteLine(address);

///////////////////

//string address = "Ehmedli,Azerbaycan,Siyezen";

//var res = address.Split(",");

//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}

//string address = "Ehmedli,Azerbaycan,Siyezen";

//Console.WriteLine(address.ToLower());
//////////////////

//string address = "Ehmedli,Azerbaycan,Siyezen";

//address = "Roya";

//Console.WriteLine(address.ToLower());

////////



//string address = "Ehmedli,Azerbaycan,Siyezen";

//    address = "Roya";

//Console.WriteLine(address.ToUpper());

//////////////////////////////////////////////

//string address = "roya";

//var letter = address[0].ToString().ToUpper();

//var arr = address.ToCharArray();

//arr[0] = char.Parse(letter);

//string result = "";
//foreach (var item in arr)
//{
//    Console.Write(item);

//}
//////////////////////////////////

//string name = "jale";

//Console.WriteLine(name.ToUpper());



//string name = "jale";

//Console.WriteLine(name.Substring(1).ToUpper());

////////////////////
///

//string name = "    jale";

//string name2 = "jale";

//Console.WriteLine(name.Trim());

//Console.WriteLine(name == name2);

//////////////////////

#endregion






//Task-2

name ();

static void name()

{
    Console.WriteLine("Hesen");
}



static string Name()
{
    return "Hesen";
}

string result = Name();
Console.WriteLine(result.Replace("Hesen","neseH"));

    