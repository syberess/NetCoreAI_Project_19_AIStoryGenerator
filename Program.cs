﻿using System.Text;
using System.Text.Json;

class Program
{
    private static readonly string apiKey = "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";

    static async Task Main()
    {
        Console.Write("Hikaye Türünü seçiniz(Macera,Korku, Bilim Kurgu, Fantastik, Komedi):");
        string genre = Console.ReadLine();

        Console.Write("Ana karekteriniz kim: ");
        string character = Console.ReadLine();

        Console.Write("Hikaye nerede geçiyor:");
        string setting = Console.ReadLine();

        Console.Write("Hikayenin uzunluu(kısa/orta/uzun):");
        string length = Console.ReadLine();

        string prompt = $"{genre} türünde bir hikaye yaz. Baş karekterin adı {character} . Hikaye {setting} bölgesinde geçiyor. {length} bir hikaye olsun.Giriş ,gelişme , sonuç içermeli.";

        string story = await GenerateStory(prompt);
        Console.WriteLine();
        Console.WriteLine("----- AI Tarafında Oluşturulan Hikaye -----");
        Console.WriteLine(story);
    }

    static async Task<string> GenerateStory(string prompt)
    {
        var client = new HttpClient();
        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

        var requestBody = new
        {
            model = "gpt-3.5-turbo",
            messages = new[]
            {
                new { role = "system", content = "You are a creative story writer" },
                new { role = "user", content = prompt }
            },
            max_tokens = 1000

        };

        var jsonContent = new StringContent(JsonSerializer.Serialize(requestBody), Encoding.UTF8, "application/json");
        HttpResponseMessage response = await client.PostAsync("https://api.openai.com/v1/chat/completions", jsonContent);

        string responseContent = await response.Content.ReadAsStringAsync();
        JsonDocument doc = JsonDocument.Parse(responseContent);
        return doc.RootElement.GetProperty("choices")[0].GetProperty("message").GetProperty("content").GetString();

    }
}