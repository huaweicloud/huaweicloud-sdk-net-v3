using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MigrateSubNetworkInterfaceOption 
    {

        /// <summary>
        /// 目的宿主网卡ID
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

        /// <summary>
        /// 待迁移辅助弹性网卡列表
        /// </summary>
        [JsonProperty("sub_network_interfaces", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, string>> SubNetworkInterfaces { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrateSubNetworkInterfaceOption {\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  subNetworkInterfaces: ").Append(SubNetworkInterfaces).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigrateSubNetworkInterfaceOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MigrateSubNetworkInterfaceOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.SubNetworkInterfaces == input.SubNetworkInterfaces ||
                    this.SubNetworkInterfaces != null &&
                    input.SubNetworkInterfaces != null &&
                    this.SubNetworkInterfaces.SequenceEqual(input.SubNetworkInterfaces)
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
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.SubNetworkInterfaces != null)
                    hashCode = hashCode * 59 + this.SubNetworkInterfaces.GetHashCode();
                return hashCode;
            }
        }
    }
}
