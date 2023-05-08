using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle.MODEL;

namespace Controle.BLL
{
    public static class ProjetoRepository
    {
        public static void Add(Projeto _projetos)
        {
            using (var DBContext = new DCAtvpontuadav3Controledeprojetosv3ControleDalDatabseDatabaseMdfContext())
            {
                DBContext.Add(_projetos);
                DBContext.SaveChanges();
            }
        }

        public static Projeto GetByID(int Id)
        {
            using (var DBContext = new DCAtvpontuadav3Controledeprojetosv3ControleDalDatabseDatabaseMdfContext())
            {
                var projetos = DBContext.Projetos.Single(p => p.Id == Id);
                return projetos;
            }
        }

        public static List<Projeto> GetAll()
        {
            using (var DBContext = new DCAtvpontuadav3Controledeprojetosv3ControleDalDatabseDatabaseMdfContext())
            {
                var projetos = DBContext.Projetos.ToList();
                return projetos;
            }
        }

        public static void Update(Projeto _projetos)
        {
            using (var DBContext = new DCAtvpontuadav3Controledeprojetosv3ControleDalDatabseDatabaseMdfContext())
            {
                var projetos = DBContext.Projetos.Single(p => p.Id == _projetos.Id);
                projetos.Nome = _projetos.Nome;
                projetos.NomeGerente = _projetos.NomeGerente;
                projetos.DataI = _projetos.DataI;
                projetos.Status = _projetos.Status;
                projetos.Resumo = _projetos.Resumo;
                DBContext.SaveChanges();

            }

        }
        public static void Excluir(Projeto _projetos) 
        {
            using (var DBContext = new DCAtvpontuadav3Controledeprojetosv3ControleDalDatabseDatabaseMdfContext())
            {
                var projetos = DBContext.Projetos.Single(p => p.Id == _projetos.Id);
                DBContext.Remove(projetos);
                DBContext.SaveChanges();
            }
        }

        public static Projeto GetByNome(String nome)
        {
            using (var DBContext = new DCAtvpontuadav3Controledeprojetosv3ControleDalDatabseDatabaseMdfContext())
            {
                
                try
                {
                    var projeto = DBContext.Projetos.Single(p => p.Nome == nome);
                    return projeto;
                } catch(Exception ex)
                {
                    try
                    {
                        var projeto = DBContext.Projetos.First(p => p.Nome == nome);
                        return projeto;
                    }catch(Exception execption)
                    {
                        return null;
                    }
                   
                }

            }
        }



    }
}
