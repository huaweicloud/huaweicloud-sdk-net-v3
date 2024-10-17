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
    public class SetQuota 
    {

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 实例个数配额。取值范围0~100000。(如果已经存在实例，应该大于已经存在的实例个数)
        /// </summary>
        [JsonProperty("instance_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceQuota { get; set; }

        /// <summary>
        /// CPU核数配额。取值范围0~2147483646。(如果已经存在实例，应该大于已经占用的cpu个数)
        /// </summary>
        [JsonProperty("vcpus_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? VcpusQuota { get; set; }

        /// <summary>
        /// 内存使用配额，单位为GB。取值范围0~2147483646。(如果已经存在实例，应该大于已经占用的内存数)
        /// </summary>
        [JsonProperty("ram_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? RamQuota { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetQuota {\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  instanceQuota: ").Append(InstanceQuota).Append("\n");
            sb.Append("  vcpusQuota: ").Append(VcpusQuota).Append("\n");
            sb.Append("  ramQuota: ").Append(RamQuota).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetQuota);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetQuota input)
        {
            if (input == null) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.InstanceQuota != input.InstanceQuota || (this.InstanceQuota != null && !this.InstanceQuota.Equals(input.InstanceQuota))) return false;
            if (this.VcpusQuota != input.VcpusQuota || (this.VcpusQuota != null && !this.VcpusQuota.Equals(input.VcpusQuota))) return false;
            if (this.RamQuota != input.RamQuota || (this.RamQuota != null && !this.RamQuota.Equals(input.RamQuota))) return false;

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
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.InstanceQuota != null) hashCode = hashCode * 59 + this.InstanceQuota.GetHashCode();
                if (this.VcpusQuota != null) hashCode = hashCode * 59 + this.VcpusQuota.GetHashCode();
                if (this.RamQuota != null) hashCode = hashCode * 59 + this.RamQuota.GetHashCode();
                return hashCode;
            }
        }
    }
}
