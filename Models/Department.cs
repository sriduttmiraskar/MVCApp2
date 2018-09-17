using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp2.Models
{
    [MetadataType(typeof(DeptMetaData))]
    public partial class Dept
    {

    }

    public class DeptMetaData
    {
        [Display(Name = "Department Name")]
        public string Name { get; set; }
    }
}