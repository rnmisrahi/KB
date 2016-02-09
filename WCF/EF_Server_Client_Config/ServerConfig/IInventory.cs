using ServerConfig.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServerConfig
{
    [ServiceContract]
    interface IInventory
    {
        [OperationContract]
        int DbAddItem(String name, int quantity);

        [OperationContract]
        int DbAddQuantity(int itemId, int quantity);

        [OperationContract]
        int DbSubtractQuantity(int itemId, int quantity);

        [OperationContract]
        List<Item> DbGetItems();

        [OperationContract]
        void DbRemoveItem(int id);

        [OperationContract]
        Item DbGetItem(int id);

        [OperationContract]
        void DbSaveItem(Item newItem);

        [OperationContract]
        void DbClearItems();
    }
}
