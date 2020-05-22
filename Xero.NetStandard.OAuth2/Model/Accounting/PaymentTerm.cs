/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.1.2
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

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// PaymentTerm
    /// </summary>
    [DataContract]
    public partial class PaymentTerm :  IEquatable<PaymentTerm>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets Bills
        /// </summary>
        [DataMember(Name="Bills", EmitDefaultValue=false)]
        public Bill Bills { get; set; }

        /// <summary>
        /// Gets or Sets Sales
        /// </summary>
        [DataMember(Name="Sales", EmitDefaultValue=false)]
        public Bill Sales { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentTerm {\n");
            sb.Append("  Bills: ").Append(Bills).Append("\n");
            sb.Append("  Sales: ").Append(Sales).Append("\n");
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
            return this.Equals(input as PaymentTerm);
        }

        /// <summary>
        /// Returns true if PaymentTerm instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentTerm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentTerm input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bills == input.Bills ||
                    (this.Bills != null &&
                    this.Bills.Equals(input.Bills))
                ) && 
                (
                    this.Sales == input.Sales ||
                    (this.Sales != null &&
                    this.Sales.Equals(input.Sales))
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
                if (this.Bills != null)
                    hashCode = hashCode * 59 + this.Bills.GetHashCode();
                if (this.Sales != null)
                    hashCode = hashCode * 59 + this.Sales.GetHashCode();
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