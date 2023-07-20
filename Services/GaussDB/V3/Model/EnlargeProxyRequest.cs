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
    /// proxy节点扩容信息
    /// </summary>
    public class EnlargeProxyRequest 
    {

        /// <summary>
        /// proxy节点扩容操作需要扩容的节点数。  扩容的节点数的取值范围：1~30之间的整数。  限制条件：该实例的proxy节点的总数量小于等于32。
        /// </summary>
        [JsonProperty("node_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeNum { get; set; }

        /// <summary>
        /// 数据库代理ID。  如果实例只开启了一个代理，可不传该参数；如果实例开启了多个代理，则必须指定一个数据库代理，扩容新的代理节点。
        /// </summary>
        [JsonProperty("proxy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnlargeProxyRequest {\n");
            sb.Append("  nodeNum: ").Append(NodeNum).Append("\n");
            sb.Append("  proxyId: ").Append(ProxyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnlargeProxyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnlargeProxyRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NodeNum == input.NodeNum ||
                    (this.NodeNum != null &&
                    this.NodeNum.Equals(input.NodeNum))
                ) && 
                (
                    this.ProxyId == input.ProxyId ||
                    (this.ProxyId != null &&
                    this.ProxyId.Equals(input.ProxyId))
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
                if (this.NodeNum != null)
                    hashCode = hashCode * 59 + this.NodeNum.GetHashCode();
                if (this.ProxyId != null)
                    hashCode = hashCode * 59 + this.ProxyId.GetHashCode();
                return hashCode;
            }
        }
    }
}
