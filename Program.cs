boxeador boxeador1 = new boxeador();
boxeador boxeador2 = new boxeador();
int opcion;


do
{
    Console.WriteLine("1. Cargar datos Boxeador I");
    Console.WriteLine("2. Cargar datos Boxeador II");
    Console.WriteLine("3. Pelear!!");
    Console.WriteLine("4. Salir");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            boxeador1 = ingresarBoxeador();
        break;

        case 2:
            boxeador2 = ingresarBoxeador();
        break;

        case 3:
            pelear();
        break;

    }

}while (opcion != 4);


void pelear()
{
    if (boxeador1 != null && boxeador2 != null)
    {
        if (boxeador1.ObtenerSkill() > boxeador2.ObtenerSkill())
    {
        if (boxeador1.ObtenerSkill() >= 30)
        {
            Console.WriteLine("Ganó " + boxeador1.nombre + " por KO");
        }
        else if (boxeador1.ObtenerSkill() >= 10 && boxeador1.ObtenerSkill() <= 30)
        {
            Console.WriteLine("Ganó " + boxeador1.nombre + " por puntos en fallo unanime");
        }
        else if (boxeador1.ObtenerSkill() < 10)
        {
            Console.WriteLine("Ganó " + boxeador1.nombre + " por puntos en fallo dividio");
        }
    }
    else if (boxeador2.ObtenerSkill() >= 30)
        {
            Console.WriteLine("Ganó " + boxeador2.nombre + " por KO");
        }
        else if (boxeador2.ObtenerSkill() >= 10 && boxeador2.ObtenerSkill() <= 30)
        {
            Console.WriteLine("Ganó " + boxeador2.nombre + " por puntos en fallo unanime");
        }
        else if (boxeador2.ObtenerSkill() < 10)
        {
            Console.WriteLine("Ganó " + boxeador2.nombre + " por puntos en fallo dividio");
        }
    }
    
}


boxeador ingresarBoxeador()
{
    string nombre = ingresarNombre("Ingrese el nombre del boxeador");
    string pais = ingresarPais("Ingrese el pais del boxeador");
    int peso = ingresarPeso("Ingrese el peso del boxeador");
    double velocidadPiernas = ingresarVelocidad("Ingrese la velocidad de las piernas del boxeador");
    double potenciaGolpes = ingresarpotencia("Ingrese la potencia del boxeador");

    boxeador unBoxeador = new boxeador(nombre, pais, peso, velocidadPiernas, potenciaGolpes);
    return unBoxeador;
}


double ingresarpotencia(string msj)
{
    double potencia;
    Console.WriteLine(msj);
    potencia=double.Parse(Console.ReadLine());
    while (potencia<0 && potencia>100)
    {
        Console.WriteLine("Incorrecto. Vuelve a Ingresar la potencia");
        potencia=double.Parse(Console.ReadLine());
    }
    return potencia;
}

double ingresarVelocidad(string msj)
{
    double vel;
    Console.WriteLine(msj);
    vel=double.Parse(Console.ReadLine());
    while (vel<0 && vel>100)
    {
        Console.WriteLine("Incorrecto. Vuelva a ingresar la velocidad de las piernas");
        vel=double.Parse(Console.ReadLine());
    }
    return vel;
}


int ingresarPeso(string msj)
{
    int peso;
    Console.WriteLine(msj);
    peso = int.Parse(Console.ReadLine());
    return peso;
}

string ingresarPais(string msj)
{
    string pais;
    Console.WriteLine(msj);
    pais = (Console.ReadLine());
    return pais;
}

string ingresarNombre(string msj)
{
    string nombre;
    Console.WriteLine(msj);
    nombre = Console.ReadLine();
    return nombre;
}
