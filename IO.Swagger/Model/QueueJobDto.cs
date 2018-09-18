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
    /// Class of queue job information
    /// </summary>
    [DataContract]
    public partial class QueueJobDto :  IEquatable<QueueJobDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueJobDto" /> class.
        /// </summary>
        /// <param name="JobName">Name.</param>
        /// <param name="JobId">Identifier.</param>
        /// <param name="QueueType">Type.</param>
        /// <param name="MethodName">Name of method.</param>
        public QueueJobDto(string JobName = default(string), string JobId = default(string), string QueueType = default(string), string MethodName = default(string))
        {
            this.JobName = JobName;
            this.JobId = JobId;
            this.QueueType = QueueType;
            this.MethodName = MethodName;
        }
        
        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="jobName", EmitDefaultValue=false)]
        public string JobName { get; set; }

        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="jobId", EmitDefaultValue=false)]
        public string JobId { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        /// <value>Type</value>
        [DataMember(Name="queueType", EmitDefaultValue=false)]
        public string QueueType { get; set; }

        /// <summary>
        /// Name of method
        /// </summary>
        /// <value>Name of method</value>
        [DataMember(Name="methodName", EmitDefaultValue=false)]
        public string MethodName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueJobDto {\n");
            sb.Append("  JobName: ").Append(JobName).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  QueueType: ").Append(QueueType).Append("\n");
            sb.Append("  MethodName: ").Append(MethodName).Append("\n");
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
            return this.Equals(input as QueueJobDto);
        }

        /// <summary>
        /// Returns true if QueueJobDto instances are equal
        /// </summary>
        /// <param name="input">Instance of QueueJobDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueJobDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobName == input.JobName ||
                    (this.JobName != null &&
                    this.JobName.Equals(input.JobName))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.QueueType == input.QueueType ||
                    (this.QueueType != null &&
                    this.QueueType.Equals(input.QueueType))
                ) && 
                (
                    this.MethodName == input.MethodName ||
                    (this.MethodName != null &&
                    this.MethodName.Equals(input.MethodName))
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
                if (this.JobName != null)
                    hashCode = hashCode * 59 + this.JobName.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.QueueType != null)
                    hashCode = hashCode * 59 + this.QueueType.GetHashCode();
                if (this.MethodName != null)
                    hashCode = hashCode * 59 + this.MethodName.GetHashCode();
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
