﻿namespace _3._Data.Model
{
    public class ModelBase
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool IsActive { get; set; }
    }
}
