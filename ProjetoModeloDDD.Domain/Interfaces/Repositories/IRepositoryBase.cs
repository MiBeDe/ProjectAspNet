using System.Collections;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        // Crud Básico com os seguintes comando anonimos

        // Adicionar
        void Add(TEntity obj);

        // Pegar Por Id
        TEntity GetById(int id);

        // Enumerar(pegar) todos 
        IEnumerable<TEntity> GetAll();

        // Atualizar
        void Update(TEntity obj);

        // Remover
        void Remove(TEntity obj);

        // Forçar implementação
        void Dispose();

    }
}
