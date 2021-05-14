using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OpExtendInfoRemoveResources 
    {

        /// <summary>
        /// 删除失败的资源数量
        /// </summary>
        [JsonProperty("fail_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailCount { get; set; }

        /// <summary>
        /// 删除的备份数量
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<Resource> Resources { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpExtendInfoRemoveResources {\n");
            sb.Append("  failCount: ").Append(FailCount).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpExtendInfoRemoveResources);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OpExtendInfoRemoveResources input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FailCount == input.FailCount ||
                    (this.FailCount != null &&
                    this.FailCount.Equals(input.FailCount))
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
                (
                    this.Resources == input.Resources ||
                    this.Resources != null &&
                    input.Resources != null &&
                    this.Resources.SequenceEqual(input.Resources)
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
                if (this.FailCount != null)
                    hashCode = hashCode * 59 + this.FailCount.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.Resources != null)
                    hashCode = hashCode * 59 + this.Resources.GetHashCode();
                return hashCode;
            }
        }
    }
}
