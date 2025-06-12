using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 结果
    /// </summary>
    public class ShowUserOverPackageQuotaResult 
    {

        /// <summary>
        /// 套餐超期
        /// </summary>
        [JsonProperty("is_over_quota", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOverQuota { get; set; }

        /// <summary>
        /// 构建套餐
        /// </summary>
        [JsonProperty("build_quota", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildQuota { get; set; }

        /// <summary>
        /// 已使用的套餐用量，套餐为unlimit时无此信息
        /// </summary>
        [JsonProperty("used_quota", NullValueHandling = NullValueHandling.Ignore)]
        public string UsedQuota { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowUserOverPackageQuotaResult {\n");
            sb.Append("  isOverQuota: ").Append(IsOverQuota).Append("\n");
            sb.Append("  buildQuota: ").Append(BuildQuota).Append("\n");
            sb.Append("  usedQuota: ").Append(UsedQuota).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowUserOverPackageQuotaResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowUserOverPackageQuotaResult input)
        {
            if (input == null) return false;
            if (this.IsOverQuota != input.IsOverQuota || (this.IsOverQuota != null && !this.IsOverQuota.Equals(input.IsOverQuota))) return false;
            if (this.BuildQuota != input.BuildQuota || (this.BuildQuota != null && !this.BuildQuota.Equals(input.BuildQuota))) return false;
            if (this.UsedQuota != input.UsedQuota || (this.UsedQuota != null && !this.UsedQuota.Equals(input.UsedQuota))) return false;

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
                if (this.IsOverQuota != null) hashCode = hashCode * 59 + this.IsOverQuota.GetHashCode();
                if (this.BuildQuota != null) hashCode = hashCode * 59 + this.BuildQuota.GetHashCode();
                if (this.UsedQuota != null) hashCode = hashCode * 59 + this.UsedQuota.GetHashCode();
                return hashCode;
            }
        }
    }
}
