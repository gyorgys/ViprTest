using oneDrive;
namespace TestApp
{
    public class OneDriveListItem
    {
        public Iitem Item;
        
        /// <summary>
        /// Initializes a new instance of the OneDriveListItem class.
        /// </summary>
        public OneDriveListItem(Iitem item)
        {
            this.Item = item;
        }

        public override string ToString()
        {
            string itemName;
            if (Item.folder != null)
            {
                if (Item.folder.childCount > 0)
                {
                    itemName = "[+] " + Item.name;
                }
                else
                {
                    itemName = "[ ] " + Item.name;
                }
            }
            else
            {
                if (Item.photo != null)
                {
                    itemName = " ⃞  " + Item.name;
                }
                else
                {
                    itemName = "    " + Item.name;
                }
            }
            return itemName;
        }

    }
}