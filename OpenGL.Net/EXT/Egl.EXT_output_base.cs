
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
	public partial class Egl
	{
		/// <summary>
		/// [EGL] Value of EGL_NO_OUTPUT_LAYER_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_output_base")]
		public const int NO_OUTPUT_LAYER_EXT = 0;

		/// <summary>
		/// [EGL] Value of EGL_NO_OUTPUT_PORT_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_output_base")]
		public const int NO_OUTPUT_PORT_EXT = 0;

		/// <summary>
		/// [EGL] Value of EGL_BAD_OUTPUT_LAYER_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_output_base")]
		public const int BAD_OUTPUT_LAYER_EXT = 0x322D;

		/// <summary>
		/// [EGL] Value of EGL_BAD_OUTPUT_PORT_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_output_base")]
		public const int BAD_OUTPUT_PORT_EXT = 0x322E;

		/// <summary>
		/// [EGL] Value of EGL_SWAP_INTERVAL_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_output_base")]
		public const int SWAP_INTERVAL_EXT = 0x322F;

		/// <summary>
		/// [EGL] eglGetOutputLayersEXT: Binding for eglGetOutputLayersEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="layers">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="max_layers">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="num_layers">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_output_base")]
		public static bool GetOutputLayersEXT(IntPtr dpy, IntPtr[] attrib_list, [Out] IntPtr[] layers, int max_layers, [Out] int[] num_layers)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_attrib_list = attrib_list)
				fixed (IntPtr* p_layers = layers)
				fixed (int* p_num_layers = num_layers)
				{
					Debug.Assert(Delegates.peglGetOutputLayersEXT != null, "peglGetOutputLayersEXT not implemented");
					retValue = Delegates.peglGetOutputLayersEXT(dpy, p_attrib_list, p_layers, max_layers, p_num_layers);
					LogCommand("eglGetOutputLayersEXT", retValue, dpy, attrib_list, layers, max_layers, num_layers					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglGetOutputPortsEXT: Binding for eglGetOutputPortsEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="ports">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="max_ports">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="num_ports">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_output_base")]
		public static bool GetOutputPortsEXT(IntPtr dpy, IntPtr[] attrib_list, [Out] IntPtr[] ports, int max_ports, [Out] int[] num_ports)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_attrib_list = attrib_list)
				fixed (IntPtr* p_ports = ports)
				fixed (int* p_num_ports = num_ports)
				{
					Debug.Assert(Delegates.peglGetOutputPortsEXT != null, "peglGetOutputPortsEXT not implemented");
					retValue = Delegates.peglGetOutputPortsEXT(dpy, p_attrib_list, p_ports, max_ports, p_num_ports);
					LogCommand("eglGetOutputPortsEXT", retValue, dpy, attrib_list, ports, max_ports, num_ports					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglOutputLayerAttribEXT: Binding for eglOutputLayerAttribEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="layer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_output_base")]
		public static bool OutputLayerAttribEXT(IntPtr dpy, IntPtr layer, int attribute, IntPtr value)
		{
			bool retValue;

			Debug.Assert(Delegates.peglOutputLayerAttribEXT != null, "peglOutputLayerAttribEXT not implemented");
			retValue = Delegates.peglOutputLayerAttribEXT(dpy, layer, attribute, value);
			LogCommand("eglOutputLayerAttribEXT", retValue, dpy, layer, attribute, value			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglQueryOutputLayerAttribEXT: Binding for eglQueryOutputLayerAttribEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="layer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_output_base")]
		public static bool QueryOutputLayerAttribEXT(IntPtr dpy, IntPtr layer, int attribute, IntPtr[] value)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_value = value)
				{
					Debug.Assert(Delegates.peglQueryOutputLayerAttribEXT != null, "peglQueryOutputLayerAttribEXT not implemented");
					retValue = Delegates.peglQueryOutputLayerAttribEXT(dpy, layer, attribute, p_value);
					LogCommand("eglQueryOutputLayerAttribEXT", retValue, dpy, layer, attribute, value					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglQueryOutputLayerStringEXT: Binding for eglQueryOutputLayerStringEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="layer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_output_base")]
		public static string QueryOutputLayerStringEXT(IntPtr dpy, IntPtr layer, int name)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglQueryOutputLayerStringEXT != null, "peglQueryOutputLayerStringEXT not implemented");
			retValue = Delegates.peglQueryOutputLayerStringEXT(dpy, layer, name);
			LogCommand("eglQueryOutputLayerStringEXT", Marshal.PtrToStringAnsi(retValue), dpy, layer, name			);
			DebugCheckErrors(retValue);

			return (Marshal.PtrToStringAnsi(retValue));
		}

		/// <summary>
		/// [EGL] eglOutputPortAttribEXT: Binding for eglOutputPortAttribEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="port">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_output_base")]
		public static bool OutputPortAttribEXT(IntPtr dpy, IntPtr port, int attribute, IntPtr value)
		{
			bool retValue;

			Debug.Assert(Delegates.peglOutputPortAttribEXT != null, "peglOutputPortAttribEXT not implemented");
			retValue = Delegates.peglOutputPortAttribEXT(dpy, port, attribute, value);
			LogCommand("eglOutputPortAttribEXT", retValue, dpy, port, attribute, value			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglQueryOutputPortAttribEXT: Binding for eglQueryOutputPortAttribEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="port">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_output_base")]
		public static bool QueryOutputPortAttribEXT(IntPtr dpy, IntPtr port, int attribute, IntPtr[] value)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_value = value)
				{
					Debug.Assert(Delegates.peglQueryOutputPortAttribEXT != null, "peglQueryOutputPortAttribEXT not implemented");
					retValue = Delegates.peglQueryOutputPortAttribEXT(dpy, port, attribute, p_value);
					LogCommand("eglQueryOutputPortAttribEXT", retValue, dpy, port, attribute, value					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglQueryOutputPortStringEXT: Binding for eglQueryOutputPortStringEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="port">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_output_base")]
		public static string QueryOutputPortStringEXT(IntPtr dpy, IntPtr port, int name)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglQueryOutputPortStringEXT != null, "peglQueryOutputPortStringEXT not implemented");
			retValue = Delegates.peglQueryOutputPortStringEXT(dpy, port, name);
			LogCommand("eglQueryOutputPortStringEXT", Marshal.PtrToStringAnsi(retValue), dpy, port, name			);
			DebugCheckErrors(retValue);

			return (Marshal.PtrToStringAnsi(retValue));
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglGetOutputLayersEXT", ExactSpelling = true)]
			internal extern static unsafe bool eglGetOutputLayersEXT(IntPtr dpy, IntPtr* attrib_list, IntPtr* layers, int max_layers, int* num_layers);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglGetOutputPortsEXT", ExactSpelling = true)]
			internal extern static unsafe bool eglGetOutputPortsEXT(IntPtr dpy, IntPtr* attrib_list, IntPtr* ports, int max_ports, int* num_ports);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglOutputLayerAttribEXT", ExactSpelling = true)]
			internal extern static unsafe bool eglOutputLayerAttribEXT(IntPtr dpy, IntPtr layer, int attribute, IntPtr value);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglQueryOutputLayerAttribEXT", ExactSpelling = true)]
			internal extern static unsafe bool eglQueryOutputLayerAttribEXT(IntPtr dpy, IntPtr layer, int attribute, IntPtr* value);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglQueryOutputLayerStringEXT", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglQueryOutputLayerStringEXT(IntPtr dpy, IntPtr layer, int name);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglOutputPortAttribEXT", ExactSpelling = true)]
			internal extern static unsafe bool eglOutputPortAttribEXT(IntPtr dpy, IntPtr port, int attribute, IntPtr value);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglQueryOutputPortAttribEXT", ExactSpelling = true)]
			internal extern static unsafe bool eglQueryOutputPortAttribEXT(IntPtr dpy, IntPtr port, int attribute, IntPtr* value);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglQueryOutputPortStringEXT", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglQueryOutputPortStringEXT(IntPtr dpy, IntPtr port, int name);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_EXT_output_base")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglGetOutputLayersEXT(IntPtr dpy, IntPtr* attrib_list, IntPtr* layers, int max_layers, int* num_layers);

			[RequiredByFeature("EGL_EXT_output_base")]
			internal static eglGetOutputLayersEXT peglGetOutputLayersEXT;

			[RequiredByFeature("EGL_EXT_output_base")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglGetOutputPortsEXT(IntPtr dpy, IntPtr* attrib_list, IntPtr* ports, int max_ports, int* num_ports);

			[RequiredByFeature("EGL_EXT_output_base")]
			internal static eglGetOutputPortsEXT peglGetOutputPortsEXT;

			[RequiredByFeature("EGL_EXT_output_base")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglOutputLayerAttribEXT(IntPtr dpy, IntPtr layer, int attribute, IntPtr value);

			[RequiredByFeature("EGL_EXT_output_base")]
			internal static eglOutputLayerAttribEXT peglOutputLayerAttribEXT;

			[RequiredByFeature("EGL_EXT_output_base")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglQueryOutputLayerAttribEXT(IntPtr dpy, IntPtr layer, int attribute, IntPtr* value);

			[RequiredByFeature("EGL_EXT_output_base")]
			internal static eglQueryOutputLayerAttribEXT peglQueryOutputLayerAttribEXT;

			[RequiredByFeature("EGL_EXT_output_base")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr eglQueryOutputLayerStringEXT(IntPtr dpy, IntPtr layer, int name);

			[RequiredByFeature("EGL_EXT_output_base")]
			internal static eglQueryOutputLayerStringEXT peglQueryOutputLayerStringEXT;

			[RequiredByFeature("EGL_EXT_output_base")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglOutputPortAttribEXT(IntPtr dpy, IntPtr port, int attribute, IntPtr value);

			[RequiredByFeature("EGL_EXT_output_base")]
			internal static eglOutputPortAttribEXT peglOutputPortAttribEXT;

			[RequiredByFeature("EGL_EXT_output_base")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglQueryOutputPortAttribEXT(IntPtr dpy, IntPtr port, int attribute, IntPtr* value);

			[RequiredByFeature("EGL_EXT_output_base")]
			internal static eglQueryOutputPortAttribEXT peglQueryOutputPortAttribEXT;

			[RequiredByFeature("EGL_EXT_output_base")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr eglQueryOutputPortStringEXT(IntPtr dpy, IntPtr port, int name);

			[RequiredByFeature("EGL_EXT_output_base")]
			internal static eglQueryOutputPortStringEXT peglQueryOutputPortStringEXT;

		}
	}

}
