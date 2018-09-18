/* 
 * Abletech.Arxivar.Server.WebApi.Services
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// SendToIxFeSignRequiredRequestDto
    /// </summary>
    [DataContract]
    public partial class SendToIxFeSignRequiredRequestDto :  IEquatable<SendToIxFeSignRequiredRequestDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendToIxFeSignRequiredRequestDto" /> class.
        /// </summary>
        /// <param name="DocumentList">Document list to send.</param>
        public SendToIxFeSignRequiredRequestDto(List<int?> DocumentList = default(List<int?>))
        {
            this.DocumentList = DocumentList;
        }
        
        /// <summary>
        /// Document list to send
        /// </summary>
        /// <value>Document list to send</value>
        [DataMember(Name="documentList", EmitDefaultValue=false)]
        public List<int?> DocumentList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendToIxFeSignRequiredRequestDto {\n");
            sb.Append("  DocumentList: ").Append(DocumentList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SendToIxFeSignRequiredRequestDto);
        }

        /// <summary>
        /// Returns true if SendToIxFeSignRequiredRequestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of SendToIxFeSignRequiredRequestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendToIxFeSignRequiredRequestDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocumentList == input.DocumentList ||
                    this.DocumentList != null &&
                    this.DocumentList.SequenceEqual(input.DocumentList)
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
                if (this.DocumentList != null)
                    hashCode = hashCode * 59 + this.DocumentList.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
