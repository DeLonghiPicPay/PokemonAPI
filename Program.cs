using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Pokemon;

public class Program
{
    private static readonly HttpClient client = new HttpClient();

    public static async Task Main(string[] args)
    {
        while (true)
        {
        bool nomeExiste = false;
        do{
            Console.Write("Digite o nome do seu pokemon: ");
            string pokemonName = Console.ReadLine(); //the EndPoint
            string url = "https://pokeapi.co/api/v2/pokemon/" + pokemonName;

            try
            {
                // Send request and deserialize JSON response into the Pokemon model
                Pokemon.Pokemon pokemon = await client.GetFromJsonAsync<Pokemon.Pokemon>(url);

                // Output the result
                Console.WriteLine($"ID: {pokemon.Id}");
                Console.WriteLine($"Name: {pokemon.Name}");
                foreach(Abilities ability in pokemon.Abilities)
                { //For para percorrer as habilidades
                    Console.WriteLine($"Abilities Slot: {ability.Slot}");
                    Console.WriteLine($"Ability Name: {ability.Ability.Name}");
                    Console.WriteLine($"Ability URL: {ability.Ability.Url}");
                    Console.WriteLine($"Is Hidden: {ability.IsHidden}");
                }
                Console.WriteLine($"Height: {pokemon.Height}");
                Console.WriteLine($"Weight: {pokemon.Weight}");
                nomeExiste = true;
            }
            catch (HttpRequestException e)
            {
                nomeExiste = false;
                Console.WriteLine("Request error: " + e.Message);
                Console.WriteLine("Nome Inexistente!");
            }
        } while(!nomeExiste);
    
        }
    }
}


