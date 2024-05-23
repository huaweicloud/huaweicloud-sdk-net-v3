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
    public class ShowCreateAccountStatusResponse : SdkResponse
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
            sb.Append("class ShowCreateAccountStatusResponse {\n");
            sb.Append("  createAccountStatus: ").Append(CreateAccountStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCreateAccountStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCreateAccountStatusResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreateAccountStatus == input.CreateAccountStatus ||
                    (this.CreateAccountStatus != null &&
                    this.CreateAccountStatus.Equals(input.CreateAccountStatus))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CreateAccountStatus != null)
                    hashCode = hashCode * 59 + this.CreateAccountStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
