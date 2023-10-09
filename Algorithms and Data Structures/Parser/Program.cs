using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main()
    {
        string jsonFilePath = "E:/Medrick-Projects/JsonParser/JsonParser/data.json";
        string jsonString = File.ReadAllText(jsonFilePath);

        List<PlayerData> players = JsonConvert.DeserializeObject<List<PlayerData>>(jsonString);
        Dictionary<string, PlayerData> playerDataDictionary = new Dictionary<string, PlayerData>();
        PlayerData selectedPlayerData;

        foreach (var player in players)
        {
            playerDataDictionary.Add(player.Username, player);
        }

        bool isValidUser = false;

        while (!isValidUser)
        {
            Console.Write("Enter username: ");
            string userInput = Console.ReadLine();

            if (playerDataDictionary.TryGetValue(userInput, out selectedPlayerData))
            {
                Console.WriteLine("Info for the selected player: ");
                selectedPlayerData.Display();
                isValidUser = true;
            }
            else
            {
                Console.WriteLine("Player not found. Please try again.");
            }
        }
    }
}
