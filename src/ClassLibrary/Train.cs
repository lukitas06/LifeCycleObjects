//--------------------------------------------------------------------------------
// <copyright file="Train.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;

namespace ClassLibrary
{
    /// <summary>
    /// Esta clase representa un tren muy básico.
    /// </summary>
    public class Train
    {
        private string trainIdentifier{get;set;}  ///Esto es una variable de instancia
        private static int count{get;set;}=0;  ///Esto es una variable de clase

        public Train(string trainIdentifier){ ///Se define el constructor
            this.trainIdentifier=trainIdentifier;
            count+=1;   ///Cada vez que se crea un objeto, se suma uno a la cuentra de instancias
            Console.WriteLine("Se ejecuto "+Train.count+" veces el constructor");
        } 
        /// <summary>
        /// Obtiene un valor que indica si las maquinas del tren han sido encendidas o no.
        /// </summary>
        /// <value><c>true</c> si las máquinas fueron encendidas, <c>false</c> en caso contrario.</value>
        public bool IsEngineStarted { get; private set; }

        /// <summary>
        /// Enciende las máquinas del tren.
        /// </summary>
        /// <returns>
        /// <c>true</c> si las máquinas pueden ser encendidas, <c>false</c> en caso contrario.
        /// </returns>
        public bool StartEngines()
        {
            if (this.IsEngineStarted)
            {
                Console.Write("The engines are already running");
                return false;
            }

            this.IsEngineStarted = true;
            Console.Write("Engines on");
            return true;
        }

        /// <summary>
        /// Detiene las máquinas del tren.
        /// </summary>
        /// <returns>
        /// <c>true</c> si las máquinas pueden ser detenidas, <c>false</c> en caso contrario.
        /// </returns>
        public bool StopEngines()
        {
            if (this.IsEngineStarted)
            {
                this.IsEngineStarted = false;
                Console.Write("Engines off");
                return true;
            }

            Console.Write("The engines are already stopped");
            return this.IsEngineStarted;
        }
        ~Train() ///Se agrega el destructor, que saca uno a la cuenta cada vez que se destruye un objeto
        {
            count--;
            Console.WriteLine("Destruyendo instancias... Quedan "+count+" instancias");
        } 
       
    }
}