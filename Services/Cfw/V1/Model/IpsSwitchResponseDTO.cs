using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// ips特性状态返回查询
    /// </summary>
    public class IpsSwitchResponseDTO 
    {

        /// <summary>
        /// ips开关id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 基础防御状态
        /// </summary>
        [JsonProperty("basic_defense_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? BasicDefenseStatus { get; set; }

        /// <summary>
        /// 虚拟补丁状态
        /// </summary>
        [JsonProperty("virtual_patches_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? VirtualPatchesStatus { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpsSwitchResponseDTO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  basicDefenseStatus: ").Append(BasicDefenseStatus).Append("\n");
            sb.Append("  virtualPatchesStatus: ").Append(VirtualPatchesStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IpsSwitchResponseDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IpsSwitchResponseDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.BasicDefenseStatus == input.BasicDefenseStatus ||
                    (this.BasicDefenseStatus != null &&
                    this.BasicDefenseStatus.Equals(input.BasicDefenseStatus))
                ) && 
                (
                    this.VirtualPatchesStatus == input.VirtualPatchesStatus ||
                    (this.VirtualPatchesStatus != null &&
                    this.VirtualPatchesStatus.Equals(input.VirtualPatchesStatus))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.BasicDefenseStatus != null)
                    hashCode = hashCode * 59 + this.BasicDefenseStatus.GetHashCode();
                if (this.VirtualPatchesStatus != null)
                    hashCode = hashCode * 59 + this.VirtualPatchesStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
