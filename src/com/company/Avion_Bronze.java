package com.company;

public class Avion_Bronze extends Avion {
    public Avion_Bronze (int capacidad_comb, int costo_por_km, int capacidad_maxima_pas, int velocidad, char propulsion) {
        this.Capacidad_Combustible = capacidad_comb;
        this.Costo_por_KM = costo_por_km;
        this.Capacidad_Maxima_pasajeros = capacidad_maxima_pas;
        this.Velocidad_Max = velocidad;
        this.Propulsion = propulsion;
    }
}
