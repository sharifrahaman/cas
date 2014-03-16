﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CAS.Models
{
    public class IELTS
    {
        [Key, ForeignKey("EnglishProficiency")]
        public int Id { get; set; }
        public double OverallScore { get; set; }
        public double Reading { get; set; }
        public double Writting { get; set; }
        public double Listening { get; set; }
        public double Speaking { get; set; }

        public EnglishProficiency EnglishProficiency { get; set; }
    }
}