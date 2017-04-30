
// Copyright (C) 2015-2017 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

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
		/// Binding for glGetGraphicsResetStatusARB.
		/// </summary>
		[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
		public static GraphicsResetStatus GetGraphicsResetStatusARB()
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetGraphicsResetStatusARB != null, "pglGetGraphicsResetStatusARB not implemented");
			retValue = Delegates.pglGetGraphicsResetStatusARB();
			LogCommand("glGetGraphicsResetStatusARB", (GraphicsResetStatus)retValue			);
			DebugCheckErrors(retValue);

			return ((GraphicsResetStatus)retValue);
		}

		/// <summary>
		/// Binding for glGetnTexImageARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="img">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
		public static void GetnTexImageARB(TextureTarget target, Int32 level, PixelFormat format, PixelType type, Int32 bufSize, IntPtr img)
		{
			Debug.Assert(Delegates.pglGetnTexImageARB != null, "pglGetnTexImageARB not implemented");
			Delegates.pglGetnTexImageARB((Int32)target, level, (Int32)format, (Int32)type, bufSize, img);
			LogCommand("glGetnTexImageARB", null, target, level, format, type, bufSize, img			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnTexImageARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="img">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
		public static void GetnTexImageARB(TextureTarget target, Int32 level, PixelFormat format, PixelType type, Int32 bufSize, Object img)
		{
			GCHandle pin_img = GCHandle.Alloc(img, GCHandleType.Pinned);
			try {
				GetnTexImageARB(target, level, format, type, bufSize, pin_img.AddrOfPinnedObject());
			} finally {
				pin_img.Free();
			}
		}

		/// <summary>
		/// Binding for glGetnCompressedTexImageARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="lod">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="img">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
		public static void GetnCompressedTexImageARB(TextureTarget target, Int32 lod, Int32 bufSize, IntPtr img)
		{
			Debug.Assert(Delegates.pglGetnCompressedTexImageARB != null, "pglGetnCompressedTexImageARB not implemented");
			Delegates.pglGetnCompressedTexImageARB((Int32)target, lod, bufSize, img);
			LogCommand("glGetnCompressedTexImageARB", null, target, lod, bufSize, img			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnCompressedTexImageARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="lod">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="img">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
		public static void GetnCompressedTexImageARB(TextureTarget target, Int32 lod, Int32 bufSize, Object img)
		{
			GCHandle pin_img = GCHandle.Alloc(img, GCHandleType.Pinned);
			try {
				GetnCompressedTexImageARB(target, lod, bufSize, pin_img.AddrOfPinnedObject());
			} finally {
				pin_img.Free();
			}
		}

		/// <summary>
		/// Binding for glGetnUniformfvARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
		public static void GetnUniformARB(UInt32 program, Int32 location, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformfvARB != null, "pglGetnUniformfvARB not implemented");
					Delegates.pglGetnUniformfvARB(program, location, (Int32)@params.Length, p_params);
					LogCommand("glGetnUniformfvARB", null, program, location, @params.Length, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnUniformivARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
		public static void GetnUniformARB(UInt32 program, Int32 location, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformivARB != null, "pglGetnUniformivARB not implemented");
					Delegates.pglGetnUniformivARB(program, location, (Int32)@params.Length, p_params);
					LogCommand("glGetnUniformivARB", null, program, location, @params.Length, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnUniformuivARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
		public static void GetnUniformARB(UInt32 program, Int32 location, [Out] UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformuivARB != null, "pglGetnUniformuivARB not implemented");
					Delegates.pglGetnUniformuivARB(program, location, (Int32)@params.Length, p_params);
					LogCommand("glGetnUniformuivARB", null, program, location, @params.Length, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnUniformdvARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
		public static void GetnUniformARB(UInt32 program, Int32 location, [Out] double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformdvARB != null, "pglGetnUniformdvARB not implemented");
					Delegates.pglGetnUniformdvARB(program, location, (Int32)@params.Length, p_params);
					LogCommand("glGetnUniformdvARB", null, program, location, @params.Length, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnMapdvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:MapTarget"/>.
		/// </param>
		/// <param name="query">
		/// A <see cref="T:MapQuery"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
		public static void GetnMapARB(MapTarget target, MapQuery query, Int32 bufSize, [Out] double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglGetnMapdvARB != null, "pglGetnMapdvARB not implemented");
					Delegates.pglGetnMapdvARB((Int32)target, (Int32)query, bufSize, p_v);
					LogCommand("glGetnMapdvARB", null, target, query, bufSize, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnMapdvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:MapTarget"/>.
		/// </param>
		/// <param name="query">
		/// A <see cref="T:MapQuery"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
		public static void GetnMapARB(MapTarget target, MapQuery query, [Out] double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglGetnMapdvARB != null, "pglGetnMapdvARB not implemented");
					Delegates.pglGetnMapdvARB((Int32)target, (Int32)query, (Int32)v.Length, p_v);
					LogCommand("glGetnMapdvARB", null, target, query, v.Length, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnMapfvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:MapTarget"/>.
		/// </param>
		/// <param name="query">
		/// A <see cref="T:MapQuery"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
		public static void GetnMapARB(MapTarget target, MapQuery query, Int32 bufSize, [Out] float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglGetnMapfvARB != null, "pglGetnMapfvARB not implemented");
					Delegates.pglGetnMapfvARB((Int32)target, (Int32)query, bufSize, p_v);
					LogCommand("glGetnMapfvARB", null, target, query, bufSize, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnMapfvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:MapTarget"/>.
		/// </param>
		/// <param name="query">
		/// A <see cref="T:MapQuery"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
		public static void GetnMapARB(MapTarget target, MapQuery query, [Out] float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglGetnMapfvARB != null, "pglGetnMapfvARB not implemented");
					Delegates.pglGetnMapfvARB((Int32)target, (Int32)query, (Int32)v.Length, p_v);
					LogCommand("glGetnMapfvARB", null, target, query, v.Length, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnMapivARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:MapTarget"/>.
		/// </param>
		/// <param name="query">
		/// A <see cref="T:MapQuery"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
		public static void GetnMapARB(MapTarget target, MapQuery query, Int32 bufSize, [Out] Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglGetnMapivARB != null, "pglGetnMapivARB not implemented");
					Delegates.pglGetnMapivARB((Int32)target, (Int32)query, bufSize, p_v);
					LogCommand("glGetnMapivARB", null, target, query, bufSize, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnMapivARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:MapTarget"/>.
		/// </param>
		/// <param name="query">
		/// A <see cref="T:MapQuery"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
		public static void GetnMapARB(MapTarget target, MapQuery query, [Out] Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglGetnMapivARB != null, "pglGetnMapivARB not implemented");
					Delegates.pglGetnMapivARB((Int32)target, (Int32)query, (Int32)v.Length, p_v);
					LogCommand("glGetnMapivARB", null, target, query, v.Length, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnPixelMapfvARB.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:PixelMap"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
		public static void GetnPixelMapARB(PixelMap map, Int32 bufSize, [Out] float[] values)
		{
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pglGetnPixelMapfvARB != null, "pglGetnPixelMapfvARB not implemented");
					Delegates.pglGetnPixelMapfvARB((Int32)map, bufSize, p_values);
					LogCommand("glGetnPixelMapfvARB", null, map, bufSize, values					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnPixelMapfvARB.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:PixelMap"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
		public static void GetnPixelMapARB(PixelMap map, [Out] float[] values)
		{
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pglGetnPixelMapfvARB != null, "pglGetnPixelMapfvARB not implemented");
					Delegates.pglGetnPixelMapfvARB((Int32)map, (Int32)values.Length, p_values);
					LogCommand("glGetnPixelMapfvARB", null, map, values.Length, values					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnPixelMapuivARB.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:PixelMap"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
		public static void GetnPixelMapARB(PixelMap map, Int32 bufSize, [Out] UInt32[] values)
		{
			unsafe {
				fixed (UInt32* p_values = values)
				{
					Debug.Assert(Delegates.pglGetnPixelMapuivARB != null, "pglGetnPixelMapuivARB not implemented");
					Delegates.pglGetnPixelMapuivARB((Int32)map, bufSize, p_values);
					LogCommand("glGetnPixelMapuivARB", null, map, bufSize, values					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnPixelMapuivARB.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:PixelMap"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
		public static void GetnPixelMapARB(PixelMap map, [Out] UInt32[] values)
		{
			unsafe {
				fixed (UInt32* p_values = values)
				{
					Debug.Assert(Delegates.pglGetnPixelMapuivARB != null, "pglGetnPixelMapuivARB not implemented");
					Delegates.pglGetnPixelMapuivARB((Int32)map, (Int32)values.Length, p_values);
					LogCommand("glGetnPixelMapuivARB", null, map, values.Length, values					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnPixelMapusvARB.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:PixelMap"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
		public static void GetnPixelMapARB(PixelMap map, Int32 bufSize, [Out] UInt16[] values)
		{
			unsafe {
				fixed (UInt16* p_values = values)
				{
					Debug.Assert(Delegates.pglGetnPixelMapusvARB != null, "pglGetnPixelMapusvARB not implemented");
					Delegates.pglGetnPixelMapusvARB((Int32)map, bufSize, p_values);
					LogCommand("glGetnPixelMapusvARB", null, map, bufSize, values					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnPixelMapusvARB.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:PixelMap"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
		public static void GetnPixelMapARB(PixelMap map, [Out] UInt16[] values)
		{
			unsafe {
				fixed (UInt16* p_values = values)
				{
					Debug.Assert(Delegates.pglGetnPixelMapusvARB != null, "pglGetnPixelMapusvARB not implemented");
					Delegates.pglGetnPixelMapusvARB((Int32)map, (Int32)values.Length, p_values);
					LogCommand("glGetnPixelMapusvARB", null, map, values.Length, values					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnPolygonStippleARB.
		/// </summary>
		/// <param name="pattern">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
		public static void GetnPolygonStippleARB([Out] byte[] pattern)
		{
			unsafe {
				fixed (byte* p_pattern = pattern)
				{
					Debug.Assert(Delegates.pglGetnPolygonStippleARB != null, "pglGetnPolygonStippleARB not implemented");
					Delegates.pglGetnPolygonStippleARB((Int32)pattern.Length, p_pattern);
					LogCommand("glGetnPolygonStippleARB", null, pattern.Length, pattern					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnColorTableARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ColorTableTarget"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
		public static void GetnColorTableARB(ColorTableTarget target, PixelFormat format, PixelType type, Int32 bufSize, IntPtr table)
		{
			Debug.Assert(Delegates.pglGetnColorTableARB != null, "pglGetnColorTableARB not implemented");
			Delegates.pglGetnColorTableARB((Int32)target, (Int32)format, (Int32)type, bufSize, table);
			LogCommand("glGetnColorTableARB", null, target, format, type, bufSize, table			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnColorTableARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ColorTableTarget"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
		public static void GetnColorTableARB(ColorTableTarget target, PixelFormat format, PixelType type, Int32 bufSize, Object table)
		{
			GCHandle pin_table = GCHandle.Alloc(table, GCHandleType.Pinned);
			try {
				GetnColorTableARB(target, format, type, bufSize, pin_table.AddrOfPinnedObject());
			} finally {
				pin_table.Free();
			}
		}

		/// <summary>
		/// Binding for glGetnConvolutionFilterARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTarget"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
		public static void GetnConvolutionFilterARB(ConvolutionTarget target, PixelFormat format, PixelType type, Int32 bufSize, IntPtr image)
		{
			Debug.Assert(Delegates.pglGetnConvolutionFilterARB != null, "pglGetnConvolutionFilterARB not implemented");
			Delegates.pglGetnConvolutionFilterARB((Int32)target, (Int32)format, (Int32)type, bufSize, image);
			LogCommand("glGetnConvolutionFilterARB", null, target, format, type, bufSize, image			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnConvolutionFilterARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTarget"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
		public static void GetnConvolutionFilterARB(ConvolutionTarget target, PixelFormat format, PixelType type, Int32 bufSize, Object image)
		{
			GCHandle pin_image = GCHandle.Alloc(image, GCHandleType.Pinned);
			try {
				GetnConvolutionFilterARB(target, format, type, bufSize, pin_image.AddrOfPinnedObject());
			} finally {
				pin_image.Free();
			}
		}

		/// <summary>
		/// Binding for glGetnSeparableFilterARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:SeparableTargetEXT"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="rowBufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="row">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="columnBufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="column">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="span">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
		public static void GetnSeparableFilterARB(SeparableTargetEXT target, PixelFormat format, PixelType type, Int32 rowBufSize, IntPtr row, Int32 columnBufSize, IntPtr column, IntPtr span)
		{
			Debug.Assert(Delegates.pglGetnSeparableFilterARB != null, "pglGetnSeparableFilterARB not implemented");
			Delegates.pglGetnSeparableFilterARB((Int32)target, (Int32)format, (Int32)type, rowBufSize, row, columnBufSize, column, span);
			LogCommand("glGetnSeparableFilterARB", null, target, format, type, rowBufSize, row, columnBufSize, column, span			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnSeparableFilterARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:SeparableTargetEXT"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="rowBufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="row">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="columnBufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="column">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="span">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
		public static void GetnSeparableFilterARB(SeparableTargetEXT target, PixelFormat format, PixelType type, Int32 rowBufSize, Object row, Int32 columnBufSize, Object column, Object span)
		{
			GCHandle pin_row = GCHandle.Alloc(row, GCHandleType.Pinned);
			GCHandle pin_column = GCHandle.Alloc(column, GCHandleType.Pinned);
			GCHandle pin_span = GCHandle.Alloc(span, GCHandleType.Pinned);
			try {
				GetnSeparableFilterARB(target, format, type, rowBufSize, pin_row.AddrOfPinnedObject(), columnBufSize, pin_column.AddrOfPinnedObject(), pin_span.AddrOfPinnedObject());
			} finally {
				pin_row.Free();
				pin_column.Free();
				pin_span.Free();
			}
		}

		/// <summary>
		/// Binding for glGetnHistogramARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:HistogramTargetEXT"/>.
		/// </param>
		/// <param name="reset">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
		public static void GetnHistogramARB(HistogramTargetEXT target, bool reset, PixelFormat format, PixelType type, Int32 bufSize, IntPtr values)
		{
			Debug.Assert(Delegates.pglGetnHistogramARB != null, "pglGetnHistogramARB not implemented");
			Delegates.pglGetnHistogramARB((Int32)target, reset, (Int32)format, (Int32)type, bufSize, values);
			LogCommand("glGetnHistogramARB", null, target, reset, format, type, bufSize, values			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnHistogramARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:HistogramTargetEXT"/>.
		/// </param>
		/// <param name="reset">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
		public static void GetnHistogramARB(HistogramTargetEXT target, bool reset, PixelFormat format, PixelType type, Int32 bufSize, Object values)
		{
			GCHandle pin_values = GCHandle.Alloc(values, GCHandleType.Pinned);
			try {
				GetnHistogramARB(target, reset, format, type, bufSize, pin_values.AddrOfPinnedObject());
			} finally {
				pin_values.Free();
			}
		}

		/// <summary>
		/// Binding for glGetnMinmaxARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:MinmaxTargetEXT"/>.
		/// </param>
		/// <param name="reset">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
		public static void GetnMinmaxARB(MinmaxTargetEXT target, bool reset, PixelFormat format, PixelType type, Int32 bufSize, IntPtr values)
		{
			Debug.Assert(Delegates.pglGetnMinmaxARB != null, "pglGetnMinmaxARB not implemented");
			Delegates.pglGetnMinmaxARB((Int32)target, reset, (Int32)format, (Int32)type, bufSize, values);
			LogCommand("glGetnMinmaxARB", null, target, reset, format, type, bufSize, values			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnMinmaxARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:MinmaxTargetEXT"/>.
		/// </param>
		/// <param name="reset">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
		public static void GetnMinmaxARB(MinmaxTargetEXT target, bool reset, PixelFormat format, PixelType type, Int32 bufSize, Object values)
		{
			GCHandle pin_values = GCHandle.Alloc(values, GCHandleType.Pinned);
			try {
				GetnMinmaxARB(target, reset, format, type, bufSize, pin_values.AddrOfPinnedObject());
			} finally {
				pin_values.Free();
			}
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetGraphicsResetStatusARB", ExactSpelling = true)]
			internal extern static Int32 glGetGraphicsResetStatusARB();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnTexImageARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnTexImageARB(Int32 target, Int32 level, Int32 format, Int32 type, Int32 bufSize, IntPtr img);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnCompressedTexImageARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnCompressedTexImageARB(Int32 target, Int32 lod, Int32 bufSize, IntPtr img);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnUniformfvARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnUniformfvARB(UInt32 program, Int32 location, Int32 bufSize, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnUniformivARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnUniformivARB(UInt32 program, Int32 location, Int32 bufSize, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnUniformuivARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnUniformuivARB(UInt32 program, Int32 location, Int32 bufSize, UInt32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnUniformdvARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnUniformdvARB(UInt32 program, Int32 location, Int32 bufSize, double* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnMapdvARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnMapdvARB(Int32 target, Int32 query, Int32 bufSize, double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnMapfvARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnMapfvARB(Int32 target, Int32 query, Int32 bufSize, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnMapivARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnMapivARB(Int32 target, Int32 query, Int32 bufSize, Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnPixelMapfvARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnPixelMapfvARB(Int32 map, Int32 bufSize, float* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnPixelMapuivARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnPixelMapuivARB(Int32 map, Int32 bufSize, UInt32* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnPixelMapusvARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnPixelMapusvARB(Int32 map, Int32 bufSize, UInt16* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnPolygonStippleARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnPolygonStippleARB(Int32 bufSize, byte* pattern);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnColorTableARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnColorTableARB(Int32 target, Int32 format, Int32 type, Int32 bufSize, IntPtr table);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnConvolutionFilterARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnConvolutionFilterARB(Int32 target, Int32 format, Int32 type, Int32 bufSize, IntPtr image);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnSeparableFilterARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnSeparableFilterARB(Int32 target, Int32 format, Int32 type, Int32 rowBufSize, IntPtr row, Int32 columnBufSize, IntPtr column, IntPtr span);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnHistogramARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnHistogramARB(Int32 target, bool reset, Int32 format, Int32 type, Int32 bufSize, IntPtr values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnMinmaxARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnMinmaxARB(Int32 target, bool reset, Int32 format, Int32 type, Int32 bufSize, IntPtr values);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glGetGraphicsResetStatusARB();

			[ThreadStatic]
			internal static glGetGraphicsResetStatusARB pglGetGraphicsResetStatusARB;

			[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnTexImageARB(Int32 target, Int32 level, Int32 format, Int32 type, Int32 bufSize, IntPtr img);

			[ThreadStatic]
			internal static glGetnTexImageARB pglGetnTexImageARB;

			[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnCompressedTexImageARB(Int32 target, Int32 lod, Int32 bufSize, IntPtr img);

			[ThreadStatic]
			internal static glGetnCompressedTexImageARB pglGetnCompressedTexImageARB;

			[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnUniformfvARB(UInt32 program, Int32 location, Int32 bufSize, float* @params);

			[ThreadStatic]
			internal static glGetnUniformfvARB pglGetnUniformfvARB;

			[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnUniformivARB(UInt32 program, Int32 location, Int32 bufSize, Int32* @params);

			[ThreadStatic]
			internal static glGetnUniformivARB pglGetnUniformivARB;

			[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnUniformuivARB(UInt32 program, Int32 location, Int32 bufSize, UInt32* @params);

			[ThreadStatic]
			internal static glGetnUniformuivARB pglGetnUniformuivARB;

			[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnUniformdvARB(UInt32 program, Int32 location, Int32 bufSize, double* @params);

			[ThreadStatic]
			internal static glGetnUniformdvARB pglGetnUniformdvARB;

			[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnMapdvARB(Int32 target, Int32 query, Int32 bufSize, double* v);

			[ThreadStatic]
			internal static glGetnMapdvARB pglGetnMapdvARB;

			[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnMapfvARB(Int32 target, Int32 query, Int32 bufSize, float* v);

			[ThreadStatic]
			internal static glGetnMapfvARB pglGetnMapfvARB;

			[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnMapivARB(Int32 target, Int32 query, Int32 bufSize, Int32* v);

			[ThreadStatic]
			internal static glGetnMapivARB pglGetnMapivARB;

			[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnPixelMapfvARB(Int32 map, Int32 bufSize, float* values);

			[ThreadStatic]
			internal static glGetnPixelMapfvARB pglGetnPixelMapfvARB;

			[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnPixelMapuivARB(Int32 map, Int32 bufSize, UInt32* values);

			[ThreadStatic]
			internal static glGetnPixelMapuivARB pglGetnPixelMapuivARB;

			[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnPixelMapusvARB(Int32 map, Int32 bufSize, UInt16* values);

			[ThreadStatic]
			internal static glGetnPixelMapusvARB pglGetnPixelMapusvARB;

			[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnPolygonStippleARB(Int32 bufSize, byte* pattern);

			[ThreadStatic]
			internal static glGetnPolygonStippleARB pglGetnPolygonStippleARB;

			[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnColorTableARB(Int32 target, Int32 format, Int32 type, Int32 bufSize, IntPtr table);

			[ThreadStatic]
			internal static glGetnColorTableARB pglGetnColorTableARB;

			[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnConvolutionFilterARB(Int32 target, Int32 format, Int32 type, Int32 bufSize, IntPtr image);

			[ThreadStatic]
			internal static glGetnConvolutionFilterARB pglGetnConvolutionFilterARB;

			[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnSeparableFilterARB(Int32 target, Int32 format, Int32 type, Int32 rowBufSize, IntPtr row, Int32 columnBufSize, IntPtr column, IntPtr span);

			[ThreadStatic]
			internal static glGetnSeparableFilterARB pglGetnSeparableFilterARB;

			[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnHistogramARB(Int32 target, bool reset, Int32 format, Int32 type, Int32 bufSize, IntPtr values);

			[ThreadStatic]
			internal static glGetnHistogramARB pglGetnHistogramARB;

			[RequiredByFeature("GL_ARB_robustness", Profile = "compatibility")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnMinmaxARB(Int32 target, bool reset, Int32 format, Int32 type, Int32 bufSize, IntPtr values);

			[ThreadStatic]
			internal static glGetnMinmaxARB pglGetnMinmaxARB;

		}
	}

}
