using System;

public class Circulo {
    private double radio;

    public double Radio {
        get { return radio; }
        set { radio = value; }
    }

    public Circulo(double radioInicial) {
        radio = radioInicial;
    }

    public double CalcularArea() {
        return Math.PI * Math.Pow(radio, 2);
    }

    public double CalcularPerimetro() {
        return 2 * Math.PI * radio;
    }
}
