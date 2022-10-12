using System;

class Pessoa
{

    private string nome;
    private double peso;
    private double altura;

    public Pessoa(string nome, double peso, double altura)
    {
        this.nome = nome;
        this.peso = peso;
        this.altura = altura;
    }

    public string getNome()
    {
        return nome;
    }
    public double getPeso()
    {
        return peso;
    }

    public double getAltura()
    {
        return altura;
    }
}