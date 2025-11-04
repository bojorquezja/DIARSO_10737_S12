// See https://aka.ms/new-console-template for more information
using observador;

Youtube y = new Youtube();
y.AgregaSub(new Subscriptor("Carlos"));
y.AgregaSub(new Subscriptor("Jose"));
y.AgregaSub(new Subscriptor("Roberto"));
y.Publicar();
