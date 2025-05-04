using System;
using System.Collections.Generic;

namespace ConexionDataBase.Models;

public partial class Mascotum
{
    public int IdMascota { get; set; }

    public string Nombre { get; set; } = null!;

    public string Especie { get; set; } = null!;

    public string? Raza { get; set; }

    public string Sexo { get; set; } = null!;

    public int? Edad { get; set; }

    public string Run { get; set; } = null!;

    public virtual ICollection<FichaAtencion> FichaAtencions { get; set; } = new List<FichaAtencion>();

    public virtual Cliente RunNavigation { get; set; } = null!;
}
