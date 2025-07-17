using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowSpResResponse : SdkResponse
    {

        /// <summary>
        /// SP下所有企业已使用的会议并发数量。
        /// </summary>
        [JsonProperty("usedAccountsCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsedAccountsCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSpResResponse {\n");
            sb.Append("  usedAccountsCount: ").Append(UsedAccountsCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSpResResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSpResResponse input)
        {
            if (input == null) return false;
            if (this.UsedAccountsCount != input.UsedAccountsCount || (this.UsedAccountsCount != null && !this.UsedAccountsCount.Equals(input.UsedAccountsCount))) return false;

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
                if (this.UsedAccountsCount != null) hashCode = hashCode * 59 + this.UsedAccountsCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
