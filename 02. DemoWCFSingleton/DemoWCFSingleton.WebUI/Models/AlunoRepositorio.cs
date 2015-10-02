using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoWCFSingleton.WebUI.Models
{
    public class AlunoRepositorio : IDisposable
    {
        private readonly AlunoService.AlunoServiceClient _ctx;
        public AlunoRepositorio()
        {
            _ctx = new AlunoService.AlunoServiceClient();
        }

        public IList<AlunoVM> GetAlunos()
        {
            return
                _ctx.ObterAlunos()
                .Select(d => new AlunoVM
                {
                    ID = d.ID,
                    Nome = d.Nome,
                    Cadastro = d.Cadastro
                }).ToList();
        }


        public void Dispose()
        {
            _ctx.Close();
        }
    }
}