using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Identity;

namespace UP.Areas.Identity.Data;

// Add profile data for application users by adding properties to the UPUser class
public class UPUser : IdentityUser
{

    [Display(Name = "First Name")]
    [Required(ErrorMessage = "First Name is required!")]
    [StringLength(20, ErrorMessage = "First Name can have max 20 characters")]
    public string? Firstname { get; set; }

    [Display(Name = "Last Name")]
    [Required(ErrorMessage = "Last Name is required!")]
    [StringLength(20, ErrorMessage = "Last Name can have max 20 characters")]
    public string? Lastname { get; set; }

    [Display(Name = "Middle Name")]
    public string? Middlename { get; set; }

    [Display(Name = "Title")]
    public string? Title { get; set; }

    [Display(Name = "Gender")]
    [Required(ErrorMessage = "Gender is required!")]
    public string? Gender { get; set; }


    [Required(ErrorMessage = "Address is required!")]
    [DataType(DataType.MultilineText)]
    [Display(Name = "Address")]
    public string? Address { get; set; }

    [Required(ErrorMessage = "Username is required!")]
    [Display(Name = "Username")]
    public string? Usern { get; set; }

    [Display(Name = "Role")]
    public string? Role { get; set; }
    public byte[]? ProfilePicture { get; set; }


}

