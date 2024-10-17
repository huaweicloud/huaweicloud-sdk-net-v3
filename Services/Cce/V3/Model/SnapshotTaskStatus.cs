using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SnapshotTaskStatus 
    {

        /// <summary>
        /// 最近一次备份的时间
        /// </summary>
        [JsonProperty("latestBackupTime", NullValueHandling = NullValueHandling.Ignore)]
        public string LatestBackupTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SnapshotTaskStatus {\n");
            sb.Append("  latestBackupTime: ").Append(LatestBackupTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SnapshotTaskStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SnapshotTaskStatus input)
        {
            if (input == null) return false;
            if (this.LatestBackupTime != input.LatestBackupTime || (this.LatestBackupTime != null && !this.LatestBackupTime.Equals(input.LatestBackupTime))) return false;

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
                if (this.LatestBackupTime != null) hashCode = hashCode * 59 + this.LatestBackupTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
