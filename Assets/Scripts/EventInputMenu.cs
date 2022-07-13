using System;

public static class EventInputMenu

{

    public static Action<int, int, int> Data;   //событие, на которое будет подписка

    public static void ChangeData(int delta, int offset, int angel)  //метод оповещения, о том что событие произошло
    {
        Data?.Invoke(delta, offset, angel);    //оповещение, о том что событие произошло (? означает, что команда выполнится только если хоть кто-то подписан)
    }

}

