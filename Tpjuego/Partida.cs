using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpjuego
{
    public class Partida
    {
        private static List<Partida> partidas = new List<Partida>();

        private int Codigo { get; set; }

        private Partida()
        {

        }

        public int RetornarCodigo()
        {
            return this.Codigo;
        }

        public Partida CrearVerificarPartida(int codigo)
        {
            var partida = partidas.SingleOrDefault(x => x.Codigo == codigo);

            if (partida == null)
            {
                partida = new Partida();
                partidas.Add(partida);
            }

            return partida;
        }

    }
}
