namespace Dediconst_Opakovani;

public class Nekromant : Mag
{
   
    
    public Nekromant(string jmeno, int zivoty, int sila, int mana)
        : base(jmeno, zivoty, sila, mana)
    {
     
    }

    public override void Utok(Bojovnik cil)
    {
        base.Utok(cil);
        if (cil.JeZivy() == false)
        {
            Lecba();
        }
    }

    public void Lecba()
    {
        Uzdrav(30);
    }
}