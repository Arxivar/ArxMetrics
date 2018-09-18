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
    /// Class of Timestamp
    /// </summary>
    [DataContract]
    public partial class TimestampInfoDTO :  IEquatable<TimestampInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimestampInfoDTO" /> class.
        /// </summary>
        /// <param name="TimestampTime">Creation Date.</param>
        /// <param name="ValidTo">Validity Date To.</param>
        /// <param name="Serial">Serial Number.</param>
        /// <param name="Hash">Hash.</param>
        /// <param name="HashAlgorithm">Algorithm of Hash.</param>
        /// <param name="Version">Version.</param>
        /// <param name="ArxCertifiedIdentity">Identity of Certificate.</param>
        /// <param name="Depth">Depth.</param>
        /// <param name="IsVerified">Is Verified.</param>
        /// <param name="WarningMessage">Message of Warning.</param>
        public TimestampInfoDTO(DateTime? TimestampTime = default(DateTime?), DateTime? ValidTo = default(DateTime?), string Serial = default(string), string Hash = default(string), string HashAlgorithm = default(string), string Version = default(string), CertifiedIdentityDTO ArxCertifiedIdentity = default(CertifiedIdentityDTO), int? Depth = default(int?), bool? IsVerified = default(bool?), string WarningMessage = default(string))
        {
            this.TimestampTime = TimestampTime;
            this.ValidTo = ValidTo;
            this.Serial = Serial;
            this.Hash = Hash;
            this.HashAlgorithm = HashAlgorithm;
            this.Version = Version;
            this.ArxCertifiedIdentity = ArxCertifiedIdentity;
            this.Depth = Depth;
            this.IsVerified = IsVerified;
            this.WarningMessage = WarningMessage;
        }
        
        /// <summary>
        /// Creation Date
        /// </summary>
        /// <value>Creation Date</value>
        [DataMember(Name="timestampTime", EmitDefaultValue=false)]
        public DateTime? TimestampTime { get; set; }

        /// <summary>
        /// Validity Date To
        /// </summary>
        /// <value>Validity Date To</value>
        [DataMember(Name="validTo", EmitDefaultValue=false)]
        public DateTime? ValidTo { get; set; }

        /// <summary>
        /// Serial Number
        /// </summary>
        /// <value>Serial Number</value>
        [DataMember(Name="serial", EmitDefaultValue=false)]
        public string Serial { get; set; }

        /// <summary>
        /// Hash
        /// </summary>
        /// <value>Hash</value>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public string Hash { get; set; }

        /// <summary>
        /// Algorithm of Hash
        /// </summary>
        /// <value>Algorithm of Hash</value>
        [DataMember(Name="hashAlgorithm", EmitDefaultValue=false)]
        public string HashAlgorithm { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        /// <value>Version</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Identity of Certificate
        /// </summary>
        /// <value>Identity of Certificate</value>
        [DataMember(Name="arxCertifiedIdentity", EmitDefaultValue=false)]
        public CertifiedIdentityDTO ArxCertifiedIdentity { get; set; }

        /// <summary>
        /// Depth
        /// </summary>
        /// <value>Depth</value>
        [DataMember(Name="depth", EmitDefaultValue=false)]
        public int? Depth { get; set; }

        /// <summary>
        /// Is Verified
        /// </summary>
        /// <value>Is Verified</value>
        [DataMember(Name="isVerified", EmitDefaultValue=false)]
        public bool? IsVerified { get; set; }

        /// <summary>
        /// Message of Warning
        /// </summary>
        /// <value>Message of Warning</value>
        [DataMember(Name="warningMessage", EmitDefaultValue=false)]
        public string WarningMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimestampInfoDTO {\n");
            sb.Append("  TimestampTime: ").Append(TimestampTime).Append("\n");
            sb.Append("  ValidTo: ").Append(ValidTo).Append("\n");
            sb.Append("  Serial: ").Append(Serial).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  HashAlgorithm: ").Append(HashAlgorithm).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  ArxCertifiedIdentity: ").Append(ArxCertifiedIdentity).Append("\n");
            sb.Append("  Depth: ").Append(Depth).Append("\n");
            sb.Append("  IsVerified: ").Append(IsVerified).Append("\n");
            sb.Append("  WarningMessage: ").Append(WarningMessage).Append("\n");
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
            return this.Equals(input as TimestampInfoDTO);
        }

        /// <summary>
        /// Returns true if TimestampInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TimestampInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimestampInfoDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TimestampTime == input.TimestampTime ||
                    (this.TimestampTime != null &&
                    this.TimestampTime.Equals(input.TimestampTime))
                ) && 
                (
                    this.ValidTo == input.ValidTo ||
                    (this.ValidTo != null &&
                    this.ValidTo.Equals(input.ValidTo))
                ) && 
                (
                    this.Serial == input.Serial ||
                    (this.Serial != null &&
                    this.Serial.Equals(input.Serial))
                ) && 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && 
                (
                    this.HashAlgorithm == input.HashAlgorithm ||
                    (this.HashAlgorithm != null &&
                    this.HashAlgorithm.Equals(input.HashAlgorithm))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.ArxCertifiedIdentity == input.ArxCertifiedIdentity ||
                    (this.ArxCertifiedIdentity != null &&
                    this.ArxCertifiedIdentity.Equals(input.ArxCertifiedIdentity))
                ) && 
                (
                    this.Depth == input.Depth ||
                    (this.Depth != null &&
                    this.Depth.Equals(input.Depth))
                ) && 
                (
                    this.IsVerified == input.IsVerified ||
                    (this.IsVerified != null &&
                    this.IsVerified.Equals(input.IsVerified))
                ) && 
                (
                    this.WarningMessage == input.WarningMessage ||
                    (this.WarningMessage != null &&
                    this.WarningMessage.Equals(input.WarningMessage))
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
                if (this.TimestampTime != null)
                    hashCode = hashCode * 59 + this.TimestampTime.GetHashCode();
                if (this.ValidTo != null)
                    hashCode = hashCode * 59 + this.ValidTo.GetHashCode();
                if (this.Serial != null)
                    hashCode = hashCode * 59 + this.Serial.GetHashCode();
                if (this.Hash != null)
                    hashCode = hashCode * 59 + this.Hash.GetHashCode();
                if (this.HashAlgorithm != null)
                    hashCode = hashCode * 59 + this.HashAlgorithm.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.ArxCertifiedIdentity != null)
                    hashCode = hashCode * 59 + this.ArxCertifiedIdentity.GetHashCode();
                if (this.Depth != null)
                    hashCode = hashCode * 59 + this.Depth.GetHashCode();
                if (this.IsVerified != null)
                    hashCode = hashCode * 59 + this.IsVerified.GetHashCode();
                if (this.WarningMessage != null)
                    hashCode = hashCode * 59 + this.WarningMessage.GetHashCode();
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
