using System;

public class EventBroker
{
    public static event Action YourAction;

    public static void CallYourAction()
    {
        if (YourAction != null)
            YourAction();
    }
    // add EventBroker.CallYourAction(); in publisher
    // add EventBroker.YourAction += *function to call* in Start method of subscriber
    // also in subscriber add EventBroker.YourAction -= *function to call* in OnDisable method
}