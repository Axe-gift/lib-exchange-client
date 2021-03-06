/* 
 * Blockchain.com Exchange REST API
 *
 * ## Introduction Welcome to Blockchain.com's Exchange API and developer documentation. \\ These documents detail and give examples of various functionality offered by the API such as receiving real time market data, requesting balance information and performing trades. ## To Get Started Create or log into your existing Blockchain.com Exchange account \\ Select API from the drop down menu \\ Fill out form and click “Create New API Key Now” \\ Once generated you can view your keys under API Settings. \\ Please be aware that the API key can only be used once it was verified via email.  The API key must be set via the \\ `X-API-Token`\\ header.  The base URL to be used for all calls is \\ `https://api.blockchain.com/v3/exchange`  Autogenerated clients for this API can be found [here](https://github.com/blockchain/lib-exchange-client). 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.com.blockchain.exchange.rest.model
{
    /// <summary>
    /// WithdrawalInfo
    /// </summary>
    [DataContract]
    public partial class WithdrawalInfo :  IEquatable<WithdrawalInfo>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public WithdrawalStatus? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WithdrawalInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WithdrawalInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WithdrawalInfo" /> class.
        /// </summary>
        /// <param name="withdrawalId">Unique ID for this withdrawal.</param>
        /// <param name="amount">The amount to withdraw in the currency specified (required).</param>
        /// <param name="fee">The amount charged in fees for this withdrawal.</param>
        /// <param name="currency">currency (required).</param>
        /// <param name="beneficiary">beneficiary (required).</param>
        /// <param name="state">state.</param>
        /// <param name="timestamp">Time in ms since 01/01/1970 (epoch).</param>
        public WithdrawalInfo(string withdrawalId = default(string), double amount = default(double), double fee = default(double), string currency = default(string), string beneficiary = default(string), WithdrawalStatus? state = default(WithdrawalStatus?), long timestamp = default(long))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for WithdrawalInfo and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new InvalidDataException("currency is a required property for WithdrawalInfo and cannot be null");
            }
            else
            {
                this.Currency = currency;
            }
            
            // to ensure "beneficiary" is required (not null)
            if (beneficiary == null)
            {
                throw new InvalidDataException("beneficiary is a required property for WithdrawalInfo and cannot be null");
            }
            else
            {
                this.Beneficiary = beneficiary;
            }
            
            this.WithdrawalId = withdrawalId;
            this.Fee = fee;
            this.State = state;
            this.Timestamp = timestamp;
        }
        
        /// <summary>
        /// Unique ID for this withdrawal
        /// </summary>
        /// <value>Unique ID for this withdrawal</value>
        [DataMember(Name="withdrawalId", EmitDefaultValue=false)]
        public string WithdrawalId { get; set; }

        /// <summary>
        /// The amount to withdraw in the currency specified
        /// </summary>
        /// <value>The amount to withdraw in the currency specified</value>
        [DataMember(Name="amount", EmitDefaultValue=true)]
        public double Amount { get; set; }

        /// <summary>
        /// The amount charged in fees for this withdrawal
        /// </summary>
        /// <value>The amount charged in fees for this withdrawal</value>
        [DataMember(Name="fee", EmitDefaultValue=false)]
        public double Fee { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=true)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Beneficiary
        /// </summary>
        [DataMember(Name="beneficiary", EmitDefaultValue=true)]
        public string Beneficiary { get; set; }


        /// <summary>
        /// Time in ms since 01/01/1970 (epoch)
        /// </summary>
        /// <value>Time in ms since 01/01/1970 (epoch)</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public long Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WithdrawalInfo {\n");
            sb.Append("  WithdrawalId: ").Append(WithdrawalId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Beneficiary: ").Append(Beneficiary).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as WithdrawalInfo);
        }

        /// <summary>
        /// Returns true if WithdrawalInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of WithdrawalInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WithdrawalInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WithdrawalId == input.WithdrawalId ||
                    (this.WithdrawalId != null &&
                    this.WithdrawalId.Equals(input.WithdrawalId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Beneficiary == input.Beneficiary ||
                    (this.Beneficiary != null &&
                    this.Beneficiary.Equals(input.Beneficiary))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                if (this.WithdrawalId != null)
                    hashCode = hashCode * 59 + this.WithdrawalId.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Fee != null)
                    hashCode = hashCode * 59 + this.Fee.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Beneficiary != null)
                    hashCode = hashCode * 59 + this.Beneficiary.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
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

            
            // Currency (string) pattern
            Regex regexCurrency = new Regex(@"^[A-Z]{3,5}$", RegexOptions.CultureInvariant);
            if (false == regexCurrency.Match(this.Currency).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, must match a pattern of " + regexCurrency, new [] { "Currency" });
            }

            yield break;
        }
    }

}
