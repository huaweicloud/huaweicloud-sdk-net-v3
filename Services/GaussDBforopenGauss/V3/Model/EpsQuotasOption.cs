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
    public class EpsQuotasOption 
    {

        /// <summary>
        /// 企业项目Id。
        /// </summary>
        [JsonProperty("enterprise_projects_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectsId { get; set; }

        /// <summary>
        /// 实例的配额。取值范围：实际创建的实例个数 ~ 100,000。
        /// </summary>
        [JsonProperty("instance_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceQuota { get; set; }

        /// <summary>
        /// cpu的配额。取值范围：实际使用的cpu核数 ~ 2,147,483,646。
        /// </summary>
        [JsonProperty("vcpus_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? VcpusQuota { get; set; }

        /// <summary>
        /// 内存的配额。单位GB。取值范围：实际使用的内存 ~ 2,147,483,646。
        /// </summary>
        [JsonProperty("ram_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? RamQuota { get; set; }

        /// <summary>
        /// 存储空间的配额。单位：GB。取值范围：实际使用的存储空间 ~ 2,147,483,646。
        /// </summary>
        [JsonProperty("volume_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? VolumeQuota { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EpsQuotasOption {\n");
            sb.Append("  enterpriseProjectsId: ").Append(EnterpriseProjectsId).Append("\n");
            sb.Append("  instanceQuota: ").Append(InstanceQuota).Append("\n");
            sb.Append("  vcpusQuota: ").Append(VcpusQuota).Append("\n");
            sb.Append("  ramQuota: ").Append(RamQuota).Append("\n");
            sb.Append("  volumeQuota: ").Append(VolumeQuota).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EpsQuotasOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EpsQuotasOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnterpriseProjectsId == input.EnterpriseProjectsId ||
                    (this.EnterpriseProjectsId != null &&
                    this.EnterpriseProjectsId.Equals(input.EnterpriseProjectsId))
                ) && 
                (
                    this.InstanceQuota == input.InstanceQuota ||
                    (this.InstanceQuota != null &&
                    this.InstanceQuota.Equals(input.InstanceQuota))
                ) && 
                (
                    this.VcpusQuota == input.VcpusQuota ||
                    (this.VcpusQuota != null &&
                    this.VcpusQuota.Equals(input.VcpusQuota))
                ) && 
                (
                    this.RamQuota == input.RamQuota ||
                    (this.RamQuota != null &&
                    this.RamQuota.Equals(input.RamQuota))
                ) && 
                (
                    this.VolumeQuota == input.VolumeQuota ||
                    (this.VolumeQuota != null &&
                    this.VolumeQuota.Equals(input.VolumeQuota))
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
                if (this.EnterpriseProjectsId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectsId.GetHashCode();
                if (this.InstanceQuota != null)
                    hashCode = hashCode * 59 + this.InstanceQuota.GetHashCode();
                if (this.VcpusQuota != null)
                    hashCode = hashCode * 59 + this.VcpusQuota.GetHashCode();
                if (this.RamQuota != null)
                    hashCode = hashCode * 59 + this.RamQuota.GetHashCode();
                if (this.VolumeQuota != null)
                    hashCode = hashCode * 59 + this.VolumeQuota.GetHashCode();
                return hashCode;
            }
        }
    }
}
