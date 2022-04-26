﻿using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace web.EF
{
    public class PersonalDataModel: BasicModel
    {
        [Key]
        public Guid Id { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string NoneFatherName { get; set; }
        public string PreviousLastName { get; set; }
        public string FullNamePatronymicInTheGenitiveCase { get; set; }
        public string Sex { get; set; }
        public string DateOfBirth { get; set; }
        public bool RefusalOfIndividualPersonalNumber { get; set; }
        public int IndividualPersonalNumber { get; set; }
        public string Email { get; set; }
        public bool ЬaritalІtatus { get; set; }
        public string Note { get; set; }
        public virtual IdentityUser User { get; set; }
        public virtual PlaceOfBirthModel PlaceOfBirth { get; set; }
        public virtual BloodTypeModel BloodType { get; set; }
        public virtual StatusModel Status { get; set; }
    }
}
