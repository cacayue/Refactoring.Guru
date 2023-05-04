using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0105_Liskov_Substitution
{
    public class Docmuent
    {
        public string Data { get; set; }

        public string FileName { get; set; }

        public string Open()
        {
            return Data;
        }
    }

    public class WritableDoc : Docmuent
    {
        public void Save()
        {
            Console.WriteLine("Save");
        }
    }

    public class Project
    {
        public List<Docmuent> AllDocmuents { get; set; }

        public List<WritableDoc> WritableDocmuents { get; set; }

        public Project(List<Docmuent> docmuents, List<WritableDoc> writableDocmuents)
        {
            AllDocmuents = docmuents;
            WritableDocmuents = writableDocmuents;
        }

        public void OpenAll()
        {
            foreach (var docmuent in AllDocmuents)
            {
                docmuent.Open();
            }
        }

        public void SaveAll()
        {
            foreach (var docmuent in WritableDocmuents)
            {
                docmuent.Save();
            }
        }
    }
}
