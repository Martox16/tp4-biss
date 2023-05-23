public class Pais
{
    public string Nombre{get;private set;}
    public string imgBandera{get;private set;}
    public int Poblacion{get;private set;}
    public DateTime FechaIndependencia{get;private set;}
    public string AtractivosTuristicos{get;private set;}

    public Pais()
    { 
    }
    public Pais(string nom, string imgBan, int pob, DateTime FI, string AT)
    {
        Nombre = nom;
        imgBandera =imgBan;
        Poblacion = pob;
        FechaIndependencia =FI;
        AtractivosTuristicos = AT;
    }
}