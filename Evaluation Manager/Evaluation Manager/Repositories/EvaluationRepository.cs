using DBLayer;
using Evaluation_Manager.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.Repositories
{
    public class EvaluationRepository
    {
        public static Evaluation GetEvaluation(Student student, Activity activity)
        {
            Evaluation evaluation = null;
            string sql = $"SELECT * FROM Evaluation" + 
                $"WHERE IdStudent = {student.Id} AND IdActivity = {activity.Id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                evaluation = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return evaluation;
        }

        private static Evaluation CreateObject(SqlDataReader reader)
        {
            /* Dosent work need to fiw it (the solution is push on github of the techer)
         Activity = ActivityRepository.GetActivity(
             int.Parse(reader["IdActivity"].ToString())
             ),
         Student = StudentRepository.GetStudent(
             int.Parse(reader["IdStudents"].ToString))
             ),
         Evaluator = TeacherRepository.GetTeacher(
             int.Parse(reader["Evaluation"].ToString))
             );*/
            return null;
        }
    }
}
