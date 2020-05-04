using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class CustomerModel
    {
        /* 
         * -- bir müşterinin özelliklerini 
         * tutmak için kullandığımız nesnedir.
         * 
         * -- genellikle veriTabanlarındaki columnların 
         * karşılıklarını bir class içinde tutabilriz.
         */

        /* Field(alan) Tanımlama */
        private string firstName;

        /* Property(özellik) Tanımlama */
        public int Id { get; set; }
        public string FirstName
        {
            get { return "Syn. " + firstName; }
            set { firstName = value; }
        }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
