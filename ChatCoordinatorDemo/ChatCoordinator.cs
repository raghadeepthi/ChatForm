using System;
using System.Collections.Generic;

public delegate void MessageHandler(string message);
public class ChatCoordinator
{
    //Singleton class - A class which can be instantiated only once
    // Private consturctor so that instance of this class cannot be created outside the class
    private ChatCoordinator()
    {

    }
    private static ChatCoordinator obj;
    // As the class is private and singleton to instantiated using method
    public static ChatCoordinator GetObject()
    {
        if (obj == null)
            obj = new ChatCoordinator();
        return obj;

    }
    
    List<MessageHandler> lstHandler = new List<MessageHandler>();
    public void register(MessageHandler handler)
    {
        lstHandler.Add(handler);
    }
    public void Broadcast(string message)
    {
        foreach (MessageHandler mh in lstHandler)
        {
            mh(message);
        }
    }


   





}

