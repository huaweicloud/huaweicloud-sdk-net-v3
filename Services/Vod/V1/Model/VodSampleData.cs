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
    public class VodSampleData 
    {

        /// <summary>
        /// 存储空间。  单位：GB。
        /// </summary>
        [JsonProperty("storage", NullValueHandling = NullValueHandling.Ignore)]
        public float? Storage { get; set; }

        /// <summary>
        /// 转码时长。  单位：秒。
        /// </summary>
        [JsonProperty("transcode", NullValueHandling = NullValueHandling.Ignore)]
        public long? Transcode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VodSampleData {\n");
            sb.Append("  storage: ").Append(Storage).Append("\n");
            sb.Append("  transcode: ").Append(Transcode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VodSampleData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VodSampleData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Storage == input.Storage ||
                    (this.Storage != null &&
                    this.Storage.Equals(input.Storage))
                ) && 
                (
                    this.Transcode == input.Transcode ||
                    (this.Transcode != null &&
                    this.Transcode.Equals(input.Transcode))
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
                if (this.Storage != null)
                    hashCode = hashCode * 59 + this.Storage.GetHashCode();
                if (this.Transcode != null)
                    hashCode = hashCode * 59 + this.Transcode.GetHashCode();
                return hashCode;
            }
        }
    }
}
