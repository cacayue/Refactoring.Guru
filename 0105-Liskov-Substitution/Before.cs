using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0105_Liskov_Substitution.Before
{
    public class Docmuent
    {
        public string Data { get; set; }

        public string  FileName { get; set; }

        public string Open()
        {
            return Data;
        }

        public virtual void Save() {
            Console.WriteLine("save");
        }
    }

    public class ReadOnlyDoc: Docmuent
    {
        public override void Save()
        {
            throw new Exception("只读不能修改");
        }
    }

    public class Project
    {
        public List<Docmuent> Docmuents { get; set; }

        public Project(List<Docmuent> docmuents)
        {
            Docmuents = docmuents;
        }

        public void OpenAll()
        {
            foreach (var docmuent in Docmuents)
            {
                docmuent.Open();
            }
        }

        public void SaveAll()
        {
            foreach (var docmuent in Docmuents)
            {
                // 遗漏该判断容易导致异常
                if (!(docmuent is ReadOnlyDoc))
                {
                    docmuent.Save();
                }
            }
        }
    }
}
