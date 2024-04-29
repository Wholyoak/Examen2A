using Examen2A;

///Empleado por Proyectos
EmpleadoPorProyecto EmpleadoProyecto = new EmpleadoPorProyecto();
GestorRecursosHumanos GestorRRHHProyectos = new GestorRecursosHumanos(EmpleadoProyecto);
ListarEmpleados listar = new ListarEmpleados();
Console.WriteLine("******* Explicación del Calculo de Bonificación **********");
Console.WriteLine("si es menor de 270 horas al mes el bono es de: S/. 0.00   ");
Console.WriteLine("si pasa mas de 270 horas al mes el bono es de: S/. 200.00 ");
Console.WriteLine("si pasa mas de 300 horas al mes el bono es de: S/. 400.00 ");
Console.WriteLine("si pasa mas de 360 horas al mes el bono es de: S/. 800.00 ");
Console.WriteLine("************* Fin del Calculo de Bonificación ************");
Console.WriteLine(" ");
Console.WriteLine("******************* Lista de empleados *******************");

//Empleado empleado1 = new Empleado
//{
//    Id = 1,
//    Nombre = "Wilmer Holyoak",
//    SalarioPorHora = 50
//};
//EmpleadoProyecto.CantidadHorasTrabajadas = 300;
//GestorRRHHProyectos.CalcularPagos(empleado1);
//Console.WriteLine(" ");

//Empleado empleado2 = new Empleado
//{
//    Id = 2,
//    Nombre = "Robert Navarro",
//    SalarioPorHora = 60
//};
//EmpleadoProyecto.CantidadHorasTrabajadas = 380;
//GestorRRHHProyectos.CalcularPagos(empleado2);
listar.listarEmpleados(1, "Wilmer Holyoak", 60, "PorProyecto",300,0);
listar.listarEmpleados(2, "Carlos Cabrera", 55, "PorProyecto", 280,0);
listar.listarEmpleados(3, "Juan Perez", 70, "PorProyecto", 50,0);
listar.listarEmpleados(4, "Marco Polo", 60, "TiempoCompleto",270, 1);
listar.listarEmpleados(5, "Diego Flores", 100, "TiempoCompleto", 300, 1);
listar.listarEmpleados(6, "Pedro Quezada", 80, "TiempoCompleto", 250, 1);

Console.Read();