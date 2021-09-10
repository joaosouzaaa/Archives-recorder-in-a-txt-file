using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
    class Base : IPerson
    {
        /// <summary>
        /// Constructors
        /// </summary>
        /// <param name="name">Define the name</param>
        /// <param name="telephone">Define the telephone</param>
        /// <param name="id">Dephine the ID</param>
        public Base(string name, string telephone, string id)
        {
            this.Name = name;
            this.Telephone = telephone;
            this.ID = id;
        }
        
        public Base() { }
        // Constructor with nothing inside to other classes refer to it when it's not refering to the ones of above.
        
        public string Name;
        public string Telephone;
        public string ID;
        public void SetName(string name) { this.Name = name; }
        public void SetTelephone(string telephone) { this.Telephone = telephone; }
        public void SetID(string id) { this.ID = id; }
        //It's defying the constructors from the interface as being the ones from here.

        public virtual void Record()
        {
            var data = this.Read();
            // Verify if the archive exists and tell where to add the constructors in the archive.
            data.Add(this);
            StreamWriter writer = new StreamWriter(Local());
            writer.WriteLine("name;telephone;id");
            // Write the prase above in the .txt archive.
            foreach(Base i in data)
            {
                var line = (i.Name + ";" + i.Telephone + ";" + i.ID + ";");
                writer.WriteLine(line);
                // Set the name, telephone and id and write it in the archive.
            }
            writer.Close();
            // Stop writing in the archive.
        }

        private string Local()
        {
            return ConfigurationManager.AppSettings["Database"] + this.GetType() + ".txt";
            // Set the local where the archive will be created.
        }

        public List<IPerson> Read()
        {
            var list = new List<IPerson>();
            if (File.Exists(Local()))
            {
                using (StreamReader archive = File.OpenText(Local()))
                // Creates a list from the interface and if the local exists it will create a .txt archive in this local.
                {
                    string line;
                    int i = 0;
                    while ((line = archive.ReadLine()) != null)
                    // While my file be diferent from null it will do:
                    {
                        i++;
                        if (i == 1) continue;
                        var data = line.Split(';');

                        var definer = (IPerson)Activator.CreateInstance(this.GetType());
                        // It will create a file of the especyfied type.
                        definer.SetName(data[0]);
                        definer.SetTelephone(data[1]);
                        definer.SetID(data[2]);
                        list.Add(definer);
                        // It will define the name, telephone and id on positions 0, 1 and 2 and add them to the list.
                    }
                }
            }
            
            return list;
        }
    }
}
