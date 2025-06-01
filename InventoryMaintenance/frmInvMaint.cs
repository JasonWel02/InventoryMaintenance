using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
    {
        /*
         * Signature: Jason Welsh
         * This Constructor will allow me to drag and drop objects on the designer. 
         */
        public frmInvMaint()
        {
            InitializeComponent();
        }

        // Add a statement here that declares the list of items.
        public static List<InvItem> invItems;

        /*
         * Signature: Jason Welsh
        */
        private void frmInvMaint_Load(object sender, EventArgs e)
        {
            // Add a statement here that gets the list of items.
            var invItem = InvItemDB.GetItems();

            invItems = invItem;

            FillItemListBox();
        
        }
        /*
         * Signature: Jason Welsh
         */
        private void FillItemListBox()
        {
            InvItem invItem = new InvItem();
            lstItems.Items.Clear();
            // Add code here that loads the list box with the items in the list.
            foreach(var item in invItems)
            {
                lstItems.Items.Add(invItem.GetDisplayText(item.ItemNo, item.Description, item.Price));

            }
        }
        /*
         * Signature: Jason Welsh
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add code here that creates an instance of the New Item form
            frmNewItem newItem = new frmNewItem();
            // and then gets a new item from that form.
            var invItem = newItem.GetNewItem();
            invItems.Add(invItem);

            if (invItem != null)
            {
                InvItemDB.SaveItems(invItems);
            }
            FillItemListBox();
        }

        /*
         * Signature: Jason Welsh
         */
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstItems.SelectedIndex;
            if (i != -1)
            {
                // Add code here that displays a dialog box to confirm
                ConfirmDelete deleteForm = new ConfirmDelete();

                deleteForm.StartPosition = FormStartPosition.CenterScreen;
                var decision = deleteForm.ShowDialog(this);



                // if the deletion is confirmed.
                if (decision == DialogResult.OK)
                {
                // the deletion and then removes the item from the list,
                    invItems.RemoveAt(i);
                // saves the list of products, and refreshes the list box
                    InvItemDB.SaveItems(invItems);
                    FillItemListBox();
                }
                if (decision == DialogResult.Cancel)
                {
                    deleteForm.Close();
                }


            }
        }

        /*
         * Signature: Jason Welsh
         */
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
