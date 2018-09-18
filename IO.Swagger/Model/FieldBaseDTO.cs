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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Class of field item
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "className")]
    [JsonSubtypes.KnownSubType(typeof(OriginalFieldDTO), "OriginalFieldDTO")]
    [JsonSubtypes.KnownSubType(typeof(AdditionalFieldGroupDTO), "AdditionalFieldGroupDTO")]
    [JsonSubtypes.KnownSubType(typeof(OriginFieldDTO), "OriginFieldDTO")]
    [JsonSubtypes.KnownSubType(typeof(AdditionalFieldDateTimeDTO), "AdditionalFieldDateTimeDTO")]
    [JsonSubtypes.KnownSubType(typeof(AdditionalFieldTableDTO), "AdditionalFieldTableDTO")]
    [JsonSubtypes.KnownSubType(typeof(DocumentDateExpiredFieldDTO), "DocumentDateExpiredFieldDTO")]
    [JsonSubtypes.KnownSubType(typeof(StateFieldDTO), "StateFieldDTO")]
    [JsonSubtypes.KnownSubType(typeof(ToFieldDTO), "ToFieldDTO")]
    [JsonSubtypes.KnownSubType(typeof(AdditionalFieldStringDTO), "AdditionalFieldStringDTO")]
    [JsonSubtypes.KnownSubType(typeof(AdditionalFieldDoubleDTO), "AdditionalFieldDoubleDTO")]
    [JsonSubtypes.KnownSubType(typeof(FolderFieldDTO), "FolderFieldDTO")]
    [JsonSubtypes.KnownSubType(typeof(AdditionalFieldBooleanDTO), "AdditionalFieldBooleanDTO")]
    [JsonSubtypes.KnownSubType(typeof(NumberFieldDTO), "NumberFieldDTO")]
    [JsonSubtypes.KnownSubType(typeof(NoteFieldDTO), "NoteFieldDTO")]
    [JsonSubtypes.KnownSubType(typeof(AuthorityDataFieldDTO), "AuthorityDataFieldDTO")]
    [JsonSubtypes.KnownSubType(typeof(AttachmentFieldDTO), "AttachmentFieldDTO")]
    [JsonSubtypes.KnownSubType(typeof(ProtocolDateFieldDTO), "ProtocolDateFieldDTO")]
    [JsonSubtypes.KnownSubType(typeof(BinderFieldDTO), "BinderFieldDTO")]
    [JsonSubtypes.KnownSubType(typeof(DocumentDateFieldDto), "DocumentDateFieldDto")]
    [JsonSubtypes.KnownSubType(typeof(AdditionalFieldDTO), "AdditionalFieldDTO")]
    [JsonSubtypes.KnownSubType(typeof(CcFieldDTO), "CcFieldDTO")]
    [JsonSubtypes.KnownSubType(typeof(StringFieldDTO), "StringFieldDTO")]
    [JsonSubtypes.KnownSubType(typeof(SendersFieldDTO), "SendersFieldDTO")]
    [JsonSubtypes.KnownSubType(typeof(BusinessUnitFieldDTO), "BusinessUnitFieldDTO")]
    [JsonSubtypes.KnownSubType(typeof(AdditionalFieldClasseDTO), "AdditionalFieldClasseDTO")]
    [JsonSubtypes.KnownSubType(typeof(AdditionalFieldComboDTO), "AdditionalFieldComboDTO")]
    [JsonSubtypes.KnownSubType(typeof(FromFieldDTO), "FromFieldDTO")]
    [JsonSubtypes.KnownSubType(typeof(ImportantFieldDTO), "ImportantFieldDTO")]
    [JsonSubtypes.KnownSubType(typeof(AdditionalFieldMultivalueDTO), "AdditionalFieldMultivalueDTO")]
    [JsonSubtypes.KnownSubType(typeof(BinderPreviewFieldDTO), "BinderPreviewFieldDTO")]
    [JsonSubtypes.KnownSubType(typeof(AssociationFieldDTO), "AssociationFieldDTO")]
    [JsonSubtypes.KnownSubType(typeof(SubjectFieldDTO), "SubjectFieldDTO")]
    [JsonSubtypes.KnownSubType(typeof(AdditionalFieldIntDTO), "AdditionalFieldIntDTO")]
    [JsonSubtypes.KnownSubType(typeof(DocumentTypeFieldDTO), "DocumentTypeFieldDTO")]
    [JsonSubtypes.KnownSubType(typeof(BarcodeFieldDTO), "BarcodeFieldDTO")]
    public partial class FieldBaseDTO :  IEquatable<FieldBaseDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldBaseDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FieldBaseDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldBaseDTO" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="ExternalId">External identifier.</param>
        /// <param name="Description">Label.</param>
        /// <param name="Order">Order.</param>
        /// <param name="DataSource">DataSource identifier.</param>
        /// <param name="Required">Required.</param>
        /// <param name="Formula">Formula.</param>
        /// <param name="ClassName">Name of class (required).</param>
        /// <param name="Locked">Locked in read-only.</param>
        /// <param name="ComboGruppiId">Data Group Identifier.</param>
        /// <param name="DependencyFields">List of dependent fields.</param>
        /// <param name="Associations">Associated fields.</param>
        /// <param name="IsAdditional">Field type additional.</param>
        /// <param name="Visible">Visible.</param>
        /// <param name="PredefinedProfileFormula">Formula in the context of predefined profile.</param>
        public FieldBaseDTO(string Name = default(string), string ExternalId = default(string), string Description = default(string), int? Order = default(int?), string DataSource = default(string), bool? Required = default(bool?), string Formula = default(string), string ClassName = default(string), bool? Locked = default(bool?), string ComboGruppiId = default(string), List<DependencyFieldItem> DependencyFields = default(List<DependencyFieldItem>), List<AssocitationFieldItem> Associations = default(List<AssocitationFieldItem>), bool? IsAdditional = default(bool?), bool? Visible = default(bool?), string PredefinedProfileFormula = default(string))
        {
            // to ensure "ClassName" is required (not null)
            if (ClassName == null)
            {
                throw new InvalidDataException("ClassName is a required property for FieldBaseDTO and cannot be null");
            }
            else
            {
                this.ClassName = ClassName;
            }
            this.Name = Name;
            this.ExternalId = ExternalId;
            this.Description = Description;
            this.Order = Order;
            this.DataSource = DataSource;
            this.Required = Required;
            this.Formula = Formula;
            this.Locked = Locked;
            this.ComboGruppiId = ComboGruppiId;
            this.DependencyFields = DependencyFields;
            this.Associations = Associations;
            this.IsAdditional = IsAdditional;
            this.Visible = Visible;
            this.PredefinedProfileFormula = PredefinedProfileFormula;
        }
        
        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// External identifier
        /// </summary>
        /// <value>External identifier</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Label
        /// </summary>
        /// <value>Label</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Order
        /// </summary>
        /// <value>Order</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }

        /// <summary>
        /// DataSource identifier
        /// </summary>
        /// <value>DataSource identifier</value>
        [DataMember(Name="dataSource", EmitDefaultValue=false)]
        public string DataSource { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        /// <value>Required</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// Formula
        /// </summary>
        /// <value>Formula</value>
        [DataMember(Name="formula", EmitDefaultValue=false)]
        public string Formula { get; set; }

        /// <summary>
        /// Name of class
        /// </summary>
        /// <value>Name of class</value>
        [DataMember(Name="className", EmitDefaultValue=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// Locked in read-only
        /// </summary>
        /// <value>Locked in read-only</value>
        [DataMember(Name="locked", EmitDefaultValue=false)]
        public bool? Locked { get; set; }

        /// <summary>
        /// Data Group Identifier
        /// </summary>
        /// <value>Data Group Identifier</value>
        [DataMember(Name="comboGruppiId", EmitDefaultValue=false)]
        public string ComboGruppiId { get; set; }

        /// <summary>
        /// List of dependent fields
        /// </summary>
        /// <value>List of dependent fields</value>
        [DataMember(Name="dependencyFields", EmitDefaultValue=false)]
        public List<DependencyFieldItem> DependencyFields { get; set; }

        /// <summary>
        /// Associated fields
        /// </summary>
        /// <value>Associated fields</value>
        [DataMember(Name="associations", EmitDefaultValue=false)]
        public List<AssocitationFieldItem> Associations { get; set; }

        /// <summary>
        /// Field type additional
        /// </summary>
        /// <value>Field type additional</value>
        [DataMember(Name="isAdditional", EmitDefaultValue=false)]
        public bool? IsAdditional { get; set; }

        /// <summary>
        /// Visible
        /// </summary>
        /// <value>Visible</value>
        [DataMember(Name="visible", EmitDefaultValue=false)]
        public bool? Visible { get; set; }

        /// <summary>
        /// Formula in the context of predefined profile
        /// </summary>
        /// <value>Formula in the context of predefined profile</value>
        [DataMember(Name="predefinedProfileFormula", EmitDefaultValue=false)]
        public string PredefinedProfileFormula { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldBaseDTO {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  DataSource: ").Append(DataSource).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Formula: ").Append(Formula).Append("\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  ComboGruppiId: ").Append(ComboGruppiId).Append("\n");
            sb.Append("  DependencyFields: ").Append(DependencyFields).Append("\n");
            sb.Append("  Associations: ").Append(Associations).Append("\n");
            sb.Append("  IsAdditional: ").Append(IsAdditional).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
            sb.Append("  PredefinedProfileFormula: ").Append(PredefinedProfileFormula).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as FieldBaseDTO);
        }

        /// <summary>
        /// Returns true if FieldBaseDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldBaseDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldBaseDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.DataSource == input.DataSource ||
                    (this.DataSource != null &&
                    this.DataSource.Equals(input.DataSource))
                ) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
                ) && 
                (
                    this.Formula == input.Formula ||
                    (this.Formula != null &&
                    this.Formula.Equals(input.Formula))
                ) && 
                (
                    this.ClassName == input.ClassName ||
                    (this.ClassName != null &&
                    this.ClassName.Equals(input.ClassName))
                ) && 
                (
                    this.Locked == input.Locked ||
                    (this.Locked != null &&
                    this.Locked.Equals(input.Locked))
                ) && 
                (
                    this.ComboGruppiId == input.ComboGruppiId ||
                    (this.ComboGruppiId != null &&
                    this.ComboGruppiId.Equals(input.ComboGruppiId))
                ) && 
                (
                    this.DependencyFields == input.DependencyFields ||
                    this.DependencyFields != null &&
                    this.DependencyFields.SequenceEqual(input.DependencyFields)
                ) && 
                (
                    this.Associations == input.Associations ||
                    this.Associations != null &&
                    this.Associations.SequenceEqual(input.Associations)
                ) && 
                (
                    this.IsAdditional == input.IsAdditional ||
                    (this.IsAdditional != null &&
                    this.IsAdditional.Equals(input.IsAdditional))
                ) && 
                (
                    this.Visible == input.Visible ||
                    (this.Visible != null &&
                    this.Visible.Equals(input.Visible))
                ) && 
                (
                    this.PredefinedProfileFormula == input.PredefinedProfileFormula ||
                    (this.PredefinedProfileFormula != null &&
                    this.PredefinedProfileFormula.Equals(input.PredefinedProfileFormula))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.DataSource != null)
                    hashCode = hashCode * 59 + this.DataSource.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Formula != null)
                    hashCode = hashCode * 59 + this.Formula.GetHashCode();
                if (this.ClassName != null)
                    hashCode = hashCode * 59 + this.ClassName.GetHashCode();
                if (this.Locked != null)
                    hashCode = hashCode * 59 + this.Locked.GetHashCode();
                if (this.ComboGruppiId != null)
                    hashCode = hashCode * 59 + this.ComboGruppiId.GetHashCode();
                if (this.DependencyFields != null)
                    hashCode = hashCode * 59 + this.DependencyFields.GetHashCode();
                if (this.Associations != null)
                    hashCode = hashCode * 59 + this.Associations.GetHashCode();
                if (this.IsAdditional != null)
                    hashCode = hashCode * 59 + this.IsAdditional.GetHashCode();
                if (this.Visible != null)
                    hashCode = hashCode * 59 + this.Visible.GetHashCode();
                if (this.PredefinedProfileFormula != null)
                    hashCode = hashCode * 59 + this.PredefinedProfileFormula.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
