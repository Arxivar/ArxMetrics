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
    /// Class of search
    /// </summary>
    [DataContract]
    public partial class SearchDTO :  IEquatable<SearchDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDTO" /> class.
        /// </summary>
        /// <param name="Description">The description of the search.</param>
        /// <param name="DaAAndOr">Possible values:  0: And  1: Or .</param>
        /// <param name="Fields">Fields.</param>
        public SearchDTO(string Description = default(string), int? DaAAndOr = default(int?), List<FieldBaseForSearchDTO> Fields = default(List<FieldBaseForSearchDTO>))
        {
            this.Description = Description;
            this.DaAAndOr = DaAAndOr;
            this.Fields = Fields;
        }
        
        /// <summary>
        /// The description of the search
        /// </summary>
        /// <value>The description of the search</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Possible values:  0: And  1: Or 
        /// </summary>
        /// <value>Possible values:  0: And  1: Or </value>
        [DataMember(Name="daAAndOr", EmitDefaultValue=false)]
        public int? DaAAndOr { get; set; }

        /// <summary>
        /// Fields
        /// </summary>
        /// <value>Fields</value>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchDTO> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchDTO {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DaAAndOr: ").Append(DaAAndOr).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
            return this.Equals(input as SearchDTO);
        }

        /// <summary>
        /// Returns true if SearchDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DaAAndOr == input.DaAAndOr ||
                    (this.DaAAndOr != null &&
                    this.DaAAndOr.Equals(input.DaAAndOr))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DaAAndOr != null)
                    hashCode = hashCode * 59 + this.DaAAndOr.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
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
