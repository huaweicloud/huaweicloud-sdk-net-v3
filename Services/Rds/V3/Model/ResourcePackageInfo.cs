using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResourcePackageInfo 
    {

        /// <summary>
        /// 资源包ID。
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 引擎名称。
        /// </summary>
        [JsonProperty("engine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineName { get; set; }

        /// <summary>
        /// 已使用配额。
        /// </summary>
        [JsonProperty("used_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsedQuota { get; set; }

        /// <summary>
        /// 总配额。
        /// </summary>
        [JsonProperty("total_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalQuota { get; set; }

        /// <summary>
        /// 资源包状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourcePackageInfo {\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  engineName: ").Append(EngineName).Append("\n");
            sb.Append("  usedQuota: ").Append(UsedQuota).Append("\n");
            sb.Append("  totalQuota: ").Append(TotalQuota).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourcePackageInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourcePackageInfo input)
        {
            if (input == null) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.EngineName != input.EngineName || (this.EngineName != null && !this.EngineName.Equals(input.EngineName))) return false;
            if (this.UsedQuota != input.UsedQuota || (this.UsedQuota != null && !this.UsedQuota.Equals(input.UsedQuota))) return false;
            if (this.TotalQuota != input.TotalQuota || (this.TotalQuota != null && !this.TotalQuota.Equals(input.TotalQuota))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.EngineName != null) hashCode = hashCode * 59 + this.EngineName.GetHashCode();
                if (this.UsedQuota != null) hashCode = hashCode * 59 + this.UsedQuota.GetHashCode();
                if (this.TotalQuota != null) hashCode = hashCode * 59 + this.TotalQuota.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
