
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
		/// [GL] glImportMemoryFdEXT: Binding for glImportMemoryFdEXT.
		/// </summary>
		/// <param name="memory">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="handleType">
		/// A <see cref="T:ExternalHandleType"/>.
		/// </param>
		/// <param name="fd">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_memory_object_fd", Api = "gl|gles2")]
		public static void ImportMemoryEXT(UInt32 memory, UInt64 size, ExternalHandleType handleType, Int32 fd)
		{
			Debug.Assert(Delegates.pglImportMemoryFdEXT != null, "pglImportMemoryFdEXT not implemented");
			Delegates.pglImportMemoryFdEXT(memory, size, (Int32)handleType, fd);
			LogCommand("glImportMemoryFdEXT", null, memory, size, handleType, fd			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glImportMemoryFdEXT", ExactSpelling = true)]
			internal extern static void glImportMemoryFdEXT(UInt32 memory, UInt64 size, Int32 handleType, Int32 fd);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_memory_object_fd", Api = "gl|gles2")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glImportMemoryFdEXT(UInt32 memory, UInt64 size, Int32 handleType, Int32 fd);

			[RequiredByFeature("GL_EXT_memory_object_fd", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glImportMemoryFdEXT pglImportMemoryFdEXT;

		}
	}

}
