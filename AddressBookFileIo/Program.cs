using System;
using System.Collections.Generic;

namespace AddressBook
{
    class AddressBook
    {
        public static Dictionary<string, List<AddressBook>> addressBook = new Dictionary<string, List<AddressBook>>();
        public static Dictionary<string, List<AddressBook>> City = new Dictionary<string, List<AddressBook>>();
        public static Dictionary<string, List<AddressBook>> State = new Dictionary<string, List<AddressBook>>();
        private List<AddressBook> people;

        static void Main(string[] args)
        {

            // Set the Foreground color to blue
            Console.ForegroundColor = ConsoleColor.Blue;

            // Display current Foreground color
            // Console.WriteLine("Changed Foreground Color: {0}",
            // Console.ForegroundColor);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("---------------------------------------Welcome to Address Book System----------------------------");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("Enter the number of address books: ");
            int noOfAddressBook = Convert.ToInt32(Console.ReadLine());
            int noOfBooks = 0;
            while (noOfBooks < noOfAddressBook)
            {
                Console.WriteLine("Enter the address book name : ");
                string addressbookname = Console.ReadLine();
                AddressBook addrBook = new AddressBook();
                Console.WriteLine("Enter the no of contacts in the address book: ");
                int noOfContact = Convert.ToInt32(Console.ReadLine());

                while (noOfContact > 0)
                {
                    Console.WriteLine("Enter the details of contact to be added: ");

                    Console.Write("Enter First Name: ");
                    string FirstName = Console.ReadLine();

                    Console.Write("Enter Last Name: ");
                    string LastName = Console.ReadLine();

                    Console.Write("Enter Phone Number: ");
                    string PhoneNumber = Console.ReadLine();

                    Console.Write("Enter Address : ");
                    string Addresses = Console.ReadLine();

                    Console.Write("Enter City : ");
                    string City = Console.ReadLine();

                    Console.Write("Enter State : ");
                    string State = Console.ReadLine();

                    Console.Write("Enter ZipCode: ");
                    string ZipCode = Console.ReadLine();

                    Console.Write("Enter EmailId: ");
                    string EmailId = Console.ReadLine();
                    addrBook.GetCustomer(FirstName, LastName, PhoneNumber, Addresses, City, State, ZipCode, EmailId);
                    noOfContact--;

                    Console.WriteLine(" ");
                    addrBook.ListContact();
                }
                Console.WriteLine("1.To Edit/Modify the Contact  details");
                Console.WriteLine("2.To  Delete/remove the Contact  details");
                Console.WriteLine("If You Want To Serach Or View Contact By City Or State Click 3.option");
                Console.WriteLine("3.city or state");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addrBook.EditContact();
                        Console.WriteLine(" ");
                        addrBook.ListContact();
                        break;
                    case 2:
                        addrBook.DeletePeople();
                        Console.WriteLine(" ");
                        addrBook.ListContact();
                        break;


                }
                if (addressBook.ContainsKey(addressbookname))
                {
                    Console.WriteLine("Existing address book name");
                    return;
                }
                else
                {
                    addressBook.Add(addressbookname, addrBook.people);
                }
                noOfBooks++;

                foreach (KeyValuePair<string, List<AddressBook>> addr in addressBook)
                {
                    Console.WriteLine("The address Books are:{0}", addr.Key);

                }


                Console.WriteLine("Enter 1-To Search a person through a City");
                Console.WriteLine("Enter 2-To Search a person through a State");
                Console.WriteLine("Enter 3-To view a person by state list or city list");
                Console.WriteLine("Enter 4. Sort the Person  ");
                Console.WriteLine("Enter 5. Sort the Based By City ");
                Console.WriteLine("Enter 6. Sort the Based By State  ");
                Console.WriteLine("Enter 7. Sort the Based By Zipcode ");
                Console.WriteLine("Enter 8.write a data in file");
                Console.WriteLine("Enter 9.read a data in file");
                int opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {

                    case 1:
                        SearchAddress(opt);
                        break;
                    case 2:
                        SearchAddress(opt);
                        break;
                    case 3:
                        AddressBook.CountCityorState();
                        break;
                    case 4:

                        //uc 11 sort name using sort function

                        AddressBook.SortByPersonName(addressBook);
                        break;
                    case 5:
                        AddressBook.SortBasedByCity(addressBook);
                        break;
                    case 6:
                        AddressBook.SortBasedByState(addressBook);
                        break;
                    case 7:
                        AddressBook.SortBasedByZipCode(addressBook);
                        break;


                    default:
                        Console.WriteLine("Invalid Option!");
                        break;
                }


            }

            static void SearchAddress(int option)
            {
                string city, state;
                if (option == 1)
                {
                    Console.WriteLine("Enter the City Name");
                    city = Console.ReadLine();
                    foreach (KeyValuePair<string, List<AddressBook>> kvp in addressBook)
                    {
                        AddressBook.StoreCityList(kvp.Key, kvp.Value, city);

                    }
                    if (option == 2)
                    {
                        Console.WriteLine("Enter the City Name");
                        state = Console.ReadLine();
                        foreach (KeyValuePair<string, List<AddressBook>> kvp in addressBook)
                        {
                            AddressBook.StoreStateList(kvp.Key, kvp.Value, state);
                        }
                    }
                }
            }
        }

        private static void StoreStateList(string key, List<AddressBook> value, string state)
        {
            throw new NotImplementedException();
        }

        private static void StoreCityList(string key, List<AddressBook> value, string city)
        {
            throw new NotImplementedException();
        }

        private static void SortBasedByZipCode(Dictionary<string, List<AddressBook>> addressBook)
        {
            throw new NotImplementedException();
        }

        private static void SortBasedByState(Dictionary<string, List<AddressBook>> addressBook)
        {
            throw new NotImplementedException();
        }

        private static void SortBasedByCity(Dictionary<string, List<AddressBook>> addressBook)
        {
            throw new NotImplementedException();
        }

        private static void SortByPersonName(Dictionary<string, List<AddressBook>> addressBook)
        {
            throw new NotImplementedException();
        }

        private static void CountCityorState()
        {
            throw new NotImplementedException();
        }

        private void DeletePeople()
        {
            throw new NotImplementedException();
        }

        private void EditContact()
        {
            throw new NotImplementedException();
        }

        private void ListContact()
        {
            throw new NotImplementedException();
        }

        private void GetCustomer(string firstName, string lastName, string phoneNumber, string addresses, string city, string state, string zipCode, string emailId)
        {
            throw new NotImplementedException();
        }
    }
}