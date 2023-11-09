// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using gestor_stock_clientes;
using gestor_stock_clientes.Properties;

Pieza p1 = new Pieza(10);
Pieza p2 = new Pieza(11);
Pieza p3 = new Pieza(12);
Pieza p4 = new Pieza(13);
Pieza p5 = new Pieza(14);
Pieza p6 = new Pieza(15);

List<Pieza> piezas1 = new List<Pieza>();
List<Pieza> piezas2 = new List<Pieza>();
List<Pieza> piezas3 = new List<Pieza>();

piezas1.Add(p1); 
piezas1.Add(p2);
piezas1.Add(p3);
        
piezas2.Add(p3); 
piezas2.Add(p4);
piezas2.Add(p5);
        
piezas3.Add(p1); 
piezas3.Add(p6);
piezas3.Add(p4);

Cliente c1 = new Cliente("00000000T", "Juan", "Ourense", piezas1);
Cliente c2 = new Cliente("11111111J", "Pepe", "Santiago", piezas2);
Cliente c3 = new Cliente("22222222Y", "Ana", "Vigo", piezas3);

List<Cliente> css = new List<Cliente>();
css.Add(c1);
css.Add(c2);
css.Add(c3);

Clientes clientes = new Clientes(css);
        
Console.WriteLine(clientes);