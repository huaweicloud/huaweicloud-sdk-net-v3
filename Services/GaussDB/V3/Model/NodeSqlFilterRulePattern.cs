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
    /// SQL限流规则和最大并发数
    /// </summary>
    public class NodeSqlFilterRulePattern 
    {

        /// <summary>
        /// SQL限流规则，由一个或多个关键字（最多为128个关键字）组成，关键字之间通过\&quot;~\&quot;分隔符分开，如select~from~t1。规则中不能包含‘\\’、中英文逗号、‘~~’，不能以‘~’结尾。
        /// </summary>
        [JsonProperty("pattern", NullValueHandling = NullValueHandling.Ignore)]
        public string Pattern { get; set; }

        /// <summary>
        /// 最大并发数。取值范围：非负整数。
        /// </summary>
        [JsonProperty("max_concurrency", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxConcurrency { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeSqlFilterRulePattern {\n");
            sb.Append("  pattern: ").Append(Pattern).Append("\n");
            sb.Append("  maxConcurrency: ").Append(MaxConcurrency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeSqlFilterRulePattern);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeSqlFilterRulePattern input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pattern == input.Pattern ||
                    (this.Pattern != null &&
                    this.Pattern.Equals(input.Pattern))
                ) && 
                (
                    this.MaxConcurrency == input.MaxConcurrency ||
                    (this.MaxConcurrency != null &&
                    this.MaxConcurrency.Equals(input.MaxConcurrency))
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
                if (this.Pattern != null)
                    hashCode = hashCode * 59 + this.Pattern.GetHashCode();
                if (this.MaxConcurrency != null)
                    hashCode = hashCode * 59 + this.MaxConcurrency.GetHashCode();
                return hashCode;
            }
        }
    }
}
