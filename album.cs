using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClass.Models
{
    internal class Album
    {
        public string _namealbum;
        
        public string NameAlbum
        {
            get { return _namealbum; }
            set { _namealbum = value; }
        }
        public int _nummers;
        
        public int Nummers
        {
            get { return _nummers; }
            set { _nummers = value; }
        }

        public DateTime _datum;
        
        public DateTime Datum
        {
            get { return _datum; }
            set { _datum = value; }
        }

        public int _duurt;
        
        public int Duurt
        {
            get { return _duurt; }
            set { _duurt = value; }
        }
        
        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                TimeSpan yearsAlive = now - Datum;

                return (int)(yearsAlive.TotalDays / 365);
            }
        }
        public Album()
        {

        }
        public Album(string namealbum, int nummers)
        {
            NameAlbum = namealbum;
            Nummers = nummers;
        }
        
        public override string ToString()
        {
            return $"";
        }
        
        


        
    }
}
