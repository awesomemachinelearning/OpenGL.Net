
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
		/// [GL] Value of GL_TEXTURE_1D_BINDING_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_object")]
		public const int TEXTURE_1D_BINDING_EXT = 0x8068;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_2D_BINDING_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_object")]
		public const int TEXTURE_2D_BINDING_EXT = 0x8069;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_3D_BINDING_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_object")]
		public const int TEXTURE_3D_BINDING_EXT = 0x806A;

		/// <summary>
		/// [GL] glAreTexturesResidentEXT: Binding for glAreTexturesResidentEXT.
		/// </summary>
		/// <param name="textures">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="residences">
		/// A <see cref="T:bool[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_texture_object")]
		public static bool AreTexturesResidentEXT(UInt32[] textures, [Out] bool[] residences)
		{
			bool retValue;

			unsafe {
				fixed (UInt32* p_textures = textures)
				fixed (bool* p_residences = residences)
				{
					Debug.Assert(Delegates.pglAreTexturesResidentEXT != null, "pglAreTexturesResidentEXT not implemented");
					retValue = Delegates.pglAreTexturesResidentEXT((Int32)textures.Length, p_textures, p_residences);
					LogCommand("glAreTexturesResidentEXT", retValue, textures.Length, textures, residences					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] glDeleteTexturesEXT: Binding for glDeleteTexturesEXT.
		/// </summary>
		/// <param name="textures">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_texture_object")]
		public static void DeleteTexturesEXT(params UInt32[] textures)
		{
			unsafe {
				fixed (UInt32* p_textures = textures)
				{
					Debug.Assert(Delegates.pglDeleteTexturesEXT != null, "pglDeleteTexturesEXT not implemented");
					Delegates.pglDeleteTexturesEXT((Int32)textures.Length, p_textures);
					LogCommand("glDeleteTexturesEXT", null, textures.Length, textures					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGenTexturesEXT: Binding for glGenTexturesEXT.
		/// </summary>
		/// <param name="textures">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_texture_object")]
		public static void GenTexturesEXT(UInt32[] textures)
		{
			unsafe {
				fixed (UInt32* p_textures = textures)
				{
					Debug.Assert(Delegates.pglGenTexturesEXT != null, "pglGenTexturesEXT not implemented");
					Delegates.pglGenTexturesEXT((Int32)textures.Length, p_textures);
					LogCommand("glGenTexturesEXT", null, textures.Length, textures					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGenTexturesEXT: Binding for glGenTexturesEXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_object")]
		public static UInt32 GenTexturesEXT()
		{
			UInt32[] retValue = new UInt32[1];
			GenTexturesEXT(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// [GL] glIsTextureEXT: Binding for glIsTextureEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_texture_object")]
		public static bool IsTextureEXT(UInt32 texture)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsTextureEXT != null, "pglIsTextureEXT not implemented");
			retValue = Delegates.pglIsTextureEXT(texture);
			LogCommand("glIsTextureEXT", retValue, texture			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glAreTexturesResidentEXT", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.U1)]
			internal extern static unsafe bool glAreTexturesResidentEXT(Int32 n, UInt32* textures, bool* residences);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glDeleteTexturesEXT", ExactSpelling = true)]
			internal extern static unsafe void glDeleteTexturesEXT(Int32 n, UInt32* textures);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGenTexturesEXT", ExactSpelling = true)]
			internal extern static unsafe void glGenTexturesEXT(Int32 n, UInt32* textures);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glIsTextureEXT", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.U1)]
			internal extern static bool glIsTextureEXT(UInt32 texture);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_texture_object")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool glAreTexturesResidentEXT(Int32 n, UInt32* textures, bool* residences);

			[RequiredByFeature("GL_EXT_texture_object")]
			[ThreadStatic]
			internal static glAreTexturesResidentEXT pglAreTexturesResidentEXT;

			[RequiredByFeature("GL_EXT_texture_object")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glDeleteTexturesEXT(Int32 n, UInt32* textures);

			[RequiredByFeature("GL_EXT_texture_object")]
			[ThreadStatic]
			internal static glDeleteTexturesEXT pglDeleteTexturesEXT;

			[RequiredByFeature("GL_EXT_texture_object")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGenTexturesEXT(Int32 n, UInt32* textures);

			[RequiredByFeature("GL_EXT_texture_object")]
			[ThreadStatic]
			internal static glGenTexturesEXT pglGenTexturesEXT;

			[RequiredByFeature("GL_EXT_texture_object")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate bool glIsTextureEXT(UInt32 texture);

			[RequiredByFeature("GL_EXT_texture_object")]
			[ThreadStatic]
			internal static glIsTextureEXT pglIsTextureEXT;

		}
	}

}
