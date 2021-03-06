/* 
+   This file is part of Trilleon.  Trilleon is a client automation framework.
+  
+   Copyright (C) 2017 Disruptor Beam
+  
+   Trilleon is free software: you can redistribute it and/or modify
+   it under the terms of the GNU Lesser General Public License as published by
+   the Free Software Foundation, either version 3 of the License, or
+   (at your option) any later version.
+
+   This program is distributed in the hope that it will be useful,
+   but WITHOUT ANY WARRANTY; without even the implied warranty of
+   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
+   GNU Lesser General Public License for more details.
+
+   You should have received a copy of the GNU Lesser General Public License
+   along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

﻿using System;

namespace TrilleonAutomation {

	/// <summary>
	/// Link a test to a dependency on a seperate device. Forces these tests to be run last, when a "buddy" device can be found and a relationship can be mapped between them.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public class BuddySystem : Attribute {

		public Buddy buddy { get; private set; }
		public string ReactionOf { get; private set; }

		public BuddySystem(Buddy buddy) : this(buddy, string.Empty) {}
		public BuddySystem(Buddy buddy, string ReactionOf) {

			this.buddy = buddy;
			this.ReactionOf = ReactionOf;

		}

	}

}
