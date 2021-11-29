﻿using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Program number to get executed \n1. Validate first name \n2. Validate last name \n3. Validate EmailID \n4. Validate Mobile No. \n5. Validate Passward \n6. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("*First letter should be capital.");
                        Console.WriteLine("*length should be Minimum three characters.");
                        Console.WriteLine("Enter First name :");
                        string fname = Console.ReadLine();
                        Validation_regex Checkpattern = new Validation_regex();
                        Checkpattern.Checkfirstname(fname);
                        break;
                    case 2:
                        Console.WriteLine("*First letter should be capital.");
                        Console.WriteLine("*length should be Minimum three characters.");
                        Console.WriteLine("Enter Last name :");
                        string lname = Console.ReadLine();
                        Validation_regex lnamepattern = new Validation_regex();
                        lnamepattern.Checklastname(lname);
                        break;
                    case 3:
                        Console.WriteLine("Enter Email id :");
                        string email = Console.ReadLine();
                        Validation_regex emailpattern = new Validation_regex();
                        emailpattern.Checkemail(email);
                        break;
                    case 4:
                        Console.WriteLine("Enter Mobile No. :");
                        string mobilenum = Console.ReadLine();
                        Validation_regex mobilenumpattern = new Validation_regex();
                        mobilenumpattern.Checkmobilenum(mobilenum);
                        break;
                    case 5:
                        Console.WriteLine("Enter Passward :");
                        string passward = Console.ReadLine();
                        Validation_regex passwardruleone = new Validation_regex();
                        passwardruleone.Checkpassward(passward);
                        break;
                    case 6:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("invalid option");
                        break;
                }
            }
        }
    }
}