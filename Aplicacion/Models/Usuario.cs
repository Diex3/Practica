using System;
using System.Collections.Generic;

namespace Aplicacion.Models;

public partial class Usuario
{
    public int IdUsuarios { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Rut { get; set; } = null!;

    public string Edad { get; set; } = null!;
}
