using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class DialogClip : PlayableAsset, ITimelineClipAsset
{
    public string Desc;
    public DialogBehaviour template = new DialogBehaviour ();

    public ClipCaps clipCaps
    {
        get { return ClipCaps.Blending; }
    }

    public override Playable CreatePlayable (PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<DialogBehaviour>.Create (graph, template);
        template.Desc = Desc;
        return playable;
    }
}
