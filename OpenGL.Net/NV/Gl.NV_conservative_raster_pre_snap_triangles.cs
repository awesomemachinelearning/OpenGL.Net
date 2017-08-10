
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
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_CONSERVATIVE_RASTER_MODE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_conservative_raster_pre_snap_triangles", Api = "gl|glcore|gles2")]
		public const int CONSERVATIVE_RASTER_MODE_NV = 0x954D;

		/// <summary>
		/// [GL] Value of GL_CONSERVATIVE_RASTER_MODE_POST_SNAP_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_conservative_raster_pre_snap_triangles", Api = "gl|glcore|gles2")]
		public const int CONSERVATIVE_RASTER_MODE_POST_SNAP_NV = 0x954E;

		/// <summary>
		/// [GL] Value of GL_CONSERVATIVE_RASTER_MODE_PRE_SNAP_TRIANGLES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_conservative_raster_pre_snap_triangles", Api = "gl|glcore|gles2")]
		public const int CONSERVATIVE_RASTER_MODE_PRE_SNAP_TRIANGLES_NV = 0x954F;

		/// <summary>
		/// [GL] glConservativeRasterParameteriNV: Binding for glConservativeRasterParameteriNV.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_conservative_raster_pre_snap_triangles", Api = "gl|glcore|gles2")]
		public static void ConservativeRasterParameteriNV(Int32 pname, Int32 param)
		{
			Debug.Assert(Delegates.pglConservativeRasterParameteriNV != null, "pglConservativeRasterParameteriNV not implemented");
			Delegates.pglConservativeRasterParameteriNV(pname, param);
			LogCommand("glConservativeRasterParameteriNV", null, pname, param			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glConservativeRasterParameteriNV", ExactSpelling = true)]
			internal extern static void glConservativeRasterParameteriNV(Int32 pname, Int32 param);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_conservative_raster_pre_snap_triangles", Api = "gl|glcore|gles2")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glConservativeRasterParameteriNV(Int32 pname, Int32 param);

			[RequiredByFeature("GL_NV_conservative_raster_pre_snap_triangles", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glConservativeRasterParameteriNV pglConservativeRasterParameteriNV;

		}
	}

}
