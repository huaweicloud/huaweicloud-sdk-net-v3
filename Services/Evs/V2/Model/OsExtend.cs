using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    ///  
    /// </summary>
    public class OsExtend 
    {

        /// <summary>
        /// 扩容后的云硬盘大小，单位为GB。扩容的大小必须大于原有云硬盘容量且小于云硬盘最大容量。 云硬盘最大容量： * 数据盘：32768GB * 系统盘：1024GB
        /// </summary>
        [JsonProperty("new_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OsExtend {\n");
            sb.Append("  newSize: ").Append(NewSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OsExtend);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OsExtend input)
        {
            if (input == null) return false;
            if (this.NewSize != input.NewSize || (this.NewSize != null && !this.NewSize.Equals(input.NewSize))) return false;

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
                if (this.NewSize != null) hashCode = hashCode * 59 + this.NewSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
