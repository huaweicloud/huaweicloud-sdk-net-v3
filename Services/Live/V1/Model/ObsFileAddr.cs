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
    public class ObsFileAddr 
    {

        /// <summary>
        /// OBS的bucket名称
        /// </summary>
        [JsonProperty("bucket", NullValueHandling = NullValueHandling.Ignore)]
        public string Bucket { get; set; }

        /// <summary>
        /// OBS Bucket所在的区域，且必须保持与使用的直播服务区域保持一致。
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// OBS对象路径，遵守OSS Object定义 - 当用于指示input时，需要指定到具体对象 - 当用于指示output时，只需指定到转码结果期望存放的路径
        /// </summary>
        [JsonProperty("object", NullValueHandling = NullValueHandling.Ignore)]
        public string Object { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObsFileAddr {\n");
            sb.Append("  bucket: ").Append(Bucket).Append("\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObsFileAddr);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObsFileAddr input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bucket == input.Bucket ||
                    (this.Bucket != null &&
                    this.Bucket.Equals(input.Bucket))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
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
                if (this.Bucket != null)
                    hashCode = hashCode * 59 + this.Bucket.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Object != null)
                    hashCode = hashCode * 59 + this.Object.GetHashCode();
                return hashCode;
            }
        }
    }
}
