namespace Dediconst_Opakovani;

public class Lucistnik : Bojovnik
{
    Random rnd = new Random();
  public Lucistnik(string jmeno, int zivoty, int sila)
   : base(jmeno, zivoty, sila)
  {

  }

  public override void Utok(Bojovnik cil)
  {
      if (rnd.Next(100) < 25)
      {
          Console.WriteLine($"{jmeno} provedl KRITICKÝ ZÁSAH!");
          cil.PrijmiZraneni(sila * 2);
          
      }
      else
      {
          Console.WriteLine($"{jmeno} vystřelil na {cil.jmeno}!");
          cil.PrijmiZraneni(sila);
      }
      
      
  }

  
 
 
  
  
  
}