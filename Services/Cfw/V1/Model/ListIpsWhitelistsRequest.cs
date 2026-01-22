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
    /// Request Object
    /// </summary>
    public class ListIpsWhitelistsRequest 
    {

        /// <summary>
        /// **参数解释**： 防火墙ID，用户创建防火墙实例后产生的唯一ID，配置后可区分不同防火墙，可通过[防火墙ID获取方式](cfw_02_0028.xml)获取 **约束限制**： 不涉及 **取值范围**： 32位UUID **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("fw_instance_id", IsPath = true)]
        [JsonProperty("fw_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FwInstanceId { get; set; }

        /// <summary>
        /// **参数解释**： 白名单源地址 **约束限制**： 不涉及  **取值范围**： 不涉及  **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("source_address", IsQuery = true)]
        [JsonProperty("source_address", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceAddress { get; set; }

        /// <summary>
        /// **参数解释**：  目的地址  **约束限制**：  不涉及  **取值范围**：  不涉及  **默认取值**：  不涉及
        /// </summary>
        [SDKProperty("dest_address", IsQuery = true)]
        [JsonProperty("dest_address", NullValueHandling = NullValueHandling.Ignore)]
        public string DestAddress { get; set; }

        /// <summary>
        /// **参数解释**：  白名单名称  **约束限制**：  不涉及  **取值范围**： 不涉及  **默认取值**：  不涉及
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：  每页大小  **约束限制**：  不涉及  **取值范围**：  不涉及  **默认取值**：  不涉及
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释**：  偏移量  **约束限制**：  不涉及  **取值范围**：  不涉及  **默认取值**：  不涉及
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListIpsWhitelistsRequest {\n");
            sb.Append("  fwInstanceId: ").Append(FwInstanceId).Append("\n");
            sb.Append("  sourceAddress: ").Append(SourceAddress).Append("\n");
            sb.Append("  destAddress: ").Append(DestAddress).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListIpsWhitelistsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListIpsWhitelistsRequest input)
        {
            if (input == null) return false;
            if (this.FwInstanceId != input.FwInstanceId || (this.FwInstanceId != null && !this.FwInstanceId.Equals(input.FwInstanceId))) return false;
            if (this.SourceAddress != input.SourceAddress || (this.SourceAddress != null && !this.SourceAddress.Equals(input.SourceAddress))) return false;
            if (this.DestAddress != input.DestAddress || (this.DestAddress != null && !this.DestAddress.Equals(input.DestAddress))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;

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
                if (this.FwInstanceId != null) hashCode = hashCode * 59 + this.FwInstanceId.GetHashCode();
                if (this.SourceAddress != null) hashCode = hashCode * 59 + this.SourceAddress.GetHashCode();
                if (this.DestAddress != null) hashCode = hashCode * 59 + this.DestAddress.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                return hashCode;
            }
        }
    }
}
