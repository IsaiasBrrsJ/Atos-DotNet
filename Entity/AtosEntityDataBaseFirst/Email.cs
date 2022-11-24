using System;
using System.Collections.Generic;

namespace AtosEntityDataBaseFirst;

public partial class Email
{
    public int id { get; set; }

    public string email { get; set; } = null!;

    public int? FkPessoa { get; set; }

    public virtual Pessoa? FkPessoaNavigation { get; set; }
}
