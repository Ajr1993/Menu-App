
using System.Reflection.Metadata.Ecma335;
using MyProject;

public class Customer{
    private int ID;
    private string firstName;
    private string lastName;
    private string address;
    private long phoneNumber;
    private string DOB;
    private List<string> orderHistory;
    private bool requestBooking;
    private bool cancelBooking;
    private bool viewMenu;
    private bool allergies;
    private bool placeOrder;
    List<Customer> customers = new List<Customer>();
    public Customer(int ID, string firstName,string lastName,string address,long phoneNumber, string DOB, List<string> orderHistory,
        bool requestBooking, bool cancelBooking, bool viewMenu, bool allergies, bool placeOrder, int estimatedAttendees){
    this.ID = ID;
    this.firstName = firstName;
    this.lastName = lastName;
    this.address = address;
    this.phoneNumber = phoneNumber;
    this.DOB = DOB;
    this.orderHistory = orderHistory;
    this.requestBooking = requestBooking;
    this.cancelBooking = cancelBooking;
    this.viewMenu = viewMenu;
    this.allergies = allergies;
    this.placeOrder = placeOrder;

   
 }
 public int getID(){
    return ID;
 }
 public string getFirstName(){
    return firstName;
 }
 public string getLastName(){
    return lastName;
 }
 public string getAddress(){
    return address;
 }
 public long getphoneNumber(){
    return phoneNumber;
 }
 public string getDOB(){
    return DOB;
 }
 public List<string> getOrderHistory(){
    return orderHistory;
 }
 public bool getRequestBooking(){
    return requestBooking;
 }
 public bool getCancelBooking(){
    return cancelBooking;
 }
 public bool getViewMenu(){
    return viewMenu;
 }
 public bool getAllegeries(){
    return allergies;
 }
 public bool getPlaceOrder(){
    return placeOrder;
 }
 public List<Customer> getCustomers(){
    return customers;
 }
 

 public bool setRequestBooking(Customer customer, Booking booking){
    if(customer.getID() == booking.getTableNumber()){
        Console.WriteLine("You have already booked");
        return true;
    }

    else { 
        Console.WriteLine("Would you like to request a booking, type yes or no");
            string request = Console.ReadLine();
           if(request.ToLower() == "Yes"){
            Console.WriteLine("Request has been chosen. Please enter the date and time and total number of guests");
            string dateAndTime = Console.ReadLine();
            if(booking.getBookingDate() == null && booking.getBookingTime() == null && booking.getTableNumber() == 0){
                Console.WriteLine("Your booking has been approved");
                booking.getBookingList().Add(booking);
                
            }
            else{
                Console.WriteLine("That table has been taken for the time and date");
            }
           }
    }
    return false;
 }
    public bool requestEvent(Booking booking, Event events){
        if(booking.getBookingID() == events.getEventId()){
            Console.WriteLine("Your event has already been requested");
            return true;
        } else {
                Console.WriteLine("Would you like to book an event? type yes or no");
                string input = Console.ReadLine();
                if(input.ToLower() == "Yes"){
                    Console.WriteLine("You have requested an event. Please enter the date and time and max number of people");
                    string time = Console.ReadLine();
                    string date= Console.ReadLine();
                    int maxAttendees;
                    if(int.TryParse(Console.ReadLine(), out maxAttendees)){
                    int estimatedAttendees = events.getEstimatedAttendees();
                    }

                    if(string.IsNullOrEmpty(events.getTime()) && string.IsNullOrEmpty(events.getDate())  &&  events.getEstimatedAttendees() < events.getmaxAttendees()){
                        events.setTime(time);
                        events.setDate(date);
                        events.setMaxAttendees(maxAttendees);
                        
                    } else {
                        Console.WriteLine("Youre event has not been booked");
                        events.getEventsList().Add(events);
                    }
                }
                return false;

            }
        }
        public bool cancelBookinginList(List<Booking> bookingList, Booking booking, Customer customer ){
            for(int i =0; i < bookingList.Count; i++){
                if(booking.getBookingID() == customer.getID()){
                    Console.WriteLine("Your booking has been cancelled");
                    booking.getBookingList().Remove(booking);
                    return true;
                } else {
                    if(bookingList == null){
                        Console.WriteLine("No booking to cancel");
                    }
                }
            }
            return false;
        }
        
        public bool placeOrderForFood(Order order, Booking booking){
            if(order.getOrderId() == 0) {
                Console.WriteLine("There has been no order placed");
                return false;
            }
            else if(booking.getBookingID() == order.getOrderId()){
                Console.WriteLine("Your food has been ordered for Booking Id: " + booking.getBookingID());
                return true;
            }
            return false;
        }
        
       public bool viewMenuItems(Menu menu){
        if(menu.getFoodItems() == null){
            Console.WriteLine("Apologies, but the menu is currently empyty");
            return false;
        }
        for(int i =0; i < menu.getFoodItems().Count; i++){
            var items = menu.getFoodItems()[i];
            Console.WriteLine("Please see the menu item" + items);
            return true;
        }
        return false;
       }
       public bool hasAllergies(Allergy allergy, Menu menu){
            for(int i =0; i < menu.getFoodItems().Count; i++){
                var foodItems = menu.getFoodItems()[i];
                Console.WriteLine("Please see the menu " + foodItems);
            
            for(int j =0; j < allergy.getAffectedItems().Count; j++){
                var items = allergy.getAffectedItems()[j];
                if(menu.getFoodItems().Contains(foodItems).Equals(items)){
                Console.WriteLine("PLease see foods with an allergy " + foodItems);
            
                }
            }
           
       }
       return true;
       
    }
    public bool is18OrOver(Customer customer){
      {
    DateTime DOB;
    
    if (!DateTime.TryParse(customer.getDOB(), out DOB)){
    
        Console.WriteLine("Invalid date.");
        
    }

   
    int age = DateTime.Now.Year - DOB.Year;

    
    if (DateTime.Now.DayOfYear < DOB.DayOfYear){
    
        age--; 
    }

    if (age >= 18) {
        Console.WriteLine("You are of legal age.");
    }

    Console.WriteLine("You are not of legal age.");
    return false;
}
    }
}

    
    


    
    

 
    
