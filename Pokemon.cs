namespace Pokemon
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<TypeSlot> Types { get; set; }
        public List<Abilities> Abilities {get;set;}
        public int Height { get; set; }
        public decimal Weight { get; set; }
    }

    public class TypeSlot
    {
        public int Slot { get; set; }
        public TypeSlotDetail Type { get; set; }

    }
    public class TypeSlotDetail
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
    public class Abilities
    {
        public Ability Ability {get;set;}
        public bool IsHidden {get;set;}
        public int Slot {get;set;}

    }
    public class Ability
    {
        public string Name {get;set;}
        public string Url {get;set;}
    }
}

/*

int id;
string nome;
string [] abilities;
decimal height;
decimal weight;

*/