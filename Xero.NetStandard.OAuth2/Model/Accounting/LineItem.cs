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
    /// LineItem
    /// </summary>
    [DataContract]
    public partial class LineItem :  IEquatable<LineItem>, IValidatableObject
    {
        
        /// <summary>
        /// LineItem unique ID
        /// </summary>
        /// <value>LineItem unique ID</value>
        [DataMember(Name="LineItemID", EmitDefaultValue=false)]
        public Guid? LineItemID { get; set; }

        /// <summary>
        /// Description needs to be at least 1 char long. A line item with just a description (i.e no unit amount or quantity) can be created by specifying just a &lt;Description&gt; element that contains at least 1 character
        /// </summary>
        /// <value>Description needs to be at least 1 char long. A line item with just a description (i.e no unit amount or quantity) can be created by specifying just a &lt;Description&gt; element that contains at least 1 character</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// LineItem Quantity
        /// </summary>
        /// <value>LineItem Quantity</value>
        [DataMember(Name="Quantity", EmitDefaultValue=false)]
        public float? Quantity { get; set; }

        /// <summary>
        /// LineItem Unit Amount
        /// </summary>
        /// <value>LineItem Unit Amount</value>
        [DataMember(Name="UnitAmount", EmitDefaultValue=false)]
        public float? UnitAmount { get; set; }

        /// <summary>
        /// See Items
        /// </summary>
        /// <value>See Items</value>
        [DataMember(Name="ItemCode", EmitDefaultValue=false)]
        public string ItemCode { get; set; }

        /// <summary>
        /// See Accounts
        /// </summary>
        /// <value>See Accounts</value>
        [DataMember(Name="AccountCode", EmitDefaultValue=false)]
        public string AccountCode { get; set; }

        /// <summary>
        /// The tax type from TaxRates
        /// </summary>
        /// <value>The tax type from TaxRates</value>
        [DataMember(Name="TaxType", EmitDefaultValue=false)]
        public string TaxType { get; set; }

        /// <summary>
        /// The tax amount is auto calculated as a percentage of the line amount (see below) based on the tax rate. This value can be overriden if the calculated &lt;TaxAmount&gt; is not correct.
        /// </summary>
        /// <value>The tax amount is auto calculated as a percentage of the line amount (see below) based on the tax rate. This value can be overriden if the calculated &lt;TaxAmount&gt; is not correct.</value>
        [DataMember(Name="TaxAmount", EmitDefaultValue=false)]
        public double? TaxAmount { get; set; }

        /// <summary>
        /// If you wish to omit either of the &lt;Quantity&gt; or &lt;UnitAmount&gt; you can provide a LineAmount and Xero will calculate the missing amount for you. The line amount reflects the discounted price if a DiscountRate has been used . i.e LineAmount &#x3D; Quantity * Unit Amount * ((100 – DiscountRate)/100)
        /// </summary>
        /// <value>If you wish to omit either of the &lt;Quantity&gt; or &lt;UnitAmount&gt; you can provide a LineAmount and Xero will calculate the missing amount for you. The line amount reflects the discounted price if a DiscountRate has been used . i.e LineAmount &#x3D; Quantity * Unit Amount * ((100 – DiscountRate)/100)</value>
        [DataMember(Name="LineAmount", EmitDefaultValue=false)]
        public double? LineAmount { get; set; }

        /// <summary>
        /// Optional Tracking Category – see Tracking.  Any LineItem can have a  maximum of 2 &lt;TrackingCategory&gt; elements.
        /// </summary>
        /// <value>Optional Tracking Category – see Tracking.  Any LineItem can have a  maximum of 2 &lt;TrackingCategory&gt; elements.</value>
        [DataMember(Name="Tracking", EmitDefaultValue=false)]
        public List<LineItemTracking> Tracking { get; set; }

        /// <summary>
        /// Percentage discount being applied to a line item (only supported on  ACCREC invoices – ACC PAY invoices and credit notes in Xero do not support discounts
        /// </summary>
        /// <value>Percentage discount being applied to a line item (only supported on  ACCREC invoices – ACC PAY invoices and credit notes in Xero do not support discounts</value>
        [DataMember(Name="DiscountRate", EmitDefaultValue=false)]
        public double? DiscountRate { get; set; }

        /// <summary>
        /// Discount amount being applied to a line item. Only supported on ACCREC invoices - ACCPAY invoices and credit notes in Xero do not support discounts.
        /// </summary>
        /// <value>Discount amount being applied to a line item. Only supported on ACCREC invoices - ACCPAY invoices and credit notes in Xero do not support discounts.</value>
        [DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
        public double? DiscountAmount { get; set; }

        /// <summary>
        /// The Xero identifier for a Repeating Invoice
        /// </summary>
        /// <value>The Xero identifier for a Repeating Invoice</value>
        [DataMember(Name="RepeatingInvoiceID", EmitDefaultValue=false)]
        public Guid? RepeatingInvoiceID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineItem {\n");
            sb.Append("  LineItemID: ").Append(LineItemID).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  UnitAmount: ").Append(UnitAmount).Append("\n");
            sb.Append("  ItemCode: ").Append(ItemCode).Append("\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  TaxType: ").Append(TaxType).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  LineAmount: ").Append(LineAmount).Append("\n");
            sb.Append("  Tracking: ").Append(Tracking).Append("\n");
            sb.Append("  DiscountRate: ").Append(DiscountRate).Append("\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  RepeatingInvoiceID: ").Append(RepeatingInvoiceID).Append("\n");
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
            return this.Equals(input as LineItem);
        }

        /// <summary>
        /// Returns true if LineItem instances are equal
        /// </summary>
        /// <param name="input">Instance of LineItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LineItemID == input.LineItemID ||
                    (this.LineItemID != null &&
                    this.LineItemID.Equals(input.LineItemID))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.UnitAmount == input.UnitAmount ||
                    this.UnitAmount.Equals(input.UnitAmount)
                ) && 
                (
                    this.ItemCode == input.ItemCode ||
                    (this.ItemCode != null &&
                    this.ItemCode.Equals(input.ItemCode))
                ) && 
                (
                    this.AccountCode == input.AccountCode ||
                    (this.AccountCode != null &&
                    this.AccountCode.Equals(input.AccountCode))
                ) && 
                (
                    this.TaxType == input.TaxType ||
                    (this.TaxType != null &&
                    this.TaxType.Equals(input.TaxType))
                ) && 
                (
                    this.TaxAmount == input.TaxAmount ||
                    this.TaxAmount.Equals(input.TaxAmount)
                ) && 
                (
                    this.LineAmount == input.LineAmount ||
                    this.LineAmount.Equals(input.LineAmount)
                ) && 
                (
                    this.Tracking == input.Tracking ||
                    this.Tracking != null &&
                    input.Tracking != null &&
                    this.Tracking.SequenceEqual(input.Tracking)
                ) && 
                (
                    this.DiscountRate == input.DiscountRate ||
                    this.DiscountRate.Equals(input.DiscountRate)
                ) && 
                (
                    this.DiscountAmount == input.DiscountAmount ||
                    this.DiscountAmount.Equals(input.DiscountAmount)
                ) && 
                (
                    this.RepeatingInvoiceID == input.RepeatingInvoiceID ||
                    (this.RepeatingInvoiceID != null &&
                    this.RepeatingInvoiceID.Equals(input.RepeatingInvoiceID))
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
                if (this.LineItemID != null)
                    hashCode = hashCode * 59 + this.LineItemID.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                hashCode = hashCode * 59 + this.UnitAmount.GetHashCode();
                if (this.ItemCode != null)
                    hashCode = hashCode * 59 + this.ItemCode.GetHashCode();
                if (this.AccountCode != null)
                    hashCode = hashCode * 59 + this.AccountCode.GetHashCode();
                if (this.TaxType != null)
                    hashCode = hashCode * 59 + this.TaxType.GetHashCode();
                hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
                hashCode = hashCode * 59 + this.LineAmount.GetHashCode();
                if (this.Tracking != null)
                    hashCode = hashCode * 59 + this.Tracking.GetHashCode();
                hashCode = hashCode * 59 + this.DiscountRate.GetHashCode();
                hashCode = hashCode * 59 + this.DiscountAmount.GetHashCode();
                if (this.RepeatingInvoiceID != null)
                    hashCode = hashCode * 59 + this.RepeatingInvoiceID.GetHashCode();
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