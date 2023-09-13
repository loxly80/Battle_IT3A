using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace Battle_IT3A
{
  public class Unit
  {
    private int hp;   
    public int HP
    {
      get => hp;
      private set => Math.Max(Math.Min(value, 1000), 0);
    }

    public int DMG { get; internal set; } = 10;
    public int Angle { get; set; } = 0;
    public int Speed { get; set; } = 0;
    public Rectangle HitBox { get; set; } = new Rectangle();

    public Unit(int hp, int dmg)
    {
      HP = hp;
      DMG = dmg;
    }
  }
}
