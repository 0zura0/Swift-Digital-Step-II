using System.Data.Entity;


namespace SWIFTtask_7_
{
    //კონსტრუქტორი რომელიც ქმნის ბაზას და აკეთებს კავშირს აღწერილ ბაზებს შორის
    public class TeacherStudent : DbContext
    {
        public TeacherStudent() : base()
        {

        }

        public DbSet<Student> Student { get; set; }
        public DbSet<teacher> teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany<teacher>(s => s.teacher)
                .WithMany(c => c.pupils)
                .Map(cs =>
                {
                    cs.MapLeftKey("StudentId");
                    cs.MapRightKey("TeacherId");
                    cs.ToTable("TeacherStudent");
                });
        }
    }
}
