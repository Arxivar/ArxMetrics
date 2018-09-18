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
    /// Class of process note
    /// </summary>
    [DataContract]
    public partial class ProcessNoteDTO :  IEquatable<ProcessNoteDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessNoteDTO" /> class.
        /// </summary>
        /// <param name="Date">Creation Date.</param>
        /// <param name="Id">Identifier.</param>
        /// <param name="ProcessId">Process Identifier.</param>
        /// <param name="Note">Text.</param>
        /// <param name="UserCompleteName">User Description.</param>
        /// <param name="User">User Identifier.</param>
        public ProcessNoteDTO(DateTime? Date = default(DateTime?), int? Id = default(int?), int? ProcessId = default(int?), string Note = default(string), string UserCompleteName = default(string), int? User = default(int?))
        {
            this.Date = Date;
            this.Id = Id;
            this.ProcessId = ProcessId;
            this.Note = Note;
            this.UserCompleteName = UserCompleteName;
            this.User = User;
        }
        
        /// <summary>
        /// Creation Date
        /// </summary>
        /// <value>Creation Date</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Process Identifier
        /// </summary>
        /// <value>Process Identifier</value>
        [DataMember(Name="processId", EmitDefaultValue=false)]
        public int? ProcessId { get; set; }

        /// <summary>
        /// Text
        /// </summary>
        /// <value>Text</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// User Description
        /// </summary>
        /// <value>User Description</value>
        [DataMember(Name="userCompleteName", EmitDefaultValue=false)]
        public string UserCompleteName { get; set; }

        /// <summary>
        /// User Identifier
        /// </summary>
        /// <value>User Identifier</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public int? User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessNoteDTO {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProcessId: ").Append(ProcessId).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  UserCompleteName: ").Append(UserCompleteName).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(input as ProcessNoteDTO);
        }

        /// <summary>
        /// Returns true if ProcessNoteDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessNoteDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessNoteDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ProcessId == input.ProcessId ||
                    (this.ProcessId != null &&
                    this.ProcessId.Equals(input.ProcessId))
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.UserCompleteName == input.UserCompleteName ||
                    (this.UserCompleteName != null &&
                    this.UserCompleteName.Equals(input.UserCompleteName))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ProcessId != null)
                    hashCode = hashCode * 59 + this.ProcessId.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.UserCompleteName != null)
                    hashCode = hashCode * 59 + this.UserCompleteName.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
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
