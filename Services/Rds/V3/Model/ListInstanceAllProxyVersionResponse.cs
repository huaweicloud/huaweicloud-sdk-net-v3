using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListInstanceAllProxyVersionResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  数据库代理节点引擎版本信息列表。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("proxy_engine_version_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProxyEngineVersionInfo> ProxyEngineVersionInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstanceAllProxyVersionResponse {\n");
            sb.Append("  proxyEngineVersionInfos: ").Append(ProxyEngineVersionInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstanceAllProxyVersionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstanceAllProxyVersionResponse input)
        {
            if (input == null) return false;
            if (this.ProxyEngineVersionInfos != input.ProxyEngineVersionInfos || (this.ProxyEngineVersionInfos != null && input.ProxyEngineVersionInfos != null && !this.ProxyEngineVersionInfos.SequenceEqual(input.ProxyEngineVersionInfos))) return false;

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
                if (this.ProxyEngineVersionInfos != null) hashCode = hashCode * 59 + this.ProxyEngineVersionInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
