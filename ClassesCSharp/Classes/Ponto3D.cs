namespace Classes.Classes
{
    public class Ponto3D : Ponto
    {
        public int Z;
        public Ponto3D(int x, int y, int z) : base(x, y)
        {
            this.Z = z;
            CalcularDistancia();
        }

        public static void Calcular()
        {
            //Faz alguma coisa...
        }
        public override void CalcularDistancia3()
        {
            //Faz outra coisa ...
            base.CalcularDistancia3();
        }
    }
}