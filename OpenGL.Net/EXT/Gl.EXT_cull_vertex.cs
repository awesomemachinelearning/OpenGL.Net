
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
		/// [GL] Value of GL_CULL_VERTEX_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_cull_vertex")]
		public const int CULL_VERTEX_EXT = 0x81AA;

		/// <summary>
		/// [GL] Value of GL_CULL_VERTEX_EYE_POSITION_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_cull_vertex")]
		public const int CULL_VERTEX_EYE_POSITION_EXT = 0x81AB;

		/// <summary>
		/// [GL] Value of GL_CULL_VERTEX_OBJECT_POSITION_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_cull_vertex")]
		public const int CULL_VERTEX_OBJECT_POSITION_EXT = 0x81AC;

		/// <summary>
		/// [GL] glCullParameterdvEXT: Binding for glCullParameterdvEXT.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_cull_vertex")]
		public static void CullParameterEXT(Int32 pname, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglCullParameterdvEXT != null, "pglCullParameterdvEXT not implemented");
					Delegates.pglCullParameterdvEXT(pname, p_params);
					LogCommand("glCullParameterdvEXT", null, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glCullParameterfvEXT: Binding for glCullParameterfvEXT.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_cull_vertex")]
		public static void CullParameterEXT(Int32 pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglCullParameterfvEXT != null, "pglCullParameterfvEXT not implemented");
					Delegates.pglCullParameterfvEXT(pname, p_params);
					LogCommand("glCullParameterfvEXT", null, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glCullParameterdvEXT", ExactSpelling = true)]
			internal extern static unsafe void glCullParameterdvEXT(Int32 pname, double* @params);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glCullParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glCullParameterfvEXT(Int32 pname, float* @params);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_cull_vertex")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glCullParameterdvEXT(Int32 pname, double* @params);

			[RequiredByFeature("GL_EXT_cull_vertex")]
			[ThreadStatic]
			internal static glCullParameterdvEXT pglCullParameterdvEXT;

			[RequiredByFeature("GL_EXT_cull_vertex")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glCullParameterfvEXT(Int32 pname, float* @params);

			[RequiredByFeature("GL_EXT_cull_vertex")]
			[ThreadStatic]
			internal static glCullParameterfvEXT pglCullParameterfvEXT;

		}
	}

}
