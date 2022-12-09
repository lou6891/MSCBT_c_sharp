using System;


internal class Cars{

    public string Brand= "VolksWagen Polo";
    public string CarPlate = "FK999NS";

    public string CarYear = "2016";

    public string Location =  "hello";

    public void WriteConsole(){
                Console.WriteLine("Brand: " +Brand + " Plate Number: " + CarPlate +  " Year built: "+ CarYear + " Location: " + Location);

    }
    

    public void SetLocation(string newLocation){
        
        if(newLocation != "Madrid"){
            Location = newLocation;
        }
        else{
            Console.WriteLine("_______________ The city is not correct ________________");
        }
               
        
    }
}
