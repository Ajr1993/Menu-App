using System.Threading.Channels;

namespace MyProject;

public class Test{
    
     public static void Main(string[] args){
        Console.WriteLine("Welcome to the restaurant menu app ");

        List<string> details = new List<string>{"burger", "pizza"};
        Customer customer = new Customer(1, "John", "Smith", "123 blah blah", 07794111023, "06/02/1996", 
        details, true, false, true, false, true, 3);

        List<string> input = new List<string>{"chips", "pizza"};
       Booking booking = new Booking(1, "gf", "partner", 11.30, "Takeaway", "Out for delivery", input, "James", 13.50,
        18, "18/12/2024", "18.10");

        List<Event> eventsToCome = new List<Event>{};
        Event events = new Event(1, "Party hard", "26/11/2024", "17.13", 180, 13, true, 200, eventsToCome);

        Menu menu = new Menu(13, 13.44, false, "Pasta");
        Allergy allergy = new Allergy(12, "peanut", "moderate", "Itchy rash and vomiting");

        List<string> orders = new List<string>{"Burger", "fries"};
        Order order = new Order(1, "aled", "12:30", "Eat in", orders, "Jon", 18.00);

        while(true){
            Console.WriteLine("1. Check table availability: ");
            Console.WriteLine("2. Request event: ");
            Console.WriteLine("3. Cancel a booking: ");
            Console.WriteLine("4. Place food order: ");
            Console.WriteLine("5. View menu items: ");
            Console.WriteLine("6. Has allergies: ");
            Console.WriteLine("7. Is 18 or over: ");
            Console.WriteLine("8. Get table ID: ");
            Console.WriteLine("9. Check table availability: ");
            Console.WriteLine("10. approvedByStaff: ");
            Console.WriteLine("11. Add booking: ");
            Console.WriteLine("12. Find customer by ID: ");
            Console.WriteLine("13. Check availability: ");
            Console.WriteLine("14. Add event : ");
            Console.WriteLine("15. Remove event: ");
            Console.WriteLine("16. List all events: ");
            Console.WriteLine("17. Calculate total attendees: ");


            int choice;
            if(int.TryParse(Console.ReadLine(), out choice)){
              switch(choice){
                case 1:
                customer.setRequestBooking(customer, booking);
                break;
                case 2:
                customer.requestEvent(booking, events);
                break;
                case 3:
                List<Booking> bookingList = new List<Booking>{booking};
                customer.cancelBookinginList(bookingList,  booking, customer);
                break;
                case 4:
                customer.placeOrderForFood(order, booking);
                break;
                case 5:
                customer.viewMenuItems(menu);
                break;
                case 6:
                customer.hasAllergies(allergy, menu);
                break;
                case 7:
                customer.is18OrOver(customer);
                break;
                case 8:
                Console.WriteLine("Enter the table id to search");
                int searchID;
                if(int.TryParse(Console.ReadLine(), out searchID)){
                booking.getTableID(booking, searchID);
                }
                break;
                case 9:
                Console.WriteLine("Please enter the table id:");
                int tableId;
                if(int.TryParse(Console.ReadLine(), out tableId));

                Console.WriteLine("Please enter the date:");
                string date = Console.ReadLine();

                
                Console.WriteLine("Please enter the time:");
                string time = Console.ReadLine();
                booking.checkTableAvailability(booking, tableId, date, time);
                break;

                case 10:
                Console.WriteLine("Please the staff who approved the booking:");
                int staffId;
                if(int.TryParse(Console.ReadLine(), out staffId))
                booking.approvedByStaff(booking, staffId);
                break;
                case 11:
                Console.WriteLine("Click here to add the booking");
                booking.addBooking(booking);
                break;
                case 12:
                Console.WriteLine("Click here to remove the booking");
                booking.removeBooking(booking);
                break;
                case 13:
                Console.WriteLine("Click here to check availability for events:");
                int eventID; 
                if(int.TryParse(Console.ReadLine(), out eventID))
                Console.WriteLine("Please enter the time: ");
                string eventTime = Console.ReadLine();
                Console.WriteLine("Please enter the date: ");
                string Eventdate = Console.ReadLine();
                events.checkAvailability(events, Eventdate, eventTime, eventID);
                break;
                case 14:
                Console.WriteLine("Click here to add an event: ");
                events.addEvent(events);
                break;
                case 15:
                Console.WriteLine("Click here to remove an event: ");
                string eventIdentity = Console.ReadLine();
                events.removeEvent(events, eventIdentity);
                Console.WriteLine("Event removed successfully");
                break;
                case 16:
                Console.WriteLine("Click here to List all of the event: ");
                events.listAllEvents(events);
                break;
                case 17:
                 Console.WriteLine("Click here to List of the total attendees: ");
                 events.calculateTotalAttendees();
                 break;
                 case 18:
                 Console.WriteLine("Click here to add an affected item to the list: ");
                 Console.WriteLine("Please enter the allergy id: ");
                 int allergyId = int.Parse(Console.ReadLine());
                 Console.WriteLine("Please enter the allergy name: ");
                 string allergyName = Console.ReadLine();
                 Console.WriteLine("Please enter the severity of the allergy");
                 string allergySeverity = Console.ReadLine();
                 Console.WriteLine("Please enter the allergy description: ");
                 string description = Console.ReadLine();

                 Allergy allergies = new Allergy(allergyId, allergyName, allergySeverity, description );
                 allergy.addAffectedItem(allergies, allergy);
                 break;
                 case 19:
                 Console.WriteLine("Click here to remove an affected item to the list: ");
                 Console.WriteLine("Please enter the allergy id: ");
                 int allergyId1 = int.Parse(Console.ReadLine());
                 Console.WriteLine("Please enter the allergy name: ");
                 string allergyInput = Console.ReadLine();
                 Console.WriteLine("Please enter the severity of the allergy");
                 string severityOfAllergy = Console.ReadLine();
                 Console.WriteLine("Please enter the allergy description: ");
                 string allergyDescription = Console.ReadLine();

                 Allergy allergy1 = new Allergy(allergyId1, allergyInput, severityOfAllergy,allergyDescription);
                 allergy.removeAffectedItem(allergy1, allergy);
                break;
                case 20:
                Console.WriteLine("Click here to get the summary of the allergy: ");
                allergy.getAllergySummary(allergy);
                break;
                case 21:
                Console.WriteLine("Click here to update the details of the allergy: ");
                allergy.updateAllergyDetails(allergy);
                break;
                case 22:
                List<string> order1 = new List<string>();
                int newOrderId = 1;
                Order newOrder = new Order(newOrderId, "Bf", "12:45", "Takeaway", order1, "dave", 14.45);
                Console.WriteLine("PLease enter the name of the item: ");
                string item = Console.ReadLine();
                newOrder.addItemToOrder(newOrder, newOrderId, item);
                break;
                case 23:
                List<string> order2 = new List<string> { "Burger", "Fries", "Soda" }; 
                int nextOrderId = 2;
                Order nextOrder = new Order(nextOrderId, "GF", "13:45", "Takeaway", order2, "Bob", 15.45);
                Console.WriteLine("Current items in the order: " + string.Join(", ", order2));
                Console.WriteLine("Please enter the name of the item to remove: ");
                string nextItem = Console.ReadLine();
                nextOrder.removeItemFromOrder(nextOrderId, nextItem);
                break;
              }
            }


        }


 
            
            
            
           


    }

}
