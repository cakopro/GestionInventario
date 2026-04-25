namespace GestionInventario.Model
{
    public class DetalleVenta
    {
        public string Producto { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }

        public double Subtotal
        {
            get { return Precio * Cantidad; }
        }
    }
}
