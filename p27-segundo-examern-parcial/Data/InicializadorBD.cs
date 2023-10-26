public class InicializadorBD {
    public static void Inicializar(ContextoDatos contexto) {
        if(contexto.Articulos.Any()) {

            return;

        }
       var Articulos = new Articulo[] {
new Articulo {Descripcion="Pala cuadrada",FechaAlta=DateTime.Parse("1/1/2023"),Cantidad=11,Precio=300.45,UdeMedida="Pieza"},
new Articulo {Descripcion="Pinzas de chofer",FechaAlta=DateTime.Parse("10/2/2024"),Cantidad=12,Precio=299.0,UdeMedida="Pieza"},
new Articulo {Descripcion="Tiner",FechaAlta=DateTime.Parse("10/2/223"),Cantidad=14,Precio=10,UdeMedida="Litro"},
new Articulo {Descripcion="Manguera para regar",FechaAlta=DateTime.Parse("15/5/2022"),Cantidad=12,Precio=35,UdeMedida="Metro"}
};
        contexto.Articulos.AddRange(Articulos);
        contexto.SaveChanges();
    }
}