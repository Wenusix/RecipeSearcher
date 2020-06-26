using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyszukiwarka_Przepisów
{
    class Recipe : RecipeModel
    {
        public double Rating { get; private set; }
        public List<string> Ingredients { get; private set; }
        public int TotalTime { get; private set; }
        public int Portions { get; private set; }
        public Difficulty Difficulty { get; private set; }
        public Image Image { get; private set; }


        public static RecipeBuilder GetBuilder()
        {
            return new RecipeBuilder();
        }

  

        private Recipe(string id, string title, double rating, List<string> ingredients, int totalTime, int portions, string difficulty, string image) : base(id, title)
        {
            Rating = rating;
            Ingredients = ingredients;
            TotalTime = totalTime;
            Portions = portions;
            using (System.Net.WebClient webClient = new System.Net.WebClient())
            {
                using (Stream stream = webClient.OpenRead(image))
                {
                    Image = Image.FromStream(stream);
                }
            }
            switch (difficulty.ToLower())
            {
                case "easy": Difficulty = Difficulty.EASY; break;
                case "medium": Difficulty = Difficulty.MEDIUM; break;
                case "advanced": Difficulty = Difficulty.ADVANCED; break;
                default: Difficulty = Difficulty.OTHER; break;
            }
        }

        public string GetDifficultyText()
        {
            switch (Difficulty)
            {
                case Difficulty.EASY: return "Łatwy";
                case Difficulty.MEDIUM: return "Średni";
                case Difficulty.ADVANCED: return "Zaawansowany";
                default: return "Brak";
            }
        }

        public RecipeModel toModel()
        {
            return recipeModelFactory(Id, Title);
        }
        
        public string GetRatingStars()
        {
            int rate = (int) Math.Round(Rating, MidpointRounding.AwayFromZero);
            string toReturn = "";
            for(int i = 0; i < rate; i++)
            {
                toReturn += "✰";
            }
            return toReturn;
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
            private string image;

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
            public RecipeBuilder Image(string image)
            {
                this.image = image;
                return this;
            }

            public Recipe Build()
            {
                return new Recipe(id, title, rating, ingredients, totaltime, portions, difficulty, image);
            }

        }
    }


    enum Difficulty
    {
        EASY, MEDIUM, ADVANCED, OTHER

    }
}
