public class Order{
    int orderId;
    string orderedBy;
    string orderTime;
    string orderType;
    bool orderStatus;
    List<string> orderList;
    string approvedBy;
    double estimatedTime;

    public Order(int orderId, string orderedBy, string orderTime, string orderType, List<string> orderList, 
    string approvedBy, double estimatedTime) {
        this.orderId = orderId;
        this.orderedBy = orderedBy;
        this.orderTime = orderTime;
        this.orderType = orderType;
        this.orderList = orderList;
        this.approvedBy = approvedBy;
        this.estimatedTime = estimatedTime;
    }

    public int getOrderId(){
        return orderId;
    }
    public string getOrderTime(){
        return orderTime;
    }
    public string getOrderType(){
        return orderType;
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

    public void addItemToOrder(Order order, int orderID, string item){
       var currentOrder = order.getOrderId();
       if(currentOrder == orderID){
            order.getOrderList().Add(item);
            Console.WriteLine("Your item has been added to order");
       } else {
        Console.WriteLine("Couldnt find your order");
       }
    }
    
    public void removeItemFromOrder( int orderID, string item){
        if (this.getOrderId() == orderID){
        if (this.getOrderList().Remove(item)) {
         Console.WriteLine("The item '" + item + "' has been removed from Order ID " + orderID);
        } else {
            Console.WriteLine("The item '" + item + "' was not found in the order.");
        }
    }
    else
    {
        Console.WriteLine("Couldn't find your order ID: " + orderID);
    }
    } 
    public void getOrderSummary(Order order){
        Console.WriteLine("Your orderId is " + orderId);
        Console.WriteLine("Your orderId is " + orderedBy);
        Console.WriteLine("Your orderId is " + orderList);
        Console.WriteLine("Your orderId is " + orderStatus);
        Console.WriteLine("Your orderId is " + orderTime);
        Console.WriteLine("Your orderId is " + orderType);
        Console.WriteLine("Your orderId is " + approvedBy);
        Console.WriteLine("Your orderId is " + estimatedTime);
        for(int i =0; i < order.getOrderList().Count; i++){
            string items = order.getOrderList()[i];
            Console.WriteLine(items.ToString());
        }
    }
    }
