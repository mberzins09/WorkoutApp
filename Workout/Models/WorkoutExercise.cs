using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Models
{
    public class WorkoutExercise
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int WorkoutId { get; set; }
        public int ExerciseId { get; set; }

        public int OrderInWorkout { get; set; }
    }

}
