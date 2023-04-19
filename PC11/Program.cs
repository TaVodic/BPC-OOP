// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using PC11.EFCore;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");

using (var context = new LibraryContext())
{
    //context.Database.Migrate();

    //FillTables(context);
    //context.SaveChanges();

    //napln data function

    //query

    //var pocty = from p in context.StudentPredmet group p by p.Predmet into g
    //orderby g.Count() descending
    //

    var studenti = StudentiPredmetu(context, "OOP");
    foreach (var student in studenti)
    {
        Console.WriteLine(student.FirstName + ' ' + student.SurName);
    }

    var predmety = PredmetyStudentov(context, 100);
    foreach (var predmet in predmety)
    {
        Console.WriteLine(predmet.AbbrvId);
    }
    /*
    var pocty = from p in context.StudentPredmet group p by p.AbbrvId into g
                orderby g.Count() descending
                select new { PredmetId = g.Key.}
    */
}



static IEnumerable<Student> StudentiPredmetu(LibraryContext context, string AbbrId)
{
    return  from sp in context.StudentPredmet
            join s in context.Student on sp.StudentId equals s.StudentId
            where sp.AbbrvId == AbbrId
            select s;
}

static IEnumerable<Subject> PredmetyStudentov(LibraryContext context, int studentId)
{
    return from sp in context.StudentPredmet
           join s in context.Subject on sp.AbbrvId equals s.AbbrvId
           where sp.StudentId == studentId
           select s;
}


static void FillTables(LibraryContext context)
{
    if (!context.Student.Any(p => p.StudentId == 100))
        context.Student.Add(new Student() { FirstName = "Martin", SurName = "Tavoda", BirthDate = 2.5, StudentId = 100 });
    if (!context.Student.Any(p => p.StudentId == 101))
        context.Student.Add(new Student() { FirstName = "Marek", SurName = "Coufal", BirthDate = 2.5, StudentId = 101 });
    if (!context.Student.Any(p => p.StudentId == 102))
        context.Student.Add(new Student() { FirstName = "Vojtech", SurName = "Drtina", BirthDate = 2.6, StudentId = 102 });
    if (!context.Subject.Any(p => p.AbbrvId == "OOP"))
        context.Subject.Add(new Subject() { AbbrvId = "OOP", Name = "Objected oriented programming"});
    if (!context.Subject.Any(p => p.AbbrvId == "MA1"))
        context.Subject.Add(new Subject() { AbbrvId = "MA1", Name = "Matematika 1" });
    if (!context.Subject.Any(p => p.AbbrvId == "MVA"))
        context.Subject.Add(new Subject() { AbbrvId = "MVA", Name = "Meranie v ELE" });

    context.StudentPredmet.Add(new StudentPredmet() { AbbrvId = "OOP", StudentId = 100});
    context.StudentPredmet.Add(new StudentPredmet() { AbbrvId = "MA1", StudentId = 100});
    context.StudentPredmet.Add(new StudentPredmet() { AbbrvId = "MA1", StudentId = 101});
    context.StudentPredmet.Add(new StudentPredmet() { AbbrvId = "MA1", StudentId = 102});
    context.StudentPredmet.Add(new StudentPredmet() { AbbrvId = "MVA", StudentId = 101});
    context.StudentPredmet.Add(new StudentPredmet() { AbbrvId = "MVA", StudentId = 102});
}
