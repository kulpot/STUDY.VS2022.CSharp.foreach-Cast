using System;
using System.Collections;
using System.Collections.Generic;

//ref link:https://www.youtube.com/watch?v=nUivLyA5RLQ&list=PLRwVmtr-pp07QlmssL4igw1rnrttJXerL&index=19
//

class Base { }
class Derived : Base { }

class MainClass
{
    static void Main()
    {
        //Base b = new Derived();
        Base b = new Base();
        //Derived d = (Derived)b;   // foreach casting(parenthetical cast) cant cast error base to derive
        Derived d = b as Derived;   // as casting -- returns null(dynamic casting) cast base to derive       
        Console.WriteLine(d == null); 

        //ArrayList myPartyAges = new ArrayList() { 25, 34, "kulpot", 32 }; // old school list
        //List<int> myPartyAges = new List<int>() { 25, 34, 32 }; // generic list
        //List<Base> myPartyAges = new List<Base>() { new Derived(), new Derived() }; 
        //List<Base> myPartyAges = new List<Base>() { new Derived(), new Base() };    // exception error for new Base()
        //foreach (int age in myPartyAges)
        //foreach (Base age in myPartyAges)
        //foreach (Derived age in myPartyAges)
        //    Console.WriteLine(age);
    }
}