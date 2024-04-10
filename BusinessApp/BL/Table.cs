using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BL
{
    public class Table
    {
        private int ID;
        private int Capacity;
        private string Status;

        public Table(int capacity)
        {
            Capacity = capacity;
        }

        public Table(int capacity, int id, string status) : this(capacity)
        {
            ID = id;
            Status = status;
        }

        public int GetCapacity()
        {
            return Capacity;
        }

        public string GetStatus() 
        {
            return Status;
        }

        public int GetID()
        {
            return ID;
        }

        public void SetCapacity(int c)
        {
            Capacity = c;
        }

        public void SetStatus(string status)
        {
            Status = status;
        }
    }
}
