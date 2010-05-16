using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using seedsfromzion.Managers;
namespace seedsfromzion.GUI
{
    class FavoritesHasher
    {
        public FavoritesHasher()
        {
            

        }

        public String hashPlantId(string plantId)
        {
            InventoryManager manager = new InventoryManager();
            DataRow row= manager.findPlantById(plantId);
            if (row == null)
            {
                return null;
            }
            string name = (string)row["name"];
            string type = (string)row["type"];
            return String.Format(name + " מסוג " + type);

             
        }
    }
}
