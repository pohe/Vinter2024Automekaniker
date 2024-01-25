using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinter2024Automekaniker
{
    public class Owner : Person
    {
        public string Title { get; set; }

        public Owner(string name, string phone, string title)
            : base(name, phone)
        {
            Title = title;
        }

        public override string ToString()
        {
            return $"OwnerID: {Id}, Name: {Name}, Phone: {Phone}, title: {Title}";
        }

    }
}
