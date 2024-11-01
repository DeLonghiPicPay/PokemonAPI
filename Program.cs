using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Pokemon;
using Model.Categoria;
public class Program
{
    private static readonly HttpClient client = new HttpClient();

    public static async Task Main(string[] args)
    {
        await GetPokeballAsync("master-ball");
    }
    public static async Task/*<Pokeball.Pokeball>*/ GetPokeballAsync(string ball) //Voltar retorno dps de printar
    {
        Console.WriteLine("Entrou");
        string url = "https://pokeapi.co/api/v2/item-category/34/";

        // Send request and deserialize JSON response into the Pokemon model

        Categoria pokeball = await client.GetFromJsonAsync<Categoria>(url);

        // Output the result
        foreach(Item item in pokeball.Items)
        {
            if(item.Name == ball){
                Console.WriteLine(item.Url);
            }
        }
    }
}


