namespace Entidad.Almacen
{
    public class Bodega
    {
        public Bodega() {

        }
        public Bodega(int codigo,string nombre)
        {
            this.idBodega = idBodega;
            this.descripcion = descripcion;
        }
        public int idBodega { get; set; }
        public string descripcion { get; set; }
    }
}
