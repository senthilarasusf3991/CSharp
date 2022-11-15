namespace MultiCastingEvents
{
    public delegate void EventManager();
    public class Events
    {
        private string _eventName;
        public static event EventManager eventlink; //user Defined Event
        static int i;
        public Events (string eventName){_eventName=eventName; }
        public static void HandleEvent() //Event Triggering method
        {
            i=0;
            System.Console.WriteLine("User Registration ");
            System.Console.WriteLine("Starting the following events ");
            eventlink(); //Event Trigger -. Like clicking a button 
        }
        public void StartEvent() //Explanation about the button click action
        {
            ++i;
            System.Console.WriteLine("Event No : "+i+" is: "+_eventName+" Started ");
        }
        
    }
}