﻿using System;
using System.Linq;
using static System.Console;

namespace EduHub.Data.Samples
{
    public static class NavigationSample
    {
        public static void Run()
        {
            WriteLine();
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Navigation Sample");
            ForegroundColor = ConsoleColor.White;
            WriteLine("Selects all active students, then creates anonymous types which contain their home town and post code using the [FAMILY_DF] and [HOMEKEY_UM] navigation properties.");
            WriteLine();

            // Create an EduHubContext
            var Context = new EduHubContext();

            // Test for availability of data sets
            if (!Context.ST.IsAvailable || !Context.DF.IsAvailable || !Context.UM.IsAvailable)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("The ST, DF and UM Data Sets must be available to complete this query");
                return;
            }

            // Data Updated
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("eduHub Updated: {0:G}", Context.Age);

            // Build Query
            var activeStudentTowns = (
                from st in Context.ST
                let family = st.FAMILY_DF
                let home = family.HOMEKEY_UM
                where st.STATUS == "ACTV"
                orderby st.SCHOOL_YEAR, st.HOME_GROUP
                select new
                {
                    StudentCode = st.STKEY,
                    HomeGroup = st.HOME_GROUP,
                    YearLevel = st.SCHOOL_YEAR,
                    Town = home.ADDRESS03,
                    PostCode = home.POSTCODE
                });

            // Write Headers to Console
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"{"Code",-7} {"HG",-4} {"YL",-4} {"Town",-30} {"PC",-4}");

            // Write Data to Console
            ForegroundColor = ConsoleColor.Gray;
            foreach (var student in activeStudentTowns) // Evaluate Query
            {
                WriteLine($"{student.StudentCode,-7} {student.HomeGroup,-4} {student.YearLevel,-4} {student.Town,-30} {student.PostCode,-4}");
            }
        }
    }
}
