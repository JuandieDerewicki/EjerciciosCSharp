// See https://aka.ms/new-console-template for more information


double[] alturasPoblacion; // Declaración de arreglo
alturasPoblacion = new double[10]; // Inicializacion de arreglo
int cont = 1; // Contadores
int cont2 = 1;
double resultado1 = 0; // Resultados auxiliares para las operaciones
double resultado2 = 0;
double resultado3 = 0;
double alturasMayores = 0; // Alturas mayores y menores que la media
double alturasMenores = 0;
double media = 0; // Resultado de la media
double resultadoVarianza = 0; // Resultado de varianza (paso previo para encontrar la desviacion estandar)
double desviacionEstandar = 0; // Resultado de la desviacion estandar
double resulRangoP = 0; // Resultado de la suma de media + desviacion estandar
double resulRangoN = 0; // Resultado de la suma de media - desviacion estandar
double rangoPos = 0; // Rango positivo
double rangoNeg = 0; // Rango negativo



// Cargar y guardar los datos en el arreglo 
for (int j = 0; j < 10; j++)
{
    Console.WriteLine($"{cont} - Ingrese la altura en cm: ");
    cont++;
    double alturas = double.Parse(Console.ReadLine());
    alturasPoblacion[j] = alturas;
}

// Impresión del arreglo 
Console.WriteLine("\nLas alturas de la poblacion son: ");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Persona {cont2} - {alturasPoblacion[i]} cm");
    cont2++;
}

/* Otra manera de sumar las variables del arreglo 
// La suma de las variables que se encuentran dentro del arreglo se pueden sacar mediante Sum o de manera manual
resultado = alturasPoblacion.Sum();
Console.WriteLine(resultado);
*/

// Media 
Console.WriteLine("\n");
for (int i = 0; i < alturasPoblacion.Length; i++)
    {
        resultado1 = resultado1 + alturasPoblacion[i];
        media = resultado1 / 10;
    }
   Console.WriteLine("La media es de " + media);

// Varianza
    for (int i = 0; i < alturasPoblacion.Length; i++)
    {
        resultado2 = media - alturasPoblacion[i];
        resultado3 = Math.Pow(resultado2, 2);
        resultadoVarianza = resultadoVarianza + resultado3;
    }

// Desviacion estandar 
Console.WriteLine("\n");
desviacionEstandar = Math.Sqrt(resultadoVarianza);
Console.WriteLine("La desviacion estandar es de " + desviacionEstandar);

// Alturas que se encuentran por debajo y por encima la media
Console.WriteLine("\n");
Console.WriteLine("Alturas que se encuentran por encima de la media: ");
for (int i = 0; i < alturasPoblacion.Length; i++)
{
    if (alturasPoblacion[i] > media)
    {
        alturasMayores = alturasPoblacion[i];
        Console.WriteLine(alturasMayores);
    }
}

Console.WriteLine("Alturas que se encuentran por debajo de la media: ");
for (int i = 0; i < alturasPoblacion.Length; i++)
{
    if (alturasPoblacion[i] < media)
    {
        alturasMenores = alturasPoblacion[i];
        Console.WriteLine(alturasMenores);
    }
}

// Alturas que se encuentran dentro del rango definido por la desviacion estandar positivo
resulRangoP = media + desviacionEstandar;
Console.WriteLine($"El rango positivo se encuentra desde {media} hasta {resulRangoP}: ");

for (int i = 0; i < alturasPoblacion.Length; i++)
{
    if (alturasPoblacion[i] > media && alturasPoblacion[i] < resulRangoP)
    {
        rangoPos = alturasPoblacion[i];
        Console.WriteLine(rangoPos);
    }
}

// Alturas que se encuentran dentro del rango definido por la desviacion estandar negativo
resulRangoN = media - desviacionEstandar;
Console.WriteLine($"El rango negativo se encuentra desde {media} hasta {resulRangoN}: ");

for (int i = 0; i < alturasPoblacion.Length; i++)
{
    if (alturasPoblacion[i] < media && alturasPoblacion[i] > resulRangoN)
    {
        rangoNeg = alturasPoblacion[i];
        Console.WriteLine(rangoNeg);
    }
}





