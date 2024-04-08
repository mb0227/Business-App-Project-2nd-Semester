using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.BL;

namespace RMS.DL
{
    public interface ITableDL
    {
        int GetReservedTableID(int customerid);
        void UpdateTablesStatus(int tableID);
        void UpdateTablesStatus();
        int GetTableCapacity(int id);
        void DeleteTable(int id);
        void UpdateTable(Table t);
        List<Table> GetTables();
        Table GetTableById(int id);
        void SaveTable(Table table);
            
    }
}
