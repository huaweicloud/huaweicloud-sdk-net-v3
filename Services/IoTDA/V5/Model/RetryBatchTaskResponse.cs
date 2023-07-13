using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class RetryBatchTaskResponse : SdkResponse
    {

        /// <summary>
        /// 批量操作目标结果集合
        /// </summary>
        [JsonProperty("targets", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchTargetResult> Targets { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetryBatchTaskResponse {\n");
            sb.Append("  targets: ").Append(Targets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RetryBatchTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RetryBatchTaskResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Targets == input.Targets ||
                    this.Targets != null &&
                    input.Targets != null &&
                    this.Targets.SequenceEqual(input.Targets)
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
                if (this.Targets != null)
                    hashCode = hashCode * 59 + this.Targets.GetHashCode();
                return hashCode;
            }
        }
    }
}
