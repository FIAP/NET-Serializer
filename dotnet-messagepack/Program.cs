using dotnet_messagepack.Model;
using MessagePack;

using (HttpClient client = new())
{
    string url = "http://localhost:3000"; 

    try
    {
        HttpResponseMessage response = await client.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            Stream stream = await response.Content.ReadAsStreamAsync();

            var decodedData = MessagePackSerializer.Deserialize<Pessoa>(stream);

            Console.WriteLine("Dados decodificados em C#:");
            Console.WriteLine($"Nome: {decodedData.Nome}");
            Console.WriteLine($"Idade: {decodedData.Idade}");
            Console.WriteLine($"Cidade: {decodedData.Cidade}");
        }
        else
        {
            Console.WriteLine($"Erro: {response.StatusCode}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
}

Console.ReadLine();