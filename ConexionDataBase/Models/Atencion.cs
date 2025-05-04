using System;
using System.Collections.Generic;

namespace ConexionDataBase.Models;

public partial class Atencion
{
    public int IdAtencion { get; set; }

    public DateTime Fecha { get; set; }

    public int IdUser { get; set; }

    public int Valor { get; set; }

    public string? Observacion { get; set; }

    public virtual ICollection<FichaAtencion> FichaAtencions { get; set; } = new List<FichaAtencion>();

    public virtual Usuario IdUserNavigation { get; set; } = null!;
}
