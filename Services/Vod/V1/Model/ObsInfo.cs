using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ObsInfo 
    {

        /// <summary>
        /// OBS的bucket名称
        /// </summary>
        [JsonProperty("bucket", NullValueHandling = NullValueHandling.Ignore)]
        public string Bucket { get; set; }

        /// <summary>
        /// OBS对象路径
        /// </summary>
        [JsonProperty("object", NullValueHandling = NullValueHandling.Ignore)]
        public string Object { get; set; }

        /// <summary>
        /// 桶所在区域
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObsInfo {\n");
            sb.Append("  bucket: ").Append(Bucket).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObsInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObsInfo input)
        {
            if (input == null) return false;
            if (this.Bucket != input.Bucket || (this.Bucket != null && !this.Bucket.Equals(input.Bucket))) return false;
            if (this.Object != input.Object || (this.Object != null && !this.Object.Equals(input.Object))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;

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
                if (this.Bucket != null) hashCode = hashCode * 59 + this.Bucket.GetHashCode();
                if (this.Object != null) hashCode = hashCode * 59 + this.Object.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                return hashCode;
            }
        }
    }
}
