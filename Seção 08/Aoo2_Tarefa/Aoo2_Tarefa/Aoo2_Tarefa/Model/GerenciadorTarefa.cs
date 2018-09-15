using System;
using System.Collections.Generic;
using System.Text;

namespace Aoo2_Tarefa.Model
{
    public class GerenciadorTarefa
    {
        private List<Tarefa> Lista { get; set; }
        public void Salvar(Tarefa t)
        {
            Lista = Listagem();
            Lista.Add(t);

            SalvarNoProperties(Lista);
        }

        public List<Tarefa> Listagem()
        {
            return ListagemNoProperties();
        }

        public void Finalizar(int index, Tarefa t)
        {
            Lista = Listagem();
            Lista.RemoveAt(index);

            Lista.Add(t);
            SalvarNoProperties(Lista);
        }

        public void Deletar(Tarefa t)
        {
            Lista = Listagem();
            Lista.Remove(t);

            SalvarNoProperties(Lista);
        }

        private void SalvarNoProperties(List<Tarefa> Lista)
        {
            if (App.Current.Properties.ContainsKey("Tarefas"))
            {
                App.Current.Properties.Remove("Tarefas");
            }

            App.Current.Properties.Add("Tarefas", Lista);
        }

        private List<Tarefa> ListagemNoProperties()
        {
            if (App.Current.Properties.ContainsKey("Tarefas"))
            {
               return(List<Tarefa>) App.Current.Properties["Tarefas"];
            }
            return new List<Tarefa>();
        }
     }
}
