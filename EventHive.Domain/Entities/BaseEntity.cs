﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHive.Domain.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            this.CreatedDate = DateTime.UtcNow;
        }
        public Guid Id { get; set; }
        public Guid CreatedBy { get; set; }
        public string? CreatedByName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
