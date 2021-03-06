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
    /// \&quot;GTC\&quot; for Good Till Cancel, \&quot;IOC\&quot; for Immediate or Cancel, \&quot;FOK\&quot; for Fill or Kill, \&quot;GTD\&quot; Good Till Date
    /// </summary>
    /// <value>\&quot;GTC\&quot; for Good Till Cancel, \&quot;IOC\&quot; for Immediate or Cancel, \&quot;FOK\&quot; for Fill or Kill, \&quot;GTD\&quot; Good Till Date</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TimeInForce
    {
        /// <summary>
        /// Enum GTC for value: GTC
        /// </summary>
        [EnumMember(Value = "GTC")]
        GTC = 1,

        /// <summary>
        /// Enum IOC for value: IOC
        /// </summary>
        [EnumMember(Value = "IOC")]
        IOC = 2,

        /// <summary>
        /// Enum FOK for value: FOK
        /// </summary>
        [EnumMember(Value = "FOK")]
        FOK = 3,

        /// <summary>
        /// Enum GTD for value: GTD
        /// </summary>
        [EnumMember(Value = "GTD")]
        GTD = 4

    }

}
