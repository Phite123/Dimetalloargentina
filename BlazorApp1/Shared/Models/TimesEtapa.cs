using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared.Models
{
    public class TimesEtapa
    {
        public string Etapa { get; set; }
        public List<(string accion , DateTime time)> Times { get; set; }
        public int? TimeTotalEtapa { get; set; }

        public TimesEtapa (string etapa)
        {
            this.Etapa = etapa;
            this.Times = new();
            Times.Add(("Entrada", DateTime.Now));
        }
    }
}
