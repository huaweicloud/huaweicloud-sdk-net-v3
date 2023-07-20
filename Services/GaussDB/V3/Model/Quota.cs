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
    public class Quota 
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
        /// 实例个数配额。
        /// </summary>
        [JsonProperty("instance_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceQuota { get; set; }

        /// <summary>
        /// CPU核数配额。
        /// </summary>
        [JsonProperty("vcpus_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? VcpusQuota { get; set; }

        /// <summary>
        /// 内存使用配额，单位为GB。
        /// </summary>
        [JsonProperty("ram_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? RamQuota { get; set; }

        /// <summary>
        /// 实例剩余配额。
        /// </summary>
        [JsonProperty("availability_instance_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? AvailabilityInstanceQuota { get; set; }

        /// <summary>
        /// CPU核数剩余配额。
        /// </summary>
        [JsonProperty("availability_vcpus_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? AvailabilityVcpusQuota { get; set; }

        /// <summary>
        /// 内存剩余配额。
        /// </summary>
        [JsonProperty("availability_ram_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? AvailabilityRamQuota { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Quota {\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  enterpriseProjectName: ").Append(EnterpriseProjectName).Append("\n");
            sb.Append("  instanceQuota: ").Append(InstanceQuota).Append("\n");
            sb.Append("  vcpusQuota: ").Append(VcpusQuota).Append("\n");
            sb.Append("  ramQuota: ").Append(RamQuota).Append("\n");
            sb.Append("  availabilityInstanceQuota: ").Append(AvailabilityInstanceQuota).Append("\n");
            sb.Append("  availabilityVcpusQuota: ").Append(AvailabilityVcpusQuota).Append("\n");
            sb.Append("  availabilityRamQuota: ").Append(AvailabilityRamQuota).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Quota);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Quota input)
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
                    this.AvailabilityInstanceQuota == input.AvailabilityInstanceQuota ||
                    (this.AvailabilityInstanceQuota != null &&
                    this.AvailabilityInstanceQuota.Equals(input.AvailabilityInstanceQuota))
                ) && 
                (
                    this.AvailabilityVcpusQuota == input.AvailabilityVcpusQuota ||
                    (this.AvailabilityVcpusQuota != null &&
                    this.AvailabilityVcpusQuota.Equals(input.AvailabilityVcpusQuota))
                ) && 
                (
                    this.AvailabilityRamQuota == input.AvailabilityRamQuota ||
                    (this.AvailabilityRamQuota != null &&
                    this.AvailabilityRamQuota.Equals(input.AvailabilityRamQuota))
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
                if (this.InstanceQuota != null)
                    hashCode = hashCode * 59 + this.InstanceQuota.GetHashCode();
                if (this.VcpusQuota != null)
                    hashCode = hashCode * 59 + this.VcpusQuota.GetHashCode();
                if (this.RamQuota != null)
                    hashCode = hashCode * 59 + this.RamQuota.GetHashCode();
                if (this.AvailabilityInstanceQuota != null)
                    hashCode = hashCode * 59 + this.AvailabilityInstanceQuota.GetHashCode();
                if (this.AvailabilityVcpusQuota != null)
                    hashCode = hashCode * 59 + this.AvailabilityVcpusQuota.GetHashCode();
                if (this.AvailabilityRamQuota != null)
                    hashCode = hashCode * 59 + this.AvailabilityRamQuota.GetHashCode();
                return hashCode;
            }
        }
    }
}
