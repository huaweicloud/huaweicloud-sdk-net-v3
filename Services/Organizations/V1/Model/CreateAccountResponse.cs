using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Organizations.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateAccountResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("create_account_status", NullValueHandling = NullValueHandling.Ignore)]
        public CreateAccountStatusDto CreateAccountStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAccountResponse {\n");
            sb.Append("  createAccountStatus: ").Append(CreateAccountStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAccountResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAccountResponse input)
        {
            if (input == null) return false;
            if (this.CreateAccountStatus != input.CreateAccountStatus || (this.CreateAccountStatus != null && !this.CreateAccountStatus.Equals(input.CreateAccountStatus))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.CreateAccountStatus != null) hashCode = hashCode * 59 + this.CreateAccountStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
