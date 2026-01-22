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
    /// 
    /// </summary>
    public class IpsRuleUpdateTimeVO 
    {

        /// <summary>
        /// ips类型，0表示基础防御，1表示虚拟补丁
        /// </summary>
        [JsonProperty("ips_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpsType { get; set; }

        /// <summary>
        /// ips规则版本
        /// </summary>
        [JsonProperty("ips_version", NullValueHandling = NullValueHandling.Ignore)]
        public string IpsVersion { get; set; }

        /// <summary>
        /// ips更新时间戳
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpsRuleUpdateTimeVO {\n");
            sb.Append("  ipsType: ").Append(IpsType).Append("\n");
            sb.Append("  ipsVersion: ").Append(IpsVersion).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IpsRuleUpdateTimeVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IpsRuleUpdateTimeVO input)
        {
            if (input == null) return false;
            if (this.IpsType != input.IpsType || (this.IpsType != null && !this.IpsType.Equals(input.IpsType))) return false;
            if (this.IpsVersion != input.IpsVersion || (this.IpsVersion != null && !this.IpsVersion.Equals(input.IpsVersion))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;

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
                if (this.IpsType != null) hashCode = hashCode * 59 + this.IpsType.GetHashCode();
                if (this.IpsVersion != null) hashCode = hashCode * 59 + this.IpsVersion.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
