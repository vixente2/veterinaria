using System;
using System.Collections.Generic;

namespace ConexionDataBase.Models;

public partial class Usuario
{
    public int IdUser { get; set; }

    public string Email { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int IdRol { get; set; }

    public virtual ICollection<Atencion> Atencions { get; set; } = new List<Atencion>();

    public virtual Rol IdRolNavigation { get; set; } = null!;
}
