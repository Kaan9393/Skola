namespace CodeAlongSTRUCT
{
    struct SpecialUser        //En ny struct
    {
        public const string Name = "Anna Andersson";
        public string Location { get; set; }
        public int Age { get; set; }

        public SpecialUser(string location, int age)
        {
            Location = location;
            Age = age;
        }
    }
}
