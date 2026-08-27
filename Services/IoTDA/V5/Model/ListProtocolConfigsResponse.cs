using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListProtocolConfigsResponse : SdkResponse
    {

        /// <summary>
        /// 泛协议配置列表
        /// </summary>
        [JsonProperty("protocol_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProtocolConfigBase> ProtocolConfigs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public Page Page { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListProtocolConfigsResponse {\n");
            sb.Append("  protocolConfigs: ").Append(ProtocolConfigs).Append("\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListProtocolConfigsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListProtocolConfigsResponse input)
        {
            if (input == null) return false;
            if (this.ProtocolConfigs != input.ProtocolConfigs || (this.ProtocolConfigs != null && input.ProtocolConfigs != null && !this.ProtocolConfigs.SequenceEqual(input.ProtocolConfigs))) return false;
            if (this.Page != input.Page || (this.Page != null && !this.Page.Equals(input.Page))) return false;

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
                if (this.ProtocolConfigs != null) hashCode = hashCode * 59 + this.ProtocolConfigs.GetHashCode();
                if (this.Page != null) hashCode = hashCode * 59 + this.Page.GetHashCode();
                return hashCode;
            }
        }
    }
}
