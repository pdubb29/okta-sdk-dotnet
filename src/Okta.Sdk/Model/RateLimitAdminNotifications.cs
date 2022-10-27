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
    /// RateLimitAdminNotifications
    /// </summary>
    [DataContract(Name = "RateLimitAdminNotifications")]
    
    public partial class RateLimitAdminNotifications : IEquatable<RateLimitAdminNotifications>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitAdminNotifications" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public RateLimitAdminNotifications() { }
        
        /// <summary>
        /// Gets or Sets NotificationsEnabled
        /// </summary>
        [DataMember(Name = "notificationsEnabled", IsRequired = true, EmitDefaultValue = true)]
        public bool NotificationsEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RateLimitAdminNotifications {\n");
            sb.Append("  NotificationsEnabled: ").Append(NotificationsEnabled).Append("\n");
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
            return this.Equals(input as RateLimitAdminNotifications);
        }

        /// <summary>
        /// Returns true if RateLimitAdminNotifications instances are equal
        /// </summary>
        /// <param name="input">Instance of RateLimitAdminNotifications to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RateLimitAdminNotifications input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NotificationsEnabled == input.NotificationsEnabled ||
                    this.NotificationsEnabled.Equals(input.NotificationsEnabled)
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
                
                hashCode = (hashCode * 59) + this.NotificationsEnabled.GetHashCode();
                return hashCode;
            }
        }

    }

}
