using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 规则发现部分,数组中有多个对象时表示需要同时满足所有条件的进程才会被匹配到。 checkType为cmdLine时checkMode填contain,checkContent格式为[“xxx”]表示进程命令行参数中需要包含xxx。checkType为env时checkMode填contain,checkContent格式为 [\&quot;k1\&quot;,\&quot;v1\&quot;]表示进程环境变量中需要包含名为k1值为v1的环境变量。checkType为scope时checkMode填equals,checkContent格式为节点ID数组[\&quot;hostId1”,”hostId2”],表示规则仅会在这些节点上生效(如果不指定节点范围,规则将下发到该项目所有的节点)。
    /// </summary>
    public class DiscoveryRule 
    {

        /// <summary>
        /// 匹配值。
        /// </summary>
        [JsonProperty("checkContent", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CheckContent { get; set; }

        /// <summary>
        /// 匹配条件。contain、equals
        /// </summary>
        [JsonProperty("checkMode", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckMode { get; set; }

        /// <summary>
        /// 匹配类型。cmdLine、env、scope
        /// </summary>
        [JsonProperty("checkType", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiscoveryRule {\n");
            sb.Append("  checkContent: ").Append(CheckContent).Append("\n");
            sb.Append("  checkMode: ").Append(CheckMode).Append("\n");
            sb.Append("  checkType: ").Append(CheckType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DiscoveryRule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DiscoveryRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CheckContent == input.CheckContent ||
                    this.CheckContent != null &&
                    input.CheckContent != null &&
                    this.CheckContent.SequenceEqual(input.CheckContent)
                ) && 
                (
                    this.CheckMode == input.CheckMode ||
                    (this.CheckMode != null &&
                    this.CheckMode.Equals(input.CheckMode))
                ) && 
                (
                    this.CheckType == input.CheckType ||
                    (this.CheckType != null &&
                    this.CheckType.Equals(input.CheckType))
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
                if (this.CheckContent != null)
                    hashCode = hashCode * 59 + this.CheckContent.GetHashCode();
                if (this.CheckMode != null)
                    hashCode = hashCode * 59 + this.CheckMode.GetHashCode();
                if (this.CheckType != null)
                    hashCode = hashCode * 59 + this.CheckType.GetHashCode();
                return hashCode;
            }
        }
    }
}
