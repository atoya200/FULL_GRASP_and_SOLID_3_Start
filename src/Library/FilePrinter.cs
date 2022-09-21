using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrinter: IPrinter
{
     // Separamos por tipos las funciones de imprimir por un destino o el otro, aplicando el patrón de Polimorfismo.
    // En este caso, quedo el destino de en un archivo por el tipo FilePrinter.
    public void PrintRecipe(Recipe recipe)
    {
        File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
    }
}
}

