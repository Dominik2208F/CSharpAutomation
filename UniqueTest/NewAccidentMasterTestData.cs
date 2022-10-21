using System;
using System.Collections.Generic;

namespace UniqueTest
{
    public  class NewAccidentMasterTestData
    {
        public static string PolicyNumber { get => "55555555"; }
        public  static string RegistrationNumber {  get=> "WPR140A"; }
        public static string PolcyHolderPesel { get => "70040718298"; }
        public static string PhoneNumber { get => "667546378"; }
        public  static string EmailAdress { get => "email@example.com"; }
        public  static string DateofAccident { get => "12-12-2021"; }
        public static string DateHours { get => "12"; }
        public static string DataMinutes { get => "13"; }
        public static string PLaceofAccident { get => "Warszawa"; }
        public static string NumberofCarInvolded { get => "2"; }
        public static string Description { get => "Lelumpolelum"; }
        public  static string YearofProduction { get => "2006"; }
        public static string Brand { get => "BMW"; }
        public static string Model { get=> "Seria 3 [E90] 05-08"; }
        public static string FirstRegistrationDate { get => "02-02-2008"; }
      

        public static  MainOwnerDetail GetMainOvnerDetails()
        {
            return new MainOwnerDetail("Jan", "Kowalski", "70040718298", "667546378", "email@example.com", "PL27573289623065912671386189");
        }


        public static RegisteredDetails GetRegisteredDetails()
        {
            return new RegisteredDetails("00-006", " Orzeszkowa", "2", "3");
        }

        public struct RegisteredDetails
        {
            public string PostalCode { get; }
            public string Street { get; }
            public string House { get; }
            public string Apartment { get; }


            public RegisteredDetails(string postalcode, string street, string house, string apartment)
            {
                PostalCode = postalcode;
                Street = street;
                House = house;
                Apartment=apartment;
            }


        }

        public struct MainOwnerDetail
        {
            public string Pesel { get; }
            public string Name { get; }
            public string Surname { get; }
            public string PhoneNUmber { get; }
            public string Email { get; }
            public string IBAN { get; }

            public MainOwnerDetail( string pesel, string name,string surname, String phonenumber, string email, string iBAN)
            {
                Pesel = pesel;
                Name = name;
                Surname = surname;
                PhoneNUmber = phonenumber;
                Email = email;
                IBAN = iBAN;

            }

        }

        public static List<string> Numbers()
        {
            List<string> list = new List<string>();
            string HouseNumber = "2";
            string ApartamentNumber = "3";
            string VinNumber = "VBBF5435HTJ6RRGY6";

            list.Add(HouseNumber);
            list.Add(ApartamentNumber);
            list.Add(VinNumber);
            return list;
        }
    }
}
