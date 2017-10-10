// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

using scm=System.ComponentModel;
using uei=UnityEngine.Internal;
using RequiredByNativeCodeAttribute=UnityEngine.Scripting.RequiredByNativeCodeAttribute;
using UsedByNativeCodeAttribute=UnityEngine.Scripting.UsedByNativeCodeAttribute;

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngineInternal;

namespace UnityEngine.Networking
{


[StructLayout(LayoutKind.Sequential)]
public sealed partial class DownloadHandlerTexture : DownloadHandler
{
    
            private Texture2D mTexture;
            private bool mHasTexture;
            private bool mNonReadable;
    
    
    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    extern internal void InternalCreateTexture (bool readable) ;

    public DownloadHandlerTexture()
        {
            InternalCreateTexture(true);
        }
    
    
    [RequiredByNativeCode] 
    public DownloadHandlerTexture(bool readable)
        {
            InternalCreateTexture(readable);
            mNonReadable = !readable;
        }
    
    
    protected override byte[] GetData()
        {
            return InternalGetData();
        }
    
    
    public Texture2D texture
        {
            get { return InternalGetTexture(); }
        }
    
    
    private Texture2D InternalGetTexture()
        {
            if (mHasTexture)
            {
                if (mTexture == null)
                {
                    mTexture = new Texture2D(2, 2);
                    mTexture.LoadImage(GetData(), mNonReadable);
                }
            }
            else if (mTexture == null)
            {
                mTexture = InternalGetTextureNative();
                mHasTexture = true;
            }

            return mTexture;
        }
    
    
    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    extern private Texture2D InternalGetTextureNative () ;

    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    extern private byte[] InternalGetData () ;

    public static Texture2D GetContent(UnityWebRequest www)
        {
            return GetCheckedDownloader<DownloadHandlerTexture>(www).texture;
        }
    
    
}


}