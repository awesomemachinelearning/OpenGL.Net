
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
		/// [EGL] eglExportDMABUFImageQueryMESA: Binding for eglExportDMABUFImageQueryMESA.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="fourcc">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="num_planes">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="modifiers">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("EGL_MESA_image_dma_buf_export")]
		public static bool ExportDMABUFImageQueryMESA(IntPtr dpy, IntPtr image, int[] fourcc, int[] num_planes, UInt64[] modifiers)
		{
			bool retValue;

			unsafe {
				fixed (int* p_fourcc = fourcc)
				fixed (int* p_num_planes = num_planes)
				fixed (UInt64* p_modifiers = modifiers)
				{
					Debug.Assert(Delegates.peglExportDMABUFImageQueryMESA != null, "peglExportDMABUFImageQueryMESA not implemented");
					retValue = Delegates.peglExportDMABUFImageQueryMESA(dpy, image, p_fourcc, p_num_planes, p_modifiers);
					LogCommand("eglExportDMABUFImageQueryMESA", retValue, dpy, image, fourcc, num_planes, modifiers					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglExportDMABUFImageMESA: Binding for eglExportDMABUFImageMESA.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="fds">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="strides">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="offsets">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_MESA_image_dma_buf_export")]
		public static bool ExportDMABUFImageMESA(IntPtr dpy, IntPtr image, int[] fds, int[] strides, int[] offsets)
		{
			bool retValue;

			unsafe {
				fixed (int* p_fds = fds)
				fixed (int* p_strides = strides)
				fixed (int* p_offsets = offsets)
				{
					Debug.Assert(Delegates.peglExportDMABUFImageMESA != null, "peglExportDMABUFImageMESA not implemented");
					retValue = Delegates.peglExportDMABUFImageMESA(dpy, image, p_fds, p_strides, p_offsets);
					LogCommand("eglExportDMABUFImageMESA", retValue, dpy, image, fds, strides, offsets					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglExportDMABUFImageQueryMESA", ExactSpelling = true)]
			internal extern static unsafe bool eglExportDMABUFImageQueryMESA(IntPtr dpy, IntPtr image, int* fourcc, int* num_planes, UInt64* modifiers);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglExportDMABUFImageMESA", ExactSpelling = true)]
			internal extern static unsafe bool eglExportDMABUFImageMESA(IntPtr dpy, IntPtr image, int* fds, int* strides, int* offsets);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_MESA_image_dma_buf_export")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglExportDMABUFImageQueryMESA(IntPtr dpy, IntPtr image, int* fourcc, int* num_planes, UInt64* modifiers);

			[RequiredByFeature("EGL_MESA_image_dma_buf_export")]
			internal static eglExportDMABUFImageQueryMESA peglExportDMABUFImageQueryMESA;

			[RequiredByFeature("EGL_MESA_image_dma_buf_export")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglExportDMABUFImageMESA(IntPtr dpy, IntPtr image, int* fds, int* strides, int* offsets);

			[RequiredByFeature("EGL_MESA_image_dma_buf_export")]
			internal static eglExportDMABUFImageMESA peglExportDMABUFImageMESA;

		}
	}

}
