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
    /// This class contain information about avaible filters for a given additional field
    /// </summary>
    [DataContract]
    public partial class FieldFilterDTO :  IEquatable<FieldFilterDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldFilterDTO" /> class.
        /// </summary>
        /// <param name="KeyField">The column name of the property that the client have to use for set the value of the additional field.</param>
        /// <param name="SelectField">The column name of the property that the client have to use for display the value of the additional field.</param>
        /// <param name="Filters">Array of avaible filters for the additional field.</param>
        /// <param name="ShowFilled">This property show to client if the search for this field has to be prefilled or not.</param>
        /// <param name="DefaultField">The name of filter to use for this field by default.</param>
        public FieldFilterDTO(string KeyField = default(string), string SelectField = default(string), List<FieldBaseForSearchDTO> Filters = default(List<FieldBaseForSearchDTO>), bool? ShowFilled = default(bool?), string DefaultField = default(string))
        {
            this.KeyField = KeyField;
            this.SelectField = SelectField;
            this.Filters = Filters;
            this.ShowFilled = ShowFilled;
            this.DefaultField = DefaultField;
        }
        
        /// <summary>
        /// The column name of the property that the client have to use for set the value of the additional field
        /// </summary>
        /// <value>The column name of the property that the client have to use for set the value of the additional field</value>
        [DataMember(Name="keyField", EmitDefaultValue=false)]
        public string KeyField { get; set; }

        /// <summary>
        /// The column name of the property that the client have to use for display the value of the additional field
        /// </summary>
        /// <value>The column name of the property that the client have to use for display the value of the additional field</value>
        [DataMember(Name="selectField", EmitDefaultValue=false)]
        public string SelectField { get; set; }

        /// <summary>
        /// Array of avaible filters for the additional field
        /// </summary>
        /// <value>Array of avaible filters for the additional field</value>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<FieldBaseForSearchDTO> Filters { get; set; }

        /// <summary>
        /// This property show to client if the search for this field has to be prefilled or not
        /// </summary>
        /// <value>This property show to client if the search for this field has to be prefilled or not</value>
        [DataMember(Name="showFilled", EmitDefaultValue=false)]
        public bool? ShowFilled { get; set; }

        /// <summary>
        /// The name of filter to use for this field by default
        /// </summary>
        /// <value>The name of filter to use for this field by default</value>
        [DataMember(Name="defaultField", EmitDefaultValue=false)]
        public string DefaultField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldFilterDTO {\n");
            sb.Append("  KeyField: ").Append(KeyField).Append("\n");
            sb.Append("  SelectField: ").Append(SelectField).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  ShowFilled: ").Append(ShowFilled).Append("\n");
            sb.Append("  DefaultField: ").Append(DefaultField).Append("\n");
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
            return this.Equals(input as FieldFilterDTO);
        }

        /// <summary>
        /// Returns true if FieldFilterDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldFilterDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldFilterDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeyField == input.KeyField ||
                    (this.KeyField != null &&
                    this.KeyField.Equals(input.KeyField))
                ) && 
                (
                    this.SelectField == input.SelectField ||
                    (this.SelectField != null &&
                    this.SelectField.Equals(input.SelectField))
                ) && 
                (
                    this.Filters == input.Filters ||
                    this.Filters != null &&
                    this.Filters.SequenceEqual(input.Filters)
                ) && 
                (
                    this.ShowFilled == input.ShowFilled ||
                    (this.ShowFilled != null &&
                    this.ShowFilled.Equals(input.ShowFilled))
                ) && 
                (
                    this.DefaultField == input.DefaultField ||
                    (this.DefaultField != null &&
                    this.DefaultField.Equals(input.DefaultField))
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
                if (this.KeyField != null)
                    hashCode = hashCode * 59 + this.KeyField.GetHashCode();
                if (this.SelectField != null)
                    hashCode = hashCode * 59 + this.SelectField.GetHashCode();
                if (this.Filters != null)
                    hashCode = hashCode * 59 + this.Filters.GetHashCode();
                if (this.ShowFilled != null)
                    hashCode = hashCode * 59 + this.ShowFilled.GetHashCode();
                if (this.DefaultField != null)
                    hashCode = hashCode * 59 + this.DefaultField.GetHashCode();
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
