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
    /// Request Object
    /// </summary>
    public class DeletePortTagRequest 
    {

        /// <summary>
        /// 功能说明：端口唯一标识 取值范围：合法UUID 约束：ID对应的端口必须存在
        /// </summary>
        [SDKProperty("port_id", IsPath = true)]
        [JsonProperty("port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PortId { get; set; }

        /// <summary>
        /// 功能说明：标签键
        /// </summary>
        [SDKProperty("tag_key", IsPath = true)]
        [JsonProperty("tag_key", NullValueHandling = NullValueHandling.Ignore)]
        public string TagKey { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeletePortTagRequest {\n");
            sb.Append("  portId: ").Append(PortId).Append("\n");
            sb.Append("  tagKey: ").Append(TagKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeletePortTagRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeletePortTagRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PortId == input.PortId ||
                    (this.PortId != null &&
                    this.PortId.Equals(input.PortId))
                ) && 
                (
                    this.TagKey == input.TagKey ||
                    (this.TagKey != null &&
                    this.TagKey.Equals(input.TagKey))
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
                if (this.PortId != null)
                    hashCode = hashCode * 59 + this.PortId.GetHashCode();
                if (this.TagKey != null)
                    hashCode = hashCode * 59 + this.TagKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
