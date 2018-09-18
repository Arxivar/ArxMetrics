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
    /// FieldBaseForSearchBoolDto
    /// </summary>
    [DataContract]
    public partial class FieldBaseForSearchBoolDto : FieldBaseForSearchDTO,  IEquatable<FieldBaseForSearchBoolDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldBaseForSearchBoolDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FieldBaseForSearchBoolDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldBaseForSearchBoolDto" /> class.
        /// </summary>
        /// <param name="_Operator">Possible values:  0: Non_Impostato  1: Minore  2: Minore_Uguale  3: Uguale  4: Maggiore_Uguale  5: Maggiore  6: Diverso  7: Compreso  8: Nullo  9: Non_Nullo  10: Nullo_o_Zero  11: Non_Nullo_e_Non_Zero  12: Escluso .</param>
        /// <param name="Valore1">The value of this field.</param>
        /// <param name="Valore2">The second value for this field (used only for some operator).</param>
        public FieldBaseForSearchBoolDto(int? _Operator = default(int?), bool? Valore1 = default(bool?), bool? Valore2 = default(bool?), int? GroupId = default(int?), int? FieldType = default(int?), int? AdditionalFieldType = default(int?), int? DefaultOperator = default(int?), string TableName = default(string), int? BinderFieldId = default(int?), string Multiple = default(string), string Name = default(string), string ExternalId = default(string), string Description = default(string), int? Order = default(int?), string DataSource = default(string), bool? Required = default(bool?), string Formula = default(string), string ClassName = "FieldBaseForSearchBoolDto", bool? Locked = default(bool?), string ComboGruppiId = default(string), List<DependencyFieldItem> DependencyFields = default(List<DependencyFieldItem>), Dictionary<string, string> Associations = default(Dictionary<string, string>), bool? IsAdditional = default(bool?), bool? Visible = default(bool?), string PredefinedProfileFormula = default(string)) : base(GroupId, FieldType, AdditionalFieldType, DefaultOperator, TableName, BinderFieldId, Multiple, Name, ExternalId, Description, Order, DataSource, Required, Formula, ClassName, Locked, ComboGruppiId, DependencyFields, Associations, IsAdditional, Visible, PredefinedProfileFormula)
        {
            this._Operator = _Operator;
            this.Valore1 = Valore1;
            this.Valore2 = Valore2;
        }
        
        /// <summary>
        /// Possible values:  0: Non_Impostato  1: Minore  2: Minore_Uguale  3: Uguale  4: Maggiore_Uguale  5: Maggiore  6: Diverso  7: Compreso  8: Nullo  9: Non_Nullo  10: Nullo_o_Zero  11: Non_Nullo_e_Non_Zero  12: Escluso 
        /// </summary>
        /// <value>Possible values:  0: Non_Impostato  1: Minore  2: Minore_Uguale  3: Uguale  4: Maggiore_Uguale  5: Maggiore  6: Diverso  7: Compreso  8: Nullo  9: Non_Nullo  10: Nullo_o_Zero  11: Non_Nullo_e_Non_Zero  12: Escluso </value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public int? _Operator { get; set; }

        /// <summary>
        /// The value of this field
        /// </summary>
        /// <value>The value of this field</value>
        [DataMember(Name="valore1", EmitDefaultValue=false)]
        public bool? Valore1 { get; set; }

        /// <summary>
        /// The second value for this field (used only for some operator)
        /// </summary>
        /// <value>The second value for this field (used only for some operator)</value>
        [DataMember(Name="valore2", EmitDefaultValue=false)]
        public bool? Valore2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldBaseForSearchBoolDto {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  Valore1: ").Append(Valore1).Append("\n");
            sb.Append("  Valore2: ").Append(Valore2).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as FieldBaseForSearchBoolDto);
        }

        /// <summary>
        /// Returns true if FieldBaseForSearchBoolDto instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldBaseForSearchBoolDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldBaseForSearchBoolDto input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this._Operator == input._Operator ||
                    (this._Operator != null &&
                    this._Operator.Equals(input._Operator))
                ) && base.Equals(input) && 
                (
                    this.Valore1 == input.Valore1 ||
                    (this.Valore1 != null &&
                    this.Valore1.Equals(input.Valore1))
                ) && base.Equals(input) && 
                (
                    this.Valore2 == input.Valore2 ||
                    (this.Valore2 != null &&
                    this.Valore2.Equals(input.Valore2))
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
                int hashCode = base.GetHashCode();
                if (this._Operator != null)
                    hashCode = hashCode * 59 + this._Operator.GetHashCode();
                if (this.Valore1 != null)
                    hashCode = hashCode * 59 + this.Valore1.GetHashCode();
                if (this.Valore2 != null)
                    hashCode = hashCode * 59 + this.Valore2.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
