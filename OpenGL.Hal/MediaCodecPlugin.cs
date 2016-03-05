﻿
// Copyright (C) 2016 Luca Piccioni
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

using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace OpenGL
{
	/// <summary>
	/// Base class for supporting unmanaged plugin implementations.
	/// </summary>
	/// <typeparam name="TMedia">
	/// A <see cref="IMedia{TMediaInfo}"/> type, indicating the concrete class of the media.
	/// </typeparam>
	/// <typeparam name="TMediaInfo">
	/// A <see cref="MediaInfo"/> that stored information about <typeparamref name="TMedia"/>
	/// </typeparam>
	/// <typeparam name="TMediaCodecCriteria">
	/// A <see cref="MediaCodecCriteria"/> that specify codec parameters.
	/// </typeparam>
	abstract class MediaCodecPlugin<TMedia, TMediaInfo, TMediaCodecCriteria> : Plugin, IMediaCodecPlugin<TMedia, TMediaInfo, TMediaCodecCriteria>
		where TMedia : IMedia<TMediaInfo>
		where TMediaInfo : MediaInfo
		where TMediaCodecCriteria : MediaCodecCriteria
	{
		#region Constructors

		protected MediaCodecPlugin(string assemblyPath, string factoryFunction) :
			base(assemblyPath, factoryFunction)
		{
			
		}

		#endregion

		#region P/Invoke On Plugin

		/// <summary>
		/// Aggregate of delegates for implementing <see cref="IPlugin"/> interface.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		protected new struct Delegates
		{
			/// <summary>
			/// Delegates header: <see cref="Plugin.Delegates"/> for basic plugin management.
			/// </summary>
			public Plugin.Delegates PluginDelegates;
		}

		#endregion

		#region IMediaCodecPlugin<TMedia, TMediaInfo, TMediaCodecCriteria> Implementation

		/// <summary>
		/// Query media informations.
		/// </summary>
		/// <param name="path">
		/// A <see cref="String"/> that specify the media path.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specify parameters for loading an media stream.
		/// </param>
		/// <returns>
		/// A <typeparamref name="TMediaInfo"/> containing information about the specified media.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="stream"/> or <paramref name="criteria"/> is null.
		/// </exception>
		public abstract TMediaInfo QueryInfo(string path, TMediaCodecCriteria criteria);

		/// <summary>
		/// Query media informations.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="Stream"/> where the media data is stored.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specify parameters for loading an media stream.
		/// </param>
		/// <returns>
		/// A <typeparamref name="TMediaInfo"/> containing information about the specified media.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="stream"/> or <paramref name="criteria"/> is null.
		/// </exception>
		public abstract TMediaInfo QueryInfo(Stream stream, TMediaCodecCriteria criteria);

		/// <summary>
		/// Load media from stream.
		/// </summary>
		/// <param name="path">
		/// A <see cref="String"/> that specify the media path.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specify parameters for loading an media stream.
		/// </param>
		/// <returns>
		/// An <typeparamref name="TMedia"/> holding the media data.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="stream"/> or <paramref name="criteria"/> is null.
		/// </exception>
		public abstract TMedia Load(string path, TMediaCodecCriteria criteria);

		/// <summary>
		/// Load media from stream.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="Stream"/> where the media data is stored.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specify parameters for loading an media stream.
		/// </param>
		/// <returns>
		/// An <typeparamref name="TMedia"/> holding the media data.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="stream"/> or <paramref name="criteria"/> is null.
		/// </exception>
		public abstract TMedia Load(Stream stream, TMediaCodecCriteria criteria);

		/// <summary>
		/// Save media to stream.
		/// </summary>
		/// <param name="path">
		/// A <see cref="String"/> that specify the media path.
		/// </param>
		/// <param name="media">
		/// A <typeparamref name="TMedia"/> holding the data to be stored.
		/// </param>
		/// <param name="format">
		/// A <see cref="String"/> that specify the media format to used for saving <paramref name="media"/>.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specify parameters for loading an image stream.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="stream"/>, <paramref name="media"/> or <paramref name="criteria"/> is null.
		/// </exception>
		public abstract void Save(string path, TMedia media, string format, TMediaCodecCriteria criteria);

		/// <summary>
		/// Save media to stream.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="IO.Stream"/> which stores the media data.
		/// </param>
		/// <param name="media">
		/// A <typeparamref name="TMedia"/> holding the data to be stored.
		/// </param>
		/// <param name="format">
		/// A <see cref="String"/> that specify the media format to used for saving <paramref name="media"/>.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specify parameters for loading an image stream.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="stream"/>, <paramref name="media"/> or <paramref name="criteria"/> is null.
		/// </exception>
		public abstract void Save(Stream stream, TMedia media, string format, TMediaCodecCriteria criteria);

		/// <summary>
		/// Gets the list of media formats supported for reading.
		/// </summary>
		/// <value>
		/// The supported formats which this media codec plugin can read.
		/// </value>
		public abstract IEnumerable<string> SupportedReadFormats { get; }

		/// <summary>
		/// Check whether an media format is supported for reading.
		/// </summary>
		/// <param name="format">
		/// An <see cref="String"/> that specify the media format to test for read support.
		/// </param>
		/// <returns>
		/// A <see cref="Boolean"/> indicating whether <paramref name="format"/> is supported.
		/// </returns>
		public abstract bool IsReadSupported(string format);

		/// <summary>
		/// Gets the list of media formats supported for writing.
		/// </summary>
		/// <value>
		/// The supported formats which this media codec plugin can write.
		/// </value>
		public abstract IEnumerable<string> SupportedWriteFormats { get; }

		/// <summary>
		/// Check whether an media format is supported for writing.
		/// </summary>
		/// <param name="format">
		/// An <see cref="String"/> that specify the media format to test for write support.
		/// </param>
		/// <returns>
		/// A <see cref="Boolean"/> indicating whether <paramref name="format"/> is supported.
		/// </returns>
		public abstract bool IsWriteSupported(string format);

		/// <summary>
		/// Determine the plugin priority for a certain image format.
		/// </summary>
		/// <param name="format">
		/// An <see cref="String"/> that specify the media format to test for priority.
		/// </param>
		/// <returns>
		/// It returns an integer value indicating the priority of this implementation respect other ones supporting the same
		/// image format. Conventionally, a value of 0 indicates a totally impartial plugin implementation; a value less than 0 indicates
		/// a more confident implementation respect other plugins; a value greater than 0 indicates a fallback implementation respect other
		/// plugins.
		/// </returns>
		public abstract int GetPriority(string format);

		#endregion
	}
}
