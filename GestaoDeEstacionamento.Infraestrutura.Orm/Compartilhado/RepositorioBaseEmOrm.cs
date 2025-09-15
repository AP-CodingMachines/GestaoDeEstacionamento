using GestaoDeEstacionamento.Core.Dominio.Compartilhado;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeEstacionamento.Infraestrutura.Orm.Compartilhado
{
    public class RepositorioBaseEmOrm<T> where T : EntidadeBase<T>
    {
        protected readonly DbSet<T> registros;

        //public RepositorioBaseEmOrm() //Fazer classe AppDbContext
        //{

        //}


        public async Task CadastrarAsync(T novoRegistro) 
        {
            await registros.AddAsync(novoRegistro);
        }

        public async Task CadastrarEntidades(IList<T> entidades) 
        {
            await registros.AddRangeAsync(entidades);
        }

        public async Task<bool> EditarAsync(Guid idRegistro, T registroEditado) 
        {
            var registroSelecionado = await SelecionarRegistroPorIdAsync(idRegistro);

            if (registroSelecionado is null)
                return false;

            registroSelecionado.AtualizarRegistro(registroEditado);
            
            return true;
        }


        public virtual async Task<T?> SelecionarRegistroPorIdAsync(Guid idRegistro) 
        {
            return await registros.FirstOrDefaultAsync(x => x.Id.Equals(idRegistro));
        }

        public virtual async Task<List<T>> SelecionarRegistrosAsync() 
        {
            return await registros.ToListAsync();
        }

        public virtual async Task<List<T>> SelecionarRegistrosAsync(int quantidade)
        {
            return await registros.Take(quantidade).ToListAsync();
        }
    }
}
