using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyszukiwarka_Przepisów
{
    class Recipe
    {
        public string Id { get; private set; }
        public string Title { get; private set; }
        public double Rating { get; private set; }
        public List<string> Ingredients { get; private set; }
        public int TotalTime { get; private set; }
        public int Portions { get; private set; }
        public Difficulty Difficulty { get; private set; }

        public Image GetPhoto()
        {
            using (System.Net.WebClient webClient = new System.Net.WebClient())
            {
                using (Stream stream = webClient.OpenRead("https://assets.tmecosys.com/image/upload/t_web767x639/img/recipe/vimdb/"+Id))
                {
                    return Image.FromStream(stream);
                }
            }
        }

        public static RecipeBuilder GetBuilder()
        {
            return new RecipeBuilder();
        }

        public string GetLink()
        {
            return "https://cookidoo.pl/recipes/recipe/pl/" + Id;
        }

        private Recipe(string id, string title, double rating, List<string> ingredients, int totalTime, int portions, string difficulty)
        {
            Id = id;
            Title = title;
            Rating = rating;
            Ingredients = ingredients;
            TotalTime = totalTime;
            Portions = portions;
            switch (difficulty.ToLower())
            {
                case "easy": Difficulty = Difficulty.EASY; break;
                case "medium": Difficulty = Difficulty.MEDIUM; break;
                case "advanced": Difficulty = Difficulty.ADVANCED; break;
                default: Difficulty = Difficulty.OTHER; break;
            }
        }



        public class RecipeBuilder
        {
            private string id;
            private string title;
            private double rating;
            private List<string> ingredients = new List<string>();
            private int totaltime;
            private int portions;
            private string difficulty;

            public RecipeBuilder Id(string id)
            {
                this.id = id;
                return this;
            }
            public RecipeBuilder Title(string title)
            {
                this.title = title;
                return this;
            }
            public RecipeBuilder Rating(double rating)
            {
                this.rating = rating;
                return this;
            }
            public RecipeBuilder Ingredient(string ingredient)
            {
                this.ingredients.Add(ingredient);
                return this;
            }
            public RecipeBuilder TotalTime(int totaltime)
            {
                this.totaltime = totaltime;
                return this;
            }
            public RecipeBuilder Portions(int portions)
            {
                this.portions = portions;
                return this;
            }
            public RecipeBuilder Difficulty(string difficulty)
            {
                this.difficulty = difficulty;
                return this;
            }

            public Recipe Build()
            {
                return new Recipe(id, title, rating, ingredients, totaltime, portions, difficulty);
            }

        }
    }


    enum Difficulty
    {
        EASY, MEDIUM, ADVANCED, OTHER

    }
}
