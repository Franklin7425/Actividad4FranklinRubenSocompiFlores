using SistemaGestion.BSS;
using SistemaGestion.Modelos;
using SistemaGestion.VISTA.ClienteVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion.VISTA.PedidoVistas
{
    public partial class CalcularPedidosVista : Form
    {
        
        public CalcularPedidosVista()
        {
            InitializeComponent();
        }
        public static int IdClienteSeleccionado = 0;
        ClienteBss bsscliente = new ClienteBss();
        private void button3_Click(object sender, EventArgs e)
        {
            ClienteListarVista fr = new ClienteListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = bsscliente.ObtenerClienteIdBss(IdClienteSeleccionado);
                textBox1.Text = cliente.Nombre;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string nombreCliente = textBox1.Text.Trim();
            DataTable clientes = bsscliente.ListarClientesBass().AsEnumerable()
                                    .Where(row => row.Field<string>("nombre").Equals(nombreCliente, StringComparison.OrdinalIgnoreCase))
                                    .CopyToDataTable();
            if (clientes.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró ningún cliente con ese nombre.");
                return;
            }
            int idCliente = clientes.Rows[0].Field<int>("idcliente");
            PedidoBss pedidoBss = new PedidoBss();
            DataTable pedidosCliente = pedidoBss.ListarPedidoBass().AsEnumerable()
                                        .Where(row => row.Field<int>("idcliente") == idCliente)
                                        .CopyToDataTable();
            decimal totalMontosPedidos = 0;
            foreach (DataRow row in pedidosCliente.Rows)
            {
                totalMontosPedidos += row.Field<decimal>("total");
            }
            pedidosCliente.Columns.Add("TotalMontos", typeof(decimal));
            foreach (DataRow row in pedidosCliente.Rows)
            {
                row["TotalMontos"] = totalMontosPedidos;
            }
            dataGridView1.DataSource = pedidosCliente;
        }

    }

    
}
