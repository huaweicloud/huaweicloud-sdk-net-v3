using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// 关闭裸金属服务器接口请求结构体
    /// </summary>
    public class OsStopBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("os-stop", NullValueHandling = NullValueHandling.Ignore)]
        public OsStopBodyType OsStop { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OsStopBody {\n");
            sb.Append("  osStop: ").Append(OsStop).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OsStopBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OsStopBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OsStop == input.OsStop ||
                    (this.OsStop != null &&
                    this.OsStop.Equals(input.OsStop))
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
                if (this.OsStop != null)
                    hashCode = hashCode * 59 + this.OsStop.GetHashCode();
                return hashCode;
            }
        }
    }
}
