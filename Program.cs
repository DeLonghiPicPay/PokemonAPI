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
        string url = "https://pokeapi.co/api/v2/pokemon/pikachu"; // Replace with your API endpoint
        try
        {
            // Send request and deserialize JSON response into the Pokemon model
            Pokemon.Pokemon pokemon = await client.GetFromJsonAsync<Pokemon.Pokemon>(url);

            // Output the result
            Console.WriteLine($"ID: {pokemon.Id}");
            Console.WriteLine($"Name: {pokemon.Name}");
            foreach (TypeSlot typeSlot in pokemon.Types)
            { //For para percorrer os tipos
                Console.WriteLine($"Type Slot: {typeSlot.Slot}");
                Console.WriteLine($"Type Name: {typeSlot.Type.Name}");
                Console.WriteLine($"Type URL: {typeSlot.Type.Url}");
            }
            foreach(Abilities ability in pokemon.Abilities)
            { //For para percorrer as habilidades
                Console.WriteLine($"Abilities Slot: {ability.Slot}");
                Console.WriteLine($"Ability Name: {ability.Ability.Name}");
                Console.WriteLine($"Ability URL: {ability.Ability.Url}");
                Console.WriteLine($"Is Hidden: {ability.IsHidden}");
            }
            Console.WriteLine($"Height: {pokemon.Height}");
            Console.WriteLine($"Weight: {pokemon.Weight}");
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("Request error: " + e.Message);
        }
    }
}
