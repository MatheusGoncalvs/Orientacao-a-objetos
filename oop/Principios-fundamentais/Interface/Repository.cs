using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Principiosfundamentais.Interface
{
    public class Repository : IRepository
    {
        public Repository(int a)
        {

        }

        public void Adicionar()
        {
            //Adicionar algo
        }
    }

    public class RepositoryFake : IRepository
    {
        public void Adicionar()
        {
            throw new NotImplementedException();
        }
    }


    public class UsoImplementacao
    {
        public void Processo()
        {
            var repository = new Repository();
            repository.Adicionar();
        }
    }


    public class UsoInterface
    {
        private readonly IRepository repository;

        public UsoInterface(IRepository repository)
        {
            this.repository = repository;
        }

        public void Processo()
        {
            repository.Adicionar();
        }
    }

   public class TesteUsoInterfaceImplementacao
    {
        public void Teste()
        {
            var implementacao = new UsoImplementacao();
            implementacao.Processo();

            var abstracao = new UsoInterface(new Repository());
            abstracao.Processo();

            var reposFake = new UsoInterface(new RepositoryFake());
            reposFake.Processo();
        }
    }
}
