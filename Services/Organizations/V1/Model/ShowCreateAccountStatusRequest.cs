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
    /// Request Object
    /// </summary>
    public class ShowCreateAccountStatusRequest 
    {

        /// <summary>
        /// 指定唯一标识CreateAccount请求的ID值。
        /// </summary>
        [SDKProperty("create_account_status_id", IsPath = true)]
        [JsonProperty("create_account_status_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateAccountStatusId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCreateAccountStatusRequest {\n");
            sb.Append("  createAccountStatusId: ").Append(CreateAccountStatusId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCreateAccountStatusRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCreateAccountStatusRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreateAccountStatusId == input.CreateAccountStatusId ||
                    (this.CreateAccountStatusId != null &&
                    this.CreateAccountStatusId.Equals(input.CreateAccountStatusId))
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
                if (this.CreateAccountStatusId != null)
                    hashCode = hashCode * 59 + this.CreateAccountStatusId.GetHashCode();
                return hashCode;
            }
        }
    }
}
