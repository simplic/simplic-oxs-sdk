/*
 * Simplic.OxS.ERP
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

namespace Simplic.OxS.SDK.ERP
{
    /// <summary>
    /// Represents the shared model for a transaction item type.
    /// </summary>
    [DataContract(Name = "TransactionItemTypeModel")]
    public partial class TransactionItemTypeModel : IEquatable<TransactionItemTypeModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionItemTypeModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="organizationId">organizationId.</param>
        /// <param name="isDeleted">isDeleted.</param>
        /// <param name="name">Gets or sets the name..</param>
        /// <param name="number">Gets or sets the number..</param>
        /// <param name="hasPositionNumber">Gets or sets the has position number flag..</param>
        /// <param name="isSelectable">Gets or sets the is selectable flag..</param>
        /// <param name="detailHtml">Gets or sets the detail HTML..</param>
        /// <param name="dataTemplate">Gets or sets the data template..</param>
        /// <param name="articleGLAResolver">Gets or sets the article GLA resolver..</param>
        /// <param name="createDateTime">Gets or sets the date and time the transaction item type is created..</param>
        /// <param name="createUserId">Gets or sets the id of the user that created the transaction item type..</param>
        /// <param name="createUserName">Gets or sets the name of the user that created the transaction item type..</param>
        /// <param name="updateDateTime">Gets or sets the date and time the transaction item type is updated..</param>
        /// <param name="updateUserId">Gets or sets the id of the user that updated the transaction item type..</param>
        /// <param name="updateUserName">Gets or sets the name of the user that updated the transaction item type..</param>
        public TransactionItemTypeModel(Guid id = default(Guid), Guid organizationId = default(Guid), bool isDeleted = default(bool), string name = default(string), int number = default(int), bool hasPositionNumber = default(bool), bool isSelectable = default(bool), string detailHtml = default(string), string dataTemplate = default(string), string articleGLAResolver = default(string), DateTime createDateTime = default(DateTime), Guid? createUserId = default(Guid?), string createUserName = default(string), DateTime updateDateTime = default(DateTime), Guid? updateUserId = default(Guid?), string updateUserName = default(string))
        {
            this.Id = id;
            this.OrganizationId = organizationId;
            this.IsDeleted = isDeleted;
            this.Name = name;
            this.Number = number;
            this.HasPositionNumber = hasPositionNumber;
            this.IsSelectable = isSelectable;
            this.DetailHtml = detailHtml;
            this.DataTemplate = dataTemplate;
            this.ArticleGLAResolver = articleGLAResolver;
            this.CreateDateTime = createDateTime;
            this.CreateUserId = createUserId;
            this.CreateUserName = createUserName;
            this.UpdateDateTime = updateDateTime;
            this.UpdateUserId = updateUserId;
            this.UpdateUserName = updateUserName;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name = "organizationId", EmitDefaultValue = false)]
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        [DataMember(Name = "isDeleted", EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>Gets or sets the name.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>Gets or sets the number.</value>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public int Number { get; set; }

        /// <summary>
        /// Gets or sets the has position number flag.
        /// </summary>
        /// <value>Gets or sets the has position number flag.</value>
        [DataMember(Name = "hasPositionNumber", EmitDefaultValue = true)]
        public bool HasPositionNumber { get; set; }

        /// <summary>
        /// Gets or sets the is selectable flag.
        /// </summary>
        /// <value>Gets or sets the is selectable flag.</value>
        [DataMember(Name = "isSelectable", EmitDefaultValue = true)]
        public bool IsSelectable { get; set; }

        /// <summary>
        /// Gets or sets the detail HTML.
        /// </summary>
        /// <value>Gets or sets the detail HTML.</value>
        [DataMember(Name = "detailHtml", EmitDefaultValue = true)]
        public string DetailHtml { get; set; }

        /// <summary>
        /// Gets or sets the data template.
        /// </summary>
        /// <value>Gets or sets the data template.</value>
        [DataMember(Name = "dataTemplate", EmitDefaultValue = true)]
        public string DataTemplate { get; set; }

        /// <summary>
        /// Gets or sets the article GLA resolver.
        /// </summary>
        /// <value>Gets or sets the article GLA resolver.</value>
        [DataMember(Name = "articleGLAResolver", EmitDefaultValue = true)]
        public string ArticleGLAResolver { get; set; }

        /// <summary>
        /// Gets or sets the date and time the transaction item type is created.
        /// </summary>
        /// <value>Gets or sets the date and time the transaction item type is created.</value>
        [DataMember(Name = "createDateTime", EmitDefaultValue = false)]
        public DateTime CreateDateTime { get; set; }

        /// <summary>
        /// Gets or sets the id of the user that created the transaction item type.
        /// </summary>
        /// <value>Gets or sets the id of the user that created the transaction item type.</value>
        [DataMember(Name = "createUserId", EmitDefaultValue = true)]
        public Guid? CreateUserId { get; set; }

        /// <summary>
        /// Gets or sets the name of the user that created the transaction item type.
        /// </summary>
        /// <value>Gets or sets the name of the user that created the transaction item type.</value>
        [DataMember(Name = "createUserName", EmitDefaultValue = true)]
        public string CreateUserName { get; set; }

        /// <summary>
        /// Gets or sets the date and time the transaction item type is updated.
        /// </summary>
        /// <value>Gets or sets the date and time the transaction item type is updated.</value>
        [DataMember(Name = "updateDateTime", EmitDefaultValue = false)]
        public DateTime UpdateDateTime { get; set; }

        /// <summary>
        /// Gets or sets the id of the user that updated the transaction item type.
        /// </summary>
        /// <value>Gets or sets the id of the user that updated the transaction item type.</value>
        [DataMember(Name = "updateUserId", EmitDefaultValue = true)]
        public Guid? UpdateUserId { get; set; }

        /// <summary>
        /// Gets or sets the name of the user that updated the transaction item type.
        /// </summary>
        /// <value>Gets or sets the name of the user that updated the transaction item type.</value>
        [DataMember(Name = "updateUserName", EmitDefaultValue = true)]
        public string UpdateUserName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionItemTypeModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  HasPositionNumber: ").Append(HasPositionNumber).Append("\n");
            sb.Append("  IsSelectable: ").Append(IsSelectable).Append("\n");
            sb.Append("  DetailHtml: ").Append(DetailHtml).Append("\n");
            sb.Append("  DataTemplate: ").Append(DataTemplate).Append("\n");
            sb.Append("  ArticleGLAResolver: ").Append(ArticleGLAResolver).Append("\n");
            sb.Append("  CreateDateTime: ").Append(CreateDateTime).Append("\n");
            sb.Append("  CreateUserId: ").Append(CreateUserId).Append("\n");
            sb.Append("  CreateUserName: ").Append(CreateUserName).Append("\n");
            sb.Append("  UpdateDateTime: ").Append(UpdateDateTime).Append("\n");
            sb.Append("  UpdateUserId: ").Append(UpdateUserId).Append("\n");
            sb.Append("  UpdateUserName: ").Append(UpdateUserName).Append("\n");
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
            return this.Equals(input as TransactionItemTypeModel);
        }

        /// <summary>
        /// Returns true if TransactionItemTypeModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionItemTypeModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionItemTypeModel input)
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
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    this.IsDeleted.Equals(input.IsDeleted)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Number == input.Number ||
                    this.Number.Equals(input.Number)
                ) && 
                (
                    this.HasPositionNumber == input.HasPositionNumber ||
                    this.HasPositionNumber.Equals(input.HasPositionNumber)
                ) && 
                (
                    this.IsSelectable == input.IsSelectable ||
                    this.IsSelectable.Equals(input.IsSelectable)
                ) && 
                (
                    this.DetailHtml == input.DetailHtml ||
                    (this.DetailHtml != null &&
                    this.DetailHtml.Equals(input.DetailHtml))
                ) && 
                (
                    this.DataTemplate == input.DataTemplate ||
                    (this.DataTemplate != null &&
                    this.DataTemplate.Equals(input.DataTemplate))
                ) && 
                (
                    this.ArticleGLAResolver == input.ArticleGLAResolver ||
                    (this.ArticleGLAResolver != null &&
                    this.ArticleGLAResolver.Equals(input.ArticleGLAResolver))
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
                if (this.OrganizationId != null)
                {
                    hashCode = (hashCode * 59) + this.OrganizationId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsDeleted.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Number.GetHashCode();
                hashCode = (hashCode * 59) + this.HasPositionNumber.GetHashCode();
                hashCode = (hashCode * 59) + this.IsSelectable.GetHashCode();
                if (this.DetailHtml != null)
                {
                    hashCode = (hashCode * 59) + this.DetailHtml.GetHashCode();
                }
                if (this.DataTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.DataTemplate.GetHashCode();
                }
                if (this.ArticleGLAResolver != null)
                {
                    hashCode = (hashCode * 59) + this.ArticleGLAResolver.GetHashCode();
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
