using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MicroserviciosPrueba2
{
    class ParkingIniciado
    {


        static Parking parkingcreado;

        // Variable utilizada para ver si hay que inicializar los controladores relativos al filtro del color o ya se ha hecho
        bool colorIniciado = false;

        public void iniciaParking(ParkingDat parametros)
        {
            try
            {
                // Variables enteras que controlan el número de motos, coches y bicis con los que se incializa mi objeto parking
                // Coches: valor obligatorio, se busca el control y se pasa a entero su valor
                // Motos: valor opcional, se controla que se haya pasado valor 
                //int nmotos = 0;
                //Console.WriteLine("Numero de coches");
                //int ncoches = int.Parse(Console.ReadLine());
                int ncoches = parametros.nplazascoche;
                //int ncoches = Int32.Parse(txtBoxCoches.Text);
                //Console.WriteLine("Numero de motos");
                //String nmotosString=Console.ReadLine();
                int nmotos = parametros.nplazasmoto;
                /*if (nmotos)
                {
                    nmotos = int.Parse(nmotos);
                }
                else
                {
                    nmotos = 15;
                }*/
                int nbici = 10;

                int plazasDisponiblesCoches = ncoches;
                int plazasDisponiblesMotos = nmotos;
                int plazasDisponiblesBicis = nbici;


                // Variables para controlar cada tipo de vehículo introducido en el List del parking
                int biciscreadas = 0;
                int cochescreados = 0;
                int motoscreadas = 0;

                // Array de vehiculos para seleccionar cuál se crea de manera aleatoria
                ArrayList vehiculos = new ArrayList();

                // string quue guardará que vehículo se crea 
                string vehcreado = string.Empty;

                // StringBuilder que concatena la cadena que se muestra en la caja de texto
                StringBuilder sb = new StringBuilder();

                // Inicialización del parking
                Console.WriteLine("Nombre Parking");
                String nomPark = Console.ReadLine();
                parkingcreado = new Parking(nomPark, ncoches, nmotos);

                // Se almacenan vehículos mientras quepan bicis
                while (biciscreadas < nbici)
                {
                    // Cargamos todas las posibilidades de vehículos en nuestro arraylist y guardamos uno en vehcreado
                    vehiculos = CargarArrayRandom();
                    vehcreado = ElegirVehiculo(vehiculos);

                    // Si es un coche o una moto: si cabe todavía, creamos e inicializamos uno, los almacenamos en el List de vehículos del parking, mostramos 
                    // el mensaje de aceptado y aumentamos el contador correspondiente; si no cabe ya, mostramos su mensaje de denegado
                    if (vehcreado == "cocherandom")
                    {
                        Coche c1 = new Coche();
                        if (cochescreados < ncoches)
                        {
                            sb.Append(c1.mensajeAceptado + Environment.NewLine);
                            parkingcreado.vehaparcados.Add(c1);
                            cochescreados++;
                            plazasDisponiblesCoches = ncoches - cochescreados;
                            //Console.WriteLine(respuestaParking(parkingcreado.nombre, c1.GetType().ToString(), plazasDisponiblesCoches, true));
                            sb.Append(respuestaParking(parkingcreado.nombre, c1.GetType().Name, plazasDisponiblesCoches, true) + Environment.NewLine);
                        }
                        else
                        {
                            sb.Append(c1.mensajeDenegado + Environment.NewLine);
                            //Console.WriteLine(respuestaParking(parkingcreado.nombre, c1.GetType().ToString(), plazasDisponiblesCoches, false));
                            sb.Append(respuestaParking(parkingcreado.nombre, c1.GetType().Name, plazasDisponiblesCoches, false) + Environment.NewLine);
                        }
                    }
                    else if (vehcreado == "motorandom")
                    {
                        Moto m1 = new Moto();
                        if (motoscreadas < nmotos)
                        {
                            sb.Append(m1.mensajeAceptado + Environment.NewLine);
                            parkingcreado.vehaparcados.Add(m1);
                            motoscreadas++;
                            plazasDisponiblesMotos = nmotos - motoscreadas;
                            // Console.WriteLine(respuestaParking(parkingcreado.nombre, m1.GetType().ToString(), plazasDisponiblesMotos, true));
                            sb.Append(respuestaParking(parkingcreado.nombre, m1.GetType().Name, plazasDisponiblesMotos, true) + Environment.NewLine);
                        }
                        else
                        {
                            sb.Append(m1.mensajeDenegado + Environment.NewLine);
                            //Console.WriteLine(respuestaParking(parkingcreado.nombre, m1.GetType().ToString(), plazasDisponiblesMotos, false));
                            sb.Append(respuestaParking(parkingcreado.nombre, m1.GetType().Name, plazasDisponiblesMotos, false) + Environment.NewLine);
                        }
                    }
                    // Si es una bici no tenemos que comprobar si cabe ya que entra en el while solo en el caso de que quepan bicis
                    // Creamos e inicializamos bici, mostramos mensaje de aceptado, almacenamos en el list del parking y aumentamos el contador correspondiente
                    else if (vehcreado == "bicirandom")
                    {
                        Bicicleta b1 = new Bicicleta();
                        sb.Append(b1.mensajeAceptado + Environment.NewLine);
                        parkingcreado.vehaparcados.Add(b1);
                        biciscreadas++;
                        plazasDisponiblesBicis = nbici - biciscreadas;
                        // Console.WriteLine(respuestaParking(parkingcreado.nombre, b1.GetType().ToString(), plazasDisponiblesMotos, true));
                        sb.Append(respuestaParking(parkingcreado.nombre, b1.GetType().Name, plazasDisponiblesBicis, true) + Environment.NewLine);
                    }
                }
                // Mostramos el mensaje concatenado en el stringbuilder
                MostrarMensaje(sb.ToString());
                // En caso de que el interruptor del color siga a false, se inician el controlador del combobox y el botón de filtrar por color
                // Este interruptor existe para que, en caso de que se pulsen varias veces el botón de "Llenar parking" no se inicialicen los 
                // controladores varias veces
                /*if (colorIniciado == false)
                {
                    InitColor();
                }
                // Ponemos el interruptor a true
                colorIniciado = true;*/
            }

            catch (Exception ex)
            {
                MostrarMensaje(ex.ToString());
            }

        }

      

        public static ArrayList CargarArrayRandom()
        {
            ArrayList vehrandom = new ArrayList();

            try
            {
                vehrandom.Add("cocherandom");
                vehrandom.Add("motorandom");
                vehrandom.Add("bicirandom");

                return vehrandom;
            }
            catch (Exception ex)
            {
                return vehrandom;
            }
        }

        public static string ElegirVehiculo(ArrayList _vehrandom)
        {
            const string colorDefecto = "ColorDefecto";

            try
            {
                var random = new Random();
                int eleccion = random.Next(_vehrandom.Count);

                return _vehrandom[eleccion].ToString();
            }
            catch (Exception ex)
            {
                return colorDefecto;
            }
        }

        public static void MostrarMensaje(string _mensaje)
        {
            /*resultado.ReadOnly = false;
            resultado.Text = "";
            resultado.Text = _mensaje;
            resultado.ReadOnly = true;*/
            Console.WriteLine(_mensaje);
        }

        public String InitColor()
        {
               /*cmbColor.Enabled = true;
                bntColor.Enabled = true;

                cmbColor.Items.Add("azul");
                cmbColor.Items.Add("negro");
                cmbColor.Items.Add("blanco");
                cmbColor.Items.Add("rosa");*/
                String colorString;

                String[] colores = { "Azul", "Blanco", "Negro", "Rosa" };

                Console.WriteLine("Introduzca color para ver el numero de vehiculos(azul,blanco,negro,rosa): ");
                colorString = Console.ReadLine();

               /*if (colorString != null && !String.IsNullOrEmpty(colorString))
                {
                    if (colorString.Equals("") || !(Array.Exists(colores, element => element == colorString)))
                    {
                        while (colorString.Equals("") || !(Array.Exists(colores, element => element == colorString)))
                        {
                            Console.WriteLine("Valor incorrecto: ");
                            colorString = Console.ReadLine();

                        }
                    }

                }*/
     
            return colorString;
        }

        public void seleccColor()
        {
            try
            {
                int vehcolor = 0;

                String colorLeido = InitColor();

                // Aumentamos el contador de vehículos cuando encontramos alguno en la lista cuya propiedad color coincida con el color del combobox
                foreach (Vehiculo v in parkingcreado.vehaparcados)
                {
                    if (v.color == colorLeido)
                    {
                        vehcolor++;
                    }
                }

                // Mostramos mensaje
                string mensajeColor = "En el parking existen " + vehcolor + " vehículos de color " + colorLeido;
                MostrarMensaje(mensajeColor);
            }
            catch (Exception ex)
            {
                MostrarMensaje(ex.ToString());
            }
        }
        
        public String respuestaParking(String NOMBRE, String tipo, int plazasDisponibles, Boolean admitidoB)
        {

            String mensajeRespuesta;
            if (admitidoB)
            {
                mensajeRespuesta = ("Soy el Parking " + NOMBRE + " y acabo de aceptar un/una " + tipo + " me quedan "
                    + plazasDisponibles + " plazas disponibles para " + tipo);
            }
            else
            {
                mensajeRespuesta = ("Soy el Parking " + NOMBRE + " y acabo de rechazar un/una " + tipo);
            }

            return mensajeRespuesta;
        }

    }
}
