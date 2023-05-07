using System;
using System.Collections.Generic;

class Administrativos
{
    public List<Administrativo> ListaAdministrativos { get; set; }

    public Administrativos()
    {
        ListaAdministrativos = new List<Administrativo>()
        {
            new Administrativo("16-0170", "MARIA VIANEY", "SUASTE", "CATZIN", new DateTime(2001, 8, 4), "SUCV010804MQRSTNA5"),
            new Administrativo("16-0171", "AYLIN GUADALUPE", "VARGUEZ", "SOBERANIS", new DateTime(2000, 11, 20), "VASA001120MQRRBYA5"),
            new Administrativo("16-0172", "MARIA", "ARCOS", "DIAZ", new DateTime(1997, 8, 31), "AODM970831MCSRZR01"),
            new Administrativo("16-0170", "MARIA VIANEY", "SUASTE", "CATZIN", new DateTime(2001, 8, 4), "SUCV010804MQRSTNA5"),
            new Administrativo("16-0171", "AYLIN GUADALUPE", "VARGUEZ", "SOBERANIS", new DateTime(2000, 11, 20), "VASA001120MQRRBYA5"),
            new Administrativo("16-0172", "MARIA", "ARCOS", "DIAZ", new DateTime(1997, 8, 31), "AODM970831MCSRZR01"),new Administrativo("16-0170", "MARIA VIANEY", "SUASTE", "CATZIN", new DateTime(2001, 8, 4), "SUCV010804MQRSTNA5"),
            new Administrativo("16-0171", "AYLIN GUADALUPE", "VARGUEZ", "SOBERANIS", new DateTime(2000, 11, 20), "VASA001120MQRRBYA5"),
            new Administrativo("16-0172", "MARIA", "ARCOS", "DIAZ", new DateTime(1997, 8, 31), "AODM970831MCSRZR01"),
             new Administrativo("16-0170", "MARIA VIANEY", "SUASTE", "CATZIN", new DateTime(2001, 8, 4), "SUCV010804MQRSTNA5"),
            new Administrativo("16-0171", "AYLIN GUADALUPE", "VARGUEZ", "SOBERANIS", new DateTime(2000, 11, 20), "VASA001120MQRRBYA5"),
             new Administrativo("16-0170", "MARIA VIANEY", "SUASTE", "CATZIN", new DateTime(2001, 8, 4), "SUCV010804MQRSTNA5"),
            new Administrativo("16-0171", "AYLIN GUADALUPE", "VARGUEZ", "SOBERANIS", new DateTime(2000, 11, 20), "VASA001120MQRRBYA5"),
            new Administrativo("16-0172", "MARIA", "ARCOS", "DIAZ", new DateTime(1997, 8, 31), "AODM970831MCSRZR01"),
            new Administrativo("16-0170", "MARIA VIANEY", "SUASTE", "CATZIN", new DateTime(2001, 8, 4), "SUCV010804MQRSTNA5"),
            new Administrativo("16-0171", "AYLIN GUADALUPE", "VARGUEZ", "SOBERANIS", new DateTime(2000, 11, 20), "VASA001120MQRRBYA5"),
        };
    }
}

class Administrativo
{
    public string Matricula { get; set; }
    public string Nombre { get; set; }
    public string ApellidoP { get; set; }
    public string ApellidoM { get; set; }
    public DateTime FechaN { get; set; }
    public string CURP { get; set; }

    public Administrativo(string matricula, string nombre, string apellidoP, string apellidoM, DateTime fechaN, string curp)
    {
        Matricula = matricula;
        Nombre = nombre;
        ApellidoP = apellidoP;
        ApellidoM = apellidoM;
        FechaN = fechaN;
        CURP = curp;
    }
}
