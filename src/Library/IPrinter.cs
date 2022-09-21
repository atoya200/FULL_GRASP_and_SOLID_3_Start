namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
    {
        // Este tipo es el que sirve para imprimir en general.
        // Nace de aplicar el patrón de Polimorfismo.
        // Todos los tipos que implementen a este usarán el método PrintRecipe, todos van a imprimir la recete de la forma que creen más convenientes. 
        public void PrintRecipe(Recipe recipe);
    }
    
}