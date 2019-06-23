using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApplication
{
    enum Status
    {
        open,
        done
    }
    class Todo
    {
        public int number { get; set; }
        public string name { get; set; }
        public int status { get; set; }

        public Todo(string line)
        {
            string[] bits = line.Split(',');
            int number, status;
            Int32.TryParse(bits[0], out number);
            string name = bits[1];
            Int32.TryParse(bits[2],out status);
            this.name = name;
            this.number = number;
            this.status = status;
        }
        public string toCSV()
        {
            return number + "," +  name + "," + status;
        }
    }
}
