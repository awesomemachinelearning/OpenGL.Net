
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
	public partial class Glx
	{
		/// <summary>
		/// [GLX] Value of GLX_GPU_VENDOR_AMD symbol.
		/// </summary>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public const int GPU_VENDOR_AMD = 0x1F00;

		/// <summary>
		/// [GLX] Value of GLX_GPU_RENDERER_STRING_AMD symbol.
		/// </summary>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public const int GPU_RENDERER_STRING_AMD = 0x1F01;

		/// <summary>
		/// [GLX] Value of GLX_GPU_OPENGL_VERSION_STRING_AMD symbol.
		/// </summary>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public const int GPU_OPENGL_VERSION_STRING_AMD = 0x1F02;

		/// <summary>
		/// [GLX] Value of GLX_GPU_FASTEST_TARGET_GPUS_AMD symbol.
		/// </summary>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public const int GPU_FASTEST_TARGET_GPUS_AMD = 0x21A2;

		/// <summary>
		/// [GLX] Value of GLX_GPU_RAM_AMD symbol.
		/// </summary>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public const int GPU_RAM_AMD = 0x21A3;

		/// <summary>
		/// [GLX] Value of GLX_GPU_CLOCK_AMD symbol.
		/// </summary>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public const int GPU_CLOCK_AMD = 0x21A4;

		/// <summary>
		/// [GLX] Value of GLX_GPU_NUM_PIPES_AMD symbol.
		/// </summary>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public const int GPU_NUM_PIPES_AMD = 0x21A5;

		/// <summary>
		/// [GLX] Value of GLX_GPU_NUM_SIMD_AMD symbol.
		/// </summary>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public const int GPU_NUM_SIMD_AMD = 0x21A6;

		/// <summary>
		/// [GLX] Value of GLX_GPU_NUM_RB_AMD symbol.
		/// </summary>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public const int GPU_NUM_RB_AMD = 0x21A7;

		/// <summary>
		/// [GLX] Value of GLX_GPU_NUM_SPI_AMD symbol.
		/// </summary>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public const int GPU_NUM_SPI_AMD = 0x21A8;

		/// <summary>
		/// [GLX] glXGetGPUIDsAMD: Binding for glXGetGPUIDsAMD.
		/// </summary>
		/// <param name="maxCount">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="ids">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public static UInt32 GetAMD(UInt32 maxCount, [Out] UInt32[] ids)
		{
			UInt32 retValue;

			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglXGetGPUIDsAMD != null, "pglXGetGPUIDsAMD not implemented");
					retValue = Delegates.pglXGetGPUIDsAMD(maxCount, p_ids);
					LogCommand("glXGetGPUIDsAMD", retValue, maxCount, ids					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] glXGetGPUInfoAMD: Binding for glXGetGPUInfoAMD.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="property">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dataType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public static int GetGPUInfoAMD(UInt32 id, int property, Int32 dataType, UInt32 size, IntPtr data)
		{
			int retValue;

			Debug.Assert(Delegates.pglXGetGPUInfoAMD != null, "pglXGetGPUInfoAMD not implemented");
			retValue = Delegates.pglXGetGPUInfoAMD(id, property, dataType, size, data);
			LogCommand("glXGetGPUInfoAMD", retValue, id, property, dataType, size, data			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] glXGetContextGPUIDAMD: Binding for glXGetContextGPUIDAMD.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public static UInt32 GetContextAMD(IntPtr ctx)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglXGetContextGPUIDAMD != null, "pglXGetContextGPUIDAMD not implemented");
			retValue = Delegates.pglXGetContextGPUIDAMD(ctx);
			LogCommand("glXGetContextGPUIDAMD", retValue, ctx			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] glXCreateAssociatedContextAMD: Binding for glXCreateAssociatedContextAMD.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="share_list">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public static IntPtr CreateAssociatedContextAMD(UInt32 id, IntPtr share_list)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglXCreateAssociatedContextAMD != null, "pglXCreateAssociatedContextAMD not implemented");
			retValue = Delegates.pglXCreateAssociatedContextAMD(id, share_list);
			LogCommand("glXCreateAssociatedContextAMD", retValue, id, share_list			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] glXCreateAssociatedContextAttribsAMD: Binding for glXCreateAssociatedContextAttribsAMD.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="share_context">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribList">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public static IntPtr CreateAssociatedContextAttribsAMD(UInt32 id, IntPtr share_context, int[] attribList)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attribList = attribList)
				{
					Debug.Assert(Delegates.pglXCreateAssociatedContextAttribsAMD != null, "pglXCreateAssociatedContextAttribsAMD not implemented");
					retValue = Delegates.pglXCreateAssociatedContextAttribsAMD(id, share_context, p_attribList);
					LogCommand("glXCreateAssociatedContextAttribsAMD", retValue, id, share_context, attribList					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] glXDeleteAssociatedContextAMD: Binding for glXDeleteAssociatedContextAMD.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public static bool DeleteAssociatedContextAMD(IntPtr ctx)
		{
			bool retValue;

			Debug.Assert(Delegates.pglXDeleteAssociatedContextAMD != null, "pglXDeleteAssociatedContextAMD not implemented");
			retValue = Delegates.pglXDeleteAssociatedContextAMD(ctx);
			LogCommand("glXDeleteAssociatedContextAMD", retValue, ctx			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] glXMakeAssociatedContextCurrentAMD: Binding for glXMakeAssociatedContextCurrentAMD.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public static bool MakeAssociatedContextCurrentAMD(IntPtr ctx)
		{
			bool retValue;

			Debug.Assert(Delegates.pglXMakeAssociatedContextCurrentAMD != null, "pglXMakeAssociatedContextCurrentAMD not implemented");
			retValue = Delegates.pglXMakeAssociatedContextCurrentAMD(ctx);
			LogCommand("glXMakeAssociatedContextCurrentAMD", retValue, ctx			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] glXGetCurrentAssociatedContextAMD: Binding for glXGetCurrentAssociatedContextAMD.
		/// </summary>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public static IntPtr GetCurrentAssociatedContextAMD()
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglXGetCurrentAssociatedContextAMD != null, "pglXGetCurrentAssociatedContextAMD not implemented");
			retValue = Delegates.pglXGetCurrentAssociatedContextAMD();
			LogCommand("glXGetCurrentAssociatedContextAMD", retValue			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] glXBlitContextFramebufferAMD: Binding for glXBlitContextFramebufferAMD.
		/// </summary>
		/// <param name="dstCtx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="srcX0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcY0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcX1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcY1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstX0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstY0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstX1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstY1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="filter">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public static void BlitContextFramebufferAMD(IntPtr dstCtx, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, Int32 filter)
		{
			Debug.Assert(Delegates.pglXBlitContextFramebufferAMD != null, "pglXBlitContextFramebufferAMD not implemented");
			Delegates.pglXBlitContextFramebufferAMD(dstCtx, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			LogCommand("glXBlitContextFramebufferAMD", null, dstCtx, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter			);
			DebugCheckErrors(null);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXGetGPUIDsAMD", ExactSpelling = true)]
			internal extern static unsafe UInt32 glXGetGPUIDsAMD(UInt32 maxCount, UInt32* ids);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXGetGPUInfoAMD", ExactSpelling = true)]
			internal extern static unsafe int glXGetGPUInfoAMD(UInt32 id, int property, Int32 dataType, UInt32 size, IntPtr data);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXGetContextGPUIDAMD", ExactSpelling = true)]
			internal extern static unsafe UInt32 glXGetContextGPUIDAMD(IntPtr ctx);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXCreateAssociatedContextAMD", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXCreateAssociatedContextAMD(UInt32 id, IntPtr share_list);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXCreateAssociatedContextAttribsAMD", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXCreateAssociatedContextAttribsAMD(UInt32 id, IntPtr share_context, int* attribList);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXDeleteAssociatedContextAMD", ExactSpelling = true)]
			internal extern static unsafe bool glXDeleteAssociatedContextAMD(IntPtr ctx);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXMakeAssociatedContextCurrentAMD", ExactSpelling = true)]
			internal extern static unsafe bool glXMakeAssociatedContextCurrentAMD(IntPtr ctx);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXGetCurrentAssociatedContextAMD", ExactSpelling = true)]
			internal extern static IntPtr glXGetCurrentAssociatedContextAMD();

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXBlitContextFramebufferAMD", ExactSpelling = true)]
			internal extern static unsafe void glXBlitContextFramebufferAMD(IntPtr dstCtx, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, Int32 filter);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GLX_AMD_gpu_association")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate UInt32 glXGetGPUIDsAMD(UInt32 maxCount, UInt32* ids);

			[RequiredByFeature("GLX_AMD_gpu_association")]
			internal static glXGetGPUIDsAMD pglXGetGPUIDsAMD;

			[RequiredByFeature("GLX_AMD_gpu_association")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate int glXGetGPUInfoAMD(UInt32 id, int property, Int32 dataType, UInt32 size, IntPtr data);

			[RequiredByFeature("GLX_AMD_gpu_association")]
			internal static glXGetGPUInfoAMD pglXGetGPUInfoAMD;

			[RequiredByFeature("GLX_AMD_gpu_association")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate UInt32 glXGetContextGPUIDAMD(IntPtr ctx);

			[RequiredByFeature("GLX_AMD_gpu_association")]
			internal static glXGetContextGPUIDAMD pglXGetContextGPUIDAMD;

			[RequiredByFeature("GLX_AMD_gpu_association")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr glXCreateAssociatedContextAMD(UInt32 id, IntPtr share_list);

			[RequiredByFeature("GLX_AMD_gpu_association")]
			internal static glXCreateAssociatedContextAMD pglXCreateAssociatedContextAMD;

			[RequiredByFeature("GLX_AMD_gpu_association")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr glXCreateAssociatedContextAttribsAMD(UInt32 id, IntPtr share_context, int* attribList);

			[RequiredByFeature("GLX_AMD_gpu_association")]
			internal static glXCreateAssociatedContextAttribsAMD pglXCreateAssociatedContextAttribsAMD;

			[RequiredByFeature("GLX_AMD_gpu_association")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool glXDeleteAssociatedContextAMD(IntPtr ctx);

			[RequiredByFeature("GLX_AMD_gpu_association")]
			internal static glXDeleteAssociatedContextAMD pglXDeleteAssociatedContextAMD;

			[RequiredByFeature("GLX_AMD_gpu_association")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool glXMakeAssociatedContextCurrentAMD(IntPtr ctx);

			[RequiredByFeature("GLX_AMD_gpu_association")]
			internal static glXMakeAssociatedContextCurrentAMD pglXMakeAssociatedContextCurrentAMD;

			[RequiredByFeature("GLX_AMD_gpu_association")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate IntPtr glXGetCurrentAssociatedContextAMD();

			[RequiredByFeature("GLX_AMD_gpu_association")]
			internal static glXGetCurrentAssociatedContextAMD pglXGetCurrentAssociatedContextAMD;

			[RequiredByFeature("GLX_AMD_gpu_association")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glXBlitContextFramebufferAMD(IntPtr dstCtx, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, Int32 filter);

			[RequiredByFeature("GLX_AMD_gpu_association")]
			internal static glXBlitContextFramebufferAMD pglXBlitContextFramebufferAMD;

		}
	}

}
