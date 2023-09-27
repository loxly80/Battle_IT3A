using System.Windows.Shapes;

namespace Battle_IT3A
{
  public class Unit
  {
    public int HP { get; private set; }
    public int DMG { get; internal set; }
    public int Angle { get; set; }
    public int Speed { get; set; }
    public Rectangle HitBox { get; set; } = new Rectangle();

    public Unit(int hp, int dmg)
    {
      HP = hp;
      DMG = dmg;
    }
  }
}
