﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrialWebAPI1.Entity
{
    public class Book
    {
        public int ID { get; set; }
        public string Judul { get; set; }
        public string Penulis { get; set; }
        public string Deskripsi { get; set; }
        public string Penerbit { get; set; }
        public bool Status { get; set; }
        public string Gambar { get; set; }
        public bool isAvailable { get; set; }
    }
}
