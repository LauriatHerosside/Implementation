// See https://aka.ms/new-console-template for more information
using System;
namespace Implementation;
class AppliBits{
    
    public static void Main(string[] args)
    {
       int n,p,q,r,t , e ,f; 
   n =9;// 000...1001
System.Console.WriteLine( "Le n est égale à :"+n+ " Et la converstion est ="+ToBinary(n));
// méthode BitSET permettant de mettre à 1 un bit de rang fixé. 
     q = BitSET(n,2);
     System.Console.WriteLine("BitSET(n,2) ="+ToBinary(q));
// Une méthode BitCLR permettant de mettre à 0 un bit de rang fixé.
 p = BitCLR(n,3);
 System.Console.WriteLine("BitCLR(n,3) ="+ToBinary(p));
//méthode BitCHG permettant de remplacer un bit de rang fixé par son complément.
 r = BitCHG(n,3);
 System.Console.WriteLine("BitCHG(n,2) ="+ToBinary(r)); 
// méthode SetValBit permettant de modifier un bit de rang fixé.
t = SetValBit(n, 2,1);
 System.Console.WriteLine("SetValBit(n,2,1) ="+ToBinary(t));
//Une méthode DecalageD permettant de décaler les bits d'un entier, sur la droite de n positions 
e= DecalageD(n ,3);
 System.Console.WriteLine("DecalageD(n,3) ="+ToBinary(e));
f = DecalageG(n , 3);
System.Console.WriteLine("DecalageG(n,3) ="+ToBinary(f));
  }



  // ToBinary nous permet de mettre des nombre entier sur 8bits
    public static string ToBinary(int x)
    {
        char[] buff = new char[32];
 
        for (int i = 8; i >= 0 ; i--)
        {
            int mask = 1 << i;
            buff[31 - i] = (x & mask) != 0 ? '1' : '0';
        }
 
        return new string(buff);
    }
        // creation de la methode bitset
        static int BitSET ( int nbr , int num ) {
    
            //nous permet de positionner à un 1 le byte de rang n
            int mask; 
              mask =1<< num; 
          return nbr | mask; 

        }
        static int BitCLR ( int nbr , int n ){
            int mask;
            // nous permet de positionner à 0 le bit de rang n
                        mask = ~  (1 << n);
                        return nbr & mask;
        }
        static int BitCHG ( int nbr , int n)
        {
            int mask;
            // si le bit est à 1 il passe à 0 si il est à 0 il passe à 1
            mask = 1 << n ;
            return  n ^ mask ; 
        }
        static int DecalageD ( int nbr , int n)
        {
            //fait un decalage sur la droite
            return nbr >> n;
        }
        static int DecalageG ( int nbr, int n)
                {
                    //fait un decalage sur la gauche
                    return nbr << n;
                }
        static int BitRang ( int nbr , int rang)
        {
            // nous retourne un bit de rang fixé
            return (nbr >> rang) % 2;
        }
        static int SetValBit(int nbr , int rang , int valeur)
        {
            // nous permet de mettre à val le bit de rang fixé
             return    valeur ==0 ? BitCLR( nbr,rang):BitSET( nbr,rang) ;
        }
        static int ROL (int nbr, int n)
{ //décalage à gauche avec rotation
        int C;
        int N = nbr;
        for(int i=1; i<=n; i++)
         {
            C = BitRang(N,31);
            N = N <<1;
            N = SetValBit(N,0,C);
         }
        return N ;
}
static int ROR (int nbr,int n)
{ //décalage à droite avec rotation
        int C;
        int N = nbr;
        for(int i=1; i<=n; i++)
         {
            C = BitRang(N,0);
            N = N >> 1;
            N = SetValBit(N,31,C);
         }
        return N ;
}
    }


