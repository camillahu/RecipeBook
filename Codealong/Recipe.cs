using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Codealong
{
    internal class Recipe
    {
        protected string Name { get; set; }
        protected int Difficulty { get; set; }

        protected List<EnumCategories> Categories { get; set; }

        protected List<string> Ingredients { get; set; }

        public Recipe(string name = "Ukjent", int difficulty = 0)  //fungerer denne?
        {
            
        }
        public string GetName()
        {
            return Name; 
        }

        public int GetDifficulty()
        {
            return Difficulty;
        }

        public void SetName()
        {
            Name = Console.ReadLine();
        }

        public void SetDifficulty()
        {
            Difficulty = Convert.ToInt32(Console.ReadLine());
        }

        public void AddCategory()
        {
            
        }

        //public List<EnumCategories> GetCategory()
        //{
        //    return Categories;
        //}

        public void GetIngredients()
        {

        }
    }
}
