using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        private string title;
        private string name;
        private int age;
        private string address1, address2, address3, address4, postcode;
        public Person() { }
        public string Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return this.name;
            }
        }
        public string Title
        {
            set
            {
                this.title = value;
            }
            get
            {
                return this.title;
            }
        }
        public string Address1
        {
            set
            {
                this.address1 = value;
            }
            get
            {
                return this.address1;
            }
        }
        public string Address2
        {
            set
            {
                this.address2 = value;
            }
            get
            {
                return this.address2;
            }
        }
        public string Address3
        {
            set
            {
                this.address3 = value;
            }
            get
            {
                return this.address3;
            }
        }
        public string Address4
        {
            set
            {
                this.address4 = value;
            }
            get
            {
                return this.address4;
            }
        }
        public int Age
        {
            set
            {
                if ((value > 0) && (value < 120))
                {
                    this.age = value;
                }
            }
            get
            {
                return this.age;
            }

        }
        public string Postcode
        {
            set
            {
                this.postcode = value;
            }
            get
            {
                return this.postcode;
            }
        }
    }
}
