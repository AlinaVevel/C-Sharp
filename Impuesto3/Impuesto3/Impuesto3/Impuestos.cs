using System;

class Impuestos
{
    private int IVA;
    private int precio;


    public Impuestos()
    {
        int IVA;
        int precio;
    }

    public int getIVA()
    {
        return IVA;
    }

    public void setIVA(int IVA)
    {
        this.IVA = IVA;
    }

    public int getPrecio()
    {
        return precio;
    }

    public void setPrecio(int precio)
    {
        this.precio = precio;
    }

    public void CalculoPrecio(int IVA, int precio)
    {
        if (IVA == 4)
        {
            precio = (int) (precio * 1.04);
        }
        else if (IVA == 10)
        {
            precio = (int) (precio * 1.10);
        }
        else if (IVA == 21)
        {
            precio = (int) (precio * 1.21);
        }

        Resultado(IVA, precio);
    }

    public void Resultado(int IVA, int precio)
    {
        Console.WriteLine("El precio final del producto con el {0}% de IVA es {1} Euros", IVA, precio);
    }
}