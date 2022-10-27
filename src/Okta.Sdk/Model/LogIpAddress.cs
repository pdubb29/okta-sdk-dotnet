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
    /// Template: ModelGeneric
    /// LogIpAddress
    /// </summary>
    [DataContract(Name = "LogIpAddress")]
    
    public partial class LogIpAddress : IEquatable<LogIpAddress>
    {
        
        /// <summary>
        /// Gets or Sets GeographicalContext
        /// </summary>
        [DataMember(Name = "geographicalContext", EmitDefaultValue = false)]
        public LogGeographicalContext GeographicalContext { get; set; }

        /// <summary>
        /// Gets or Sets Ip
        /// </summary>
        [DataMember(Name = "ip", EmitDefaultValue = false)]
        public string Ip { get; private set; }

        /// <summary>
        /// Returns false as Ip should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIp()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; private set; }

        /// <summary>
        /// Returns false as Source should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSource()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string _Version { get; private set; }

        /// <summary>
        /// Returns false as _Version should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerialize_Version()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogIpAddress {\n");
            sb.Append("  GeographicalContext: ").Append(GeographicalContext).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LogIpAddress);
        }

        /// <summary>
        /// Returns true if LogIpAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of LogIpAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogIpAddress input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GeographicalContext == input.GeographicalContext ||
                    (this.GeographicalContext != null &&
                    this.GeographicalContext.Equals(input.GeographicalContext))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                
                if (this.GeographicalContext != null)
                {
                    hashCode = (hashCode * 59) + this.GeographicalContext.GetHashCode();
                }
                if (this.Ip != null)
                {
                    hashCode = (hashCode * 59) + this.Ip.GetHashCode();
                }
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
                }
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
