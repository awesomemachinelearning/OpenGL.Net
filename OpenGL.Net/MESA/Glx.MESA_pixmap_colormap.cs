
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
		/// [GLX] glXCreateGLXPixmapMESA: Binding for glXCreateGLXPixmapMESA.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="visual">
		/// A <see cref="T:Glx.XVisualInfo"/>.
		/// </param>
		/// <param name="pixmap">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="cmap">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_MESA_pixmap_colormap")]
		public static IntPtr CreateGLXPixmapMESA(IntPtr dpy, Glx.XVisualInfo visual, IntPtr pixmap, IntPtr cmap)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglXCreateGLXPixmapMESA != null, "pglXCreateGLXPixmapMESA not implemented");
			retValue = Delegates.pglXCreateGLXPixmapMESA(dpy, visual, pixmap, cmap);
			LogCommand("glXCreateGLXPixmapMESA", retValue, dpy, visual, pixmap, cmap			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXCreateGLXPixmapMESA", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXCreateGLXPixmapMESA(IntPtr dpy, Glx.XVisualInfo visual, IntPtr pixmap, IntPtr cmap);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GLX_MESA_pixmap_colormap")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr glXCreateGLXPixmapMESA(IntPtr dpy, Glx.XVisualInfo visual, IntPtr pixmap, IntPtr cmap);

			[RequiredByFeature("GLX_MESA_pixmap_colormap")]
			internal static glXCreateGLXPixmapMESA pglXCreateGLXPixmapMESA;

		}
	}

}
