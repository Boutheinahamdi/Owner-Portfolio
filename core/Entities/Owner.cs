namespace core.Entities
{
    public class Owner : EntityBase
    {
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public string Profil { get; set; }
        public Adresse adresse { get; set; }
    }

}
