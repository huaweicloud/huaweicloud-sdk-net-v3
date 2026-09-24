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
    public class OpExtendInfoUpdateExpirationTime 
    {

        /// <summary>
        /// 本次任务受影响的备份个数
        /// </summary>
        [JsonProperty("affected_backups_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? AffectedBackupsCount { get; set; }

        /// <summary>
        /// 本次任务预期过期日期，格式：YYYY-MM-DD。
        /// </summary>
        [JsonProperty("expiration_day", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpirationDay { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpExtendInfoUpdateExpirationTime {\n");
            sb.Append("  affectedBackupsCount: ").Append(AffectedBackupsCount).Append("\n");
            sb.Append("  expirationDay: ").Append(ExpirationDay).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpExtendInfoUpdateExpirationTime);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OpExtendInfoUpdateExpirationTime input)
        {
            if (input == null) return false;
            if (this.AffectedBackupsCount != input.AffectedBackupsCount || (this.AffectedBackupsCount != null && !this.AffectedBackupsCount.Equals(input.AffectedBackupsCount))) return false;
            if (this.ExpirationDay != input.ExpirationDay || (this.ExpirationDay != null && !this.ExpirationDay.Equals(input.ExpirationDay))) return false;

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
                if (this.AffectedBackupsCount != null) hashCode = hashCode * 59 + this.AffectedBackupsCount.GetHashCode();
                if (this.ExpirationDay != null) hashCode = hashCode * 59 + this.ExpirationDay.GetHashCode();
                return hashCode;
            }
        }
    }
}
