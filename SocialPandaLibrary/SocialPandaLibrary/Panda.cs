using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SocialPandaLibrary
{
    public class Panda
    {
        private string name;
        private string email;
        private Gender gender;
        private List<Panda> listP;
        private Regex regex;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
                //Match match = regex.Match(email);
                //if (!match.Success)
                //{
                //    throw new IncorrectFormatEmailExcception();
                //}
            }
        }

        public Gender Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public List<Panda> ListP
        {
            get
            {
                return listP;
            }

            set
            {
                listP = value;
            }
        }

        public Panda(string name, string email, Gender gender)
        {
            regex = new Regex(@"^@([\w\-]+)((\.(\w([\w\.\-]+)){2,3})+)$");
            this.Name = name;
            Email = email;
            this.Gender = gender;
            ListP = new List<Panda>();
        }
        public override string ToString()
        {
            return $"{Name} , {Email} , {Gender}";
        }
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + Name.GetHashCode();
            hash = (hash * 7) + Email.GetHashCode();
            hash = (hash * 7) + Gender.GetHashCode();
            return hash;
        }
        public override bool Equals(object obj)
        {
            Panda pand = (Panda)obj;
            if (pand.Email.Equals(this.Email) && pand.Gender.Equals(this.Gender) && pand.Name.Equals(this.Name))
            {
                return true;
            }
            return false;
        }
        public void Befriend(Panda panda)
        {
            if (ListP.Contains(panda))
            {
                throw new Exception();///TO DO CUSTOM EXC
            }
            ListP.Add(panda);
        }
    }

    public enum Gender
    {
        male, female
    }
}
