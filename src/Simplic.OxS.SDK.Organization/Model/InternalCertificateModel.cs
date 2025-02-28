/*
 * Simplic.OxS.Organization
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Simplic.OxS.SDK.OpenAPIDateConverter;

using Simplic.OxS.SDK;

namespace Simplic.OxS.SDK.Organization
{
    /// <summary>
    /// Represents a certificate
    /// </summary>
    [DataContract(Name = "InternalCertificateModel")]
    public partial class InternalCertificateModel : IEquatable<InternalCertificateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalCertificateModel" /> class.
        /// </summary>
        /// <param name="id">Gets or sets the certiciate id.</param>
        /// <param name="certFile">Contains the certificate file.</param>
        /// <param name="issuer">Gets or sets the certificate issuer.</param>
        /// <param name="subject">Gets or sets the certificate subject.</param>
        /// <param name="notBefore">Gets or sets the from valid date.</param>
        /// <param name="notAfter">Gets or sets the to valid date.</param>
        /// <param name="serialNumber">Gets or sets the serial number.</param>
        /// <param name="thumbprint">Gets or sets the thumbprint.</param>
        /// <param name="createDateTime">Gets or sets the create datetime.</param>
        /// <param name="createUserId">Gets or sets the create userid.</param>
        /// <param name="createUserName">Gets or sets the create username.</param>
        /// <param name="updateDateTime">Gets or sets the update datetime.</param>
        /// <param name="updateUserId">Gets or sets the update user-id.</param>
        /// <param name="updateUserName">Gets or sets the update username.</param>
        /// <param name="pfxFile">Gets or sets an optional pfx file.</param>
        /// <param name="pfxPassword">Gets or sets the pfx password.</param>
        public InternalCertificateModel(Guid id = default(Guid), byte[] certFile = default(byte[]), string issuer = default(string), string subject = default(string), DateTime notBefore = default(DateTime), DateTime notAfter = default(DateTime), string serialNumber = default(string), string thumbprint = default(string), DateTime createDateTime = default(DateTime), Guid? createUserId = default(Guid?), string createUserName = default(string), DateTime updateDateTime = default(DateTime), Guid? updateUserId = default(Guid?), string updateUserName = default(string), byte[] pfxFile = default(byte[]), string pfxPassword = default(string))
        {
            this.Id = id;
            this.CertFile = certFile;
            this.Issuer = issuer;
            this.Subject = subject;
            this.NotBefore = notBefore;
            this.NotAfter = notAfter;
            this.SerialNumber = serialNumber;
            this.Thumbprint = thumbprint;
            this.CreateDateTime = createDateTime;
            this.CreateUserId = createUserId;
            this.CreateUserName = createUserName;
            this.UpdateDateTime = updateDateTime;
            this.UpdateUserId = updateUserId;
            this.UpdateUserName = updateUserName;
            this.PfxFile = pfxFile;
            this.PfxPassword = pfxPassword;
        }

        /// <summary>
        /// Gets or sets the certiciate id
        /// </summary>
        /// <value>Gets or sets the certiciate id</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Contains the certificate file
        /// </summary>
        /// <value>Contains the certificate file</value>
        [DataMember(Name = "certFile", EmitDefaultValue = true)]
        public byte[] CertFile { get; set; }

        /// <summary>
        /// Gets or sets the certificate issuer
        /// </summary>
        /// <value>Gets or sets the certificate issuer</value>
        [DataMember(Name = "issuer", EmitDefaultValue = true)]
        public string Issuer { get; set; }

        /// <summary>
        /// Gets or sets the certificate subject
        /// </summary>
        /// <value>Gets or sets the certificate subject</value>
        [DataMember(Name = "subject", EmitDefaultValue = true)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the from valid date
        /// </summary>
        /// <value>Gets or sets the from valid date</value>
        [DataMember(Name = "notBefore", EmitDefaultValue = false)]
        public DateTime NotBefore { get; set; }

        /// <summary>
        /// Gets or sets the to valid date
        /// </summary>
        /// <value>Gets or sets the to valid date</value>
        [DataMember(Name = "notAfter", EmitDefaultValue = false)]
        public DateTime NotAfter { get; set; }

        /// <summary>
        /// Gets or sets the serial number
        /// </summary>
        /// <value>Gets or sets the serial number</value>
        [DataMember(Name = "serialNumber", EmitDefaultValue = true)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or sets the thumbprint
        /// </summary>
        /// <value>Gets or sets the thumbprint</value>
        [DataMember(Name = "thumbprint", EmitDefaultValue = true)]
        public string Thumbprint { get; set; }

        /// <summary>
        /// Gets or sets the create datetime
        /// </summary>
        /// <value>Gets or sets the create datetime</value>
        [DataMember(Name = "createDateTime", EmitDefaultValue = false)]
        public DateTime CreateDateTime { get; set; }

        /// <summary>
        /// Gets or sets the create userid
        /// </summary>
        /// <value>Gets or sets the create userid</value>
        [DataMember(Name = "createUserId", EmitDefaultValue = true)]
        public Guid? CreateUserId { get; set; }

        /// <summary>
        /// Gets or sets the create username
        /// </summary>
        /// <value>Gets or sets the create username</value>
        [DataMember(Name = "createUserName", EmitDefaultValue = true)]
        public string CreateUserName { get; set; }

        /// <summary>
        /// Gets or sets the update datetime
        /// </summary>
        /// <value>Gets or sets the update datetime</value>
        [DataMember(Name = "updateDateTime", EmitDefaultValue = false)]
        public DateTime UpdateDateTime { get; set; }

        /// <summary>
        /// Gets or sets the update user-id
        /// </summary>
        /// <value>Gets or sets the update user-id</value>
        [DataMember(Name = "updateUserId", EmitDefaultValue = true)]
        public Guid? UpdateUserId { get; set; }

        /// <summary>
        /// Gets or sets the update username
        /// </summary>
        /// <value>Gets or sets the update username</value>
        [DataMember(Name = "updateUserName", EmitDefaultValue = true)]
        public string UpdateUserName { get; set; }

        /// <summary>
        /// Gets or sets an optional pfx file
        /// </summary>
        /// <value>Gets or sets an optional pfx file</value>
        [DataMember(Name = "pfxFile", EmitDefaultValue = true)]
        public byte[] PfxFile { get; set; }

        /// <summary>
        /// Gets or sets the pfx password
        /// </summary>
        /// <value>Gets or sets the pfx password</value>
        [DataMember(Name = "pfxPassword", EmitDefaultValue = true)]
        public string PfxPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InternalCertificateModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CertFile: ").Append(CertFile).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  NotBefore: ").Append(NotBefore).Append("\n");
            sb.Append("  NotAfter: ").Append(NotAfter).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  Thumbprint: ").Append(Thumbprint).Append("\n");
            sb.Append("  CreateDateTime: ").Append(CreateDateTime).Append("\n");
            sb.Append("  CreateUserId: ").Append(CreateUserId).Append("\n");
            sb.Append("  CreateUserName: ").Append(CreateUserName).Append("\n");
            sb.Append("  UpdateDateTime: ").Append(UpdateDateTime).Append("\n");
            sb.Append("  UpdateUserId: ").Append(UpdateUserId).Append("\n");
            sb.Append("  UpdateUserName: ").Append(UpdateUserName).Append("\n");
            sb.Append("  PfxFile: ").Append(PfxFile).Append("\n");
            sb.Append("  PfxPassword: ").Append(PfxPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InternalCertificateModel);
        }

        /// <summary>
        /// Returns true if InternalCertificateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of InternalCertificateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InternalCertificateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CertFile == input.CertFile ||
                    (this.CertFile != null &&
                    this.CertFile.Equals(input.CertFile))
                ) && 
                (
                    this.Issuer == input.Issuer ||
                    (this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.NotBefore == input.NotBefore ||
                    (this.NotBefore != null &&
                    this.NotBefore.Equals(input.NotBefore))
                ) && 
                (
                    this.NotAfter == input.NotAfter ||
                    (this.NotAfter != null &&
                    this.NotAfter.Equals(input.NotAfter))
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.Thumbprint == input.Thumbprint ||
                    (this.Thumbprint != null &&
                    this.Thumbprint.Equals(input.Thumbprint))
                ) && 
                (
                    this.CreateDateTime == input.CreateDateTime ||
                    (this.CreateDateTime != null &&
                    this.CreateDateTime.Equals(input.CreateDateTime))
                ) && 
                (
                    this.CreateUserId == input.CreateUserId ||
                    (this.CreateUserId != null &&
                    this.CreateUserId.Equals(input.CreateUserId))
                ) && 
                (
                    this.CreateUserName == input.CreateUserName ||
                    (this.CreateUserName != null &&
                    this.CreateUserName.Equals(input.CreateUserName))
                ) && 
                (
                    this.UpdateDateTime == input.UpdateDateTime ||
                    (this.UpdateDateTime != null &&
                    this.UpdateDateTime.Equals(input.UpdateDateTime))
                ) && 
                (
                    this.UpdateUserId == input.UpdateUserId ||
                    (this.UpdateUserId != null &&
                    this.UpdateUserId.Equals(input.UpdateUserId))
                ) && 
                (
                    this.UpdateUserName == input.UpdateUserName ||
                    (this.UpdateUserName != null &&
                    this.UpdateUserName.Equals(input.UpdateUserName))
                ) && 
                (
                    this.PfxFile == input.PfxFile ||
                    (this.PfxFile != null &&
                    this.PfxFile.Equals(input.PfxFile))
                ) && 
                (
                    this.PfxPassword == input.PfxPassword ||
                    (this.PfxPassword != null &&
                    this.PfxPassword.Equals(input.PfxPassword))
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
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.CertFile != null)
                {
                    hashCode = (hashCode * 59) + this.CertFile.GetHashCode();
                }
                if (this.Issuer != null)
                {
                    hashCode = (hashCode * 59) + this.Issuer.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                if (this.NotBefore != null)
                {
                    hashCode = (hashCode * 59) + this.NotBefore.GetHashCode();
                }
                if (this.NotAfter != null)
                {
                    hashCode = (hashCode * 59) + this.NotAfter.GetHashCode();
                }
                if (this.SerialNumber != null)
                {
                    hashCode = (hashCode * 59) + this.SerialNumber.GetHashCode();
                }
                if (this.Thumbprint != null)
                {
                    hashCode = (hashCode * 59) + this.Thumbprint.GetHashCode();
                }
                if (this.CreateDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.CreateDateTime.GetHashCode();
                }
                if (this.CreateUserId != null)
                {
                    hashCode = (hashCode * 59) + this.CreateUserId.GetHashCode();
                }
                if (this.CreateUserName != null)
                {
                    hashCode = (hashCode * 59) + this.CreateUserName.GetHashCode();
                }
                if (this.UpdateDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.UpdateDateTime.GetHashCode();
                }
                if (this.UpdateUserId != null)
                {
                    hashCode = (hashCode * 59) + this.UpdateUserId.GetHashCode();
                }
                if (this.UpdateUserName != null)
                {
                    hashCode = (hashCode * 59) + this.UpdateUserName.GetHashCode();
                }
                if (this.PfxFile != null)
                {
                    hashCode = (hashCode * 59) + this.PfxFile.GetHashCode();
                }
                if (this.PfxPassword != null)
                {
                    hashCode = (hashCode * 59) + this.PfxPassword.GetHashCode();
                }
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
