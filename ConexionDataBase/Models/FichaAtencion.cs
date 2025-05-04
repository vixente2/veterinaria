using System;
using System.Collections.Generic;

namespace ConexionDataBase.Models;

public partial class FichaAtencion
{
    public int IdFicha { get; set; }

    public int IdMascota { get; set; }

    public int IdAtencion { get; set; }

    public double Peso { get; set; }

    public string? Comentario { get; set; }

    public virtual Atencion IdAtencionNavigation { get; set; } = null!;

    public virtual Mascotum IdMascotaNavigation { get; set; } = null!;
}
