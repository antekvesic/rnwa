﻿using System;
using System.Collections.Generic;

#nullable disable

namespace MVC_AA.Models
{
    public partial class CurrentDeptEmp
    {
        public int EmpNo { get; set; }
        public string DeptNo { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
