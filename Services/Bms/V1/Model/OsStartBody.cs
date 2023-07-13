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
    /// 启动裸金属服务器接口请求结构体
    /// </summary>
    public class OsStartBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("os-start", NullValueHandling = NullValueHandling.Ignore)]
        public StartServersInfo OsStart { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OsStartBody {\n");
            sb.Append("  osStart: ").Append(OsStart).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OsStartBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OsStartBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OsStart == input.OsStart ||
                    (this.OsStart != null &&
                    this.OsStart.Equals(input.OsStart))
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
                if (this.OsStart != null)
                    hashCode = hashCode * 59 + this.OsStart.GetHashCode();
                return hashCode;
            }
        }
    }
}
