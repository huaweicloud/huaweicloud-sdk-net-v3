using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 维度对象结构体
    /// </summary>
    public class DimChild 
    {

        /// <summary>
        /// 维度名称，当前支持维度有dcs_instance_id、dcs_cluster_redis_node、 dcs_cluster_proxy_node和dcs_memcached_instance_id。
        /// </summary>
        [JsonProperty("dim_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DimName { get; set; }

        /// <summary>
        /// 维度的路由，结构为主维度名称,当前维度名称，比如： dim_name字段为dcs_cluster_redis_node时，这个字段的值为dcs_instance_id,dcs_cluster_redis_node。
        /// </summary>
        [JsonProperty("dim_route", NullValueHandling = NullValueHandling.Ignore)]
        public string DimRoute { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DimChild {\n");
            sb.Append("  dimName: ").Append(DimName).Append("\n");
            sb.Append("  dimRoute: ").Append(DimRoute).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DimChild);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DimChild input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DimName == input.DimName ||
                    (this.DimName != null &&
                    this.DimName.Equals(input.DimName))
                ) && 
                (
                    this.DimRoute == input.DimRoute ||
                    (this.DimRoute != null &&
                    this.DimRoute.Equals(input.DimRoute))
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
                if (this.DimName != null)
                    hashCode = hashCode * 59 + this.DimName.GetHashCode();
                if (this.DimRoute != null)
                    hashCode = hashCode * 59 + this.DimRoute.GetHashCode();
                return hashCode;
            }
        }
    }
}
