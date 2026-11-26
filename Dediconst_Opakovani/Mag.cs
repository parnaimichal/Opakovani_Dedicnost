namespace Dediconst_Opakovani;

public class Mag : Bojovnik
{
    protected int mana;
     public Mag(string jmeno, int zivoty, int sila, int mana)
         : base(jmeno, zivoty, sila)
         {
            this.mana = mana;
         }

         public override void Utok(Bojovnik cil)
         {
             if (mana >= 20)
             {
                 Console.WriteLine($"{jmeno} používá magický útok na {cil.jmeno}!");
                 cil.PrijmiZraneni(sila * 3);
                 mana -= 20;
             }
             else
             {
                 cil.PrijmiZraneni(sila);
             }
         }
}
 
 