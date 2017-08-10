
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
		/// [GL] Value of GL_VIDEO_BUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_BUFFER_NV = 0x9020;

		/// <summary>
		/// [GL] Value of GL_VIDEO_BUFFER_BINDING_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_BUFFER_BINDING_NV = 0x9021;

		/// <summary>
		/// [GL] Value of GL_FIELD_UPPER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int FIELD_UPPER_NV = 0x9022;

		/// <summary>
		/// [GL] Value of GL_FIELD_LOWER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int FIELD_LOWER_NV = 0x9023;

		/// <summary>
		/// [GL] Value of GL_NUM_VIDEO_CAPTURE_STREAMS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int NUM_VIDEO_CAPTURE_STREAMS_NV = 0x9024;

		/// <summary>
		/// [GL] Value of GL_NEXT_VIDEO_CAPTURE_BUFFER_STATUS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int NEXT_VIDEO_CAPTURE_BUFFER_STATUS_NV = 0x9025;

		/// <summary>
		/// [GL] Value of GL_VIDEO_CAPTURE_TO_422_SUPPORTED_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_CAPTURE_TO_422_SUPPORTED_NV = 0x9026;

		/// <summary>
		/// [GL] Value of GL_LAST_VIDEO_CAPTURE_STATUS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int LAST_VIDEO_CAPTURE_STATUS_NV = 0x9027;

		/// <summary>
		/// [GL] Value of GL_VIDEO_BUFFER_PITCH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_BUFFER_PITCH_NV = 0x9028;

		/// <summary>
		/// [GL] Value of GL_VIDEO_COLOR_CONVERSION_MATRIX_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_COLOR_CONVERSION_MATRIX_NV = 0x9029;

		/// <summary>
		/// [GL] Value of GL_VIDEO_COLOR_CONVERSION_MAX_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_COLOR_CONVERSION_MAX_NV = 0x902A;

		/// <summary>
		/// [GL] Value of GL_VIDEO_COLOR_CONVERSION_MIN_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_COLOR_CONVERSION_MIN_NV = 0x902B;

		/// <summary>
		/// [GL] Value of GL_VIDEO_COLOR_CONVERSION_OFFSET_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_COLOR_CONVERSION_OFFSET_NV = 0x902C;

		/// <summary>
		/// [GL] Value of GL_VIDEO_BUFFER_INTERNAL_FORMAT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_BUFFER_INTERNAL_FORMAT_NV = 0x902D;

		/// <summary>
		/// [GL] Value of GL_PARTIAL_SUCCESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int PARTIAL_SUCCESS_NV = 0x902E;

		/// <summary>
		/// [GL] Value of GL_SUCCESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int SUCCESS_NV = 0x902F;

		/// <summary>
		/// [GL] Value of GL_FAILURE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int FAILURE_NV = 0x9030;

		/// <summary>
		/// [GL] Value of GL_YCBYCR8_422_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int YCBYCR8_422_NV = 0x9031;

		/// <summary>
		/// [GL] Value of GL_YCBAYCR8A_4224_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int YCBAYCR8A_4224_NV = 0x9032;

		/// <summary>
		/// [GL] Value of GL_Z6Y10Z6CB10Z6Y10Z6CR10_422_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int Z6Y10Z6CB10Z6Y10Z6CR10_422_NV = 0x9033;

		/// <summary>
		/// [GL] Value of GL_Z6Y10Z6CB10Z6A10Z6Y10Z6CR10Z6A10_4224_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int Z6Y10Z6CB10Z6A10Z6Y10Z6CR10Z6A10_4224_NV = 0x9034;

		/// <summary>
		/// [GL] Value of GL_Z4Y12Z4CB12Z4Y12Z4CR12_422_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int Z4Y12Z4CB12Z4Y12Z4CR12_422_NV = 0x9035;

		/// <summary>
		/// [GL] Value of GL_Z4Y12Z4CB12Z4A12Z4Y12Z4CR12Z4A12_4224_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int Z4Y12Z4CB12Z4A12Z4Y12Z4CR12Z4A12_4224_NV = 0x9036;

		/// <summary>
		/// [GL] Value of GL_Z4Y12Z4CB12Z4CR12_444_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int Z4Y12Z4CB12Z4CR12_444_NV = 0x9037;

		/// <summary>
		/// [GL] Value of GL_VIDEO_CAPTURE_FRAME_WIDTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_CAPTURE_FRAME_WIDTH_NV = 0x9038;

		/// <summary>
		/// [GL] Value of GL_VIDEO_CAPTURE_FRAME_HEIGHT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_CAPTURE_FRAME_HEIGHT_NV = 0x9039;

		/// <summary>
		/// [GL] Value of GL_VIDEO_CAPTURE_FIELD_UPPER_HEIGHT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_CAPTURE_FIELD_UPPER_HEIGHT_NV = 0x903A;

		/// <summary>
		/// [GL] Value of GL_VIDEO_CAPTURE_FIELD_LOWER_HEIGHT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_CAPTURE_FIELD_LOWER_HEIGHT_NV = 0x903B;

		/// <summary>
		/// [GL] Value of GL_VIDEO_CAPTURE_SURFACE_ORIGIN_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_CAPTURE_SURFACE_ORIGIN_NV = 0x903C;

		/// <summary>
		/// [GL] glBeginVideoCaptureNV: Binding for glBeginVideoCaptureNV.
		/// </summary>
		/// <param name="video_capture_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_video_capture")]
		public static void BeginVideoCaptureNV(UInt32 video_capture_slot)
		{
			Debug.Assert(Delegates.pglBeginVideoCaptureNV != null, "pglBeginVideoCaptureNV not implemented");
			Delegates.pglBeginVideoCaptureNV(video_capture_slot);
			LogCommand("glBeginVideoCaptureNV", null, video_capture_slot			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glBindVideoCaptureStreamBufferNV: Binding for glBindVideoCaptureStreamBufferNV.
		/// </summary>
		/// <param name="video_capture_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="frame_region">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_video_capture")]
		public static void BindVideoCaptureStreamBufferNV(UInt32 video_capture_slot, UInt32 stream, Int32 frame_region, IntPtr offset)
		{
			Debug.Assert(Delegates.pglBindVideoCaptureStreamBufferNV != null, "pglBindVideoCaptureStreamBufferNV not implemented");
			Delegates.pglBindVideoCaptureStreamBufferNV(video_capture_slot, stream, frame_region, offset);
			LogCommand("glBindVideoCaptureStreamBufferNV", null, video_capture_slot, stream, frame_region, offset			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glBindVideoCaptureStreamTextureNV: Binding for glBindVideoCaptureStreamTextureNV.
		/// </summary>
		/// <param name="video_capture_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="frame_region">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_video_capture")]
		public static void BindVideoCaptureStreamTextureNV(UInt32 video_capture_slot, UInt32 stream, Int32 frame_region, Int32 target, UInt32 texture)
		{
			Debug.Assert(Delegates.pglBindVideoCaptureStreamTextureNV != null, "pglBindVideoCaptureStreamTextureNV not implemented");
			Delegates.pglBindVideoCaptureStreamTextureNV(video_capture_slot, stream, frame_region, target, texture);
			LogCommand("glBindVideoCaptureStreamTextureNV", null, video_capture_slot, stream, frame_region, target, texture			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glEndVideoCaptureNV: Binding for glEndVideoCaptureNV.
		/// </summary>
		/// <param name="video_capture_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_video_capture")]
		public static void EndVideoCaptureNV(UInt32 video_capture_slot)
		{
			Debug.Assert(Delegates.pglEndVideoCaptureNV != null, "pglEndVideoCaptureNV not implemented");
			Delegates.pglEndVideoCaptureNV(video_capture_slot);
			LogCommand("glEndVideoCaptureNV", null, video_capture_slot			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetVideoCaptureivNV: Binding for glGetVideoCaptureivNV.
		/// </summary>
		/// <param name="video_capture_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_video_capture")]
		public static void GetVideoCaptureNV(UInt32 video_capture_slot, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVideoCaptureivNV != null, "pglGetVideoCaptureivNV not implemented");
					Delegates.pglGetVideoCaptureivNV(video_capture_slot, pname, p_params);
					LogCommand("glGetVideoCaptureivNV", null, video_capture_slot, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetVideoCaptureStreamivNV: Binding for glGetVideoCaptureStreamivNV.
		/// </summary>
		/// <param name="video_capture_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_video_capture")]
		public static void GetVideoCaptureStreamNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVideoCaptureStreamivNV != null, "pglGetVideoCaptureStreamivNV not implemented");
					Delegates.pglGetVideoCaptureStreamivNV(video_capture_slot, stream, pname, p_params);
					LogCommand("glGetVideoCaptureStreamivNV", null, video_capture_slot, stream, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetVideoCaptureStreamfvNV: Binding for glGetVideoCaptureStreamfvNV.
		/// </summary>
		/// <param name="video_capture_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_video_capture")]
		public static void GetVideoCaptureStreamNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVideoCaptureStreamfvNV != null, "pglGetVideoCaptureStreamfvNV not implemented");
					Delegates.pglGetVideoCaptureStreamfvNV(video_capture_slot, stream, pname, p_params);
					LogCommand("glGetVideoCaptureStreamfvNV", null, video_capture_slot, stream, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetVideoCaptureStreamdvNV: Binding for glGetVideoCaptureStreamdvNV.
		/// </summary>
		/// <param name="video_capture_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_video_capture")]
		public static void GetVideoCaptureStreamNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, [Out] double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVideoCaptureStreamdvNV != null, "pglGetVideoCaptureStreamdvNV not implemented");
					Delegates.pglGetVideoCaptureStreamdvNV(video_capture_slot, stream, pname, p_params);
					LogCommand("glGetVideoCaptureStreamdvNV", null, video_capture_slot, stream, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVideoCaptureNV: Binding for glVideoCaptureNV.
		/// </summary>
		/// <param name="video_capture_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="sequence_num">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="capture_time">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_video_capture")]
		public static Int32 VideoCaptureNV(UInt32 video_capture_slot, UInt32[] sequence_num, UInt64[] capture_time)
		{
			Int32 retValue;

			unsafe {
				fixed (UInt32* p_sequence_num = sequence_num)
				fixed (UInt64* p_capture_time = capture_time)
				{
					Debug.Assert(Delegates.pglVideoCaptureNV != null, "pglVideoCaptureNV not implemented");
					retValue = Delegates.pglVideoCaptureNV(video_capture_slot, p_sequence_num, p_capture_time);
					LogCommand("glVideoCaptureNV", retValue, video_capture_slot, sequence_num, capture_time					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] glVideoCaptureStreamParameterivNV: Binding for glVideoCaptureStreamParameterivNV.
		/// </summary>
		/// <param name="video_capture_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_video_capture")]
		public static void VideoCaptureStreamParameterNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglVideoCaptureStreamParameterivNV != null, "pglVideoCaptureStreamParameterivNV not implemented");
					Delegates.pglVideoCaptureStreamParameterivNV(video_capture_slot, stream, pname, p_params);
					LogCommand("glVideoCaptureStreamParameterivNV", null, video_capture_slot, stream, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVideoCaptureStreamParameterfvNV: Binding for glVideoCaptureStreamParameterfvNV.
		/// </summary>
		/// <param name="video_capture_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_video_capture")]
		public static void VideoCaptureStreamParameterNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglVideoCaptureStreamParameterfvNV != null, "pglVideoCaptureStreamParameterfvNV not implemented");
					Delegates.pglVideoCaptureStreamParameterfvNV(video_capture_slot, stream, pname, p_params);
					LogCommand("glVideoCaptureStreamParameterfvNV", null, video_capture_slot, stream, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVideoCaptureStreamParameterdvNV: Binding for glVideoCaptureStreamParameterdvNV.
		/// </summary>
		/// <param name="video_capture_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_video_capture")]
		public static void VideoCaptureStreamParameterNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglVideoCaptureStreamParameterdvNV != null, "pglVideoCaptureStreamParameterdvNV not implemented");
					Delegates.pglVideoCaptureStreamParameterdvNV(video_capture_slot, stream, pname, p_params);
					LogCommand("glVideoCaptureStreamParameterdvNV", null, video_capture_slot, stream, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glBeginVideoCaptureNV", ExactSpelling = true)]
			internal extern static void glBeginVideoCaptureNV(UInt32 video_capture_slot);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glBindVideoCaptureStreamBufferNV", ExactSpelling = true)]
			internal extern static unsafe void glBindVideoCaptureStreamBufferNV(UInt32 video_capture_slot, UInt32 stream, Int32 frame_region, IntPtr offset);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glBindVideoCaptureStreamTextureNV", ExactSpelling = true)]
			internal extern static void glBindVideoCaptureStreamTextureNV(UInt32 video_capture_slot, UInt32 stream, Int32 frame_region, Int32 target, UInt32 texture);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glEndVideoCaptureNV", ExactSpelling = true)]
			internal extern static void glEndVideoCaptureNV(UInt32 video_capture_slot);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetVideoCaptureivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetVideoCaptureivNV(UInt32 video_capture_slot, Int32 pname, Int32* @params);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetVideoCaptureStreamivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetVideoCaptureStreamivNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, Int32* @params);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetVideoCaptureStreamfvNV", ExactSpelling = true)]
			internal extern static unsafe void glGetVideoCaptureStreamfvNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, float* @params);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetVideoCaptureStreamdvNV", ExactSpelling = true)]
			internal extern static unsafe void glGetVideoCaptureStreamdvNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, double* @params);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVideoCaptureNV", ExactSpelling = true)]
			internal extern static unsafe Int32 glVideoCaptureNV(UInt32 video_capture_slot, UInt32* sequence_num, UInt64* capture_time);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVideoCaptureStreamParameterivNV", ExactSpelling = true)]
			internal extern static unsafe void glVideoCaptureStreamParameterivNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, Int32* @params);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVideoCaptureStreamParameterfvNV", ExactSpelling = true)]
			internal extern static unsafe void glVideoCaptureStreamParameterfvNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, float* @params);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVideoCaptureStreamParameterdvNV", ExactSpelling = true)]
			internal extern static unsafe void glVideoCaptureStreamParameterdvNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, double* @params);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_video_capture")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glBeginVideoCaptureNV(UInt32 video_capture_slot);

			[RequiredByFeature("GL_NV_video_capture")]
			[ThreadStatic]
			internal static glBeginVideoCaptureNV pglBeginVideoCaptureNV;

			[RequiredByFeature("GL_NV_video_capture")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glBindVideoCaptureStreamBufferNV(UInt32 video_capture_slot, UInt32 stream, Int32 frame_region, IntPtr offset);

			[RequiredByFeature("GL_NV_video_capture")]
			[ThreadStatic]
			internal static glBindVideoCaptureStreamBufferNV pglBindVideoCaptureStreamBufferNV;

			[RequiredByFeature("GL_NV_video_capture")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glBindVideoCaptureStreamTextureNV(UInt32 video_capture_slot, UInt32 stream, Int32 frame_region, Int32 target, UInt32 texture);

			[RequiredByFeature("GL_NV_video_capture")]
			[ThreadStatic]
			internal static glBindVideoCaptureStreamTextureNV pglBindVideoCaptureStreamTextureNV;

			[RequiredByFeature("GL_NV_video_capture")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glEndVideoCaptureNV(UInt32 video_capture_slot);

			[RequiredByFeature("GL_NV_video_capture")]
			[ThreadStatic]
			internal static glEndVideoCaptureNV pglEndVideoCaptureNV;

			[RequiredByFeature("GL_NV_video_capture")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetVideoCaptureivNV(UInt32 video_capture_slot, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_NV_video_capture")]
			[ThreadStatic]
			internal static glGetVideoCaptureivNV pglGetVideoCaptureivNV;

			[RequiredByFeature("GL_NV_video_capture")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetVideoCaptureStreamivNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_NV_video_capture")]
			[ThreadStatic]
			internal static glGetVideoCaptureStreamivNV pglGetVideoCaptureStreamivNV;

			[RequiredByFeature("GL_NV_video_capture")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetVideoCaptureStreamfvNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, float* @params);

			[RequiredByFeature("GL_NV_video_capture")]
			[ThreadStatic]
			internal static glGetVideoCaptureStreamfvNV pglGetVideoCaptureStreamfvNV;

			[RequiredByFeature("GL_NV_video_capture")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetVideoCaptureStreamdvNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, double* @params);

			[RequiredByFeature("GL_NV_video_capture")]
			[ThreadStatic]
			internal static glGetVideoCaptureStreamdvNV pglGetVideoCaptureStreamdvNV;

			[RequiredByFeature("GL_NV_video_capture")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate Int32 glVideoCaptureNV(UInt32 video_capture_slot, UInt32* sequence_num, UInt64* capture_time);

			[RequiredByFeature("GL_NV_video_capture")]
			[ThreadStatic]
			internal static glVideoCaptureNV pglVideoCaptureNV;

			[RequiredByFeature("GL_NV_video_capture")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVideoCaptureStreamParameterivNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_NV_video_capture")]
			[ThreadStatic]
			internal static glVideoCaptureStreamParameterivNV pglVideoCaptureStreamParameterivNV;

			[RequiredByFeature("GL_NV_video_capture")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVideoCaptureStreamParameterfvNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, float* @params);

			[RequiredByFeature("GL_NV_video_capture")]
			[ThreadStatic]
			internal static glVideoCaptureStreamParameterfvNV pglVideoCaptureStreamParameterfvNV;

			[RequiredByFeature("GL_NV_video_capture")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVideoCaptureStreamParameterdvNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, double* @params);

			[RequiredByFeature("GL_NV_video_capture")]
			[ThreadStatic]
			internal static glVideoCaptureStreamParameterdvNV pglVideoCaptureStreamParameterdvNV;

		}
	}

}
