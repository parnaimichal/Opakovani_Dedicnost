namespace Dediconst_Opakovani;

public class Rytir : Bojovnik
{
    protected int brneni; 
        
    public Rytir(string jmeno, int zivoty, int sila, int brneni)
        : base(jmeno, zivoty, sila)
    {
        this.brneni = brneni;
    }

    public override void PrijmiZraneni(int zraneni)
    {
        base.PrijmiZraneni(zraneni * (1 - brneni/100));
        
    }

    public override string ToString()
    {
        return base.ToString() + $", brnění {brneni}";
    }
    
}