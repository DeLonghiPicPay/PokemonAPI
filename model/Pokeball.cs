using System.Dynamic;

namespace Pokeball
{
    public class Pokeball
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public decimal PctProbabilidade { get; set; }
    }
}




/*

                    id serial primary key
					,id_treinador int references treinador
					,id_pokemon int references pokemon
					,id_pokeball int references pokeball
					,captura bool

*/