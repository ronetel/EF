//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace yp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employees
    {
        public int id_employee { get; set; }
        public string name_emp { get; set; }
        public string surname_emp { get; set; }
        public string midlname_emp { get; set; }
        public Nullable<int> position_id { get; set; }
        public System.DateTime hire_date { get; set; }
        public int salary { get; set; }
    
        public virtual Positions Positions { private get; set; }
    }
}
