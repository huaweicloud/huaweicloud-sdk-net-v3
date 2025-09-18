using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ga.V1.Model
{
    /// <summary>
    /// 创建监听器的详细信息。
    /// </summary>
    public class CreateListenerOption 
    {

        /// <summary>
        /// 监听器名称，取值范围：1~64个字符之间，只能由数字、字母、中划线和中文组成。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 监听器的描述信息，取值范围：0~255个字符之间，禁止输入字符：&lt;&gt;。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public ListenerProtocol Protocol { get; set; }
        /// <summary>
        /// 监听端口范围列表。
        /// </summary>
        [JsonProperty("port_ranges", NullValueHandling = NullValueHandling.Ignore)]
        public List<PortRange> PortRanges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("client_affinity", NullValueHandling = NullValueHandling.Ignore)]
        public ClientAffinity? ClientAffinity { get; set; }

        /// <summary>
        /// 全球加速实例ID。
        /// </summary>
        [JsonProperty("accelerator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// 标签列表。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceTag> Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateListenerOption {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  portRanges: ").Append(PortRanges).Append("\n");
            sb.Append("  clientAffinity: ").Append(ClientAffinity).Append("\n");
            sb.Append("  acceleratorId: ").Append(AcceleratorId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateListenerOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateListenerOption input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Protocol != input.Protocol) return false;
            if (this.PortRanges != input.PortRanges || (this.PortRanges != null && input.PortRanges != null && !this.PortRanges.SequenceEqual(input.PortRanges))) return false;
            if (this.ClientAffinity != input.ClientAffinity || (this.ClientAffinity != null && !this.ClientAffinity.Equals(input.ClientAffinity))) return false;
            if (this.AcceleratorId != input.AcceleratorId || (this.AcceleratorId != null && !this.AcceleratorId.Equals(input.AcceleratorId))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.PortRanges != null) hashCode = hashCode * 59 + this.PortRanges.GetHashCode();
                if (this.ClientAffinity != null) hashCode = hashCode * 59 + this.ClientAffinity.GetHashCode();
                if (this.AcceleratorId != null) hashCode = hashCode * 59 + this.AcceleratorId.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
