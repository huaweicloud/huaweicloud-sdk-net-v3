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
    public class ListInstancesSupportFastRestoreRequestBody 
    {

        /// <summary>
        /// 要恢复的时间点，格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。
        /// </summary>
        [JsonProperty("restore_time", NullValueHandling = NullValueHandling.Ignore)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// 实例id列表。
        /// </summary>
        [JsonProperty("instance_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstanceIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstancesSupportFastRestoreRequestBody {\n");
            sb.Append("  restoreTime: ").Append(RestoreTime).Append("\n");
            sb.Append("  instanceIds: ").Append(InstanceIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstancesSupportFastRestoreRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstancesSupportFastRestoreRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RestoreTime == input.RestoreTime ||
                    (this.RestoreTime != null &&
                    this.RestoreTime.Equals(input.RestoreTime))
                ) && 
                (
                    this.InstanceIds == input.InstanceIds ||
                    this.InstanceIds != null &&
                    input.InstanceIds != null &&
                    this.InstanceIds.SequenceEqual(input.InstanceIds)
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
                if (this.RestoreTime != null)
                    hashCode = hashCode * 59 + this.RestoreTime.GetHashCode();
                if (this.InstanceIds != null)
                    hashCode = hashCode * 59 + this.InstanceIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
