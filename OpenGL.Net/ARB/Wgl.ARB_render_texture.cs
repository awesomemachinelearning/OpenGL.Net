
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
	public partial class Wgl
	{
		/// <summary>
		/// [WGL] Value of WGL_BIND_TO_TEXTURE_RGB_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int BIND_TO_TEXTURE_RGB_ARB = 0x2070;

		/// <summary>
		/// [WGL] Value of WGL_BIND_TO_TEXTURE_RGBA_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int BIND_TO_TEXTURE_RGBA_ARB = 0x2071;

		/// <summary>
		/// [WGL] Value of WGL_TEXTURE_FORMAT_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int TEXTURE_FORMAT_ARB = 0x2072;

		/// <summary>
		/// [WGL] Value of WGL_TEXTURE_TARGET_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int TEXTURE_TARGET_ARB = 0x2073;

		/// <summary>
		/// [WGL] Value of WGL_MIPMAP_TEXTURE_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int MIPMAP_TEXTURE_ARB = 0x2074;

		/// <summary>
		/// [WGL] Value of WGL_TEXTURE_RGB_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int TEXTURE_RGB_ARB = 0x2075;

		/// <summary>
		/// [WGL] Value of WGL_TEXTURE_RGBA_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int TEXTURE_RGBA_ARB = 0x2076;

		/// <summary>
		/// [WGL] Value of WGL_NO_TEXTURE_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int NO_TEXTURE_ARB = 0x2077;

		/// <summary>
		/// [WGL] Value of WGL_TEXTURE_CUBE_MAP_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int TEXTURE_CUBE_MAP_ARB = 0x2078;

		/// <summary>
		/// [WGL] Value of WGL_TEXTURE_1D_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int TEXTURE_1D_ARB = 0x2079;

		/// <summary>
		/// [WGL] Value of WGL_TEXTURE_2D_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int TEXTURE_2D_ARB = 0x207A;

		/// <summary>
		/// [WGL] Value of WGL_MIPMAP_LEVEL_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int MIPMAP_LEVEL_ARB = 0x207B;

		/// <summary>
		/// [WGL] Value of WGL_CUBE_MAP_FACE_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int CUBE_MAP_FACE_ARB = 0x207C;

		/// <summary>
		/// [WGL] Value of WGL_TEXTURE_CUBE_MAP_POSITIVE_X_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int TEXTURE_CUBE_MAP_POSITIVE_X_ARB = 0x207D;

		/// <summary>
		/// [WGL] Value of WGL_TEXTURE_CUBE_MAP_NEGATIVE_X_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int TEXTURE_CUBE_MAP_NEGATIVE_X_ARB = 0x207E;

		/// <summary>
		/// [WGL] Value of WGL_TEXTURE_CUBE_MAP_POSITIVE_Y_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int TEXTURE_CUBE_MAP_POSITIVE_Y_ARB = 0x207F;

		/// <summary>
		/// [WGL] Value of WGL_TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB = 0x2080;

		/// <summary>
		/// [WGL] Value of WGL_TEXTURE_CUBE_MAP_POSITIVE_Z_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int TEXTURE_CUBE_MAP_POSITIVE_Z_ARB = 0x2081;

		/// <summary>
		/// [WGL] Value of WGL_TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB = 0x2082;

		/// <summary>
		/// [WGL] Value of WGL_FRONT_LEFT_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int FRONT_LEFT_ARB = 0x2083;

		/// <summary>
		/// [WGL] Value of WGL_FRONT_RIGHT_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int FRONT_RIGHT_ARB = 0x2084;

		/// <summary>
		/// [WGL] Value of WGL_BACK_LEFT_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int BACK_LEFT_ARB = 0x2085;

		/// <summary>
		/// [WGL] Value of WGL_BACK_RIGHT_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int BACK_RIGHT_ARB = 0x2086;

		/// <summary>
		/// [WGL] Value of WGL_AUX0_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int AUX0_ARB = 0x2087;

		/// <summary>
		/// [WGL] Value of WGL_AUX1_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int AUX1_ARB = 0x2088;

		/// <summary>
		/// [WGL] Value of WGL_AUX2_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int AUX2_ARB = 0x2089;

		/// <summary>
		/// [WGL] Value of WGL_AUX3_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int AUX3_ARB = 0x208A;

		/// <summary>
		/// [WGL] Value of WGL_AUX4_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int AUX4_ARB = 0x208B;

		/// <summary>
		/// [WGL] Value of WGL_AUX5_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int AUX5_ARB = 0x208C;

		/// <summary>
		/// [WGL] Value of WGL_AUX6_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int AUX6_ARB = 0x208D;

		/// <summary>
		/// [WGL] Value of WGL_AUX7_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int AUX7_ARB = 0x208E;

		/// <summary>
		/// [WGL] Value of WGL_AUX8_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int AUX8_ARB = 0x208F;

		/// <summary>
		/// [WGL] Value of WGL_AUX9_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int AUX9_ARB = 0x2090;

		/// <summary>
		/// [WGL] wglBindTexImageARB: Binding for wglBindTexImageARB.
		/// </summary>
		/// <param name="hPbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iBuffer">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public static bool BindTexImageARB(IntPtr hPbuffer, int iBuffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglBindTexImageARB != null, "pwglBindTexImageARB not implemented");
			retValue = Delegates.pwglBindTexImageARB(hPbuffer, iBuffer);
			LogCommand("wglBindTexImageARB", retValue, hPbuffer, iBuffer			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglReleaseTexImageARB: Binding for wglReleaseTexImageARB.
		/// </summary>
		/// <param name="hPbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iBuffer">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public static bool ReleaseTexImageARB(IntPtr hPbuffer, int iBuffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglReleaseTexImageARB != null, "pwglReleaseTexImageARB not implemented");
			retValue = Delegates.pwglReleaseTexImageARB(hPbuffer, iBuffer);
			LogCommand("wglReleaseTexImageARB", retValue, hPbuffer, iBuffer			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglSetPbufferAttribARB: Binding for wglSetPbufferAttribARB.
		/// </summary>
		/// <param name="hPbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="piAttribList">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public static bool SetPbufferAttribARB(IntPtr hPbuffer, int[] piAttribList)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piAttribList = piAttribList)
				{
					Debug.Assert(Delegates.pwglSetPbufferAttribARB != null, "pwglSetPbufferAttribARB not implemented");
					retValue = Delegates.pwglSetPbufferAttribARB(hPbuffer, p_piAttribList);
					LogCommand("wglSetPbufferAttribARB", retValue, hPbuffer, piAttribList					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglBindTexImageARB", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglBindTexImageARB(IntPtr hPbuffer, int iBuffer);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglReleaseTexImageARB", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglReleaseTexImageARB(IntPtr hPbuffer, int iBuffer);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglSetPbufferAttribARB", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglSetPbufferAttribARB(IntPtr hPbuffer, int* piAttribList);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_ARB_render_texture")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglBindTexImageARB(IntPtr hPbuffer, int iBuffer);

			[RequiredByFeature("WGL_ARB_render_texture")]
			[ThreadStatic]
			internal static wglBindTexImageARB pwglBindTexImageARB;

			[RequiredByFeature("WGL_ARB_render_texture")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglReleaseTexImageARB(IntPtr hPbuffer, int iBuffer);

			[RequiredByFeature("WGL_ARB_render_texture")]
			[ThreadStatic]
			internal static wglReleaseTexImageARB pwglReleaseTexImageARB;

			[RequiredByFeature("WGL_ARB_render_texture")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglSetPbufferAttribARB(IntPtr hPbuffer, int* piAttribList);

			[RequiredByFeature("WGL_ARB_render_texture")]
			[ThreadStatic]
			internal static wglSetPbufferAttribARB pwglSetPbufferAttribARB;

		}
	}

}
