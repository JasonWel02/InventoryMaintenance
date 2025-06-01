using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class ConfirmDelete : Form
    {
        /* What does this Constructor do?
         * When called, it inializes the component designs for the Designer, so when I drag and drop something  
         */
        public ConfirmDelete()
        {
            InitializeComponent();
        }

        /*
         * Signature: Jason Welsh
         */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /*
         * Signature: Jason Welsh
         */

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /*
         * Signature: Jason Welsh
         */

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        /*
         * Signature: Jason Welsh
         */
        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        /*
         * Signature: Jason Welsh
         */
        private void ConfirmDelete_Load(object sender, EventArgs e)
        {

        }
    }
}
