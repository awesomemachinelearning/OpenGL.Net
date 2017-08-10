
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
		/// [GL] glIglooInterfaceSGIX: Binding for glIglooInterfaceSGIX.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_igloo_interface")]
		public static void IglooInterfaceSGIX(Int32 pname, IntPtr @params)
		{
			Debug.Assert(Delegates.pglIglooInterfaceSGIX != null, "pglIglooInterfaceSGIX not implemented");
			Delegates.pglIglooInterfaceSGIX(pname, @params);
			LogCommand("glIglooInterfaceSGIX", null, pname, @params			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glIglooInterfaceSGIX: Binding for glIglooInterfaceSGIX.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_igloo_interface")]
		public static void IglooInterfaceSGIX(Int32 pname, Object @params)
		{
			GCHandle pin_params = GCHandle.Alloc(@params, GCHandleType.Pinned);
			try {
				IglooInterfaceSGIX(pname, pin_params.AddrOfPinnedObject());
			} finally {
				pin_params.Free();
			}
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glIglooInterfaceSGIX", ExactSpelling = true)]
			internal extern static unsafe void glIglooInterfaceSGIX(Int32 pname, IntPtr @params);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_SGIX_igloo_interface")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glIglooInterfaceSGIX(Int32 pname, IntPtr @params);

			[RequiredByFeature("GL_SGIX_igloo_interface")]
			[ThreadStatic]
			internal static glIglooInterfaceSGIX pglIglooInterfaceSGIX;

		}
	}

}
