using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// addresses字段数据结构说明
    /// </summary>
    public class Addresses 
    {

        /// <summary>
        /// 裸金属服务器所属网络信息。key表示裸金属服务器使用的虚拟私有云的ID。value为网络详细信息
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<Address> VpcId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Addresses {\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Addresses);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Addresses input)
        {
            if (input == null) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && input.VpcId != null && !this.VpcId.SequenceEqual(input.VpcId))) return false;

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
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                return hashCode;
            }
        }
    }
}
