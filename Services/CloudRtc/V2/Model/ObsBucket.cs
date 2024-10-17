using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ObsBucket 
    {

        /// <summary>
        /// OBS的bucket名称
        /// </summary>
        [JsonProperty("bucket", NullValueHandling = NullValueHandling.Ignore)]
        public string Bucket { get; set; }

        /// <summary>
        /// OBS的bucket所在region
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// 创建时间，格式如：2020/07/16 15:11:55 GMT+08:00
        /// </summary>
        [JsonProperty("creation_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CreationDate { get; set; }

        /// <summary>
        /// 鉴权
        /// </summary>
        [JsonProperty("is_authorized", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAuthorized { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObsBucket {\n");
            sb.Append("  bucket: ").Append(Bucket).Append("\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("  creationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  isAuthorized: ").Append(IsAuthorized).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObsBucket);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObsBucket input)
        {
            if (input == null) return false;
            if (this.Bucket != input.Bucket || (this.Bucket != null && !this.Bucket.Equals(input.Bucket))) return false;
            if (this.Location != input.Location || (this.Location != null && !this.Location.Equals(input.Location))) return false;
            if (this.CreationDate != input.CreationDate || (this.CreationDate != null && !this.CreationDate.Equals(input.CreationDate))) return false;
            if (this.IsAuthorized != input.IsAuthorized || (this.IsAuthorized != null && !this.IsAuthorized.Equals(input.IsAuthorized))) return false;

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
                if (this.Location != null) hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.CreationDate != null) hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.IsAuthorized != null) hashCode = hashCode * 59 + this.IsAuthorized.GetHashCode();
                return hashCode;
            }
        }
    }
}
