﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grados
{
    class Program
    {
        static void Main(string[] args)
        {
            LibroDeCalificaciones Libro = new LibroDeCalificaciones();
            Libro.AddCalificacion(97);
            //probando para hacer un push en github
            Console.WriteLine("solo para github");
        }
    }
}
