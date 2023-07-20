using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListQuotaResult 
    {

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 企业项目名称。
        /// </summary>
        [JsonProperty("enterprise_project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectName { get; set; }

        /// <summary>
        /// EPS实例资源配额数量，值为-1时表示配额无限制。
        /// </summary>
        [JsonProperty("instance_eps_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceEpsQuota { get; set; }

        /// <summary>
        /// EPS计算资源配额数量，值为-1时表示配额无限制。
        /// </summary>
        [JsonProperty("vcpus_eps_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? VcpusEpsQuota { get; set; }

        /// <summary>
        /// EPS内存资源配额量，单位为GB，值为-1时表示配额无限制。
        /// </summary>
        [JsonProperty("ram_eps_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? RamEpsQuota { get; set; }

        /// <summary>
        /// EPS磁盘资源配额量，单位为GB，值为-1时表示配额无限制。
        /// </summary>
        [JsonProperty("volume_eps_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? VolumeEpsQuota { get; set; }

        /// <summary>
        /// EPS实例使用数量。
        /// </summary>
        [JsonProperty("instance_used", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceUsed { get; set; }

        /// <summary>
        /// EPS计算资源使用数量。
        /// </summary>
        [JsonProperty("vcpus_used", NullValueHandling = NullValueHandling.Ignore)]
        public int? VcpusUsed { get; set; }

        /// <summary>
        /// EPS内存使用配额量，单位为GB。
        /// </summary>
        [JsonProperty("ram_used", NullValueHandling = NullValueHandling.Ignore)]
        public int? RamUsed { get; set; }

        /// <summary>
        /// EPS磁盘使用配额量，单位为GB。
        /// </summary>
        [JsonProperty("volume_used", NullValueHandling = NullValueHandling.Ignore)]
        public int? VolumeUsed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListQuotaResult {\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  enterpriseProjectName: ").Append(EnterpriseProjectName).Append("\n");
            sb.Append("  instanceEpsQuota: ").Append(InstanceEpsQuota).Append("\n");
            sb.Append("  vcpusEpsQuota: ").Append(VcpusEpsQuota).Append("\n");
            sb.Append("  ramEpsQuota: ").Append(RamEpsQuota).Append("\n");
            sb.Append("  volumeEpsQuota: ").Append(VolumeEpsQuota).Append("\n");
            sb.Append("  instanceUsed: ").Append(InstanceUsed).Append("\n");
            sb.Append("  vcpusUsed: ").Append(VcpusUsed).Append("\n");
            sb.Append("  ramUsed: ").Append(RamUsed).Append("\n");
            sb.Append("  volumeUsed: ").Append(VolumeUsed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListQuotaResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListQuotaResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.EnterpriseProjectName == input.EnterpriseProjectName ||
                    (this.EnterpriseProjectName != null &&
                    this.EnterpriseProjectName.Equals(input.EnterpriseProjectName))
                ) && 
                (
                    this.InstanceEpsQuota == input.InstanceEpsQuota ||
                    (this.InstanceEpsQuota != null &&
                    this.InstanceEpsQuota.Equals(input.InstanceEpsQuota))
                ) && 
                (
                    this.VcpusEpsQuota == input.VcpusEpsQuota ||
                    (this.VcpusEpsQuota != null &&
                    this.VcpusEpsQuota.Equals(input.VcpusEpsQuota))
                ) && 
                (
                    this.RamEpsQuota == input.RamEpsQuota ||
                    (this.RamEpsQuota != null &&
                    this.RamEpsQuota.Equals(input.RamEpsQuota))
                ) && 
                (
                    this.VolumeEpsQuota == input.VolumeEpsQuota ||
                    (this.VolumeEpsQuota != null &&
                    this.VolumeEpsQuota.Equals(input.VolumeEpsQuota))
                ) && 
                (
                    this.InstanceUsed == input.InstanceUsed ||
                    (this.InstanceUsed != null &&
                    this.InstanceUsed.Equals(input.InstanceUsed))
                ) && 
                (
                    this.VcpusUsed == input.VcpusUsed ||
                    (this.VcpusUsed != null &&
                    this.VcpusUsed.Equals(input.VcpusUsed))
                ) && 
                (
                    this.RamUsed == input.RamUsed ||
                    (this.RamUsed != null &&
                    this.RamUsed.Equals(input.RamUsed))
                ) && 
                (
                    this.VolumeUsed == input.VolumeUsed ||
                    (this.VolumeUsed != null &&
                    this.VolumeUsed.Equals(input.VolumeUsed))
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
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.EnterpriseProjectName != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectName.GetHashCode();
                if (this.InstanceEpsQuota != null)
                    hashCode = hashCode * 59 + this.InstanceEpsQuota.GetHashCode();
                if (this.VcpusEpsQuota != null)
                    hashCode = hashCode * 59 + this.VcpusEpsQuota.GetHashCode();
                if (this.RamEpsQuota != null)
                    hashCode = hashCode * 59 + this.RamEpsQuota.GetHashCode();
                if (this.VolumeEpsQuota != null)
                    hashCode = hashCode * 59 + this.VolumeEpsQuota.GetHashCode();
                if (this.InstanceUsed != null)
                    hashCode = hashCode * 59 + this.InstanceUsed.GetHashCode();
                if (this.VcpusUsed != null)
                    hashCode = hashCode * 59 + this.VcpusUsed.GetHashCode();
                if (this.RamUsed != null)
                    hashCode = hashCode * 59 + this.RamUsed.GetHashCode();
                if (this.VolumeUsed != null)
                    hashCode = hashCode * 59 + this.VolumeUsed.GetHashCode();
                return hashCode;
            }
        }
    }
}
