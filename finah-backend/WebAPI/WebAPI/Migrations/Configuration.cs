namespace WebAPI.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebAPI.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAPI.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(WebAPI.Models.ApplicationDbContext context)
        {
            var vragen = new List<Vraag>
            {
                new Vraag { Beschrijving = "Uitvoeren van dagelijkse routinehandelingen" },
                new Vraag { Beschrijving = "Iets nieuws leren (zoals het leren omgaan met bijv. een nieuwe GSM, vaatwasmachine of afstandsbediening; leren ikv een hobby)"},
                new Vraag { Beschrijving = "Denken (zoals fantaseren, een mening vormen, met ideeën spelen, of nadenken)"},
                new Vraag { Beschrijving = "Lezen (zoals boeken, instructies, kranten, in tekst of in braille)"},
                new Vraag { Beschrijving = "Rekenen (zoals gepast betalen bij een winkel)"}
            };

            vragen.ForEach(v => context.Vragen.AddOrUpdate(p => p.Id, v));
            context.SaveChanges();

            var antwoorden = new List<Antwoord>
            {
                new Antwoord { RapportId = 1, VraagId = 1, AntwoordInt = 0, AntwoordExtra = 0, Verzorger = true },
                new Antwoord { RapportId = 1, VraagId = 2, AntwoordInt = 1, AntwoordExtra = 0, Verzorger = false },
                new Antwoord { RapportId = 1, VraagId = 3, AntwoordInt = 2, AntwoordExtra = 1, Verzorger = true },
                new Antwoord { RapportId = 1, VraagId = 4, AntwoordInt = 3, AntwoordExtra = 2, Verzorger = false },
                new Antwoord { RapportId = 1, VraagId = 5, AntwoordInt = 4, AntwoordExtra = 1, Verzorger = true }
            };

            antwoorden.ForEach(a => context.Antwoorden.AddOrUpdate(p => p.Id, a));
            context.SaveChanges();

            var rapporten = new List<Rapport>
            {
                new Rapport { NaamVerzorger = "Jan Peeters", NaamPatient = "Rita Dewael", Date =  DateTime.Now},
                new Rapport { NaamVerzorger = "Jan Peeters", NaamPatient = "Carlos Santana", Date =  DateTime.Now},
                new Rapport { NaamVerzorger = "Jan Peeters", NaamPatient = "Pierre Depardieux", Date =  DateTime.Now},
                new Rapport { NaamVerzorger = "Peter Janssens", NaamPatient = "Annabel Terdolen", Date =  DateTime.Now},
                new Rapport { NaamVerzorger = "Peter Janssens", NaamPatient = "Bart Strauven", Date =  DateTime.Now},
            };

            rapporten.ForEach(r => context.Rapporten.AddOrUpdate(p => p.Id, r));
            context.SaveChanges();

        }

    }
}
