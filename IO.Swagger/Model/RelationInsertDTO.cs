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
    /// RelationInsertDTO
    /// </summary>
    [DataContract]
    public partial class RelationInsertDTO :  IEquatable<RelationInsertDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelationInsertDTO" /> class.
        /// </summary>
        /// <param name="DocNumber">Document Identifier.</param>
        /// <param name="Items">Items.</param>
        public RelationInsertDTO(int? DocNumber = default(int?), List<RelationInsertItemDTO> Items = default(List<RelationInsertItemDTO>))
        {
            this.DocNumber = DocNumber;
            this.Items = Items;
        }
        
        /// <summary>
        /// Document Identifier
        /// </summary>
        /// <value>Document Identifier</value>
        [DataMember(Name="docNumber", EmitDefaultValue=false)]
        public int? DocNumber { get; set; }

        /// <summary>
        /// Items
        /// </summary>
        /// <value>Items</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<RelationInsertItemDTO> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelationInsertDTO {\n");
            sb.Append("  DocNumber: ").Append(DocNumber).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as RelationInsertDTO);
        }

        /// <summary>
        /// Returns true if RelationInsertDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of RelationInsertDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelationInsertDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocNumber == input.DocNumber ||
                    (this.DocNumber != null &&
                    this.DocNumber.Equals(input.DocNumber))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                if (this.DocNumber != null)
                    hashCode = hashCode * 59 + this.DocNumber.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
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
