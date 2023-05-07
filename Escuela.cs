public class Escuela
{
    public string Matricula { get; set; }
    public string Nombre { get; set; }
    public string ApellidoP { get; set; }
    public string ApellidoM { get; set; }
    public DateTime FechaN { get; set; }
    public string CURP { get; set; }

    public Escuela(string matricula, string nombre, string apellidoP, string apellidoM, DateTime fechaN, string curp)
    {
        Matricula = matricula;
        Nombre = nombre;
        ApellidoP = apellidoP;
        ApellidoM = apellidoM;
        FechaN = fechaN;
        CURP = curp;
    }
}
