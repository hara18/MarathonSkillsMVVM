//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarathonSkills2020.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Timesheet_
    {
        public int TimesheetId { get; set; }
        public int StaffId { get; set; }
        public System.DateTime StartDateTime { get; set; }
        public System.DateTime EndDateTime { get; set; }
        public string PayAmount { get; set; }
    
        public virtual Staff_ Staff_ { get; set; }
    }
}
