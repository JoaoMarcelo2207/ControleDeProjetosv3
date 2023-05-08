using System;
using System.Collections.Generic;

namespace Controle.MODEL;

public partial class Projeto
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public string? NomeGerente { get; set; }

    public string? Status { get; set; }

    public string? Resumo { get; set; }

    public DateTime? DataI { get; set; }

    public DateTime? DataF { get; set; }
}
