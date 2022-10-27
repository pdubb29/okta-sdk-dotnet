/*
 * Okta Management
 *
 * Allows customers to easily access the Okta Management APIs
 *
 * The version of the OpenAPI document: 3.0.0
 * Contact: devex-public@okta.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = Okta.Sdk.Client.OpenAPIDateConverter;

namespace Okta.Sdk.Model
{
    /// <summary>
    /// Defines IssuerMode
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class IssuerMode : StringEnum
    {
        /// <summary>
        /// StringEnum IssuerMode for value: CUSTOM_URL
        /// </summary>
        public static IssuerMode CUSTOMURL = new IssuerMode("CUSTOM_URL");
        /// <summary>
        /// StringEnum IssuerMode for value: DYNAMIC
        /// </summary>
        public static IssuerMode DYNAMIC = new IssuerMode("DYNAMIC");
        /// <summary>
        /// StringEnum IssuerMode for value: ORG_URL
        /// </summary>
        public static IssuerMode ORGURL = new IssuerMode("ORG_URL");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="IssuerMode"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator IssuerMode(string value) => new IssuerMode(value);

        /// <summary>
        /// Creates a new <see cref="IssuerMode"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public IssuerMode(string value)
            : base(value)
        {
        }
    }


}
