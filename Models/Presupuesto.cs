/*Presupuestos
○ int IdPresupuesto
○ string nombreDestinatario
○ date FechaCreacion
○ List<PresupuestoDetalle> detalle
○ Metodos
■ MontoPresupuesto ()
■ MontoPresupuestoConIva() //considerar iva 21
■ CantidadProductos () //contar total de productos (sumador de
todas las cantidades del detalle)*/

public class Presupuesto
{
    public int IdPresupuesto { get; set; }
    public DateOnly FechaCreacion { get; set; }
    public string nombreDestinatario { get; set; }
    public List<PresupuestoDetalle> detalle { get; set; }

}