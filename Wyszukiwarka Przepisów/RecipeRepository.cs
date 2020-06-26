using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyszukiwarka_Przepisów
{
    class RecipeRepository : Repository<string, Recipe>
    {

        private List<Recipe> recipies;

        private static Repository<string, Recipe> repository;

        public static Repository<string, Recipe> GetRepository()
        {
            if(repository == null)
            {
                repository = new RecipeRepository();
            }
            return repository;
        }

        private RecipeRepository()
        {
            recipies = new List<Recipe>();
        }

        public void Clear()
        {
            recipies.Clear();
        }

        public List<Recipe> FindAll()
        {
            return recipies;
        }

        public Recipe FindById(string id)
        {
            return recipies.Find(v => v.Id.Equals(id));
        }

        public void Save(Recipe entity)
        {
            Recipe toFind = FindById(entity.Id);
            if (toFind != null)
            {
                recipies.Remove(toFind);
            }
            recipies.Add(entity);
        }

        public void SaveAll(List<Recipe> list)
        {
            if (recipies.Count > 0) { 
                List<Recipe> saved = recipies;
                recipies = new List<Recipe>(recipies.Count+list.Count); // Optymalizacja
                recipies.AddRange(saved);
                foreach(Recipe entity in list)
                {
                    Save(entity);
                }
                return;
            }
            recipies = new List<Recipe>(list);
        }
    }
}
