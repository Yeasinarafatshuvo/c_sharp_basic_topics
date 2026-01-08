using System;

namespace CSharpBasic
{
    // 1. Define a delegate for the event
    // Standard signature: void MethodName(object sender, EventArgs e)
    public delegate void NotifyEventHandler(object source, EventArgs args);

    class Events
    {
        public static void Run()
        {
            Console.WriteLine("=== C# Events ===");

            // Create the publisher (Process)
            ProcessBusinessLogic bl = new ProcessBusinessLogic();

            // Create the subscriber (Listener)
            EventListener listener = new EventListener();

            // Subscribe to the event using +=
            bl.ProcessCompleted += listener.OnProcessCompleted;

            // Start the process
            Console.WriteLine("Starting process...");
            bl.StartProcess();

            // Unsubscribe using -=
            bl.ProcessCompleted -= listener.OnProcessCompleted;
        }
    }

    // Publisher Class
    public class ProcessBusinessLogic
    {
        // 2. Declare the event using the delegate
        public event NotifyEventHandler ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Process is running...");
            System.Threading.Thread.Sleep(1000); // Simulate work

            // 3. Raise the event
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted()
        {
            // Check if there are any subscribers
            if (ProcessCompleted != null)
            {
                ProcessCompleted(this, EventArgs.Empty);
            }
        }
    }

    // Subscriber Class
    public class EventListener
    {
        public void OnProcessCompleted(object source, EventArgs e)
        {
            Console.WriteLine("Event Received: Process successfully completed!");
        }
    }
}
