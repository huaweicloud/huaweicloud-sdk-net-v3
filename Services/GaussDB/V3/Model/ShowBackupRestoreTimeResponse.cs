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
    /// Response Object
    /// </summary>
    public class ShowBackupRestoreTimeResponse : SdkResponse
    {

        /// <summary>
        /// 可恢复时间段列表。
        /// </summary>
        [JsonProperty("restore_times", NullValueHandling = NullValueHandling.Ignore)]
        public List<RestoreTimeInfo> RestoreTimes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBackupRestoreTimeResponse {\n");
            sb.Append("  restoreTimes: ").Append(RestoreTimes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBackupRestoreTimeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBackupRestoreTimeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RestoreTimes == input.RestoreTimes ||
                    this.RestoreTimes != null &&
                    input.RestoreTimes != null &&
                    this.RestoreTimes.SequenceEqual(input.RestoreTimes)
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
                if (this.RestoreTimes != null)
                    hashCode = hashCode * 59 + this.RestoreTimes.GetHashCode();
                return hashCode;
            }
        }
    }
}
