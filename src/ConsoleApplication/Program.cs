//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
     ///100 instancias se pueden crear facilmente sin problema
    ///Cuando intento crear 10.000.000 de instancias, 
    /// llega a un numero, y se reinicia el constructor,infinitamente.
    public static void Main()
        {       
            var t1 = new Train("Last Train To London");
            var t2 = new Train("Last Train To London");
            var t3 = new Train("Runaway Train");
            
            
        }
    }
}