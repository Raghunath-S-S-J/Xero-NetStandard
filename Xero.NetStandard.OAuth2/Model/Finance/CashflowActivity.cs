/* 
 * Xero Finance API
 *
 * The Finance API is a collection of endpoints which customers can use in the course of a loan application, which may assist lenders to gain the confidence they need to provide capital.
 *
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.Finance
{
    /// <summary>
    /// CashflowActivity
    /// </summary>
    [DataContract]
    public partial class CashflowActivity :  IEquatable<CashflowActivity>, IValidatableObject
    {
        
        /// <summary>
        /// Name of the cashflow activity type. It will be either Operating Activities, Investing Activities or Financing Activities
        /// </summary>
        /// <value>Name of the cashflow activity type. It will be either Operating Activities, Investing Activities or Financing Activities</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Total value of the activity type
        /// </summary>
        /// <value>Total value of the activity type</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public decimal? Total { get; set; }

        /// <summary>
        /// Gets or Sets CashflowTypes
        /// </summary>
        [DataMember(Name="cashflowTypes", EmitDefaultValue=false)]
        public List<CashflowType> CashflowTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CashflowActivity {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  CashflowTypes: ").Append(CashflowTypes).Append("\n");
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
            return this.Equals(input as CashflowActivity);
        }

        /// <summary>
        /// Returns true if CashflowActivity instances are equal
        /// </summary>
        /// <param name="input">Instance of CashflowActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CashflowActivity input)
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
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.CashflowTypes == input.CashflowTypes ||
                    this.CashflowTypes != null &&
                    input.CashflowTypes != null &&
                    this.CashflowTypes.SequenceEqual(input.CashflowTypes)
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.CashflowTypes != null)
                    hashCode = hashCode * 59 + this.CashflowTypes.GetHashCode();
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