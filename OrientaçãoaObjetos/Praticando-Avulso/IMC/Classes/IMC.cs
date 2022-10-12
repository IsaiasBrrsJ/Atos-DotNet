using System;

class IMC
{

    private Pessoa pessoa; // referencia classe pessoa;

    public IMC(Pessoa pessoa)
    {
        this.pessoa = pessoa;
    }

    public Pessoa getPessoa()
    {
        return pessoa;
    }
    private double calculoImc()
    {
        return pessoa.getPeso() / (pessoa.getAltura() * pessoa.getAltura());
    }


    public string Mensagem()
    {
        double imc = calculoImc();
        string stringIMC = imc.ToString("F2");
        string mensagem = "";
        if (imc >= 40)
        {
            mensagem += $"{pessoa.getNome()} IMC: {stringIMC} Obesidade III";
        }
        else if (imc > 35)
        {
            mensagem += $"{pessoa.getNome()} IMC: {stringIMC} Obesidade II";
        }
        else if (imc > 30)
        {
            mensagem += $"{pessoa.getNome()} IMC: {stringIMC} Obesidade I";
        }
        else if (imc > 25)
        {
            mensagem += $"{pessoa.getNome()} IMC: {stringIMC} Peso Normal";
        }
        else
        {
            mensagem += $"{pessoa.getNome()} IMC: {stringIMC} Abaixo do peso";
        }

        return mensagem;
    }


}