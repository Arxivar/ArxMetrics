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
    /// Class of attachment revision
    /// </summary>
    [DataContract]
    public partial class AttachmentRevisionDTO :  IEquatable<AttachmentRevisionDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentRevisionDTO" /> class.
        /// </summary>
        /// <param name="Id">Identifier.</param>
        /// <param name="AttachmentId">Identifier of attachment.</param>
        /// <param name="Revision">Revision number.</param>
        /// <param name="User">Identifier of the author.</param>
        /// <param name="UserDescription">Description of the author.</param>
        /// <param name="CreationDate">Creation Date.</param>
        /// <param name="Path">Path to store file.</param>
        /// <param name="FileName">Compressed File Name.</param>
        /// <param name="OriginalFileName">File name.</param>
        /// <param name="Hash">Hash of file.</param>
        public AttachmentRevisionDTO(int? Id = default(int?), int? AttachmentId = default(int?), int? Revision = default(int?), int? User = default(int?), string UserDescription = default(string), DateTime? CreationDate = default(DateTime?), string Path = default(string), string FileName = default(string), string OriginalFileName = default(string), string Hash = default(string))
        {
            this.Id = Id;
            this.AttachmentId = AttachmentId;
            this.Revision = Revision;
            this.User = User;
            this.UserDescription = UserDescription;
            this.CreationDate = CreationDate;
            this.Path = Path;
            this.FileName = FileName;
            this.OriginalFileName = OriginalFileName;
            this.Hash = Hash;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Identifier of attachment
        /// </summary>
        /// <value>Identifier of attachment</value>
        [DataMember(Name="attachmentId", EmitDefaultValue=false)]
        public int? AttachmentId { get; set; }

        /// <summary>
        /// Revision number
        /// </summary>
        /// <value>Revision number</value>
        [DataMember(Name="revision", EmitDefaultValue=false)]
        public int? Revision { get; set; }

        /// <summary>
        /// Identifier of the author
        /// </summary>
        /// <value>Identifier of the author</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public int? User { get; set; }

        /// <summary>
        /// Description of the author
        /// </summary>
        /// <value>Description of the author</value>
        [DataMember(Name="userDescription", EmitDefaultValue=false)]
        public string UserDescription { get; set; }

        /// <summary>
        /// Creation Date
        /// </summary>
        /// <value>Creation Date</value>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Path to store file
        /// </summary>
        /// <value>Path to store file</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Compressed File Name
        /// </summary>
        /// <value>Compressed File Name</value>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// File name
        /// </summary>
        /// <value>File name</value>
        [DataMember(Name="originalFileName", EmitDefaultValue=false)]
        public string OriginalFileName { get; set; }

        /// <summary>
        /// Hash of file
        /// </summary>
        /// <value>Hash of file</value>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public string Hash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentRevisionDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AttachmentId: ").Append(AttachmentId).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  UserDescription: ").Append(UserDescription).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  OriginalFileName: ").Append(OriginalFileName).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
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
            return this.Equals(input as AttachmentRevisionDTO);
        }

        /// <summary>
        /// Returns true if AttachmentRevisionDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AttachmentRevisionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachmentRevisionDTO input)
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
                    this.AttachmentId == input.AttachmentId ||
                    (this.AttachmentId != null &&
                    this.AttachmentId.Equals(input.AttachmentId))
                ) && 
                (
                    this.Revision == input.Revision ||
                    (this.Revision != null &&
                    this.Revision.Equals(input.Revision))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.UserDescription == input.UserDescription ||
                    (this.UserDescription != null &&
                    this.UserDescription.Equals(input.UserDescription))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.OriginalFileName == input.OriginalFileName ||
                    (this.OriginalFileName != null &&
                    this.OriginalFileName.Equals(input.OriginalFileName))
                ) && 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
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
                if (this.AttachmentId != null)
                    hashCode = hashCode * 59 + this.AttachmentId.GetHashCode();
                if (this.Revision != null)
                    hashCode = hashCode * 59 + this.Revision.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.UserDescription != null)
                    hashCode = hashCode * 59 + this.UserDescription.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.OriginalFileName != null)
                    hashCode = hashCode * 59 + this.OriginalFileName.GetHashCode();
                if (this.Hash != null)
                    hashCode = hashCode * 59 + this.Hash.GetHashCode();
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
