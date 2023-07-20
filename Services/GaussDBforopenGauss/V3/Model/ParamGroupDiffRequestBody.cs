using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ParamGroupDiffRequestBody 
    {

        /// <summary>
        /// 需要进行比较的参数组模板ID。
        /// </summary>
        [JsonProperty("source_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceId { get; set; }

        /// <summary>
        /// 需要进行比较的参数组模板ID。
        /// </summary>
        [JsonProperty("target_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParamGroupDiffRequestBody {\n");
            sb.Append("  sourceId: ").Append(SourceId).Append("\n");
            sb.Append("  targetId: ").Append(TargetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ParamGroupDiffRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ParamGroupDiffRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.TargetId == input.TargetId ||
                    (this.TargetId != null &&
                    this.TargetId.Equals(input.TargetId))
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
                if (this.SourceId != null)
                    hashCode = hashCode * 59 + this.SourceId.GetHashCode();
                if (this.TargetId != null)
                    hashCode = hashCode * 59 + this.TargetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
