// See https://aka.ms/new-console-template for more information
using adaptador;

string res = Aplicacion.ResultadoXML();
string adap = Adaptador.XMLtoJSON(res);
Biblioteca.RecibeJSON(adap);

