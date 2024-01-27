﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Domain.Common;

public abstract class BaseEntity
{
    public  int Id { get; set; }
    public  DateTime CreatedAt { get; set; }
    public  DateTime ModifiedAt { get; set; }
}
