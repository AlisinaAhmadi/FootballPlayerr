namespace FootballPlayerr
{
    public class FootballPlayer
    {
        public int Id { get; set; }

         public string Name { get; set; }
            
 
         public int age  { get; set; }
        public int ShirtNumber { get; set; }


        public void ValidateName()
        {
            if (Name.Length < 2) throw new ArgumentException("name must be at least 2 character: " + Name);
        }
        public void Validateage()
        {
            if (age <= 1) throw new ArgumentOutOfRangeException(" age must be greater than 1: " + age);
        }
        public void ValidateShirtNumber()
        {
            if (ShirtNumber < 1 || ShirtNumber > 99) throw new ArgumentNullException("ShirtNumber must be minimum 1 and maximum 8: " + ShirtNumber);

        }
        public void Validate()
        {
            ValidateName();
            Validateage();
            ValidateShirtNumber();
        }
        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(age)}={age},{nameof(ShirtNumber)} = {ShirtNumber.ToString()}}}";


        }
    }
}