using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class Globals
{
    public enum Funciones { 
        Avanzar, 
        Retroceder,
        Izquierda,
        Derecha,
        Obstaculo,
        Ciclo,
        Pausa,
        Play
    }
    public static string[] codigos = { "del", "atr", "izq", "der", "obs", "rep","stp","ply" };
    public static int tamanioInstrucciones = 60;
    public static int posicionInstrucciones = 5;
    public static int espacioEntreInstrucciones = 5;
    private static int cantInstrucciones = 0;
    public static int getCantInstrucciones()
    {
        return cantInstrucciones;
    }
    public static void agregarInstruccion()
    {
        cantInstrucciones++;
    }
    public static void eliminarInstruccion()
    {
        cantInstrucciones--;
    }
}
