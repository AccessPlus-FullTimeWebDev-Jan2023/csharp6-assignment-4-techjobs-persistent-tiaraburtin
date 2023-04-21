﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }
        public int EmployerId { get; set; }

        public List<SelectListItem>? Employers { get; set; }
        public AddJobViewModel(List<Employer> employers  )
    {
        Employers = new List<SelectListItem>();

         foreach (var employer in employers)
   {
         Employers.Add(new SelectListItem
         {
            Value = employer.Id.ToString(),
            Text = employer.Name
         });
   }
}

       
    }
}

