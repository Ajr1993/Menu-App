using System.Reflection.Metadata.Ecma335;

public class Menu{
    int menuId;
    List<Menu> foodItems = new List<Menu>();
    double price;
    bool isHalal;
    string foodName;
   
    public Menu(int menuId,  double price, bool isHalal, string foodName){
        this.menuId = menuId;
        this.price = price;
        this.isHalal = isHalal;
        this.foodName =foodName;
    }
    public int getmenuId(){
        return menuId;
    }
    public List<Menu> getFoodItems(){
        return foodItems;
    }
    public double getPrice(){
        return price;
    }
    public bool getisHalal(){
        return isHalal;
    }
    public string getFoodName(){
        return foodName;
    }
    
public string findFoodByName(Menu menu, string nameId){
    for(int i =0; i < menu.getFoodItems().Count; i++){
        var foodName = menu.getFoodItems()[i];
        if(foodName.getFoodName() == nameId){
            Console.WriteLine("Here are the foods by name " + foodName);
            return foodName.getFoodName();
        }
    }
    return "Food not found";
}
    
public bool isHalalFood(Menu menu){
    for(int i =0; i < menu.getFoodItems().Count; i++){
        var item = menu.getFoodItems()[i];
        if((!item.isHalal)){
            Console.WriteLine("Food is not Halal");
            return false;
        } else {
            Console.WriteLine("The food item is Halal " + item.getFoodName());
        }
    }
    return true;

}
public void addFoodItem(Menu menu, Menu foodItem){
foodItem.getFoodItems().Add(foodItem);
}
public void removeFoodItem(Menu menu, Menu foodItem){
foodItem.getFoodItems().Add(foodItem);
}
public double getMostExpensiveFood(Menu menu){

double expensive = menu.getFoodItems()[0].getPrice();
for(int i =1; i < menu.getFoodItems().Count; i++){
    double next = menu.getFoodItems()[1].getPrice();
    if(expensive < next){
        expensive = next;
    }
}
return expensive;
}
public double getCheapestItem(Menu menu){
    double cheapest = menu.getFoodItems()[0].getPrice();
    for(int i =0; i < menu.getFoodItems().Count; i++){
        double currentItem = menu.getFoodItems()[1].getPrice();
        if(currentItem < cheapest){
            cheapest = currentItem;
        }
    }
    return cheapest;
}
public double findTotoalCost(Menu menu){
    double total = 0.0;
    for(int i =0; i < menu.getFoodItems().Count; i++){
        var foodCost = menu.getFoodItems()[i];
        total = total + foodCost.getPrice();
        Console.WriteLine("The total is " + total);
    }
    return total;
}
public void displayMenu(Menu menu){
    for(int i =0; i < menu.getFoodItems().Count; i++){
        var menuItems = menu.getFoodItems()[i];
        Console.WriteLine("Here is the food on the menu " + menuItems);
    }
}
}