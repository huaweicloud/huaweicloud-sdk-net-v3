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
    /// 纳管节点参数。集群内已有节点支持通过重置进行重新安装并接入集群。
    /// </summary>
    public class AddNode 
    {

        /// <summary>
        /// 服务器ID，获取方式请参见ECS/BMS相关资料。
        /// </summary>
        [JsonProperty("serverID", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ServerID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("spec", NullValueHandling = NullValueHandling.Ignore)]
        public ReinstallNodeSpec Spec { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddNode {\n");
            sb.Append("  serverID: ").Append(ServerID).Append("\n");
            sb.Append("  spec: ").Append(Spec).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddNode);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddNode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServerID == input.ServerID ||
                    (this.ServerID != null &&
                    this.ServerID.Equals(input.ServerID))
                ) && 
                (
                    this.Spec == input.Spec ||
                    (this.Spec != null &&
                    this.Spec.Equals(input.Spec))
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
                if (this.Spec != null)
                    hashCode = hashCode * 59 + this.Spec.GetHashCode();
                return hashCode;
            }
        }
    }
}
