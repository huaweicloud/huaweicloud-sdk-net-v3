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
        /// object_id
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// 基础防御状态
        /// </summary>
        [JsonProperty("basic_defense_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? BasicDefenseStatus { get; set; }

        /// <summary>
        /// 虚拟补丁状态
        /// </summary>
        [JsonProperty("virtual_patches_stauts", NullValueHandling = NullValueHandling.Ignore)]
        public int? VirtualPatchesStauts { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpsSwitchResponseDTO {\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  basicDefenseStatus: ").Append(BasicDefenseStatus).Append("\n");
            sb.Append("  virtualPatchesStauts: ").Append(VirtualPatchesStauts).Append("\n");
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
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
                ) && 
                (
                    this.BasicDefenseStatus == input.BasicDefenseStatus ||
                    (this.BasicDefenseStatus != null &&
                    this.BasicDefenseStatus.Equals(input.BasicDefenseStatus))
                ) && 
                (
                    this.VirtualPatchesStauts == input.VirtualPatchesStauts ||
                    (this.VirtualPatchesStauts != null &&
                    this.VirtualPatchesStauts.Equals(input.VirtualPatchesStauts))
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
                if (this.ObjectId != null)
                    hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.BasicDefenseStatus != null)
                    hashCode = hashCode * 59 + this.BasicDefenseStatus.GetHashCode();
                if (this.VirtualPatchesStauts != null)
                    hashCode = hashCode * 59 + this.VirtualPatchesStauts.GetHashCode();
                return hashCode;
            }
        }
    }
}
