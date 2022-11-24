using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PolicyStatistics 
    {

        /// <summary>
        /// 查询服务的命名空间，各服务命名空间请参考“[服务命名空间](ces_03_0059.xml)”
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 对应命名空间的告警策略数目
        /// </summary>
        [JsonProperty("policy_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PolicyNum { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyStatistics {\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  policyNum: ").Append(PolicyNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyStatistics);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyStatistics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.PolicyNum == input.PolicyNum ||
                    (this.PolicyNum != null &&
                    this.PolicyNum.Equals(input.PolicyNum))
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
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.PolicyNum != null)
                    hashCode = hashCode * 59 + this.PolicyNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
