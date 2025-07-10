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
    /// 调整实例容量任务时返回。
    /// </summary>
    public class GetJobInfoResponseBodyJobEntitiesVolume 
    {

        /// <summary>
        /// 磁盘类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 实例原本的磁盘大小（单位：GB）。
        /// </summary>
        [JsonProperty("original_size", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalSize { get; set; }

        /// <summary>
        /// 任务的目标磁盘大小（单位：GB）。
        /// </summary>
        [JsonProperty("target_size", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetJobInfoResponseBodyJobEntitiesVolume {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  originalSize: ").Append(OriginalSize).Append("\n");
            sb.Append("  targetSize: ").Append(TargetSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetJobInfoResponseBodyJobEntitiesVolume);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetJobInfoResponseBodyJobEntitiesVolume input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.OriginalSize != input.OriginalSize || (this.OriginalSize != null && !this.OriginalSize.Equals(input.OriginalSize))) return false;
            if (this.TargetSize != input.TargetSize || (this.TargetSize != null && !this.TargetSize.Equals(input.TargetSize))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.OriginalSize != null) hashCode = hashCode * 59 + this.OriginalSize.GetHashCode();
                if (this.TargetSize != null) hashCode = hashCode * 59 + this.TargetSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
