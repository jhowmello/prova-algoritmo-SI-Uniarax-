// autor: João M. Gregorio

using System;

class Program{
    static void Main()
    {
        string[] animal = new string[3];
        
        
        for(int p = 0; p < animal.Length ; p++)
        {
            animal[p] =  Console.ReadLine();
        }
        
        if(animal[0] == "VERTEBRADO"){
            if(animal[1] == "AVE"){
                if(animal[2] == "CARNIVORO"){
                    Console.WriteLine ("ÁGUIA");
                }
            }
        }
        if(animal[0] == "VERTEBRADO"){
            if(animal[1] == "AVE"){
                if(animal[2] == "ONIVORO"){
                    Console.WriteLine ("POMBRA");
                }
            }
        }
        if(animal[0] == "VERTEBRADO"){
            if(animal[1] == "MAMIFORO"){
                if(animal[2] == "ONIVORO"){
                    Console.WriteLine ("HOMEM");
                }
            }
        }
        if(animal[0] == "VERTEBRADO"){
            if(animal[1] == "MAMIFORO"){
                if(animal[2] == "HERBIVORO"){
                    Console.WriteLine ("VACA");
                }
            }
        }
        if(animal[0] == "INVERTEBRADO"){
            if(animal[1] == "INSETO"){
                if(animal[2] == "HEMATOFAGO"){
                    Console.WriteLine ("PULGA");
                }
            }
        }
        if(animal[0] == "INVERTEBRADO"){
            if(animal[1] == "INSETO"){
                if(animal[2] == "HERBIVORO"){
                    Console.WriteLine ("LAGARTA");
                }
            }
        }
        if(animal[0] == "INVERTEBRADO"){
            if(animal[1] == "ANELIDEO"){
                if(animal[2] == "HEMATOFAGO"){
                    Console.WriteLine ("SANGUESSUGA");
                }
            }
        }
        if(animal[0] == "INVERTEBRADO"){
            if(animal[1] == "INSETO"){
                if(animal[2] == "ONIVORO"){
                    Console.WriteLine ("MINHOCA");
                }
            }
        }
        
        
    }
}
