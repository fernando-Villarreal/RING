using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class FourthControlUser : UserControl 
    {
        public FourthControlUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea confirmar su orden?", "Confirmación de Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Su compra ha sido confirmada");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea confirmar su orden?", "Confirmación de Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Su compra ha sido confirmada");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea confirmar su orden?", "Confirmación de Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Su compra ha sido confirmada");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
