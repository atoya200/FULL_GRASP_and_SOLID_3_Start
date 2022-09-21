using System;
namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter: IPrinter
{
     // Separamos por tipos las funciones de imprimir por un destino o el otro, aplicando el patrón de Polimorfismo.
    // En este caso, quedo el destino da salida por consola,  por el tipo ConsolPrinter.
    public void PrintRecipe(Recipe recipe)
    {
        Console.WriteLine(recipe.GetTextToPrint());
    }
}
}