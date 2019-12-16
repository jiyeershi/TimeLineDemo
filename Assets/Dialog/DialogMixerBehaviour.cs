using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.Animations;

public class DialogMixerBehaviour : PlayableBehaviour
{


    Dialog m_TrackBinding;

    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        m_TrackBinding = playerData as Dialog;

        if (m_TrackBinding == null)
            return;


        int inputCount = playable.GetInputCount ();

        float totalWeight = 0f;
        float greatestWeight = 0f;

        for (int i = 0; i < inputCount; i++)
        {
            float inputWeight = playable.GetInputWeight(i);
            ScriptPlayable<DialogBehaviour> inputPlayable = (ScriptPlayable<DialogBehaviour>)playable.GetInput(i);
            DialogBehaviour input = inputPlayable.GetBehaviour ();
            
            totalWeight += inputWeight;
            if (inputWeight > greatestWeight)
            {
                m_TrackBinding.text.text = input.Desc;
                greatestWeight = inputWeight;
            }
        }
    }
}
