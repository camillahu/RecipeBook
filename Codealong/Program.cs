//Du skal lage en oppskriftsapp der brukeren kan velge å:
//Se alle oppskrifter som er tilgjengelig,
//    Filtrere oppskrift basert på kategori; ex vegetar, helgekos,
//    Filtrere oppskriftene ved å søke etter oppskrifter som inneholder en spesifikk ingrediens
//    Brukeren skal kunne velge å se nærmere på en oppskrift for å få ingredienser og fremgangsmetode


using Codealong;
using Codealong.Commands;
using Codealong.Commands.Commands;

var mainMenu = new MainMenu();

while (true)
{
    mainMenu.Run();
}






//List<Recipe> Recipes = new List<Recipe>
//{
//    new Pizza("Vegetar Pizza", 2),
//    new Pizza("Pepperoni Pizza", 1),
//};




// void PrintInfo()
//{
//    foreach (var recipe in Recipes)
//    {
//        Console.WriteLine("Name: " + recipe.GetName());
//        Console.WriteLine("Vasklighetsgrad: " + recipe.GetDifficulty());
//    }
//};






 
// void Filter()
// { 
//     string input = Console.ReadLine();
//    foreach (var recipe in Recipes.Where(r=> r.GetCategory() == input))
//    {
//        Console.WriteLine("Name: " + recipe.GetName());
//        Console.WriteLine("Vasklighetsgrad: " + recipe.GetDifficulty());
//    }
//}