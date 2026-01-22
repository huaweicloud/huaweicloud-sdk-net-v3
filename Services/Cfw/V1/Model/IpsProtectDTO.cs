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
    /// description
    /// </summary>
    public class IpsProtectDTO 
    {

        /// <summary>
        /// 防护对象id，是创建云防火墙后用于区分互联网边界防护和VPC边界防护的标志id，可通过调用[查询防火墙实例接口](ListFirewallDetail.xml)，type为0时，object_id为互联网边界防护对象ID，type为1时，object_id为VPC边界防护对象ID。
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// ips防护模式，0：观察模式，1：严格模式，2：中等模式，3：宽松模式
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? Mode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpsProtectDTO {\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IpsProtectDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IpsProtectDTO input)
        {
            if (input == null) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;
            if (this.Mode != input.Mode || (this.Mode != null && !this.Mode.Equals(input.Mode))) return false;

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
                if (this.ObjectId != null) hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.Mode != null) hashCode = hashCode * 59 + this.Mode.GetHashCode();
                return hashCode;
            }
        }
    }
}
