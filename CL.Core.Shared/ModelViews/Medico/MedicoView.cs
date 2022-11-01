﻿using CL.Core.Shared.ModelViews.Especialidade;

namespace CL.Core.Shared.ModelViews.Medico
{

    public class MedicoView
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CRM { get; set; }

        public ICollection<EspecialidadeView> Especialidades { get; set; }
    }
}