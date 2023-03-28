using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityTD
{
    class Program
    {
        //sorumluluk zinciri
        //linkedlistelere benzer
        //if bloklarını dikeyden yataya taşımak şeklinde düşünülebilir
        //client var ->handler var<-concreatehandler1 , concreate handler2
        //DVI,VGA,HDMI
        //soyut sınıf var absract üsttekilere eklenen
        //Agountukaynagı->DVI,VGA,HDMI  --goster() metodu var
        //zincir 1dvı,2vga,2hdmı
        
        static void Main(string[] args)
        {
           
           
            //Goruntu goruntu = new Goruntu(new DVI());
            //goruntu.Ekle();
            //goruntu.Goster();

            //Goruntu goruntu1 = new Goruntu(new VGA());
            //goruntu1.Ekle();
            //goruntu1.Goster();

            //Goruntu goruntu2 = new Goruntu(new HDMI());
            //goruntu2.Ekle();
            //goruntu2.Goster();




            Console.ReadLine();
            
            
        }
    }
}
