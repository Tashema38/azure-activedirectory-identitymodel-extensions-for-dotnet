﻿//------------------------------------------------------------------------------
//
// Copyright (c) Microsoft Corporation.
// All rights reserved.
//
// This code is licensed under the MIT License.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files(the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and / or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions :
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
//------------------------------------------------------------------------------

using System.ComponentModel;

namespace Microsoft.IdentityModel.Protocols
{
    /// <summary>
    /// Represents the result of validation a <see cref="IConfigurationValidator{T}"/>.
    /// </summary>
    public class ConfigurationValidationResult
    {
        /// <summary>
        /// Gets or sets the <see cref="ConfigurationValidationException"/> that occurred during validation of the SignedHttpRequest.
        /// </summary>
        public ConfigurationValidationException Exception { get; set; }

        /// <summary>
        /// Gets or sets a bool indicating if the configuration validation was successful.
        /// </summary>
        [DefaultValue(false)]
        public bool Succeeded { get; set; } = false;
    }
}
