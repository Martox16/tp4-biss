public static class Info
{
    private static List<Pais> ListaPaises = new List<Pais>();

   private static void InicializarLista()
   {
    Pais unPais = new Pais("Argentina" , "argentina.png" ,  45000000 , new DateTime (1816,7,9) , "Cataratas");
    ListaPaises.Add(unPais);
    unPais = new Pais("Brasil" , "brasil.png" ,  145000000 , new DateTime (1822,9,7) , "Rio de Janeiro");
    ListaPaises.Add(unPais);
    unPais = new Pais("Chile" , "chile.png" ,  8000000 , new DateTime (1818,2,12) , "Pucon");
    ListaPaises.Add(unPais);
     unPais = new Pais("Francia" , "francia.png" , 67750000 , new DateTime (1792,9,22) , "Paris");
    ListaPaises.Add(unPais);
     unPais = new Pais("Israel" , "israel.png" ,  9364000 , new DateTime (1948,2,14) , "Heilat");
    ListaPaises.Add(unPais);
   }
   public static List<Pais> ListarPaises()
   {
    if (ListaPaises.Count == 0)
    {
        InicializarLista();
        
    }
    return ListaPaises;

   }
   public static Pais DetallePais(string Nombre)
   {
    Pais PaisBuscado = new Pais();
    foreach (Pais item in ListaPaises)
    {
        if (item.Nombre == Nombre)
        {
            return item;
        }
    }
    return PaisBuscado;

   }
}