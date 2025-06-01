using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmNewItem : Form
    {
        /*
         * This constructor allows me to drag and drop tools in the designer.
         */
        public frmNewItem()
        {
            InitializeComponent();
        }

        // Add a statement here that declares the inventory item.
        public static InvItem invItems;

        // Add a method here that gets and returns a new item.

        /*
         * Signature: Jason Welsh
         */
        public InvItem GetNewItem()
        {
            
            frmNewItem form = new frmNewItem();
            form.ShowDialog();

            return invItems;
            
            
        }
        /*
         * Signature: Jason Welsh
         */
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                frmNewItem form = new frmNewItem();

                // Add code here that creates a new item
                invItems = new InvItem(int.Parse(txtItemNo.Text), txtDescription.Text, Decimal.Parse(txtPrice.Text));
                

                // and closes the form.
                this.Close();

            }
        }

        /*
         * Signature: Jason Welsh
         */
        private bool IsValidData()
        {
            return Validator.IsPresent(txtItemNo) &&
                   Validator.IsInt32(txtItemNo) &&
                   Validator.IsPresent(txtDescription) &&
                   Validator.IsPresent(txtPrice) &&
                   Validator.IsDecimal(txtPrice);
        }

        /*
         * Signature: Jason Welsh
         */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
