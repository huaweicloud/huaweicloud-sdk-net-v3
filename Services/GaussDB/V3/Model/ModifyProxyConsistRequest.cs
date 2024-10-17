using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 修改代理一致性请求体
    /// </summary>
    public class ModifyProxyConsistRequest 
    {

        /// <summary>
        /// 会话一致性。 - 取值\&quot;true\&quot;时表示会话一致性开启。 - 取值\&quot;false\&quot;时表示会话一致性关闭。
        /// </summary>
        [JsonProperty("session_consistence", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionConsistence { get; set; }

        /// <summary>
        /// 一致性模式。默认值为空，此时以会话一致性参数session_consistence为准。 - session: 会话一致性 - global: 全局一致性 - eventual: 最终一致性
        /// </summary>
        [JsonProperty("consistence_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsistenceMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyProxyConsistRequest {\n");
            sb.Append("  sessionConsistence: ").Append(SessionConsistence).Append("\n");
            sb.Append("  consistenceMode: ").Append(ConsistenceMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyProxyConsistRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyProxyConsistRequest input)
        {
            if (input == null) return false;
            if (this.SessionConsistence != input.SessionConsistence || (this.SessionConsistence != null && !this.SessionConsistence.Equals(input.SessionConsistence))) return false;
            if (this.ConsistenceMode != input.ConsistenceMode || (this.ConsistenceMode != null && !this.ConsistenceMode.Equals(input.ConsistenceMode))) return false;

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
                if (this.SessionConsistence != null) hashCode = hashCode * 59 + this.SessionConsistence.GetHashCode();
                if (this.ConsistenceMode != null) hashCode = hashCode * 59 + this.ConsistenceMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
