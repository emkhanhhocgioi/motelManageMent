using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motelManageMent.Model
{
    public class Admin
    {
       private string _id;
       private string _name;
       private string _email;
       private string _password;
       private string _phone;
       public Admin() { }

       public Admin(string a, string b,string c ,string d,string e) {
        this._id = a;   
        this._name = b;
        this._email = c;
        this._password = d;
        this._phone = e;
        }

        public string Id { get { return _id; } }
        public string Name { get { return _name; } }
        public string Email { get { return _email; } }
        public string Password { get { return _password; } }
        public string Phone { get { return _phone; } }
         
        public void setName(string text)
        {
            this._name= text;
        }
        public void setEmail(string text)
        {
            this._email = text;
        }
        public void setPassword(string text)
        {
            this._password = text;
        }
        public void setPhone(string text)
        {
            this._phone = text;
        }
        public void setId(string text)
        {
            this._id = text;
        }
    }
}
