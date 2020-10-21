using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Customers.Concretes
{
    class Customers
    {
        #region Properties(özellikler)

        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string City { get; set; }    
        
        #endregion

        #region Fields (Alanlar)

        //string _name;
        //string _surname;
        int age;

        #endregion

        #region Behaviors(Davranışlar)

        //public void SetName(string name)
        //{
        //    _name = name;
        //}

        //public string GetName()
        //{
        //    return _name;

        //}

        //public void SetSurname(string surname)
        //{
        //    _surname = surname;
        //}

        //public string GetSurname()
        //{
        //    return _surname;
        //}

        public void SetAge(int age)
        {
            this.age = age;
        }

        public int GetAge()
        {
            return age;
        }
        #endregion


    }
}
