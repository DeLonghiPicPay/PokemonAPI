namespace Pokemon
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Abilities> Abilities {get;set;}
        public int Height { get; set; }
        public decimal Weight { get; set; }
        public override string ToString()
        {
            return $"{Id}";
        }
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
/*
O que fazer:
O software vai se basear principalmente em um sistema de captura de pokemon
Ou seja, vai ter uma entidade "captura" que vai conter o pokemon, a pokeball, o treinador
(usuário) e talvez mais algumas coisas. Cada pokeball terá uma probabilidade de capturar
o pokemon especificado, e será feito um calculo pra saber se foi possível capturar ou não.
É necessário receber da api o  

*/

