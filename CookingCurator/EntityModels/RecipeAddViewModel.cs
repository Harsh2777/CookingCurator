﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.ComponentModel;

namespace CookingCurator.EntityModels
{
    public class RecipeIngred
    {
        public int recipe_ID { get; set; }
        public int ingred_ID { get; set; }
        public int diet_ID { get; set; }
    }

    public class RecipeAddViewForm
    {
        [Required]
        [DisplayName("Recipe Title")]
        public string title { get; set; }

        [DisplayName("User rating")]
        public int rating { get; set; }

        [Required]
        [DisplayName("Instructions")]
        public string instructions { get; set; }

        [DisplayName("Date Last Updated")]
        public System.DateTime lastUpdated { get; set; }

        [DisplayName("Author")]
        public string author { get; set; }

        [DisplayName("Verified Status")]
        public bool verified { get; set; }

        [DisplayName("Source ID #")]
        public Nullable<int> source_ID { get; set; }

        [DisplayName("Source Link")]
        [DataType(DataType.Url)]
        public string source_Link { get; set; }

        [Required]
        [DisplayName("Country of Origin")]
        public string country { get; set; }

        [Required]
        [DisplayName("Meal Type")]
        public string mealTimeType { get; set; }

        [HiddenInput]
        public byte[] Content { get; set; }

        [HiddenInput]
        public string Content_Type { get; set; }

        [Required]
        [DisplayName("Ingredient Selection")]
        public string[] selectedIngredsId { get; set; }

        public IEnumerable<IngredientBaseViewModel> ingredients;

        [DisplayName("Diet Types")]
        public string[] selectedDietsId { get; set; }

        public IEnumerable<DietDescViewModel> diets;
    }

    public class RecipeAddViewModel
    {
        [Required]
        [DisplayName("Recipe Title")]
        public string title { get; set; }

        [DisplayName("User rating")]
        public int rating { get; set; }

        [Required]
        [DisplayName("Instructions")]
        public string instructions { get; set; }

        [DisplayName("Date Last Updated")]
        public System.DateTime lastUpdated { get; set; }

        [Required]
        [DisplayName("Author")]
        public string author { get; set; }

        [DisplayName("Verified Status")]
        public bool verified { get; set; }

        [DisplayName("Source ID #")]
        public Nullable<int> source_ID { get; set; }

        [DisplayName("Source Link")]
        public string source_Link { get; set; }

        [Required]
        [DisplayName("Country of Origin")]
        public string country { get; set; }

        [Required]
        [DisplayName("Meal Type")]
        public string mealTimeType { get; set; }

    }

    public class RecipeVerifiedAddViewModel
    {
        [Required]
        [DisplayName("Recipe Title")]
        public string title { get; set; }

        [DisplayName("User rating")]
        public int rating { get; set; }

        [Required]
        [DisplayName("Instructions")]
        public string instructions { get; set; }

        [DisplayName("Date Last Updated")]
        public System.DateTime lastUpdated { get; set; }

        [Required]
        [DisplayName("Author")]
        public string author { get; set; }

        [DisplayName("Verified Status")]
        public bool verified { get; set; }

        [DisplayName("Source ID #")]
        public Nullable<int> source_ID { get; set; }

        [Required]
        [DataType(DataType.Url)]
        [DisplayName("Source Link")]
        public string source_Link { get; set; }

        [Required]
        [DisplayName("Country of Origin")]
        public string country { get; set; }

        [Required]
        [DisplayName("Meal Type")]
        public string mealTimeType { get; set; }

        [HiddenInput]
        public byte[] Content { get; set; }

        [HiddenInput]
        public string Content_Type { get; set; }

        [Required]
        [DisplayName("Ingredient Selection")]
        public string[] selectedIngredsId { get; set; }

        public IEnumerable<IngredientBaseViewModel> ingredients;

        [DisplayName("Diet Types")]
        public string[] selectedDietsId { get; set; }

        public IEnumerable<DietDescViewModel> diets;
    }
}