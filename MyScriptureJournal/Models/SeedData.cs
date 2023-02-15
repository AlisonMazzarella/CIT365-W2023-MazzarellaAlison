using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;

namespace MyScriptureJournal.Models;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MyScriptureJournalContext(
        serviceProvider.GetRequiredService<
            DbContextOptions<MyScriptureJournalContext>>()))
        {
            if (context == null || context.Scripture == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            // Look for any scriptures.
            if (context.Scripture.Any())
            {
                return;   // DB has been seeded
            }

            context.Scripture.AddRange(
                new Scripture
                {
                    Book = "Genesis",
                    DateAdded = DateTime.Parse("2023-2-12"),
                    Note = "Commandment",
                    Chapter = 6M,
                    Verse = 22M
                },

                new Scripture
                {
                    Book = "John",
                    DateAdded = DateTime.Parse("2022-3-13"),
                    Note = "Witness",
                    Chapter = 5.00M,
                    Verse = 31.00M
                },

                new Scripture
                {
                    Book = "Enos",
                    DateAdded = DateTime.Parse("2023-2-23"),
                    Note = "Honesty",
                    Chapter = 1.00M,
                    Verse = 6.00M
                },

                new Scripture
                {
                    Book = "Moses",
                    DateAdded = DateTime.Parse("2022-4-15"),
                    Note = "Obey",
                    Chapter = 2.00M,
                    Verse = 3.00M
                }
            );
            context.SaveChanges();
        }
    }
}