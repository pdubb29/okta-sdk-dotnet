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
    /// CapabilitiesUpdateObject
    /// </summary>
    [DataContract(Name = "CapabilitiesUpdateObject")]
    
    public partial class CapabilitiesUpdateObject : IEquatable<CapabilitiesUpdateObject>
    {
        
        /// <summary>
        /// Gets or Sets LifecycleDeactivate
        /// </summary>
        [DataMember(Name = "lifecycleDeactivate", EmitDefaultValue = false)]
        public LifecycleDeactivateSettingObject LifecycleDeactivate { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public PasswordSettingObject Password { get; set; }

        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name = "profile", EmitDefaultValue = false)]
        public ProfileSettingObject Profile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CapabilitiesUpdateObject {\n");
            sb.Append("  LifecycleDeactivate: ").Append(LifecycleDeactivate).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
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
            return this.Equals(input as CapabilitiesUpdateObject);
        }

        /// <summary>
        /// Returns true if CapabilitiesUpdateObject instances are equal
        /// </summary>
        /// <param name="input">Instance of CapabilitiesUpdateObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapabilitiesUpdateObject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LifecycleDeactivate == input.LifecycleDeactivate ||
                    (this.LifecycleDeactivate != null &&
                    this.LifecycleDeactivate.Equals(input.LifecycleDeactivate))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Profile == input.Profile ||
                    (this.Profile != null &&
                    this.Profile.Equals(input.Profile))
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
                
                if (this.LifecycleDeactivate != null)
                {
                    hashCode = (hashCode * 59) + this.LifecycleDeactivate.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }
                if (this.Profile != null)
                {
                    hashCode = (hashCode * 59) + this.Profile.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
