using System.Dynamic;

namespace Captura;

public class Captura
{
    public int Id { get; set; }
    public int IdTreinador { get; set; }
    public int IdPokemon { get; set; }
    public int IdPokeball { get; set; }
    public bool captura { get; set; }
}





/*

                    id serial primary key
					,id_treinador int references treinador
					,id_pokemon int references pokemon
					,id_pokeball int references pokeball
					,captura bool

*/