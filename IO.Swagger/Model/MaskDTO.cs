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
    /// Class of mask to archive documents
    /// </summary>
    [DataContract]
    public partial class MaskDTO :  IEquatable<MaskDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaskDTO" /> class.
        /// </summary>
        /// <param name="Id">Identifier.</param>
        /// <param name="MaskName">Name.</param>
        /// <param name="MaskDescription">Description.</param>
        /// <param name="PredefinedProfileId">Predefined Profile Identifier.</param>
        /// <param name="User">Author Identifier.</param>
        /// <param name="ExternalId">External Identifier.</param>
        /// <param name="IsRoot">Root.</param>
        /// <param name="Type">Possible values:  0: Nothing  1: Barcode  2: Archiviazione .</param>
        /// <param name="PaMode">Possible values:  0: None  1: OnlyNever  2: OnlyOptionally  3: NeverOrOptionally  4: OnlyAlways  5: AlwaysOrNever  6: AlwaysOrOptionally  7: All .</param>
        /// <param name="ShowAdditional">Show Additional.</param>
        /// <param name="Kind">Possible values:  0: UserMask  1: SystemMask .</param>
        /// <param name="ShowGroups">Show Groups.</param>
        /// <param name="UserCompleteName">Author Complete Name.</param>
        /// <param name="PredefinedProfile">Predefined Profile associated with the mask.</param>
        /// <param name="MaskDetails">Details.</param>
        /// <param name="MaskClassOptions">Options on document type.</param>
        public MaskDTO(string Id = default(string), string MaskName = default(string), string MaskDescription = default(string), int? PredefinedProfileId = default(int?), int? User = default(int?), string ExternalId = default(string), bool? IsRoot = default(bool?), int? Type = default(int?), int? PaMode = default(int?), bool? ShowAdditional = default(bool?), int? Kind = default(int?), bool? ShowGroups = default(bool?), string UserCompleteName = default(string), PredefinedProfileDTO PredefinedProfile = default(PredefinedProfileDTO), List<MaskDetailDTO> MaskDetails = default(List<MaskDetailDTO>), List<MaskClassOptionsDTO> MaskClassOptions = default(List<MaskClassOptionsDTO>))
        {
            this.Id = Id;
            this.MaskName = MaskName;
            this.MaskDescription = MaskDescription;
            this.PredefinedProfileId = PredefinedProfileId;
            this.User = User;
            this.ExternalId = ExternalId;
            this.IsRoot = IsRoot;
            this.Type = Type;
            this.PaMode = PaMode;
            this.ShowAdditional = ShowAdditional;
            this.Kind = Kind;
            this.ShowGroups = ShowGroups;
            this.UserCompleteName = UserCompleteName;
            this.PredefinedProfile = PredefinedProfile;
            this.MaskDetails = MaskDetails;
            this.MaskClassOptions = MaskClassOptions;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="maskName", EmitDefaultValue=false)]
        public string MaskName { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="maskDescription", EmitDefaultValue=false)]
        public string MaskDescription { get; set; }

        /// <summary>
        /// Predefined Profile Identifier
        /// </summary>
        /// <value>Predefined Profile Identifier</value>
        [DataMember(Name="predefinedProfileId", EmitDefaultValue=false)]
        public int? PredefinedProfileId { get; set; }

        /// <summary>
        /// Author Identifier
        /// </summary>
        /// <value>Author Identifier</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public int? User { get; set; }

        /// <summary>
        /// External Identifier
        /// </summary>
        /// <value>External Identifier</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Root
        /// </summary>
        /// <value>Root</value>
        [DataMember(Name="isRoot", EmitDefaultValue=false)]
        public bool? IsRoot { get; set; }

        /// <summary>
        /// Possible values:  0: Nothing  1: Barcode  2: Archiviazione 
        /// </summary>
        /// <value>Possible values:  0: Nothing  1: Barcode  2: Archiviazione </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

        /// <summary>
        /// Possible values:  0: None  1: OnlyNever  2: OnlyOptionally  3: NeverOrOptionally  4: OnlyAlways  5: AlwaysOrNever  6: AlwaysOrOptionally  7: All 
        /// </summary>
        /// <value>Possible values:  0: None  1: OnlyNever  2: OnlyOptionally  3: NeverOrOptionally  4: OnlyAlways  5: AlwaysOrNever  6: AlwaysOrOptionally  7: All </value>
        [DataMember(Name="paMode", EmitDefaultValue=false)]
        public int? PaMode { get; set; }

        /// <summary>
        /// Show Additional
        /// </summary>
        /// <value>Show Additional</value>
        [DataMember(Name="showAdditional", EmitDefaultValue=false)]
        public bool? ShowAdditional { get; set; }

        /// <summary>
        /// Possible values:  0: UserMask  1: SystemMask 
        /// </summary>
        /// <value>Possible values:  0: UserMask  1: SystemMask </value>
        [DataMember(Name="kind", EmitDefaultValue=false)]
        public int? Kind { get; set; }

        /// <summary>
        /// Show Groups
        /// </summary>
        /// <value>Show Groups</value>
        [DataMember(Name="showGroups", EmitDefaultValue=false)]
        public bool? ShowGroups { get; set; }

        /// <summary>
        /// Author Complete Name
        /// </summary>
        /// <value>Author Complete Name</value>
        [DataMember(Name="userCompleteName", EmitDefaultValue=false)]
        public string UserCompleteName { get; set; }

        /// <summary>
        /// Predefined Profile associated with the mask
        /// </summary>
        /// <value>Predefined Profile associated with the mask</value>
        [DataMember(Name="predefinedProfile", EmitDefaultValue=false)]
        public PredefinedProfileDTO PredefinedProfile { get; set; }

        /// <summary>
        /// Details
        /// </summary>
        /// <value>Details</value>
        [DataMember(Name="maskDetails", EmitDefaultValue=false)]
        public List<MaskDetailDTO> MaskDetails { get; set; }

        /// <summary>
        /// Options on document type
        /// </summary>
        /// <value>Options on document type</value>
        [DataMember(Name="maskClassOptions", EmitDefaultValue=false)]
        public List<MaskClassOptionsDTO> MaskClassOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MaskDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MaskName: ").Append(MaskName).Append("\n");
            sb.Append("  MaskDescription: ").Append(MaskDescription).Append("\n");
            sb.Append("  PredefinedProfileId: ").Append(PredefinedProfileId).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  IsRoot: ").Append(IsRoot).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  PaMode: ").Append(PaMode).Append("\n");
            sb.Append("  ShowAdditional: ").Append(ShowAdditional).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  ShowGroups: ").Append(ShowGroups).Append("\n");
            sb.Append("  UserCompleteName: ").Append(UserCompleteName).Append("\n");
            sb.Append("  PredefinedProfile: ").Append(PredefinedProfile).Append("\n");
            sb.Append("  MaskDetails: ").Append(MaskDetails).Append("\n");
            sb.Append("  MaskClassOptions: ").Append(MaskClassOptions).Append("\n");
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
            return this.Equals(input as MaskDTO);
        }

        /// <summary>
        /// Returns true if MaskDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MaskDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MaskDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MaskName == input.MaskName ||
                    (this.MaskName != null &&
                    this.MaskName.Equals(input.MaskName))
                ) && 
                (
                    this.MaskDescription == input.MaskDescription ||
                    (this.MaskDescription != null &&
                    this.MaskDescription.Equals(input.MaskDescription))
                ) && 
                (
                    this.PredefinedProfileId == input.PredefinedProfileId ||
                    (this.PredefinedProfileId != null &&
                    this.PredefinedProfileId.Equals(input.PredefinedProfileId))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.IsRoot == input.IsRoot ||
                    (this.IsRoot != null &&
                    this.IsRoot.Equals(input.IsRoot))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.PaMode == input.PaMode ||
                    (this.PaMode != null &&
                    this.PaMode.Equals(input.PaMode))
                ) && 
                (
                    this.ShowAdditional == input.ShowAdditional ||
                    (this.ShowAdditional != null &&
                    this.ShowAdditional.Equals(input.ShowAdditional))
                ) && 
                (
                    this.Kind == input.Kind ||
                    (this.Kind != null &&
                    this.Kind.Equals(input.Kind))
                ) && 
                (
                    this.ShowGroups == input.ShowGroups ||
                    (this.ShowGroups != null &&
                    this.ShowGroups.Equals(input.ShowGroups))
                ) && 
                (
                    this.UserCompleteName == input.UserCompleteName ||
                    (this.UserCompleteName != null &&
                    this.UserCompleteName.Equals(input.UserCompleteName))
                ) && 
                (
                    this.PredefinedProfile == input.PredefinedProfile ||
                    (this.PredefinedProfile != null &&
                    this.PredefinedProfile.Equals(input.PredefinedProfile))
                ) && 
                (
                    this.MaskDetails == input.MaskDetails ||
                    this.MaskDetails != null &&
                    this.MaskDetails.SequenceEqual(input.MaskDetails)
                ) && 
                (
                    this.MaskClassOptions == input.MaskClassOptions ||
                    this.MaskClassOptions != null &&
                    this.MaskClassOptions.SequenceEqual(input.MaskClassOptions)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MaskName != null)
                    hashCode = hashCode * 59 + this.MaskName.GetHashCode();
                if (this.MaskDescription != null)
                    hashCode = hashCode * 59 + this.MaskDescription.GetHashCode();
                if (this.PredefinedProfileId != null)
                    hashCode = hashCode * 59 + this.PredefinedProfileId.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.IsRoot != null)
                    hashCode = hashCode * 59 + this.IsRoot.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.PaMode != null)
                    hashCode = hashCode * 59 + this.PaMode.GetHashCode();
                if (this.ShowAdditional != null)
                    hashCode = hashCode * 59 + this.ShowAdditional.GetHashCode();
                if (this.Kind != null)
                    hashCode = hashCode * 59 + this.Kind.GetHashCode();
                if (this.ShowGroups != null)
                    hashCode = hashCode * 59 + this.ShowGroups.GetHashCode();
                if (this.UserCompleteName != null)
                    hashCode = hashCode * 59 + this.UserCompleteName.GetHashCode();
                if (this.PredefinedProfile != null)
                    hashCode = hashCode * 59 + this.PredefinedProfile.GetHashCode();
                if (this.MaskDetails != null)
                    hashCode = hashCode * 59 + this.MaskDetails.GetHashCode();
                if (this.MaskClassOptions != null)
                    hashCode = hashCode * 59 + this.MaskClassOptions.GetHashCode();
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
