using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowStructTemplateRequest 
    {

        /// <summary>
        /// 日志组ID
        /// </summary>
        [SDKProperty("logGroupId", IsQuery = true)]
        [JsonProperty("logGroupId", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupId { get; set; }

        /// <summary>
        /// 日志流ID
        /// </summary>
        [SDKProperty("logStreamId", IsQuery = true)]
        [JsonProperty("logStreamId", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStructTemplateRequest {\n");
            sb.Append("  logGroupId: ").Append(LogGroupId).Append("\n");
            sb.Append("  logStreamId: ").Append(LogStreamId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStructTemplateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStructTemplateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LogGroupId == input.LogGroupId ||
                    (this.LogGroupId != null &&
                    this.LogGroupId.Equals(input.LogGroupId))
                ) && 
                (
                    this.LogStreamId == input.LogStreamId ||
                    (this.LogStreamId != null &&
                    this.LogStreamId.Equals(input.LogStreamId))
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
                if (this.LogGroupId != null)
                    hashCode = hashCode * 59 + this.LogGroupId.GetHashCode();
                if (this.LogStreamId != null)
                    hashCode = hashCode * 59 + this.LogStreamId.GetHashCode();
                return hashCode;
            }
        }
    }
}
