using System.Dynamic;

namespace Model.Categoria;
public class Categoria
{
    public int Id { get; set; }
    public List<Item> Items { get; set; }

    public decimal PctProbabilidade { get; set; }
}
public class Item()
{   //Isso vai deixar de existir, só vou deixar aqui para testar mesmo
    public string Name { get; set; } 
    public string Url { get; set; }
}





/*

                    id serial primary key
					,id_treinador int references treinador
					,id_pokemon int references pokemon
					,id_pokeball int references pokeball
					,captura bool

*/