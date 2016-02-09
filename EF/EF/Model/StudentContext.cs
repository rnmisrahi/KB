using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Model
{
    public class StudentContext:DbContext
    {
        //If we don't use a parameter, the name will also be the whole path:
        // EF.Model.StudentContext
        //Also, if we use the Initializer, then the DB name will be "CodeFirst_Student", otherwise the name
        //  uses the whole path of the project: EF.Model.StudentContext
        //  How can we create the DB without initializing? By just "using it" like adding a record.
        //In that case, the name "CodeFirst_Student" will be ignored. Apparently what gives the name to
        //  the DB is this parameter along with the initialization of the DB.
        public StudentContext():base("CodeFirst__Student")
        {

        }

        public DbSet<Student> Students { get; set; }

    }
}
