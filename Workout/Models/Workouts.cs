﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Models
{
    public class Workouts
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        // Navigation
        public List<WorkoutExercise> Exercises { get; set; } = new();
    }

}
