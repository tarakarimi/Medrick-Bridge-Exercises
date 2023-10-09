using System;
using System.Collections.Generic;

public class PlayerData
{
    public string Username { get; set; }
    public int Level { get; set; }
    public string Guild { get; set; }
    public List<string> Items { get; set; }
    public string SkinId { get; set; }

    public PlayerData(string username = "defaultUser", int level = 0, string guild = null, List<string> items = null, string skinId = null)
    {
        Username = username;
        Level = level;
        Guild = guild;
        Items = items;
        SkinId = skinId;
    }
}