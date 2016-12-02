
// Copyright (C) 2009-2015 Luca Piccioni
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

namespace OpenGL.Objects
{
	public enum QueryTarget
	{
		SamplesPassed = Gl.SAMPLES_PASSED,

		TimeElapsed = Gl.TIME_ELAPSED,

		PrimitivesGenerated = Gl.PRIMITIVES_GENERATED,

		TransformFeedbackPrimitivesGenerated = Gl.TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN,

		AnySamplesPassed = Gl.ANY_SAMPLES_PASSED
	}
}