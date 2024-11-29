public class Event{
    int eventId;
    string title;
    string date;
    string time;
    int maxAttendees;
    int requestorID;
    bool isApproved;
    private int estimatedAttendees;
    List<Event> eventsList = new List<Event>();

    public Event(int eventId, string title, string date, string time, int maxAttendees, int requestorID, bool isApproved,
   int estimatedAttendees, List<Event>eventsList){
        this.eventId = eventId;
        this.title = title;
        this.date = date;
        this.time = time;
        this.maxAttendees = maxAttendees;
        this.requestorID = requestorID;
        this.isApproved = isApproved;
         Console.WriteLine("Please enter the estimated number of attendees");
    string userInput = Console.ReadLine();
    if(int.TryParse(userInput, out int attendees));
    this.estimatedAttendees = attendees;
    this.eventsList = eventsList;
    }

    public int getEventId(){
        return eventId;
    }
    public string getTitle(){
        return title;
    }
    public string getTime(){
        return time;
    }
    public string getDate(){
        return date;
    }
    public int getmaxAttendees(){
        return maxAttendees;
    }
    public int getRequestorID(){
        return requestorID;
    }
    public bool getIsApproved(){
        return isApproved;
    }
    public int getEstimatedAttendees(){
        return estimatedAttendees;
    }
    public List<Event> getEventsList(){
        return eventsList;
    }
    public void setTime(string time){
        this.time = time;
    }
    public void setDate(string date){
        this.date = date;
    }
    public void setMaxAttendees(int maxAttendees){
        this.maxAttendees = maxAttendees;
    }
    public bool findCustomerByID(Customer customer, int searchID){
     for(int i =0; i < customer.getCustomers().Count; i++){
        var currentCustomer = customer.getCustomers()[i];
        if(currentCustomer.getID() == searchID){
            Console.WriteLine("We have found matching id's");
        }
     }
     return true;
}
    public bool checkAvailability(Event events, string date, string time, int eventiD){
        for(int i =0; i < events.getEventsList().Count; i++){
            if(events.getEventId() == eventiD && events.getDate() == date && events.getTime() == time){
                Console.WriteLine("Availability has been confirmed");
                return true;
            } else{
                Console.WriteLine("There is no availability left");
            }
        }
      
            return false;
        }
        public void addEvent(Event events){
            events.getEventsList().Add(events);
            Console.WriteLine("Your event has been added");
        }
        public void removeEvent(Event events, string eventIdentity){
          for(int i =0; i < events.getEventsList().Count; i++){
            var currentEvent = events.getEventsList()[i];
            if(currentEvent.Equals(eventIdentity)){
                Console.WriteLine("Your event has been removed");
            }
          }
          }
         
        public void listAllEvents(Event upcommingEvents){
            if(upcommingEvents.getEventId() == 0){
                Console.WriteLine("No events on system");
            } else {
                for(int i =0; i < upcommingEvents.getEventsList().Count; i++){
                    var gig = upcommingEvents.getEventsList()[i];
                    Console.WriteLine("THe list of events is " + gig);
                }
                
            }
        }
        public int calculateTotalAttendees(){
            int total = 0;
      for(int i =0; i < eventsList.Count; i++){
        total = total + eventsList[i].getmaxAttendees();
        Console.WriteLine("The total attendees is " + total);
      }
      return total;
}
}

