using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CheckEnterpriseIdResponse : SdkResponse
    {

        /// <summary>
        /// 企业ID是否已被使用。
        /// </summary>
        [JsonProperty("is_used", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsUsed { get; set; }

        /// <summary>
        /// 企业ID。
        /// </summary>
        [JsonProperty("enterprise_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckEnterpriseIdResponse {\n");
            sb.Append("  isUsed: ").Append(IsUsed).Append("\n");
            sb.Append("  enterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckEnterpriseIdResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckEnterpriseIdResponse input)
        {
            if (input == null) return false;
            if (this.IsUsed != input.IsUsed || (this.IsUsed != null && !this.IsUsed.Equals(input.IsUsed))) return false;
            if (this.EnterpriseId != input.EnterpriseId || (this.EnterpriseId != null && !this.EnterpriseId.Equals(input.EnterpriseId))) return false;

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
                if (this.IsUsed != null) hashCode = hashCode * 59 + this.IsUsed.GetHashCode();
                if (this.EnterpriseId != null) hashCode = hashCode * 59 + this.EnterpriseId.GetHashCode();
                return hashCode;
            }
        }
    }
}
