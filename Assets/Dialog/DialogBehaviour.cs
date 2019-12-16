using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.Animations;

[Serializable]
public class DialogBehaviour : PlayableBehaviour
{
    public string Desc;
    public Dialog dialog;
    
    public override void OnGraphStart(Playable playable)
    {
//        Debug.Log("------------DialogBehaviour OnGraphStart-------------");      
    }
    
    public override void OnGraphStop(Playable playable)
    {
//        Debug.Log("------------DialogBehaviour OnGraphStop-------------");
    }

    public override void OnPlayableCreate(Playable playable)
    {
        //dialog =  playable.GetGraph().GetResolver();
        
//        object aa = playable.GetUserData();
//        Debug.Log("------------DialogBehaviour OnPlayableCreate-------------");
        
    }


    public override void OnPlayableDestroy(Playable playable)
    {
//        Debug.Log("------------DialogBehaviour OnPlayableDestroy-------------");
        if (dialog)
        {
//            dialog.Close();    
        }
    }

  
    public override void OnBehaviourDelay(Playable playable, FrameData info)
    {
//        Debug.Log("------------DialogBehaviour OnBehaviourDelay-------------");
    }


    public override void OnBehaviourPlay(Playable playable, FrameData info)
    {
        
        dialog = info.output.GetUserData() as Dialog;
//        Debug.Log("------------DialogBehaviour OnBehaviourPlay-------------" + dialog);
        dialog.Open();
    }

   
    public override void OnBehaviourPause(Playable playable, FrameData info)
    {
//        Debug.Log("------------DialogBehaviour OnBehaviourPause-------------");
        if (dialog)
        {
            dialog.ShowComplete();    
        }
    }

    
    public override void PrepareData(Playable playable, FrameData info)
    {
//        Debug.Log("------------DialogBehaviour PrepareData-------------");
    }

    private int j = 0;
    public override void PrepareFrame(Playable playable, FrameData info)
    {
        if (j++ == 0)
        {
//            Debug.Log("------------DialogBehaviour PrepareFrame-------------");    
        }
        
    }


    private int i = 0; 
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        if (i++ == 0)
        {
            dialog = playerData as Dialog;
//            Debug.Log("------------DialogBehaviour ProcessFrame-------------");
        }
    }
    
}
