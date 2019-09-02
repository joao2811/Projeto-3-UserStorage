using System;
using System.ComponentModel.DataAnnotations;

namespace projeto.WebAPI.Models
{
    public class GameAccount
    {
        [Key]
        public int Account_ID{get;set;}
        public string Account_Username{get;set;}
        public string Account_Email{get;set;}
        public string Account_Birthday{get;set;}
        public string Account_RegistrationDate{get;}
        public string Account_Password{get;set;}
        public string Account_Telephone{get;set;}

        public GameAccount(){}
        public GameAccount(int AccountID, string accountUsername, string accountEmail, string accountBirthday, string accountPassword, string accountTelephone)
        {
            this.Account_ID = AccountID;
            this.Account_Username = accountUsername;
            this.Account_Email = accountEmail;
            this.Account_Birthday = accountBirthday;
            this.Account_RegistrationDate = DateTime.Now.ToString("dd/MM/yyyy");
            this.Account_Password = accountPassword;
            this.Account_Telephone = accountTelephone;
        }

    }
}