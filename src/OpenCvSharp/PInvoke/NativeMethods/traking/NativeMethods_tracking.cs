﻿using System;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;
using System.Text;
using OpenCvSharp.Tracking;

#pragma warning disable 1591
#pragma warning disable CA1401 // P/Invokes should not be visible

// ReSharper disable UnusedMember.Global
// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo

namespace OpenCvSharp
{
    static partial class NativeMethods
    {
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus tracking_Tracker_init(IntPtr obj, IntPtr image, Rect boundingBox);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus tracking_Tracker_update(IntPtr obj, IntPtr image, ref Rect boundingBox, out int returnValue);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus tracking_Ptr_Tracker_delete(IntPtr ptr);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus tracking_Ptr_Tracker_get(IntPtr ptr, out IntPtr returnValue);


        // TrackerKCF

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus tracking_TrackerKCF_create1(out IntPtr returnValue);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus tracking_TrackerKCF_create2(TrackerKCF.Params parameters, out IntPtr returnValue);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus tracking_Ptr_TrackerKCF_delete(IntPtr ptr);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus tracking_Ptr_TrackerKCF_get(IntPtr ptr, out IntPtr returnValue);


        // TrackerMIL

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus tracking_TrackerMIL_create1(out IntPtr returnValue);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe ExceptionStatus tracking_TrackerMIL_create2(TrackerMIL.Params* parameters, out IntPtr returnValue);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus tracking_Ptr_TrackerMIL_delete(IntPtr ptr);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus tracking_Ptr_TrackerMIL_get(IntPtr ptr, out IntPtr returnValue);
        

        // TrackerGOTURN

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus tracking_TrackerGOTURN_create1(out IntPtr returnValue);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe ExceptionStatus tracking_TrackerGOTURN_create2(TrackerGOTURN.Params* parameters, out IntPtr returnValue);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus tracking_Ptr_TrackerGOTURN_delete(IntPtr ptr);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus tracking_Ptr_TrackerGOTURN_get(IntPtr ptr, out IntPtr returnValue);


        // TrackerCSRT

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus tracking_TrackerCSRT_create1(out IntPtr returnValue);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus tracking_TrackerCSRT_create2(ref TrackerCSRT.Params parameters, out IntPtr returnValue);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus tracking_Ptr_TrackerCSRT_delete(IntPtr ptr);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus tracking_Ptr_TrackerCSRT_get(IntPtr ptr, out IntPtr returnValue);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus tracking_TrackerCSRT_setInitialMask(IntPtr tracker, IntPtr mask);
    }
}