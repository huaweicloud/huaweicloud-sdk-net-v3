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
    /// **参数解释**： 自定义节点池纳管节点参数。 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及 
    /// </summary>
    public class AddNodesToNodePool 
    {

        /// <summary>
        /// **参数解释**： 服务器ID，从ECS/BMS控制台获取。 &gt; 获取方式：在控制台的“服务列表”中，单击“计算 &gt; 弹性云服务器 ECS/裸金属服务器 BMS”，单击服务器的名称，在服务器详情页的“基本信息”页签下找到“ID”字段复制即可。  **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及 
        /// </summary>
        [JsonProperty("serverID", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ServerID { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddNodesToNodePool {\n");
            sb.Append("  serverID: ").Append(ServerID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddNodesToNodePool);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddNodesToNodePool input)
        {
            if (input == null) return false;
            if (this.ServerID != input.ServerID || (this.ServerID != null && !this.ServerID.Equals(input.ServerID))) return false;

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
                if (this.ServerID != null) hashCode = hashCode * 59 + this.ServerID.GetHashCode();
                return hashCode;
            }
        }
    }
}
