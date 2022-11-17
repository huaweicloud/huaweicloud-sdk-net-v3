using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListRouteTablesResponse : SdkResponse
    {

        /// <summary>
        /// 路由表对象列表
        /// </summary>
        [JsonProperty("routetables", NullValueHandling = NullValueHandling.Ignore)]
        public List<RouteTableListResp> Routetables { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRouteTablesResponse {\n");
            sb.Append("  routetables: ").Append(Routetables).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRouteTablesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRouteTablesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Routetables == input.Routetables ||
                    this.Routetables != null &&
                    input.Routetables != null &&
                    this.Routetables.SequenceEqual(input.Routetables)
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
                if (this.Routetables != null)
                    hashCode = hashCode * 59 + this.Routetables.GetHashCode();
                return hashCode;
            }
        }
    }
}
