namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
    {
        // Este tipo es el que sirve para imprimir en general.
        // Nace de aplicar el patrón de Polimorfismo.
        public void PrintRecipe(Recipe recipe);
    }
    
}