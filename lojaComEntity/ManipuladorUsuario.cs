using lojaComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity
{
    class UsuarioDao
    {
        private EntidadesContext contexto;

        public UsuarioDao()
        {
            contexto = new EntidadesContext();
        }
        public void SaveChanges()
        {
            contexto.SaveChanges();
        }
        public void Salva(Usuario usuario)
        {
            // grava um log
            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();
        }
        
        public Usuario BuscaPorId(int id)
        {
            return contexto.Usuarios.FirstOrDefault(u => u.ID == id);
        }

        public void Remove(Usuario usuario)
        {
            contexto.Usuarios.Remove(usuario);
            contexto.SaveChanges();
        }
    }
}
