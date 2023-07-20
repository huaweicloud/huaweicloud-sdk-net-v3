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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyProxyConsistRequest {\n");
            sb.Append("  sessionConsistence: ").Append(SessionConsistence).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.SessionConsistence == input.SessionConsistence ||
                    (this.SessionConsistence != null &&
                    this.SessionConsistence.Equals(input.SessionConsistence))
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
                if (this.SessionConsistence != null)
                    hashCode = hashCode * 59 + this.SessionConsistence.GetHashCode();
                return hashCode;
            }
        }
    }
}
