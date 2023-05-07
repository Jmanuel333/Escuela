using System;
using System.Collections.Generic;

public class Maestros
{
    public List<(string Matricula, string Nombre, string ApellidoP, string ApellidoM, DateTime FechaN, string CURP)> DatosMaestros { get; set; }

    public Maestros()
    {
        DatosMaestros = new List<(string Matricula, string Nombre, string ApellidoP, string ApellidoM, DateTime FechaN, string CURP)>
        {
            ("16-0164", "ANGELA YAZMIN", "XULUC", "POOT", new DateTime(1999, 8, 19), "XUPA990819MQRLTN06"),
            ("16-0165", "JESUS ALEJANDRO", "GIL", "UC", new DateTime(2001, 6, 5), "GIUJ010605HYNLCSA2"),
            ("16-0166", "FERNANDA VIANEY", "LOPEZ", "UH", new DateTime(1998, 7, 8), "LOUF980708MQRPHR02"),
            ("16-0167", "AMERICA CITLALI", "MARTINEZ", "SARMIENTO", new DateTime(2001, 10, 08), "MASA011008MQRRRMA9"),
            ("16-0168", "WALDEMAR", "SILVAN", "GALLEGOS", new DateTime(2001, 01, 01), "SIGW010101HCCLLLA4"),
            ("16-0169", "ANGELA YAZMIN", "XULUC", "POOT", new DateTime(1999, 8, 19), "XUPA990819MQRLTN06"),
            ("16-0170", "JESUS ALEJANDRO", "GIL", "UC", new DateTime(2001, 6, 5), "GIUJ010605HYNLCSA2"),
            ("16-0171", "FERNANDA VIANEY", "LOPEZ", "UH", new DateTime(1998, 7, 8), "LOUF980708MQRPHR02"),
            ("16-0172", "AMERICA CITLALI", "MARTINEZ", "SARMIENTO", new DateTime(2001, 10, 09), "MASA011009MQRRRMA9"),
            ("16-0173", "WALDEMAR", "SILVAN", "GALLEGOS", new DateTime(2001, 01, 01), "SIGW010101HCCLLLA4"),
            ("16-0174", "ANGELA YAZMIN", "XULUC", "POOT", new DateTime(1999, 8, 19), "XUPA990819MQRLTN06"),
            ("16-0175", "JESUS ALEJANDRO", "GIL", "UC", new DateTime(2001, 6, 5), "GIUJ010605HYNLCSA2"),
            ("16-0176", "FERNANDA VIANEY", "LOPEZ", "UH", new DateTime(1998, 7, 8), "LOUF980708MQRPHR02"),
            ("16-0177", "AMERICA CITLALI", "MARTINEZ", "SARMIENTO", new DateTime(2001, 10, 07), "MASA011007MQRRRMA9"),
            ("16-0178", "WALDEMAR", "SILVAN", "GALLEGOS", new DateTime(2001, 01, 01), "SIGW010101HCCLLLA4"),
            ("16-0179", "ANGELA YAZMIN", "XULUC", "POOT", new DateTime(1999, 8, 19), "XUPA990819MQRLTN06"),
            ("16-0180", "JESUS ALEJANDRO", "GIL", "UC", new DateTime(2001, 6, 5), "GIUJ010605HYNLCSA2"),
            ("16-0181", "FERNANDA VIANEY", "LOPEZ", "UH", new DateTime(1998, 7, 8), "LOUF980708MQRPHR02"),
            ("16-0182", "AMERICA CITLALI", "MARTINEZ", "SARMIENTO", new DateTime(2001, 10, 03), "MASA011003MQRRRMA9"),
            ("16-0183", "WALDEMAR", "SILVAN", "GALLEGOS", new DateTime(2001, 01, 01), "SIGW010101HCCLLLA4"),
        };
    }
}
