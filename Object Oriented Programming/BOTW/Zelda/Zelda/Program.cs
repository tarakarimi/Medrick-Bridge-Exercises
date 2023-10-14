using Zelda;

class Program
{
    public static void Main()
    {
        // Enemy with default values
        Enemy unknownEnemy = new Enemy();

        // Create different types of enemies
        Chuchu smallFireChuchu = new Chuchu(size: Chuchu.ChuchuSize.Small, type: Chuchu.ChuchuType.Fire);
        Wizzrobe fireWizzrobe = new Wizzrobe(type: Wizzrobe.WizzrobeType.Fire);
        Pebblit earthPebblit = new Pebblit(type: Pebblit.PebblitType.Frost);
        Moblin blueMoblin = new Moblin(type: Moblin.MoblinType.Blue);
        Lizalfos greenLizalfos = new Lizalfos(type: Lizalfos.LizalfosType.Green);
        Lynel redLynel = new Lynel(type: Lynel.LynelType.Red);

        // Call methods from enemies
        greenLizalfos.Swim();
        blueMoblin.ShieldBlock();
        redLynel.Roar();

        // Display info of the enemies
        smallFireChuchu.DisplayInfo();
    }
}