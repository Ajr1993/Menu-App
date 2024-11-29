using System.Reflection.Metadata.Ecma335;

public class Booking{
int bookingID;
string orderedBy;
string orderFor;
double orderTime;
string orderType;
string orderStatus;
List<string> orderList;
string approvedBy;
double estimatedTime;
int tableNumber;
string bookingDate;
string bookingTime;
 private List<Booking> bookingList = new List<Booking>();

public Booking(int bookingId, string orderedBy,string orderFor, double orderTime,string orderType,string orderStatus, List<string> orderList,
string approvedBy, double estimatedTime, int tableNumber, string bookingDate, string bookingTime){
    this.bookingID = bookingID;
    this.orderedBy = orderedBy;
    this.orderFor = orderFor;
    this.orderType = orderType;
    this.orderStatus = orderStatus;
    this.orderList = orderList;
    this.approvedBy = approvedBy;
    this.estimatedTime = estimatedTime;
    this.tableNumber = tableNumber;
    this.bookingDate = bookingDate;
    this.bookingTime = bookingTime;
 
}

public int getBookingID(){
    return bookingID;
}
public string getOrderedBy(){
    return orderedBy;
}
public string getOrderFor(){
    return orderFor;
}
public double getOrderTime(){
    return orderTime;
}
public string getOrderType(){
    return orderType;
}
public string getOrderStatus(){
    return orderStatus;
}
public List<string> getOrderList(){
    return orderList;
}
public string getApprovedBy(){
    return approvedBy;
}
public double getEstimatedTime(){
    return estimatedTime;
}
public int getTableNumber(){
    return tableNumber;
}
public string getBookingDate(){
    return bookingDate;
} 
public string getBookingTime(){
    return bookingTime;
}
public List<Booking> getBookingList(){
    return bookingList;
}
public int getTableID(Booking booking, int searchID){
    var findTable = booking.getTableNumber();
    if(findTable == searchID){
        Console.WriteLine("The table ID has been found " + findTable);
        return findTable;
    } else {
        Console.WriteLine("The table ID could not be found");
    }
    return -1;
}

public int checkTableAvailability(Booking booking, int tableId, string date, string time){
    for(int i =0; i < booking.getBookingList().Count; i++){
        if(booking.getTableNumber() == tableId && booking.getBookingDate() == date && booking.getBookingTime() == time){
            Console.WriteLine("Your table is free to book");
            return tableId;
        } else {
            Console.WriteLine("You table has not been booked");
        }
    }
    return -1;
}
    
public bool approvedByStaff(Booking booking, int staffId){
    var approved = booking.getApprovedBy();
    if(approved == staffId.ToString()){
        Console.WriteLine("You booking has been approved by a member of staff " + staffId);
        return true;
    } else {
        Console.WriteLine("You booking has npt been approved by a member of staff ");
    }
    return false;
}
public void addBooking(Booking booking){
    bookingList.Add(booking);
    Console.WriteLine("Your booking has been added to the list");
}
public void removeBooking(Booking booking){
    bookingList.Remove(booking);
    Console.WriteLine("Your booking has been removed from the list");
}
}
