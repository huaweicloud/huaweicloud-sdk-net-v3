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
    /// 租户状态信息
    /// </summary>
    public class ShowDomainStatusResult 
    {

        /// <summary>
        /// 租户状态0:未开通; 1:正常; 2:冻结; 3:关闭; 4、5:注销
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Status { get; set; }

        /// <summary>
        /// 是否包含免费额度
        /// </summary>
        [JsonProperty("free_quota", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FreeQuota { get; set; }

        /// <summary>
        /// 是否启用自定义环境
        /// </summary>
        [JsonProperty("allow_custom_env", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? AllowCustomEnv { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDomainStatusResult {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  freeQuota: ").Append(FreeQuota).Append("\n");
            sb.Append("  allowCustomEnv: ").Append(AllowCustomEnv).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDomainStatusResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDomainStatusResult input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.FreeQuota != input.FreeQuota || (this.FreeQuota != null && !this.FreeQuota.Equals(input.FreeQuota))) return false;
            if (this.AllowCustomEnv != input.AllowCustomEnv || (this.AllowCustomEnv != null && !this.AllowCustomEnv.Equals(input.AllowCustomEnv))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.FreeQuota != null) hashCode = hashCode * 59 + this.FreeQuota.GetHashCode();
                if (this.AllowCustomEnv != null) hashCode = hashCode * 59 + this.AllowCustomEnv.GetHashCode();
                return hashCode;
            }
        }
    }
}
