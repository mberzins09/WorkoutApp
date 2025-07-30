using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Models
{
    public class MuscleGroup
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; } // e.g., "Ikrs", "Vēderprese"
    }

}
