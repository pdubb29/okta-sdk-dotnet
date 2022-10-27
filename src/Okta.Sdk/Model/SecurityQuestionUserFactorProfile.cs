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
    /// SecurityQuestionUserFactorProfile
    /// </summary>
    [DataContract(Name = "SecurityQuestionUserFactorProfile")]
    
    public partial class SecurityQuestionUserFactorProfile : IEquatable<SecurityQuestionUserFactorProfile>
    {
        
        /// <summary>
        /// Gets or Sets Answer
        /// </summary>
        [DataMember(Name = "answer", EmitDefaultValue = false)]
        public string Answer { get; set; }

        /// <summary>
        /// Gets or Sets Question
        /// </summary>
        [DataMember(Name = "question", EmitDefaultValue = false)]
        public string Question { get; set; }

        /// <summary>
        /// Gets or Sets QuestionText
        /// </summary>
        [DataMember(Name = "questionText", EmitDefaultValue = false)]
        public string QuestionText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SecurityQuestionUserFactorProfile {\n");
            sb.Append("  Answer: ").Append(Answer).Append("\n");
            sb.Append("  Question: ").Append(Question).Append("\n");
            sb.Append("  QuestionText: ").Append(QuestionText).Append("\n");
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
            return this.Equals(input as SecurityQuestionUserFactorProfile);
        }

        /// <summary>
        /// Returns true if SecurityQuestionUserFactorProfile instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityQuestionUserFactorProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityQuestionUserFactorProfile input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Answer == input.Answer ||
                    (this.Answer != null &&
                    this.Answer.Equals(input.Answer))
                ) && 
                (
                    this.Question == input.Question ||
                    (this.Question != null &&
                    this.Question.Equals(input.Question))
                ) && 
                (
                    this.QuestionText == input.QuestionText ||
                    (this.QuestionText != null &&
                    this.QuestionText.Equals(input.QuestionText))
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
                
                if (this.Answer != null)
                {
                    hashCode = (hashCode * 59) + this.Answer.GetHashCode();
                }
                if (this.Question != null)
                {
                    hashCode = (hashCode * 59) + this.Question.GetHashCode();
                }
                if (this.QuestionText != null)
                {
                    hashCode = (hashCode * 59) + this.QuestionText.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
