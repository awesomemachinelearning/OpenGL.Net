
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
		/// [GL] Value of GL_RENDERBUFFER_COVERAGE_SAMPLES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_framebuffer_multisample_coverage", Api = "gl|glcore")]
		public const int RENDERBUFFER_COVERAGE_SAMPLES_NV = 0x8CAB;

		/// <summary>
		/// [GL] Value of GL_RENDERBUFFER_COLOR_SAMPLES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_framebuffer_multisample_coverage", Api = "gl|glcore")]
		public const int RENDERBUFFER_COLOR_SAMPLES_NV = 0x8E10;

		/// <summary>
		/// [GL] Value of GL_MAX_MULTISAMPLE_COVERAGE_MODES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_framebuffer_multisample_coverage", Api = "gl|glcore")]
		public const int MAX_MULTISAMPLE_COVERAGE_MODES_NV = 0x8E11;

		/// <summary>
		/// [GL] Value of GL_MULTISAMPLE_COVERAGE_MODES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_framebuffer_multisample_coverage", Api = "gl|glcore")]
		public const int MULTISAMPLE_COVERAGE_MODES_NV = 0x8E12;

		/// <summary>
		/// [GL] glRenderbufferStorageMultisampleCoverageNV: Binding for glRenderbufferStorageMultisampleCoverageNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:RenderbufferTarget"/>.
		/// </param>
		/// <param name="coverageSamples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="colorSamples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:InternalFormat"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_framebuffer_multisample_coverage", Api = "gl|glcore")]
		public static void RenderbufferStorageMultisampleCoverageNV(RenderbufferTarget target, Int32 coverageSamples, Int32 colorSamples, InternalFormat internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglRenderbufferStorageMultisampleCoverageNV != null, "pglRenderbufferStorageMultisampleCoverageNV not implemented");
			Delegates.pglRenderbufferStorageMultisampleCoverageNV((Int32)target, coverageSamples, colorSamples, (Int32)internalformat, width, height);
			LogCommand("glRenderbufferStorageMultisampleCoverageNV", null, target, coverageSamples, colorSamples, internalformat, width, height			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glRenderbufferStorageMultisampleCoverageNV", ExactSpelling = true)]
			internal extern static void glRenderbufferStorageMultisampleCoverageNV(Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalformat, Int32 width, Int32 height);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_framebuffer_multisample_coverage", Api = "gl|glcore")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glRenderbufferStorageMultisampleCoverageNV(Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalformat, Int32 width, Int32 height);

			[RequiredByFeature("GL_NV_framebuffer_multisample_coverage", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glRenderbufferStorageMultisampleCoverageNV pglRenderbufferStorageMultisampleCoverageNV;

		}
	}

}
