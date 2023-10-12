/*
 * Simplic.OxS.Contract
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

namespace Simplic.OxS.SDK.Contract
{
    /// <summary>
    /// ContractModel
    /// </summary>
    [DataContract(Name = "ContractModel")]
    public partial class ContractModel : IEquatable<ContractModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets BillingType
        /// </summary>
        [DataMember(Name = "billingType", EmitDefaultValue = false)]
        public BillingTypeModel? BillingType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractModel" /> class.
        /// </summary>
        /// <param name="number">number.</param>
        /// <param name="name">name.</param>
        /// <param name="referenceNumber">referenceNumber.</param>
        /// <param name="orderDate">orderDate.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="billingType">billingType.</param>
        /// <param name="projectId">projectId.</param>
        /// <param name="termOfPayment">termOfPayment.</param>
        /// <param name="submissionDate">submissionDate.</param>
        /// <param name="insurance">insurance.</param>
        /// <param name="creditworthiness">creditworthiness.</param>
        /// <param name="creditLimit">creditLimit.</param>
        /// <param name="id">id.</param>
        /// <param name="organizationId">organizationId.</param>
        /// <param name="status">status.</param>
        /// <param name="businessPartner">businessPartner.</param>
        /// <param name="customer">customer.</param>
        /// <param name="representativeUser">representativeUser.</param>
        /// <param name="contactPerson">contactPerson.</param>
        /// <param name="items">items.</param>
        /// <param name="createDateTime">createDateTime.</param>
        /// <param name="createUserId">createUserId.</param>
        /// <param name="createUserName">createUserName.</param>
        /// <param name="updateDateTime">updateDateTime.</param>
        /// <param name="updateUserId">updateUserId.</param>
        /// <param name="updateUserName">updateUserName.</param>
        public ContractModel(string number = default(string), string name = default(string), string referenceNumber = default(string), DateTime? orderDate = default(DateTime?), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), BillingTypeModel? billingType = default(BillingTypeModel?), Guid? projectId = default(Guid?), TermsOfPaymentModel termOfPayment = default(TermsOfPaymentModel), string submissionDate = default(string), double? insurance = default(double?), string creditworthiness = default(string), string creditLimit = default(string), Guid id = default(Guid), Guid organizationId = default(Guid), ContractStatusModel status = default(ContractStatusModel), BillableContactModel businessPartner = default(BillableContactModel), BillableContactModel customer = default(BillableContactModel), UserModel representativeUser = default(UserModel), AddressModel contactPerson = default(AddressModel), List<ContractItemModel> items = default(List<ContractItemModel>), DateTime createDateTime = default(DateTime), Guid? createUserId = default(Guid?), string createUserName = default(string), DateTime updateDateTime = default(DateTime), Guid? updateUserId = default(Guid?), string updateUserName = default(string))
        {
            this.Number = number;
            this.Name = name;
            this.ReferenceNumber = referenceNumber;
            this.OrderDate = orderDate;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.BillingType = billingType;
            this.ProjectId = projectId;
            this.TermOfPayment = termOfPayment;
            this.SubmissionDate = submissionDate;
            this.Insurance = insurance;
            this.Creditworthiness = creditworthiness;
            this.CreditLimit = creditLimit;
            this.Id = id;
            this.OrganizationId = organizationId;
            this.Status = status;
            this.BusinessPartner = businessPartner;
            this.Customer = customer;
            this.RepresentativeUser = representativeUser;
            this.ContactPerson = contactPerson;
            this.Items = items;
            this.CreateDateTime = createDateTime;
            this.CreateUserId = createUserId;
            this.CreateUserName = createUserName;
            this.UpdateDateTime = updateDateTime;
            this.UpdateUserId = updateUserId;
            this.UpdateUserName = updateUserName;
        }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name = "number", EmitDefaultValue = true)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceNumber
        /// </summary>
        [DataMember(Name = "referenceNumber", EmitDefaultValue = true)]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Gets or Sets OrderDate
        /// </summary>
        [DataMember(Name = "orderDate", EmitDefaultValue = true)]
        public DateTime? OrderDate { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "startDate", EmitDefaultValue = true)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "endDate", EmitDefaultValue = true)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        [DataMember(Name = "projectId", EmitDefaultValue = true)]
        public Guid? ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets TermOfPayment
        /// </summary>
        [DataMember(Name = "termOfPayment", EmitDefaultValue = false)]
        public TermsOfPaymentModel TermOfPayment { get; set; }

        /// <summary>
        /// Gets or Sets SubmissionDate
        /// </summary>
        [DataMember(Name = "submissionDate", EmitDefaultValue = true)]
        public string SubmissionDate { get; set; }

        /// <summary>
        /// Gets or Sets Insurance
        /// </summary>
        [DataMember(Name = "insurance", EmitDefaultValue = true)]
        public double? Insurance { get; set; }

        /// <summary>
        /// Gets or Sets Creditworthiness
        /// </summary>
        [DataMember(Name = "creditworthiness", EmitDefaultValue = true)]
        public string Creditworthiness { get; set; }

        /// <summary>
        /// Gets or Sets CreditLimit
        /// </summary>
        [DataMember(Name = "creditLimit", EmitDefaultValue = true)]
        public string CreditLimit { get; set; }

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
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public ContractStatusModel Status { get; set; }

        /// <summary>
        /// Gets or Sets BusinessPartner
        /// </summary>
        [DataMember(Name = "businessPartner", EmitDefaultValue = false)]
        public BillableContactModel BusinessPartner { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = false)]
        public BillableContactModel Customer { get; set; }

        /// <summary>
        /// Gets or Sets RepresentativeUser
        /// </summary>
        [DataMember(Name = "representativeUser", EmitDefaultValue = false)]
        public UserModel RepresentativeUser { get; set; }

        /// <summary>
        /// Gets or Sets ContactPerson
        /// </summary>
        [DataMember(Name = "contactPerson", EmitDefaultValue = false)]
        public AddressModel ContactPerson { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = true)]
        public List<ContractItemModel> Items { get; set; }

        /// <summary>
        /// Gets or Sets CreateDateTime
        /// </summary>
        [DataMember(Name = "createDateTime", EmitDefaultValue = false)]
        public DateTime CreateDateTime { get; set; }

        /// <summary>
        /// Gets or Sets CreateUserId
        /// </summary>
        [DataMember(Name = "createUserId", EmitDefaultValue = true)]
        public Guid? CreateUserId { get; set; }

        /// <summary>
        /// Gets or Sets CreateUserName
        /// </summary>
        [DataMember(Name = "createUserName", EmitDefaultValue = true)]
        public string CreateUserName { get; set; }

        /// <summary>
        /// Gets or Sets UpdateDateTime
        /// </summary>
        [DataMember(Name = "updateDateTime", EmitDefaultValue = false)]
        public DateTime UpdateDateTime { get; set; }

        /// <summary>
        /// Gets or Sets UpdateUserId
        /// </summary>
        [DataMember(Name = "updateUserId", EmitDefaultValue = true)]
        public Guid? UpdateUserId { get; set; }

        /// <summary>
        /// Gets or Sets UpdateUserName
        /// </summary>
        [DataMember(Name = "updateUserName", EmitDefaultValue = true)]
        public string UpdateUserName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContractModel {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  OrderDate: ").Append(OrderDate).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  BillingType: ").Append(BillingType).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  TermOfPayment: ").Append(TermOfPayment).Append("\n");
            sb.Append("  SubmissionDate: ").Append(SubmissionDate).Append("\n");
            sb.Append("  Insurance: ").Append(Insurance).Append("\n");
            sb.Append("  Creditworthiness: ").Append(Creditworthiness).Append("\n");
            sb.Append("  CreditLimit: ").Append(CreditLimit).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  BusinessPartner: ").Append(BusinessPartner).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  RepresentativeUser: ").Append(RepresentativeUser).Append("\n");
            sb.Append("  ContactPerson: ").Append(ContactPerson).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as ContractModel);
        }

        /// <summary>
        /// Returns true if ContractModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ContractModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ReferenceNumber == input.ReferenceNumber ||
                    (this.ReferenceNumber != null &&
                    this.ReferenceNumber.Equals(input.ReferenceNumber))
                ) && 
                (
                    this.OrderDate == input.OrderDate ||
                    (this.OrderDate != null &&
                    this.OrderDate.Equals(input.OrderDate))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.BillingType == input.BillingType ||
                    this.BillingType.Equals(input.BillingType)
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.TermOfPayment == input.TermOfPayment ||
                    (this.TermOfPayment != null &&
                    this.TermOfPayment.Equals(input.TermOfPayment))
                ) && 
                (
                    this.SubmissionDate == input.SubmissionDate ||
                    (this.SubmissionDate != null &&
                    this.SubmissionDate.Equals(input.SubmissionDate))
                ) && 
                (
                    this.Insurance == input.Insurance ||
                    (this.Insurance != null &&
                    this.Insurance.Equals(input.Insurance))
                ) && 
                (
                    this.Creditworthiness == input.Creditworthiness ||
                    (this.Creditworthiness != null &&
                    this.Creditworthiness.Equals(input.Creditworthiness))
                ) && 
                (
                    this.CreditLimit == input.CreditLimit ||
                    (this.CreditLimit != null &&
                    this.CreditLimit.Equals(input.CreditLimit))
                ) && 
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
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.BusinessPartner == input.BusinessPartner ||
                    (this.BusinessPartner != null &&
                    this.BusinessPartner.Equals(input.BusinessPartner))
                ) && 
                (
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
                ) && 
                (
                    this.RepresentativeUser == input.RepresentativeUser ||
                    (this.RepresentativeUser != null &&
                    this.RepresentativeUser.Equals(input.RepresentativeUser))
                ) && 
                (
                    this.ContactPerson == input.ContactPerson ||
                    (this.ContactPerson != null &&
                    this.ContactPerson.Equals(input.ContactPerson))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.ReferenceNumber != null)
                {
                    hashCode = (hashCode * 59) + this.ReferenceNumber.GetHashCode();
                }
                if (this.OrderDate != null)
                {
                    hashCode = (hashCode * 59) + this.OrderDate.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BillingType.GetHashCode();
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                if (this.TermOfPayment != null)
                {
                    hashCode = (hashCode * 59) + this.TermOfPayment.GetHashCode();
                }
                if (this.SubmissionDate != null)
                {
                    hashCode = (hashCode * 59) + this.SubmissionDate.GetHashCode();
                }
                if (this.Insurance != null)
                {
                    hashCode = (hashCode * 59) + this.Insurance.GetHashCode();
                }
                if (this.Creditworthiness != null)
                {
                    hashCode = (hashCode * 59) + this.Creditworthiness.GetHashCode();
                }
                if (this.CreditLimit != null)
                {
                    hashCode = (hashCode * 59) + this.CreditLimit.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.OrganizationId != null)
                {
                    hashCode = (hashCode * 59) + this.OrganizationId.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.BusinessPartner != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessPartner.GetHashCode();
                }
                if (this.Customer != null)
                {
                    hashCode = (hashCode * 59) + this.Customer.GetHashCode();
                }
                if (this.RepresentativeUser != null)
                {
                    hashCode = (hashCode * 59) + this.RepresentativeUser.GetHashCode();
                }
                if (this.ContactPerson != null)
                {
                    hashCode = (hashCode * 59) + this.ContactPerson.GetHashCode();
                }
                if (this.Items != null)
                {
                    hashCode = (hashCode * 59) + this.Items.GetHashCode();
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
