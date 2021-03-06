/*
 * Copyright 2011 Shou Takenaka
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace Fidely.Framework.Integration
{
    /// <summary>
    /// Represents the matching mode that is used to determine whether or not show the autocomplete item.
    /// </summary>
    public enum MatchingMode
    {
        /// <summary>
        /// Represents partial matching mode.
        /// </summary>
        Partial = 0,

        /// <summary>
        /// Represents prefix search mode.
        /// </summary>
        Prefix,
    }
}