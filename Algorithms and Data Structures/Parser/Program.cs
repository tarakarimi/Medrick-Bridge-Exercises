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
    }
}
