
using UnityEngine;
using UnityEngine.Playables;

public class DialogReciever : MonoBehaviour, INotificationReceiver
{
    public void OnNotify(Playable origin, INotification notification, object context)
    {
        Debug.Log("DialogSignalReciever OnNotify 1 ...");
//        if (notification as DialogMarker)
//        {
//            Debug.Log("DialogSignalReciever OnNotify...");
//        }
    }

  
}
