﻿using System;
using System.Runtime.InteropServices;
using CoreLocation;
using Foundation;

namespace BMapBinding
{
    //[Verify (InferredFromMemberPrefix)]
    public enum BMKAnnotationViewDragState : uint
    {
        None = 0,
        Starting,
        Dragging,
        Canceling,
        Ending
    }

    /*[StructLayout (LayoutKind.Sequential)]
    public struct 
    {
        public uint keepAlive;

        public uint levelCrossFade;

        public uint drawingDisabled;

        public uint usesTiledLayer;
    }*/

    public enum BMKUserTrackingMode : uint
    {
        None = 0,
        Heading,
        Follow,
        FollowWithHeading
    }

    public enum BMKLogoPosition : uint
    {
        LeftBottom = 0,
        LeftTop,
        CenterBottom,
        CenterTop,
        RightBottom,
        RightTop
    }

    public enum BMKSwitchIndoorFloorError : uint
    {
        Success = 0,
        Failed,
        NotFocused,
        NotExist
    }

    //[Verify (InferredFromMemberPrefix)]
    public enum BMKOfflineStatus : uint
    {
        Update = 0,
        Zipcnt = 1,
        Unzip = 2,
        Errzip = 3,
        Newver = 4,
        Unzipfinish = 5,
        Add = 6
    }

    //[Verify (InferredFromMemberPrefix)]
    public enum BMKPinAnnotationColor : uint
    {
        Red = 0,
        Green,
        Purple
    }
}
