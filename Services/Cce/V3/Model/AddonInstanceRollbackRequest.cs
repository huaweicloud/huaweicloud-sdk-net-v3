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
    /// **参数解释**： 回滚插件实例请求结构体。 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
    /// </summary>
    public class AddonInstanceRollbackRequest 
    {

        /// <summary>
        /// **参数解释**： 集群ID，获取方式请参见[如何获取接口URI中参数](cce_02_0271.xml)。 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("clusterID", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterID { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddonInstanceRollbackRequest {\n");
            sb.Append("  clusterID: ").Append(ClusterID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddonInstanceRollbackRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddonInstanceRollbackRequest input)
        {
            if (input == null) return false;
            if (this.ClusterID != input.ClusterID || (this.ClusterID != null && !this.ClusterID.Equals(input.ClusterID))) return false;

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
                if (this.ClusterID != null) hashCode = hashCode * 59 + this.ClusterID.GetHashCode();
                return hashCode;
            }
        }
    }
}
