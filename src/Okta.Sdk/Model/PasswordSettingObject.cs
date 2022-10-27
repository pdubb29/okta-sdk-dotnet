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
    /// PasswordSettingObject
    /// </summary>
    [DataContract(Name = "PasswordSettingObject")]
    
    public partial class PasswordSettingObject : IEquatable<PasswordSettingObject>
    {

        /// <summary>
        /// Gets or Sets Change
        /// </summary>
        [DataMember(Name = "change", EmitDefaultValue = false)]
        
        public ChangeEnum Change { get; set; }

        /// <summary>
        /// Gets or Sets Seed
        /// </summary>
        [DataMember(Name = "seed", EmitDefaultValue = false)]
        
        public SeedEnum Seed { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        
        public EnabledStatus Status { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PasswordSettingObject {\n");
            sb.Append("  Change: ").Append(Change).Append("\n");
            sb.Append("  Seed: ").Append(Seed).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as PasswordSettingObject);
        }

        /// <summary>
        /// Returns true if PasswordSettingObject instances are equal
        /// </summary>
        /// <param name="input">Instance of PasswordSettingObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PasswordSettingObject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Change == input.Change ||
                    this.Change.Equals(input.Change)
                ) && 
                (
                    this.Seed == input.Seed ||
                    this.Seed.Equals(input.Seed)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                
                hashCode = (hashCode * 59) + this.Change.GetHashCode();
                hashCode = (hashCode * 59) + this.Seed.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                return hashCode;
            }
        }

    }

}
