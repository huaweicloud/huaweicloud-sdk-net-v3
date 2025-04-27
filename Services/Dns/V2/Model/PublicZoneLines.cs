using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PublicZoneLines 
    {

        /// <summary>
        /// 线路ID。
        /// </summary>
        [JsonProperty("line", NullValueHandling = NullValueHandling.Ignore)]
        public string Line { get; set; }

        /// <summary>
        /// 线路名称。
        /// </summary>
        [JsonProperty("line_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LineName { get; set; }

        /// <summary>
        /// 创建时间。 格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublicZoneLines {\n");
            sb.Append("  line: ").Append(Line).Append("\n");
            sb.Append("  lineName: ").Append(LineName).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublicZoneLines);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PublicZoneLines input)
        {
            if (input == null) return false;
            if (this.Line != input.Line || (this.Line != null && !this.Line.Equals(input.Line))) return false;
            if (this.LineName != input.LineName || (this.LineName != null && !this.LineName.Equals(input.LineName))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;

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
                if (this.Line != null) hashCode = hashCode * 59 + this.Line.GetHashCode();
                if (this.LineName != null) hashCode = hashCode * 59 + this.LineName.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
