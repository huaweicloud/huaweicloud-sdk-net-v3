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
    /// 
    /// </summary>
    public class NodeManagement 
    {

        /// <summary>
        /// **参数解释**： 云服务器组ID，指定后将绑定云服务器组，节点池中所有节点将创建在该云服务器组下。绑定云服务器组后节点池中的节点数量不允许超出云服务器组可添加的云服务器数量，否则将导致节点池无法扩容。 &gt; - 绑定云服务器组后，云服务器将严格按照亲和策略分布，同时也会限制节点池中节点个数上限。由于ECS创建云服务器时本身具有一定反亲和能力，如果仅需云服务器分散的创建在不同主机上以提高业务的可靠性，又不希望节点个数受到云服务器组的限制，请勿绑定云服务器组。 &gt; - 云服务组支持解绑，解绑后存量节点仍属于原云服务器组，新建节点将不再绑定云服务器组。 当节点池中不存在节点时支持绑定新的云服务器组或者切换绑定的云服务器组  **约束限制**： 指定云服务器组时节点池中的节点数量不允许超出云服务器组的配额限制。 **取值范围**： - 不指定或者指定空字符串：表示解绑云服务器组 - 云服务器组ID：表示切换节点池绑定的云服务组  **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("serverGroupReference", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerGroupReference { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeManagement {\n");
            sb.Append("  serverGroupReference: ").Append(ServerGroupReference).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeManagement);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeManagement input)
        {
            if (input == null) return false;
            if (this.ServerGroupReference != input.ServerGroupReference || (this.ServerGroupReference != null && !this.ServerGroupReference.Equals(input.ServerGroupReference))) return false;

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
                if (this.ServerGroupReference != null) hashCode = hashCode * 59 + this.ServerGroupReference.GetHashCode();
                return hashCode;
            }
        }
    }
}
