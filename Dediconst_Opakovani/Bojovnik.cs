namespace Dediconst_Opakovani;

public class Bojovnik
{
    public string jmeno { get; }
    public int zivoty { get; private set; }
    protected int maxZivoty;
    protected int sila;
    
    public Bojovnik(string jmeno, int zivoty, int sila)
    {
        this.jmeno = jmeno;
        this.maxZivoty = zivoty;
        this.zivoty = zivoty;
        this.sila = sila;
    }

    public bool JeZivy()
    {
        return zivoty > 0;
    }

    public virtual void Utok(Bojovnik cil)
    {
        Console.WriteLine($"{jmeno} útočí na {cil.jmeno}!");
        cil.PrijmiZraneni(sila);
    }

    public virtual void PrijmiZraneni(int zraneni)
    {
        zivoty -= zraneni;
        
        if (zivoty < 0)
            {
            zivoty = 0;
            }

        Console.WriteLine($"Zivoty: {zivoty}");
        
    }

    public override string ToString()
    {
        return $"{jmeno} (Bojovnik) – HP {zivoty}/{maxZivoty}, síla {sila}";
    }
    
    public void Uzdrav(int leceni)
    {
        zivoty += leceni;

        if (zivoty > maxZivoty)
        {
            zivoty = maxZivoty;
        }
        Console.WriteLine($"Zivoty: {zivoty}");
    }

    


}