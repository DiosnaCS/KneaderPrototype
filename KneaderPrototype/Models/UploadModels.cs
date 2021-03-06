﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Mvc;

namespace KneaderPrototype.Upload.Models
{
    public class UploadFile
    {
        /// <summary>
        /// Model for upload file to upload (9_Upload) directory
        /// </summary>
        [Required]
        [DataType(DataType.Upload)]
        [Display(Name = "Upload File")]
        public HttpPostedFileBase File { get; set; }

        public string plcName {get; set;}
    } 
}