/*Productos
○ int idProducto
○ string descripcion
○ int precio*/

using Microsoft.AspNetCore.Mvc;

public class Productos
{
    public int idProducto { get; set; }
    public string descripcion { get; set; }
    public int precio { get; set; }

}


public class ProductosController: Controller
{
 private ProductoRepository productoRepository;
 public ProductosController()
 {
productoRepository= new ProductoRepository();
 }
}