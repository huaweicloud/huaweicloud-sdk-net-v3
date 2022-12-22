using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V2.Model
{
    /// <summary>
    /// This is a auto create Response Object
    /// </summary>
    public class BandwidthPkgResp 
    {

        /// <summary>
        /// - 功能说明：加油包ID - 取值范围：1-64，支持数字、字母、中文、_(下划线)、-（中划线）
        /// </summary>
        [JsonProperty("resourceId", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// - 功能说明：加油包名称
        /// </summary>
        [JsonProperty("resourceName", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// - 功能说明：资源创建时间，UTC时间格式：2016-03-28T00:00:00Z
        /// </summary>
        [JsonProperty("processedTime", NullValueHandling = NullValueHandling.Ignore)]
        public string ProcessedTime { get; set; }

        /// <summary>
        /// - 功能说明：加油包绑定的原带宽ID
        /// </summary>
        [JsonProperty("bandwidthId", NullValueHandling = NullValueHandling.Ignore)]
        public string BandwidthId { get; set; }

        /// <summary>
        /// - 功能说明：加油包的大小，即在原始带宽之上提升的带宽大小 - 取值范围：&gt;1M，pkgSize+原始带宽大小 &lt; 云服务带宽接口限制的带宽上限
        /// </summary>
        [JsonProperty("pkgSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? PkgSize { get; set; }

        /// <summary>
        /// - 功能说明：租户id
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// - 功能说明：加油包订单相关信息格式：非空时值为&#39;&#39;orderId:productId&#39;&#39;
        /// </summary>
        [JsonProperty("billingInfo", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingInfo { get; set; }

        /// <summary>
        /// - 功能说明：加油包起始生效时间，UTC时间格式：2016-03-28T00:00:00Z - 取值范围：startTime &gt;&#x3D; 服务处理请求的时间
        /// </summary>
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// - 功能说明：加油包结束时间UTC时间格式：2016-03-28T00:00:00Z - 取值范围：startTime &lt; endTime
        /// </summary>
        [JsonProperty("endTime", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// - 功能说明：加油包资源状态，仅管理员权限可以变更状态 - 取值范围：&#39;&#39;pending&#39;&#39;, &#39;&#39;active&#39;&#39;, &#39;&#39;completed&#39;&#39;, &#39;&#39;error&#39;&#39;
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BandwidthPkgResp {\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  processedTime: ").Append(ProcessedTime).Append("\n");
            sb.Append("  bandwidthId: ").Append(BandwidthId).Append("\n");
            sb.Append("  pkgSize: ").Append(PkgSize).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  billingInfo: ").Append(BillingInfo).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BandwidthPkgResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BandwidthPkgResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
                ) && 
                (
                    this.ResourceName == input.ResourceName ||
                    (this.ResourceName != null &&
                    this.ResourceName.Equals(input.ResourceName))
                ) && 
                (
                    this.ProcessedTime == input.ProcessedTime ||
                    (this.ProcessedTime != null &&
                    this.ProcessedTime.Equals(input.ProcessedTime))
                ) && 
                (
                    this.BandwidthId == input.BandwidthId ||
                    (this.BandwidthId != null &&
                    this.BandwidthId.Equals(input.BandwidthId))
                ) && 
                (
                    this.PkgSize == input.PkgSize ||
                    (this.PkgSize != null &&
                    this.PkgSize.Equals(input.PkgSize))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.BillingInfo == input.BillingInfo ||
                    (this.BillingInfo != null &&
                    this.BillingInfo.Equals(input.BillingInfo))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceName != null)
                    hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.ProcessedTime != null)
                    hashCode = hashCode * 59 + this.ProcessedTime.GetHashCode();
                if (this.BandwidthId != null)
                    hashCode = hashCode * 59 + this.BandwidthId.GetHashCode();
                if (this.PkgSize != null)
                    hashCode = hashCode * 59 + this.PkgSize.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.BillingInfo != null)
                    hashCode = hashCode * 59 + this.BillingInfo.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
