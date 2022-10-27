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
    /// Defines FactorStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class FactorStatus : StringEnum
    {
        /// <summary>
        /// StringEnum FactorStatus for value: ACTIVE
        /// </summary>
        public static FactorStatus ACTIVE = new FactorStatus("ACTIVE");
        /// <summary>
        /// StringEnum FactorStatus for value: DISABLED
        /// </summary>
        public static FactorStatus DISABLED = new FactorStatus("DISABLED");
        /// <summary>
        /// StringEnum FactorStatus for value: ENROLLED
        /// </summary>
        public static FactorStatus ENROLLED = new FactorStatus("ENROLLED");
        /// <summary>
        /// StringEnum FactorStatus for value: EXPIRED
        /// </summary>
        public static FactorStatus EXPIRED = new FactorStatus("EXPIRED");
        /// <summary>
        /// StringEnum FactorStatus for value: INACTIVE
        /// </summary>
        public static FactorStatus INACTIVE = new FactorStatus("INACTIVE");
        /// <summary>
        /// StringEnum FactorStatus for value: NOT_SETUP
        /// </summary>
        public static FactorStatus NOTSETUP = new FactorStatus("NOT_SETUP");
        /// <summary>
        /// StringEnum FactorStatus for value: PENDING_ACTIVATION
        /// </summary>
        public static FactorStatus PENDINGACTIVATION = new FactorStatus("PENDING_ACTIVATION");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="FactorStatus"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator FactorStatus(string value) => new FactorStatus(value);

        /// <summary>
        /// Creates a new <see cref="FactorStatus"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public FactorStatus(string value)
            : base(value)
        {
        }
    }


}
