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

namespace Fidely.Framework.Caching
{
    internal class CacheItem<TKey, TValue>
    {
        public CacheItem(TKey key, TValue value)
        {
            Key = key;
            Value = value;
            Hits = 0;
        }

        public TKey Key { get; private set; }

        public TValue Value { get; private set; }

        public int Hits { get; set; }
    }
}