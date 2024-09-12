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
    /// 自定义节点池纳管节点参数。
    /// </summary>
    public class AddNodesToNodePool 
    {

        /// <summary>
        /// 服务器ID，获取方式请参见ECS/BMS相关资料。
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
            if (input == null)
                return false;

            return 
                (
                    this.ServerID == input.ServerID ||
                    (this.ServerID != null &&
                    this.ServerID.Equals(input.ServerID))
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
                if (this.ServerID != null)
                    hashCode = hashCode * 59 + this.ServerID.GetHashCode();
                return hashCode;
            }
        }
    }
}
