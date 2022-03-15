﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOAddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
                Console.WriteLine(" Welcome to contact management program");
                ContactOperations co = new ContactOperations();

                ShowOptions();

                void ShowOptions()
                {
                    Console.Write("\n Select Option : 1.Display Contacts  \t 2.Edit Contact Details \t");
                    int option = int.Parse(Console.ReadLine());


                    switch (option)
                    {
                        case 1:
                            co.GetContactDetails();
                            ShowOptions();
                            break;
                        case 2:
                            co.EditContact();
                            ShowOptions();
                            break;
                        default: break;
                    }
                }
            
        }
    }
}
