using Projeto_WindowsForms.DAL;
using Projeto_WindowsForms.Modelo;

namespace Projeto_WindowsForms.Controle
{
    public class EmpresaControle : ControleBase
    {
        public void cadastrarEmpresa(Empresa empresa)
        {
            validacao.validarDadosEmpresa(empresa);

            if (string.IsNullOrEmpty(validacao.mensagem))
            {
                try
                {
                    var empresaDAO = new EmpresaDAO();
                    empresaDAO.cadastrarEmpresa(empresa);
                }
                catch (Exception e)
                {
                    this.mensagem = e.Message;
                }
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public void editarEmpresa(Empresa empresa)
        {
            validacao.validarDadosEmpresa(empresa);

            if (string.IsNullOrEmpty(validacao.mensagem))
            {
                try
                {
                    var empresaDAO = new EmpresaDAO();
                    empresaDAO.editarEmpresa(empresa);
                }
                catch (Exception e)
                {
                    this.mensagem = e.Message;
                }
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public List<Empresa> listarEmpresas()
        {
            try
            {
                var empresaDao = new EmpresaDAO();

                return empresaDao.listarEmpresa();
            }
            catch (Exception e)
            {
                this.mensagem = e.Message;
            }

            return new List<Empresa>();
        }

        public void desativarEmpresa(int id)
        {
            try
            {
                var empresaDao = new EmpresaDAO();

                empresaDao.desativarEmpresa(id);
            }
            catch (Exception e)
            {
                this.mensagem = e.Message;
            }
        }

        public Empresa buscarEmpresa(int id)
        {
            try
            {
                var empresaDao = new EmpresaDAO();

                return empresaDao.buscarEmpresa(id);
            }
            catch (Exception e)
            {
                this.mensagem = e.Message;
            }

            return null;
        }
    }
}
