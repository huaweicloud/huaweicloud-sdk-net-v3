using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BinlogClearPolicyRequestBody 
    {

        /// <summary>
        /// 取值范围0-7*24
        /// </summary>
        [JsonProperty("binlog_retention_hours", NullValueHandling = NullValueHandling.Ignore)]
        public long? BinlogRetentionHours { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BinlogClearPolicyRequestBody {\n");
            sb.Append("  binlogRetentionHours: ").Append(BinlogRetentionHours).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BinlogClearPolicyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BinlogClearPolicyRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BinlogRetentionHours == input.BinlogRetentionHours ||
                    (this.BinlogRetentionHours != null &&
                    this.BinlogRetentionHours.Equals(input.BinlogRetentionHours))
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
                if (this.BinlogRetentionHours != null)
                    hashCode = hashCode * 59 + this.BinlogRetentionHours.GetHashCode();
                return hashCode;
            }
        }
    }
}
