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
    /// 
    /// </summary>
    public class CloseMysqlProxyRequestBody 
    {

        /// <summary>
        /// 数据库代理ID列表。  如果实例只开启了一个代理，可不传该字段；如果实例开启了多个代理，则必须指定要关闭的代理。
        /// </summary>
        [JsonProperty("proxy_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProxyIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloseMysqlProxyRequestBody {\n");
            sb.Append("  proxyIds: ").Append(ProxyIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CloseMysqlProxyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CloseMysqlProxyRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProxyIds == input.ProxyIds ||
                    this.ProxyIds != null &&
                    input.ProxyIds != null &&
                    this.ProxyIds.SequenceEqual(input.ProxyIds)
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
                if (this.ProxyIds != null)
                    hashCode = hashCode * 59 + this.ProxyIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
