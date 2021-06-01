using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassModeloTorneo
{
    public class Torneo
    {
        public string nomTorneo { get; set; }
        public int numEquipos { get; set; }
        private Equipo[] equipos;
        private int posicion = 0;

        public Torneo()
        {

        }

        public Torneo(string nombreTor, int equipos)
        {
            nomTorneo = nombreTor;
            numEquipos = equipos;
        }

        public Torneo(int numequipos)
        {
            equipos = new Equipo[numequipos];
        }

        public Torneo(int numequipos, string Nombre_torneo)
        {
            nomTorneo = Nombre_torneo;
            equipos = new Equipo[numequipos];

        }

        public String AgregarEquipo(String club, String ciudad, short no_J, short año)
        {
            String mensaje;
            if (posicion <= equipos.Length - 1)
            {
                
                equipos[posicion] = new Equipo();
                equipos[posicion].NombreClub = club;
                equipos[posicion].Ciudad = ciudad;
                equipos[posicion].Num_jugadores = no_J;
                equipos[posicion].Año_fundacionn = año;
                posicion++;

                mensaje = "Equipo agregado.";
            }
            else
            {
                mensaje = "Ya se insertaron los equipos indicados.";
            }
            return mensaje;
        }

        public string[] devuelveDatosEquipos()
        {
            string[] temporal = new string[posicion];//Los que se han insertado
            int t = 0;
            for (t = 0; t <= posicion - 1; t++)
            {
                temporal[t] = equipos[t].TodosDatosEquipos();
            }
            return temporal;
        }


        public string EliminarPorPosicion(int indiceEliminar)
        {
            string cad = "";
            int h = 0;
            if (indiceEliminar != -1)
            {
                for (h = indiceEliminar; h <= posicion - 2; h++)
                {
                    equipos[h] = equipos[h + 1];
                }
                posicion--;
                cad = "Se ha eliminado al equipo.";
            }
            else
            {
                cad = "Debe seleccionar un equipo para eliminar.";
            }
            return cad;
        }


        private int buscarequipo(string nombreabuscar)
        {
            int piedrita = -1;

            int g = 0;
            for (g = 0; g < posicion - 1; g++)
            {
                
                if (equipos[g].NombreClub == nombreabuscar)
                {
                    piedrita = g;
                    g = posicion;
                }
            }
            return piedrita;
        }

        public string EliminarporBusqueda(string equipoEliminar)
        {
            string cad = "";
            int encontrado = 0;
            encontrado = buscarequipo(equipoEliminar);

            if (encontrado==-1)
            {
                cad = "No existe el equipo a eliminar.";
            }
            else
            {
                cad = EliminarPorPosicion(encontrado);
            }

            return cad;
        }

        public string Eliminartodascopias(string equipoeliminar)

        {
            string cad = "";
            int g = 0, h = 0, encontrado = 0;

            for (g = 0; g < posicion - 1; g++)
            {
                if (equipos[g].NombreClub == equipoeliminar)
                {

                    encontrado = g;
                    for (h=encontrado; h <= posicion-2; h++)
                    {
                        equipos[h] = equipos[h + 1];
                    }
                    posicion--;
                    cad = "Se eliminaron los equipos.";

                    if (equipos[g].NombreClub==equipoeliminar)
                    {
                        g--;
                    }
                }
                else
                {
                    cad = "No se encontro el equipo que quiere eliminar";
                }
            }
            return cad;
        }


        //métodos de la práctica
        public string Modificar(String club, String ciudad, short no_J, short año, int posiSeleccionada)
        {
            string cad = "";
            int posiEquipo = posiSeleccionada;

            if (posiEquipo == -1)
            {
                cad = "Debe seleccionar un equipo para modificar";
            }
            else
            {
                equipos[posiEquipo].NombreClub = club;
                equipos[posiEquipo].Ciudad = ciudad;
                equipos[posiEquipo].Num_jugadores = no_J;
                equipos[posiEquipo].Año_fundacionn = año;
                //posicion++;

                cad = "Los datos del equipo se modificaron";
            }
            return cad;
        }

        public string InsertarDepuesDe(String club, String ciudad, short no_J, short año, int posiSeleccionada)
        {
            string cad = "";
            int posiEquipo = posiSeleccionada + 1;
            //int sig = posicion;

            if (posiEquipo == -1)
            {
                cad = "Debe seleccionar un equipo para agregar uno nuevo despues.";
            }
            else
            {
                if (posicion <= equipos.Length - 1)
                {
                    for(int x= posicion;x>posiEquipo;x--)
                    {
                        equipos[x] = equipos[x - 1];
                    }
                    equipos[posiEquipo] = new Equipo();
                    equipos[posiEquipo].NombreClub = club;
                    equipos[posiEquipo].Ciudad = ciudad;
                    equipos[posiEquipo].Num_jugadores = no_J;
                    equipos[posiEquipo].Año_fundacionn = año;
                    posicion++;

                    cad = "Se inserto un nuevo equipo.";
                }
                else
                {
                    cad = "Ya se han insertado todos los equipos correspondientes a este torneo.";
                }
            }
            return cad;
        }

        /////este metodo me sirve para la clase CONFEDERACION
        public string TodosDatosTorneos()
        {
            string salida = "";
            //if (posicion <= tor.Length - 1)
            //{
               
                salida = "Torneo: " + nomTorneo + "- Equipos:" + equipos.Length;
               
            //}
            return salida;
        }


    }
}
