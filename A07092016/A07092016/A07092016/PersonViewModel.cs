using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A07092016
{
    public class PersonViewModel : IPersonViewModel
    {
        List<Person> personList = new = List < Person() >;
        public PersonViewModel()
        {
            personList.Add(new Person("Anders", "And", ""));
        }
        
    }
}
