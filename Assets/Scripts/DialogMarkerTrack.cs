
using UnityEngine.Timeline;

[TrackColor(0.2f, 0.2f, 0.3f)]
[TrackClipType(typeof(DialogMarker))]
[TrackBindingType(typeof(DialogReciever))]
public class DialogMarkerTrack : MarkerTrack
{
    
}
