
package javaapplication19;


public class Model {
    
    int sayi;

    public int getSayi() {
        return sayi;
    }

    public void setSayi(int sayi) {
        if (sayi<5) {
            sayi=0;
            System.out.println("sayi 5 ten kücük");
        }
        else {
           this.sayi = sayi; 
        }   
    }
    
    
    
    
    
}
