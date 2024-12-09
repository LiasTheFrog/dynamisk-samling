using System.Runtime.InteropServices;

public class Samling<T>{
    int buffert;
    T[] Listan;
    int längd;
    int antal;

public void expandera(int storlek){
if(storlek<1){
return;
}else{
    längd = längd + storlek;
    T[] temp = new T[längd];
for(int i = 0; i < antal; i++){
temp[i] = Listan[i];
}
Listan = temp;
}
}

public void reducera(){
    längd = antal;
    T[] temp = new T[längd];
for(int i = 0; i < antal; i++){
temp[i] = Listan[i];
}
Listan = temp;
}

public void läggtill(T b){
if(antal == längd){
expandera(1);
}
Listan[antal] = b;
}

public void print(){
    for(int i = 0; i < antal; i++){
Console.WriteLine(Listan[i]);
}
}
    public Samling(){
buffert = 30;
Listan = new T[längd];
längd = 30;
antal = 0;
    }

}

class Program{
    static void Main(){
Samling<bool> MinSamling= new Samling<bool>();
MinSamling.läggtill(true);
MinSamling.läggtill(false);
MinSamling.reducera();
MinSamling.print();
    }
}

