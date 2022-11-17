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
    /// os-start字段数据结构说明
    /// </summary>
    public class StartServersInfo 
    {

        /// <summary>
        /// 裸金属服务器ID列表，详情请参见表3 servers字段数据结构说明
        /// </summary>
        [JsonProperty("servers", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServersList> Servers { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartServersInfo {\n");
            sb.Append("  servers: ").Append(Servers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StartServersInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StartServersInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Servers == input.Servers ||
                    this.Servers != null &&
                    input.Servers != null &&
                    this.Servers.SequenceEqual(input.Servers)
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
                if (this.Servers != null)
                    hashCode = hashCode * 59 + this.Servers.GetHashCode();
                return hashCode;
            }
        }
    }
}
