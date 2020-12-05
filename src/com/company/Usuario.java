package com.company;

public class Usuario {
    public String nombre;
    public String apellido;
    public int DNI = 0;
    public int edad = 0;
    public Usuario(String Nombre, String apellido, int DNI, int edad) {
        this.nombre = Nombre;
        this.apellido = DNI;
        this.DNI = DNI;
        this.edad = edad;
    }
    public String getNombre() {
        return nombre;
    }
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }
    public String getApellido() {
        return apellido;
    }
    public void setApellido(String apellido) {
        this.nombre = apellido;
    }
    public int getDNI() {
        return DNI;
    }
    public void setDNI(int DNI) {
        this.DNI = DNI;
    }
    public int getEdad() {
        return edad;
    }
    public void setEdad(int edad) {
        this.edad = edad;
    }
}
