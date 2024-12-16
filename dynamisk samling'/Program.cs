using System.Runtime.InteropServices;

public class Samling<T>{
    /// <summary>
    /// ingenting...
    /// </summary>
    int buffert;  
    T[] Listan;
    /// <summary>
    /// antal tillgängliga platser.
    /// </summary>
    int längd;
    /// <summary>
    /// antalet upptagna platser.
    /// </summary>
    int antal;

/// <summary>
/// utökar listan
/// </summary>
/// <param name="storlek">hur stor listan är</param>
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
antal++;
}

/// <summary>
/// Ska ta bort ett objekt från listan.
/// </summary>
/// <param name="k">vilket index man ska ta bort.</param>
public void TaBort(int k){
if(antal == 0 || k > antal && k < 0){    // fortsätt................... 
    return;
}
Console.WriteLine($"tar bort index {k}");
 T[] temp = new T[längd];
 int d = 0;
for(int i = 0; i < antal-1; i++){
    if(i == k){
        d =1;
    }
    temp[i] = Listan[i+d];
}
Listan = temp;
antal--;
}

public void print(){
    for(int i = 0; i < antal; i++){
Console.WriteLine($"{i}: {Listan[i]}");
}
}
    public Samling(){
buffert = 30;
längd = 30;
Listan = new T[längd];

antal = 0;
    }

}

class Program{
    static void Main(){
Samling<int> MinSamling= new Samling<int>();
MinSamling.läggtill(150);
MinSamling.läggtill(555);
MinSamling.läggtill(333);
MinSamling.läggtill(299);
MinSamling.reducera();
MinSamling.print();
MinSamling.TaBort(2);
MinSamling.print();
    }
}

