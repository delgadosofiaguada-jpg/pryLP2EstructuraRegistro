using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryLP2EstructuraRegistro
{
    internal class Vector
    {
        //Declaración de REGISTRO
        public struct RegCliente
        {
            public Int32 Codigo;
            public String Usuario;
            public Decimal Deuda;
            public Decimal Limite;
        }
        //Declaración del VECTOR
        static public RegCliente[] Clientes = new RegCliente[10];

        //Declaración del INDICE
        static public Int32 IND = 0;

        static public void precarga()
        {
            Clientes[IND].Codigo = 10;
            Clientes[IND].Usuario = "Ana";
            Clientes[IND].Deuda = 1000;
            Clientes[IND].Limite = 10000;
            IND++;
            Clientes[IND].Codigo = 20;
            Clientes[IND].Usuario = "Diego";
            Clientes[IND].Deuda = 0;
            Clientes[IND].Limite = 20000;
            IND++;
            Clientes[IND].Codigo = 30;
            Clientes[IND].Usuario = "Maria";
            Clientes[IND].Deuda = 3000;
            Clientes[IND].Limite = 30000;
            IND++;

        }
        static public void OrdenarCodigoAsc()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCliente Aux;//Registro para poder contener los 4 campos
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Codigo > Clientes[i + 1].Codigo)//Si es mayor a la posicion que le sigue
                    {
                        Aux = Clientes[i];//Pasa a una variable auxiliar para guardar el regitro(Los 4 campos)
                        Clientes[i] = Clientes[i + 1];//Cargamos el dato en esa posicion
                        Clientes[i + 1] = Aux;//Se invirtieron
                    }
                    i++;
                }
                c++;
            }


        }

        static public void OrdenarCodigoDesc()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCliente Aux;//Registro para poder contener los 4 campos
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Codigo < Clientes[i + 1].Codigo)//Si es mayor a la posicion que le sigue
                    {
                        Aux = Clientes[i];//Pasa a una variable auxiliar para guardar el regitro(Los 4 campos)
                        Clientes[i] = Clientes[i + 1];//Cargamos el dato en esa posicion
                        Clientes[i + 1] = Aux;//Se invirtieron
                    }
                    i++;
                }
                c++;
            }

        }

        static public void OrdenarNombreAsc()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCliente Aux;//Registro para poder contener los 4 campos
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Usuario.CompareTo(Clientes[i + 1].Usuario)>0)//Si es mayor a la posicion que le sigue
                    {
                        Aux = Clientes[i];//Pasa a una variable auxiliar para guardar el regitro(Los 4 campos)
                        Clientes[i] = Clientes[i + 1];//Cargamos el dato en esa posicion
                        Clientes[i + 1] = Aux;//Se invirtieron
                    }
                    i++;
                }
                c++;
            }

        }

        static public void OrdenarNombreDesc()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCliente Aux;//Registro para poder contener los 4 campos
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Usuario.CompareTo(Clientes[i + 1].Usuario)<0)//Si es mayor a la posicion que le sigue
                    {
                        Aux = Clientes[i];//Pasa a una variable auxiliar para guardar el regitro(Los 4 campos)
                        Clientes[i] = Clientes[i + 1];//Cargamos el dato en esa posicion
                        Clientes[i + 1] = Aux;//Se invirtieron
                    }
                    i++;
                }
                c++;
            }
        }
        private static object CompareTo(object value)
        {
            throw new NotImplementedException();
        }

        static public void OrdenarLimiteAsc()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCliente Aux;//Registro para poder contener los 4 campos
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Limite.CompareTo(Clientes[i + 1].Limite) > 0)//Si es mayor a la posicion que le sigue
                    {
                        Aux = Clientes[i];//Pasa a una variable auxiliar para guardar el regitro(Los 4 campos)
                        Clientes[i] = Clientes[i + 1];//Cargamos el dato en esa posicion
                        Clientes[i + 1] = Aux;//Se invirtieron
                    }
                    i++;
                }
                c++;
            }

        }

        static public void OrdenarLimiteDesc()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCliente Aux;//Registro para poder contener los 4 campos
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Usuario.CompareTo(Clientes[i + 1].Usuario) < 0)//Si es mayor a la posicion que le sigue
                    {
                        Aux = Clientes[i];//Pasa a una variable auxiliar para guardar el regitro(Los 4 campos)
                        Clientes[i] = Clientes[i + 1];//Cargamos el dato en esa posicion
                        Clientes[i + 1] = Aux;//Se invirtieron
                    }
                    i++;
                }
                c++;
            }
        }

        static public void OrdenarDeudaAsc()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCliente Aux;//Registro para poder contener los 4 campos
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Deuda.CompareTo(Clientes[i + 1].Deuda) > 0)//Si es mayor a la posicion que le sigue
                    {
                        Aux = Clientes[i];//Pasa a una variable auxiliar para guardar el regitro(Los 4 campos)
                        Clientes[i] = Clientes[i + 1];//Cargamos el dato en esa posicion
                        Clientes[i + 1] = Aux;//Se invirtieron
                    }
                    i++;
                }
                c++;
            }
        }

        static public void OrdenarDeudaDesc()
        {

            Int32 c = 0;
            Int32 i = 0;
            RegCliente Aux;//Registro para poder contener los 4 campos
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Deuda.CompareTo(Clientes[i + 1].Deuda) <0)//Si es mayor a la posicion que le sigue
                    {
                        Aux = Clientes[i];//Pasa a una variable auxiliar para guardar el regitro(Los 4 campos)
                        Clientes[i] = Clientes[i + 1];//Cargamos el dato en esa posicion
                        Clientes[i + 1] = Aux;//Se invirtieron
                    }
                    i++;
                }
                c++;
            }
        }
    }
}
