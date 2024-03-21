using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PackageRequestArgs 
    {

        /// <summary>
        /// 录制播放相关配置
        /// </summary>
        [JsonProperty("record", NullValueHandling = NullValueHandling.Ignore)]
        public List<RecordRequestArgs> Record { get; set; }

        /// <summary>
        /// 时移播放相关配置
        /// </summary>
        [JsonProperty("timeshift", NullValueHandling = NullValueHandling.Ignore)]
        public List<TimeshiftRequestArgs> Timeshift { get; set; }

        /// <summary>
        /// 直播播放相关配置
        /// </summary>
        [JsonProperty("live", NullValueHandling = NullValueHandling.Ignore)]
        public List<LiveRequestArgs> Live { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PackageRequestArgs {\n");
            sb.Append("  record: ").Append(Record).Append("\n");
            sb.Append("  timeshift: ").Append(Timeshift).Append("\n");
            sb.Append("  live: ").Append(Live).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PackageRequestArgs);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PackageRequestArgs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Record == input.Record ||
                    this.Record != null &&
                    input.Record != null &&
                    this.Record.SequenceEqual(input.Record)
                ) && 
                (
                    this.Timeshift == input.Timeshift ||
                    this.Timeshift != null &&
                    input.Timeshift != null &&
                    this.Timeshift.SequenceEqual(input.Timeshift)
                ) && 
                (
                    this.Live == input.Live ||
                    this.Live != null &&
                    input.Live != null &&
                    this.Live.SequenceEqual(input.Live)
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
                if (this.Record != null)
                    hashCode = hashCode * 59 + this.Record.GetHashCode();
                if (this.Timeshift != null)
                    hashCode = hashCode * 59 + this.Timeshift.GetHashCode();
                if (this.Live != null)
                    hashCode = hashCode * 59 + this.Live.GetHashCode();
                return hashCode;
            }
        }
    }
}
