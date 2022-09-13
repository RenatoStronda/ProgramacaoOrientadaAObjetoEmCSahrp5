// See https://aka.ms/new-console-template for more information
using System;

namespace heranca{
    class Program{
        public static void Main(string[] args) {
            Animal a = new Animal("A",10.5f);
            Animal b = new Animal();
            Gato g = new Gato();
            Console.WriteLine(g.miar());

            Cachorro c = new Cachorro();
            Console.WriteLine(c.latir());
            Gato g2 = new Gato("Azul",30.5f);
            Cachorro c2 = new Cachorro("verde", 54.3f);
        }
    }

    public class Animal{
        private string cor;
        private float peso;

        public Animal() {}

        public Animal(string cor, float peso){
            this.cor = cor;
            this.peso = peso;
        } 
    }

    public class Gato:Animal {
        public Gato(string a, float b) : base(a,b) {}

        public Gato() : base(){}

        public string miar(){
            return "miaaauuuuu";
        }
    }
    public class Cachorro:Animal{
        public Cachorro(string a,float b) : base(a,b) {}
        public Cachorro() : base(){}

        public string latir(){
            return"au au";
        }
    }
}