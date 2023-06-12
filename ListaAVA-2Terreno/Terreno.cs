public class Terreno
{
    private double largura;
    private double comprimento;

    public Terreno(double largura, double comprimento)
    {
        this.largura = largura;
        this.comprimento = comprimento;
    }

    public double getLargura()
    {
        return this.largura;
    }
    public void setLargura()
    {
        this.largura = this.largura;
    }

    public double getComprimento()
    {
        return this.comprimento;
    }
    public void setComprimento()
    {
        this.comprimento = this.comprimento;
    }
    
    public double Area(double larg, double cumpri)
    {
        double conta = larg * cumpri;
        return conta;
    }
    public double Valor(double metro, double l , double c)
    {
        double conta = l * c;
        double calculo = metro * conta;
        return calculo;
    }

}