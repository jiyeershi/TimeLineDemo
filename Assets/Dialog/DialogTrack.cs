using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using System.Collections.Generic;
using UnityEngine.Animations;

[TrackColor(0.855f, 0.8623f, 0.87f)]
[TrackClipType(typeof(DialogClip))]
[TrackBindingType(typeof(Dialog))]
public class DialogTrack : TrackAsset
{
    public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
    {
        return ScriptPlayable<DialogMixerBehaviour>.Create (graph, inputCount);
    }

    // Please note this assumes only one component of type AimConstraint on the same gameobject.
    public override void GatherProperties (PlayableDirector director, IPropertyCollector driver)
    {
#if UNITY_EDITOR
        Dialog trackBinding = director.GetGenericBinding(this) as Dialog;
        if (trackBinding == null)
            return;

#endif
        base.GatherProperties (director, driver);
    }
}
