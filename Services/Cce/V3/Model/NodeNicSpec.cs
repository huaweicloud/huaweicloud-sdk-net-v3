using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 节点网卡的描述信息。 
    /// </summary>
    public class NodeNicSpec 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("primaryNic", NullValueHandling = NullValueHandling.Ignore)]
        public NicSpec PrimaryNic { get; set; }

        /// <summary>
        /// 扩展网卡 &gt;创建节点池添加节点时不支持该参数。
        /// </summary>
        [JsonProperty("extNics", NullValueHandling = NullValueHandling.Ignore)]
        public List<NicSpec> ExtNics { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeNicSpec {\n");
            sb.Append("  primaryNic: ").Append(PrimaryNic).Append("\n");
            sb.Append("  extNics: ").Append(ExtNics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeNicSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeNicSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PrimaryNic == input.PrimaryNic ||
                    (this.PrimaryNic != null &&
                    this.PrimaryNic.Equals(input.PrimaryNic))
                ) && 
                (
                    this.ExtNics == input.ExtNics ||
                    this.ExtNics != null &&
                    input.ExtNics != null &&
                    this.ExtNics.SequenceEqual(input.ExtNics)
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
                if (this.PrimaryNic != null)
                    hashCode = hashCode * 59 + this.PrimaryNic.GetHashCode();
                if (this.ExtNics != null)
                    hashCode = hashCode * 59 + this.ExtNics.GetHashCode();
                return hashCode;
            }
        }
    }
}
