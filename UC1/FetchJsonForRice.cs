using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InventoryDataManagementUC2
{
    class FetchJsonForRice
    {
        public object JsonConvert { get; private set; }

        public Rice Read(string Path)
        {

            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Rice>(json);

                }
                catch (Exception e)
                {
                    Console.WriteLine("Problem Reading file");
                    return null;
                }

            }
        }
    }
}
