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
    /// IdentityProviderCredentialsTrust
    /// </summary>
    [DataContract(Name = "IdentityProviderCredentialsTrust")]
    
    public partial class IdentityProviderCredentialsTrust : IEquatable<IdentityProviderCredentialsTrust>
    {

        /// <summary>
        /// Gets or Sets Revocation
        /// </summary>
        [DataMember(Name = "revocation", EmitDefaultValue = false)]
        
        public IdentityProviderCredentialsTrustRevocation Revocation { get; set; }
        
        /// <summary>
        /// Gets or Sets Audience
        /// </summary>
        [DataMember(Name = "audience", EmitDefaultValue = false)]
        public string Audience { get; set; }

        /// <summary>
        /// Gets or Sets Issuer
        /// </summary>
        [DataMember(Name = "issuer", EmitDefaultValue = false)]
        public string Issuer { get; set; }

        /// <summary>
        /// Gets or Sets Kid
        /// </summary>
        [DataMember(Name = "kid", EmitDefaultValue = false)]
        public string Kid { get; set; }

        /// <summary>
        /// Gets or Sets RevocationCacheLifetime
        /// </summary>
        [DataMember(Name = "revocationCacheLifetime", EmitDefaultValue = false)]
        public int RevocationCacheLifetime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IdentityProviderCredentialsTrust {\n");
            sb.Append("  Audience: ").Append(Audience).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  Kid: ").Append(Kid).Append("\n");
            sb.Append("  Revocation: ").Append(Revocation).Append("\n");
            sb.Append("  RevocationCacheLifetime: ").Append(RevocationCacheLifetime).Append("\n");
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
            return this.Equals(input as IdentityProviderCredentialsTrust);
        }

        /// <summary>
        /// Returns true if IdentityProviderCredentialsTrust instances are equal
        /// </summary>
        /// <param name="input">Instance of IdentityProviderCredentialsTrust to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdentityProviderCredentialsTrust input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Audience == input.Audience ||
                    (this.Audience != null &&
                    this.Audience.Equals(input.Audience))
                ) && 
                (
                    this.Issuer == input.Issuer ||
                    (this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer))
                ) && 
                (
                    this.Kid == input.Kid ||
                    (this.Kid != null &&
                    this.Kid.Equals(input.Kid))
                ) && 
                (
                    this.Revocation == input.Revocation ||
                    this.Revocation.Equals(input.Revocation)
                ) && 
                (
                    this.RevocationCacheLifetime == input.RevocationCacheLifetime ||
                    this.RevocationCacheLifetime.Equals(input.RevocationCacheLifetime)
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
                
                if (this.Audience != null)
                {
                    hashCode = (hashCode * 59) + this.Audience.GetHashCode();
                }
                if (this.Issuer != null)
                {
                    hashCode = (hashCode * 59) + this.Issuer.GetHashCode();
                }
                if (this.Kid != null)
                {
                    hashCode = (hashCode * 59) + this.Kid.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Revocation.GetHashCode();
                hashCode = (hashCode * 59) + this.RevocationCacheLifetime.GetHashCode();
                return hashCode;
            }
        }

    }

}
