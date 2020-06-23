namespace EF_ExistingDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Students
    {
        public int ID { get; set; }

        public string StudentName { get; set; }

        public string Course { get; set; }

        public int Age { get; set; }
    }
}
