﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3
{
    class Ent : Bitmon
    {
        Random rnd = new Random();
        new int tiempoDeVida;
        new int posx;
        new int posy;
        new int esperanzaVida;

        // Al constructor dedl bitmons le metemos los parametros de su ubicacion para que el bitmon los guarde
        public Ent(int posx, int posy, int tiempoDeVida, int esperanzaVida)
        {
            this.posx = posx;
            this.posy = posy;
            this.tiempoDeVida = tiempoDeVida;
            this.esperanzaVida = esperanzaVida;
        }

        public override int Get_esperanza()
        {
            return esperanzaVida;
        }
        // Para obtener el tiempo de vida del bitmon
        public override int Get_TiempoDeVida()
        {
            return tiempoDeVida;
        }

        // Reduce el tiempo de vida mientras pasan los meses
        public override void ReducirTiempoDeVida(int numero)
        {
            if (tiempoDeVida > 0)
            {
                tiempoDeVida -= numero;
            }
            else
            {
                tiempoDeVida = 0;
            }
        }
        // Aca si el Bitmon puede cambiar el tipo de terreno en el que esta, lo hace
        public override Terreno CambioTerreno(int a)
        {
            return new Vegetacion();
        }

        // Aca retornamos el nombre de la especie que es, para poder ocuparlo
        public override string Get_Especie()
        {
            return especie = "ent";
        }

        // Retornamos el nombre de la especie vacio, para poder hacer que 
        // desaparezca el nombre del bitmon cuando se mueve
        public override string Get_Especie_Vacio()
        {
            return especie = "";
        }

        // Aca se obtienen las ventajas del daño de ataca de una especie contra otra
        public override int Daño(Bitmon bitmon)
        {
            if (bitmon.Get_Especie() == "gofue" || bitmon.Get_Especie() == "doti" || bitmon.Get_Especie() == "dorvalo")
            {
                return puntosDeAtaque * 2;
            }
            else
            {
                return Convert.ToInt32(puntosDeAtaque * 0.5);
            }
        }

        // Nos da la posision 'x' en la que se encuentra el Bitmon
        // 'x' son las filas
        public override int Get_Posx()
        {
            return posx;
        }

        // Nos da la posision 'y' en la que se encuentra el Bitmon
        // 'y' son las columnas
        public override int Get_Posy()
        {
            return posy;
        }

        // Metodo que utilizamos para que se mueva en 'filas'
        public int Moverse_Fila()
        {
            posx += rnd.Next(-1, 2);
            return posx;
        }

        // Metodo que utilizamos para que se mueva en 'columnas'
        public int Moverse_Columna()
        {
            posy += rnd.Next(-1, 2);
            return posy;
        }

        // Metodo que utilizamos para el movimiento del Bitmon, en este caso vacio,
        // puesto que no se puede mover.
        public override void Moverse(Mapa mapa)
        {

        }
    }
}