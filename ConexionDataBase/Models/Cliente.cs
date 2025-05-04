using System;
using System.Collections.Generic;

namespace ConexionDataBase.Models;

public partial class Cliente
{
    public string Run { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int Fono { get; set; }

    public string? Direccion { get; set; }

    public virtual ICollection<Mascotum> Mascota { get; set; } = new List<Mascotum>();

}
