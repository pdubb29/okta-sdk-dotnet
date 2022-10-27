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
    /// Defines LoadingPageTouchPointVariant
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class LoadingPageTouchPointVariant : StringEnum
    {
        /// <summary>
        /// StringEnum LoadingPageTouchPointVariant for value: NONE
        /// </summary>
        public static LoadingPageTouchPointVariant NONE = new LoadingPageTouchPointVariant("NONE");
        /// <summary>
        /// StringEnum LoadingPageTouchPointVariant for value: OKTA_DEFAULT
        /// </summary>
        public static LoadingPageTouchPointVariant OKTADEFAULT = new LoadingPageTouchPointVariant("OKTA_DEFAULT");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="LoadingPageTouchPointVariant"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator LoadingPageTouchPointVariant(string value) => new LoadingPageTouchPointVariant(value);

        /// <summary>
        /// Creates a new <see cref="LoadingPageTouchPointVariant"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public LoadingPageTouchPointVariant(string value)
            : base(value)
        {
        }
    }


}
