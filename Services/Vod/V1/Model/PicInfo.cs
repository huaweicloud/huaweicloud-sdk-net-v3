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
    public class PicInfo 
    {

        /// <summary>
        /// 截图在obs桶中路径
        /// </summary>
        [JsonProperty("object_key", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectKey { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PicInfo {\n");
            sb.Append("  objectKey: ").Append(ObjectKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PicInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PicInfo input)
        {
            if (input == null) return false;
            if (this.ObjectKey != input.ObjectKey || (this.ObjectKey != null && !this.ObjectKey.Equals(input.ObjectKey))) return false;

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
                if (this.ObjectKey != null) hashCode = hashCode * 59 + this.ObjectKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
