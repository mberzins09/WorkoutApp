using Microsoft.EntityFrameworkCore;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimaryKeyAttribute = SQLite.PrimaryKeyAttribute;

namespace Workout.Models
{
    public class Exercise
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public int MuscleGroupId { get; set; } // FK to MuscleGroup
        public int HardnessLevel { get; set; } // 1–5
        public int WorkoutTimeSeconds { get; set; }

        public string VideoUrl { get; set; }

        public int? EquipmentId { get; set; } // FK to Equipment (nullable)

        public int SessionNr { get; set; }

        // Many-to-many (Restrictions)
        public List<ExerciseRestriction> Restrictions { get; set; } = new();
        public List<ExerciseMuscleGroup> MuscleGroups { get; set; } = new();
        public List<ExerciseEquipment> Equipments { get; set; } = new();
    }

}
