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
    /// Response Object
    /// </summary>
    public class ShowBinlogClearPolicyResponse : SdkResponse
    {

        /// <summary>
        /// binlog保留时长
        /// </summary>
        [JsonProperty("binlog_retention_hours", NullValueHandling = NullValueHandling.Ignore)]
        public int? BinlogRetentionHours { get; set; }

        /// <summary>
        /// 二进制日志保留策略,取值：time、fast - time:表示按时长保留二进制文件 - fast:表示快速清理,不保留二进制文件
        /// </summary>
        [JsonProperty("binlog_clear_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BinlogClearType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBinlogClearPolicyResponse {\n");
            sb.Append("  binlogRetentionHours: ").Append(BinlogRetentionHours).Append("\n");
            sb.Append("  binlogClearType: ").Append(BinlogClearType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBinlogClearPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBinlogClearPolicyResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BinlogRetentionHours == input.BinlogRetentionHours ||
                    (this.BinlogRetentionHours != null &&
                    this.BinlogRetentionHours.Equals(input.BinlogRetentionHours))
                ) && 
                (
                    this.BinlogClearType == input.BinlogClearType ||
                    (this.BinlogClearType != null &&
                    this.BinlogClearType.Equals(input.BinlogClearType))
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
                if (this.BinlogClearType != null)
                    hashCode = hashCode * 59 + this.BinlogClearType.GetHashCode();
                return hashCode;
            }
        }
    }
}
