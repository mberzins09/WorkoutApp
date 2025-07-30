using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workout.Models;

namespace Workout.Services
{
    public class WorkoutDatabase
    {
        private readonly SQLiteAsyncConnection _db;

        public WorkoutDatabase(string dbPath)
        {
            _db = new SQLiteAsyncConnection(dbPath);
            _ = Init();
        }

        private async Task Init()
        {
            await _db.CreateTableAsync<Exercise>();
            await _db.CreateTableAsync<Workouts>();
            await _db.CreateTableAsync<WorkoutExercise>();
            await _db.CreateTableAsync<MuscleGroup>();
            await _db.CreateTableAsync<Equipment>();
            await _db.CreateTableAsync<RestrictionTag>();
            await _db.CreateTableAsync<ExerciseRestriction>();
            await _db.CreateTableAsync<ExerciseMuscleGroup>();
            await _db.CreateTableAsync<ExerciseEquipment>();

        }

        // Add CRUD methods here...
    }

}
