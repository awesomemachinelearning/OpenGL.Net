
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Egl
	{
		/// <summary>
		/// [EGL] Value of EGL_CONTEXT_MINOR_VERSION symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int CONTEXT_MINOR_VERSION = 0x30FB;

		/// <summary>
		/// [EGL] Value of EGL_CONTEXT_OPENGL_PROFILE_MASK symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int CONTEXT_OPENGL_PROFILE_MASK = 0x30FD;

		/// <summary>
		/// [EGL] Value of EGL_CONTEXT_OPENGL_RESET_NOTIFICATION_STRATEGY symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int CONTEXT_OPENGL_RESET_NOTIFICATION_STRATEGY = 0x31BD;

		/// <summary>
		/// [EGL] Value of EGL_NO_RESET_NOTIFICATION symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int NO_RESET_NOTIFICATION = 0x31BE;

		/// <summary>
		/// [EGL] Value of EGL_LOSE_CONTEXT_ON_RESET symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int LOSE_CONTEXT_ON_RESET = 0x31BF;

		/// <summary>
		/// [EGL] Value of EGL_CONTEXT_OPENGL_CORE_PROFILE_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		[Log(BitmaskName = "EGLContextProfileMask")]
		public const uint CONTEXT_OPENGL_CORE_PROFILE_BIT = 0x00000001;

		/// <summary>
		/// [EGL] Value of EGL_CONTEXT_OPENGL_COMPATIBILITY_PROFILE_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		[Log(BitmaskName = "EGLContextProfileMask")]
		public const uint CONTEXT_OPENGL_COMPATIBILITY_PROFILE_BIT = 0x00000002;

		/// <summary>
		/// [EGL] Value of EGL_CONTEXT_OPENGL_DEBUG symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int CONTEXT_OPENGL_DEBUG = 0x31B0;

		/// <summary>
		/// [EGL] Value of EGL_CONTEXT_OPENGL_FORWARD_COMPATIBLE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int CONTEXT_OPENGL_FORWARD_COMPATIBLE = 0x31B1;

		/// <summary>
		/// [EGL] Value of EGL_CONTEXT_OPENGL_ROBUST_ACCESS symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int CONTEXT_OPENGL_ROBUST_ACCESS = 0x31B2;

		/// <summary>
		/// [EGL] Value of EGL_OPENGL_ES3_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		[RequiredByFeature("EGL_KHR_create_context")]
		[Log(BitmaskName = "EGLRenderableTypeMask")]
		public const uint OPENGL_ES3_BIT = 0x00000040;

		/// <summary>
		/// [EGL] Value of EGL_CL_EVENT_HANDLE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int CL_EVENT_HANDLE = 0x309C;

		/// <summary>
		/// [EGL] Value of EGL_SYNC_CL_EVENT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int SYNC_CL_EVENT = 0x30FE;

		/// <summary>
		/// [EGL] Value of EGL_SYNC_CL_EVENT_COMPLETE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int SYNC_CL_EVENT_COMPLETE = 0x30FF;

		/// <summary>
		/// [EGL] Value of EGL_SYNC_PRIOR_COMMANDS_COMPLETE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int SYNC_PRIOR_COMMANDS_COMPLETE = 0x30F0;

		/// <summary>
		/// [EGL] Value of EGL_SYNC_TYPE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int SYNC_TYPE = 0x30F7;

		/// <summary>
		/// [EGL] Value of EGL_SYNC_STATUS symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int SYNC_STATUS = 0x30F1;

		/// <summary>
		/// [EGL] Value of EGL_SYNC_CONDITION symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int SYNC_CONDITION = 0x30F8;

		/// <summary>
		/// [EGL] Value of EGL_SIGNALED symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int SIGNALED = 0x30F2;

		/// <summary>
		/// [EGL] Value of EGL_UNSIGNALED symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int UNSIGNALED = 0x30F3;

		/// <summary>
		/// [EGL] Value of EGL_SYNC_FLUSH_COMMANDS_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		[Log(BitmaskName = "EGLSyncFlagsKHR")]
		public const int SYNC_FLUSH_COMMANDS_BIT = 0x0001;

		/// <summary>
		/// [EGL] Value of EGL_FOREVER symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const ulong FOREVER = 0xFFFFFFFFFFFFF;

		/// <summary>
		/// [EGL] Value of EGL_TIMEOUT_EXPIRED symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int TIMEOUT_EXPIRED = 0x30F5;

		/// <summary>
		/// [EGL] Value of EGL_CONDITION_SATISFIED symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int CONDITION_SATISFIED = 0x30F6;

		/// <summary>
		/// [EGL] Value of EGL_NO_SYNC symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int NO_SYNC = 0;

		/// <summary>
		/// [EGL] Value of EGL_SYNC_FENCE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int SYNC_FENCE = 0x30F9;

		/// <summary>
		/// [EGL] Value of EGL_GL_COLORSPACE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int GL_COLORSPACE = 0x309D;

		/// <summary>
		/// [EGL] Value of EGL_GL_RENDERBUFFER symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int GL_RENDERBUFFER = 0x30B9;

		/// <summary>
		/// [EGL] Value of EGL_GL_TEXTURE_2D symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int GL_TEXTURE_2D = 0x30B1;

		/// <summary>
		/// [EGL] Value of EGL_GL_TEXTURE_LEVEL symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int GL_TEXTURE_LEVEL = 0x30BC;

		/// <summary>
		/// [EGL] Value of EGL_GL_TEXTURE_3D symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int GL_TEXTURE_3D = 0x30B2;

		/// <summary>
		/// [EGL] Value of EGL_GL_TEXTURE_ZOFFSET symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int GL_TEXTURE_ZOFFSET = 0x30BD;

		/// <summary>
		/// [EGL] Value of EGL_GL_TEXTURE_CUBE_MAP_POSITIVE_X symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x30B3;

		/// <summary>
		/// [EGL] Value of EGL_GL_TEXTURE_CUBE_MAP_NEGATIVE_X symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x30B4;

		/// <summary>
		/// [EGL] Value of EGL_GL_TEXTURE_CUBE_MAP_POSITIVE_Y symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x30B5;

		/// <summary>
		/// [EGL] Value of EGL_GL_TEXTURE_CUBE_MAP_NEGATIVE_Y symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x30B6;

		/// <summary>
		/// [EGL] Value of EGL_GL_TEXTURE_CUBE_MAP_POSITIVE_Z symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x30B7;

		/// <summary>
		/// [EGL] Value of EGL_GL_TEXTURE_CUBE_MAP_NEGATIVE_Z symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x30B8;

		/// <summary>
		/// [EGL] Value of EGL_IMAGE_PRESERVED symbol.
		/// </summary>
		[AliasOf("EGL_IMAGE_PRESERVED_KHR")]
		[RequiredByFeature("EGL_VERSION_1_5")]
		[RequiredByFeature("EGL_KHR_image_base")]
		public const int IMAGE_PRESERVED = 0x30D2;

		/// <summary>
		/// [EGL] Value of EGL_NO_IMAGE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int NO_IMAGE = 0;

		/// <summary>
		/// [EGL] eglCreateSync: Binding for eglCreateSync.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[AliasOf("eglCreateSync64KHR")]
		[RequiredByFeature("EGL_VERSION_1_5")]
		[RequiredByFeature("EGL_KHR_cl_event2")]
		public static IntPtr CreateSync(IntPtr dpy, uint type, IntPtr[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (IntPtr* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreateSync != null, "peglCreateSync not implemented");
					retValue = Delegates.peglCreateSync(dpy, type, p_attrib_list);
					LogCommand("eglCreateSync", retValue, dpy, type, attrib_list					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglDestroySync: Binding for eglDestroySync.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[AliasOf("eglDestroySyncKHR")]
		[RequiredByFeature("EGL_VERSION_1_5")]
		[RequiredByFeature("EGL_KHR_fence_sync")]
		[RequiredByFeature("EGL_KHR_reusable_sync")]
		public static bool DestroySync(IntPtr dpy, IntPtr sync)
		{
			bool retValue;

			Debug.Assert(Delegates.peglDestroySync != null, "peglDestroySync not implemented");
			retValue = Delegates.peglDestroySync(dpy, sync);
			LogCommand("eglDestroySync", retValue, dpy, sync			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglClientWaitSync: Binding for eglClientWaitSync.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="flags">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="timeout">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[AliasOf("eglClientWaitSyncKHR")]
		[RequiredByFeature("EGL_VERSION_1_5")]
		[RequiredByFeature("EGL_KHR_fence_sync")]
		[RequiredByFeature("EGL_KHR_reusable_sync")]
		public static int ClientWaitSync(IntPtr dpy, IntPtr sync, int flags, UInt64 timeout)
		{
			int retValue;

			Debug.Assert(Delegates.peglClientWaitSync != null, "peglClientWaitSync not implemented");
			retValue = Delegates.peglClientWaitSync(dpy, sync, flags, timeout);
			LogCommand("eglClientWaitSync", retValue, dpy, sync, flags, timeout			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglGetSyncAttrib: Binding for eglGetSyncAttrib.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public static bool GetSyncAttrib(IntPtr dpy, IntPtr sync, int attribute, [Out] IntPtr[] value)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_value = value)
				{
					Debug.Assert(Delegates.peglGetSyncAttrib != null, "peglGetSyncAttrib not implemented");
					retValue = Delegates.peglGetSyncAttrib(dpy, sync, attribute, p_value);
					LogCommand("eglGetSyncAttrib", retValue, dpy, sync, attribute, value					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglCreateImage: Binding for eglCreateImage.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="ctx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public static IntPtr CreateImage(IntPtr dpy, IntPtr ctx, uint target, IntPtr buffer, IntPtr[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (IntPtr* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreateImage != null, "peglCreateImage not implemented");
					retValue = Delegates.peglCreateImage(dpy, ctx, target, buffer, p_attrib_list);
					LogCommand("eglCreateImage", retValue, dpy, ctx, target, buffer, attrib_list					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglDestroyImage: Binding for eglDestroyImage.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[AliasOf("eglDestroyImageKHR")]
		[RequiredByFeature("EGL_VERSION_1_5")]
		[RequiredByFeature("EGL_KHR_image")]
		[RequiredByFeature("EGL_KHR_image_base")]
		public static bool DestroyImage(IntPtr dpy, IntPtr image)
		{
			bool retValue;

			Debug.Assert(Delegates.peglDestroyImage != null, "peglDestroyImage not implemented");
			retValue = Delegates.peglDestroyImage(dpy, image);
			LogCommand("eglDestroyImage", retValue, dpy, image			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglGetPlatformDisplay: Binding for eglGetPlatformDisplay.
		/// </summary>
		/// <param name="platform">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="native_display">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public static IntPtr GetPlatformDisplay(uint platform, IntPtr native_display, IntPtr[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (IntPtr* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglGetPlatformDisplay != null, "peglGetPlatformDisplay not implemented");
					retValue = Delegates.peglGetPlatformDisplay(platform, native_display, p_attrib_list);
					LogCommand("eglGetPlatformDisplay", retValue, platform, native_display, attrib_list					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglCreatePlatformWindowSurface: Binding for eglCreatePlatformWindowSurface.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="config">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="native_window">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public static IntPtr CreatePlatformWindowSurface(IntPtr dpy, IntPtr config, IntPtr native_window, IntPtr[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (IntPtr* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreatePlatformWindowSurface != null, "peglCreatePlatformWindowSurface not implemented");
					retValue = Delegates.peglCreatePlatformWindowSurface(dpy, config, native_window, p_attrib_list);
					LogCommand("eglCreatePlatformWindowSurface", retValue, dpy, config, native_window, attrib_list					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglCreatePlatformPixmapSurface: Binding for eglCreatePlatformPixmapSurface.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="config">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="native_pixmap">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public static IntPtr CreatePlatformPixmapSurface(IntPtr dpy, IntPtr config, IntPtr native_pixmap, IntPtr[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (IntPtr* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreatePlatformPixmapSurface != null, "peglCreatePlatformPixmapSurface not implemented");
					retValue = Delegates.peglCreatePlatformPixmapSurface(dpy, config, native_pixmap, p_attrib_list);
					LogCommand("eglCreatePlatformPixmapSurface", retValue, dpy, config, native_pixmap, attrib_list					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglWaitSync: Binding for eglWaitSync.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="flags">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public static bool WaitSync(IntPtr dpy, IntPtr sync, int flags)
		{
			bool retValue;

			Debug.Assert(Delegates.peglWaitSync != null, "peglWaitSync not implemented");
			retValue = Delegates.peglWaitSync(dpy, sync, flags);
			LogCommand("eglWaitSync", retValue, dpy, sync, flags			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglCreateSync", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreateSync(IntPtr dpy, uint type, IntPtr* attrib_list);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglDestroySync", ExactSpelling = true)]
			internal extern static unsafe bool eglDestroySync(IntPtr dpy, IntPtr sync);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglClientWaitSync", ExactSpelling = true)]
			internal extern static unsafe int eglClientWaitSync(IntPtr dpy, IntPtr sync, int flags, UInt64 timeout);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglGetSyncAttrib", ExactSpelling = true)]
			internal extern static unsafe bool eglGetSyncAttrib(IntPtr dpy, IntPtr sync, int attribute, IntPtr* value);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglCreateImage", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreateImage(IntPtr dpy, IntPtr ctx, uint target, IntPtr buffer, IntPtr* attrib_list);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglDestroyImage", ExactSpelling = true)]
			internal extern static unsafe bool eglDestroyImage(IntPtr dpy, IntPtr image);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglGetPlatformDisplay", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglGetPlatformDisplay(uint platform, IntPtr native_display, IntPtr* attrib_list);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglCreatePlatformWindowSurface", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreatePlatformWindowSurface(IntPtr dpy, IntPtr config, IntPtr native_window, IntPtr* attrib_list);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglCreatePlatformPixmapSurface", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreatePlatformPixmapSurface(IntPtr dpy, IntPtr config, IntPtr native_pixmap, IntPtr* attrib_list);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglWaitSync", ExactSpelling = true)]
			internal extern static unsafe bool eglWaitSync(IntPtr dpy, IntPtr sync, int flags);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_VERSION_1_5")]
			[RequiredByFeature("EGL_KHR_cl_event2")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr eglCreateSync(IntPtr dpy, uint type, IntPtr* attrib_list);

			[AliasOf("eglCreateSync")]
			[AliasOf("eglCreateSync64KHR")]
			[RequiredByFeature("EGL_VERSION_1_5")]
			[RequiredByFeature("EGL_KHR_cl_event2")]
			internal static eglCreateSync peglCreateSync;

			[RequiredByFeature("EGL_VERSION_1_5")]
			[RequiredByFeature("EGL_KHR_fence_sync")]
			[RequiredByFeature("EGL_KHR_reusable_sync")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglDestroySync(IntPtr dpy, IntPtr sync);

			[AliasOf("eglDestroySync")]
			[AliasOf("eglDestroySyncKHR")]
			[RequiredByFeature("EGL_VERSION_1_5")]
			[RequiredByFeature("EGL_KHR_fence_sync")]
			[RequiredByFeature("EGL_KHR_reusable_sync")]
			internal static eglDestroySync peglDestroySync;

			[RequiredByFeature("EGL_VERSION_1_5")]
			[RequiredByFeature("EGL_KHR_fence_sync")]
			[RequiredByFeature("EGL_KHR_reusable_sync")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate int eglClientWaitSync(IntPtr dpy, IntPtr sync, int flags, UInt64 timeout);

			[AliasOf("eglClientWaitSync")]
			[AliasOf("eglClientWaitSyncKHR")]
			[RequiredByFeature("EGL_VERSION_1_5")]
			[RequiredByFeature("EGL_KHR_fence_sync")]
			[RequiredByFeature("EGL_KHR_reusable_sync")]
			internal static eglClientWaitSync peglClientWaitSync;

			[RequiredByFeature("EGL_VERSION_1_5")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglGetSyncAttrib(IntPtr dpy, IntPtr sync, int attribute, IntPtr* value);

			[RequiredByFeature("EGL_VERSION_1_5")]
			internal static eglGetSyncAttrib peglGetSyncAttrib;

			[RequiredByFeature("EGL_VERSION_1_5")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr eglCreateImage(IntPtr dpy, IntPtr ctx, uint target, IntPtr buffer, IntPtr* attrib_list);

			[RequiredByFeature("EGL_VERSION_1_5")]
			internal static eglCreateImage peglCreateImage;

			[RequiredByFeature("EGL_VERSION_1_5")]
			[RequiredByFeature("EGL_KHR_image")]
			[RequiredByFeature("EGL_KHR_image_base")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglDestroyImage(IntPtr dpy, IntPtr image);

			[AliasOf("eglDestroyImage")]
			[AliasOf("eglDestroyImageKHR")]
			[RequiredByFeature("EGL_VERSION_1_5")]
			[RequiredByFeature("EGL_KHR_image")]
			[RequiredByFeature("EGL_KHR_image_base")]
			internal static eglDestroyImage peglDestroyImage;

			[RequiredByFeature("EGL_VERSION_1_5")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr eglGetPlatformDisplay(uint platform, IntPtr native_display, IntPtr* attrib_list);

			[RequiredByFeature("EGL_VERSION_1_5")]
			internal static eglGetPlatformDisplay peglGetPlatformDisplay;

			[RequiredByFeature("EGL_VERSION_1_5")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr eglCreatePlatformWindowSurface(IntPtr dpy, IntPtr config, IntPtr native_window, IntPtr* attrib_list);

			[RequiredByFeature("EGL_VERSION_1_5")]
			internal static eglCreatePlatformWindowSurface peglCreatePlatformWindowSurface;

			[RequiredByFeature("EGL_VERSION_1_5")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr eglCreatePlatformPixmapSurface(IntPtr dpy, IntPtr config, IntPtr native_pixmap, IntPtr* attrib_list);

			[RequiredByFeature("EGL_VERSION_1_5")]
			internal static eglCreatePlatformPixmapSurface peglCreatePlatformPixmapSurface;

			[RequiredByFeature("EGL_VERSION_1_5")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglWaitSync(IntPtr dpy, IntPtr sync, int flags);

			[RequiredByFeature("EGL_VERSION_1_5")]
			internal static eglWaitSync peglWaitSync;

		}
	}

}
