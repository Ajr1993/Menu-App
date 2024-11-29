using System.Dynamic;

namespace MyProject;

public class Allergy{
    int allergyID;
    string allergenName;
    string allergySeverity;
    string allergyDescription;
    List<Allergy> affectedItems = new List<Allergy>();

    public Allergy(int allergyID, string allergenName, string allergySeverity, string allergyDescription){
        this.allergyID = allergyID;
        this.allergenName = allergenName;
        this.allergySeverity = allergySeverity;
        this.allergyDescription = allergyDescription;
    }

    public  int getallergyID(){
        return allergyID;
    }
    public string getAllergenName(){
        return allergenName;
    }
    public string getAllergySeverity(){
        return allergySeverity;
    }
    public string getAllergyDescription(){
        return allergyDescription;
    }
    public List<Allergy> getAffectedItems(){
        return affectedItems;
    }

public void addAffectedItem(Allergy allergy, Allergy affectedItem){
    if(allergy.getAffectedItems().Contains(affectedItem)){
        allergy.getAffectedItems().Add(affectedItem);
        Console.WriteLine("Your item has been added to affected items " + affectedItems);
    } else {
        Console.WriteLine("Your item has not been added to affected items " + affectedItems);
    }
}
public void removeAffectedItem(Allergy affectedItem, Allergy allergy){
    if(allergy.getAffectedItems().Contains(affectedItem)){
    allergy.getAffectedItems().Remove(affectedItem);
    Console.WriteLine("Your item has been added to affected items " + affectedItems);
} else {
        Console.WriteLine("Your item has not been added to affected items " + affectedItems);
    }

}
public void getAllergySummary(Allergy allergy){
    Console.WriteLine("The allergy id is " + allergy.getallergyID());
    Console.WriteLine("The name of the allergy is " + allergy.getAllergenName());
    Console.WriteLine("The severity of the allergy is " + allergy.getAllergySeverity());
    Console.WriteLine("The allergy description is " + allergy.getAllergyDescription());
    for(int i =0; i < allergy.getAffectedItems().Count; i++){
        var affectedItems = allergy.getAffectedItems()[i];
        Console.WriteLine("The affected items are " + affectedItems.getAllergenName());
    }
    
}
public void updateAllergyDetails(Allergy allergy){
   Console.WriteLine("PLease select which option you would like to update");
   Console.WriteLine("1. update allergy id");
   Console.WriteLine("2. update allergen name");
   Console.WriteLine("3. update allergen description ");
   
   string userInput = Console.ReadLine();
   
   switch(userInput) {
    case "1":
    Console.WriteLine("PLease enter the new allergy id");
    int newId;
    if(int.TryParse(Console.ReadLine(), out newId)){
       allergy.allergyID = newId;
       Console.WriteLine("The allergy id has been updated");
    }
    break;

    case "2":
    Console.WriteLine("PLease enter the new allergen name");
    string newName = Console.ReadLine();
    allergy.allergenName = newName;
    Console.WriteLine("The allergen name has been updated");
    break;

    case "3":
    Console.WriteLine("Please enter the new description of the allergen");
    string newDescription = Console.ReadLine();
    allergy.allergyDescription = newDescription;
    Console.WriteLine("The allergen description has been updated");
    break;

        default:
        Console.WriteLine("Invalid number");
        break;
   }


   }
   
   
}


