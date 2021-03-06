﻿// Copyright 2016 Datalust Pty Ltd
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections.Generic;

namespace Seq.Forwarder.Cli.Features
{
    class KeyValuePropertiesFeature : CommandFeature
    {
        readonly Dictionary<string, string> _properties = new Dictionary<string, string>();

        public Dictionary<string, string> Properties => _properties; 
         
        public override void Enable(OptionSet options)
        {
            options.Add(
                "p={=}|property={=}", 
                "Attach additional properties to the imported events, e.g. -p Customer=C123 -p Environment=Production", 
                (n, v) => _properties.Add(n.Trim(), string.IsNullOrWhiteSpace(v) ? null : v.Trim()));
        }
    }
}
