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
    /// Class of request to apply timestamp
    /// </summary>
    [DataContract]
    public partial class TimestampRequestDTO :  IEquatable<TimestampRequestDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimestampRequestDTO" /> class.
        /// </summary>
        /// <param name="TsaId">Timestamp Identifier.</param>
        /// <param name="TimestampElementList">Items.</param>
        public TimestampRequestDTO(string TsaId = default(string), List<TimestampElementRequestDTO> TimestampElementList = default(List<TimestampElementRequestDTO>))
        {
            this.TsaId = TsaId;
            this.TimestampElementList = TimestampElementList;
        }
        
        /// <summary>
        /// Timestamp Identifier
        /// </summary>
        /// <value>Timestamp Identifier</value>
        [DataMember(Name="tsaId", EmitDefaultValue=false)]
        public string TsaId { get; set; }

        /// <summary>
        /// Items
        /// </summary>
        /// <value>Items</value>
        [DataMember(Name="timestampElementList", EmitDefaultValue=false)]
        public List<TimestampElementRequestDTO> TimestampElementList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimestampRequestDTO {\n");
            sb.Append("  TsaId: ").Append(TsaId).Append("\n");
            sb.Append("  TimestampElementList: ").Append(TimestampElementList).Append("\n");
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
            return this.Equals(input as TimestampRequestDTO);
        }

        /// <summary>
        /// Returns true if TimestampRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TimestampRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimestampRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TsaId == input.TsaId ||
                    (this.TsaId != null &&
                    this.TsaId.Equals(input.TsaId))
                ) && 
                (
                    this.TimestampElementList == input.TimestampElementList ||
                    this.TimestampElementList != null &&
                    this.TimestampElementList.SequenceEqual(input.TimestampElementList)
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
                if (this.TsaId != null)
                    hashCode = hashCode * 59 + this.TsaId.GetHashCode();
                if (this.TimestampElementList != null)
                    hashCode = hashCode * 59 + this.TimestampElementList.GetHashCode();
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
