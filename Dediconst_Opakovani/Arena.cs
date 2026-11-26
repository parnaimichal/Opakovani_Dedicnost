namespace Dediconst_Opakovani;

public class Arena
{
    public Arena()
    {
        
    }
    
    public static Bojovnik Souboj(Bojovnik a, Bojovnik b)
    {
        while (a.JeZivy() && b.JeZivy())
        {
            a.Utok(b);

            if (a.JeZivy())
            {
                b.Utok(a);
            }
        }

        if (a.JeZivy())
        {
            return a;
        }
        else 
            return b;
    }
}