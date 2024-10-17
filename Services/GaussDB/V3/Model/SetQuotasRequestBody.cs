using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SetQuotasRequestBody 
    {

        /// <summary>
        /// 资源列表对象。
        /// </summary>
        [JsonProperty("quota_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<SetQuota> QuotaList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetQuotasRequestBody {\n");
            sb.Append("  quotaList: ").Append(QuotaList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetQuotasRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetQuotasRequestBody input)
        {
            if (input == null) return false;
            if (this.QuotaList != input.QuotaList || (this.QuotaList != null && input.QuotaList != null && !this.QuotaList.SequenceEqual(input.QuotaList))) return false;

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
                if (this.QuotaList != null) hashCode = hashCode * 59 + this.QuotaList.GetHashCode();
                return hashCode;
            }
        }
    }
}
