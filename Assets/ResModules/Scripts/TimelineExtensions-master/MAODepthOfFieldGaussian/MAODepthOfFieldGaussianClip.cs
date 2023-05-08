// This code is automatically generated by PostProcessing Extension Wizard.
// For more information, please visit 
// https://github.com/ShiinaRinne/TimelineExtensions

using System;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[Serializable]
public class MAODepthOfFieldGaussianClip : PlayableAsset, ITimelineClipAsset
{
    [Min(0f)] public float gaussianStart = 10f;
    [Min(0f)] public float gaussianEnd = 30f;
    [Range(0.5f, 1.5f)] public float gaussianMaxRadius = 1f;
    public bool highQualitySampling = false;


    public ClipCaps clipCaps
    {
        get { return ClipCaps.Blending; }
    }

    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<MAODepthOfFieldGaussianBehaviour>.Create(graph);
        var behaviour = playable.GetBehaviour();

        behaviour.GaussianStart = gaussianStart;
        behaviour.GaussianEnd = gaussianEnd;
        behaviour.GaussianMaxRadius = gaussianMaxRadius;
        behaviour.HighQualitySampling = highQualitySampling;


        return playable;
    }
}