using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListRdSforMySqlProxyResponse : SdkResponse
    {

        /// <summary>
        /// 数据库实例下的数据库代理信息列表。
        /// </summary>
        [JsonProperty("proxy_query_info_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryProxyResponseV3> ProxyQueryInfoList { get; set; }

        /// <summary>
        /// 支持同时开启的数据库代理的最大数量。
        /// </summary>
        [JsonProperty("max_proxy_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxProxyNum { get; set; }

        /// <summary>
        /// 单个数据库代理支持选择的代理节点的最大数量。
        /// </summary>
        [JsonProperty("max_proxy_node_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxProxyNodeNum { get; set; }

        /// <summary>
        /// 是否支持创建数据库代理时设置负载均衡路由模式。
        /// </summary>
        [JsonProperty("support_balance_route_mode_for_favored_version", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportBalanceRouteModeForFavoredVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRdSforMySqlProxyResponse {\n");
            sb.Append("  proxyQueryInfoList: ").Append(ProxyQueryInfoList).Append("\n");
            sb.Append("  maxProxyNum: ").Append(MaxProxyNum).Append("\n");
            sb.Append("  maxProxyNodeNum: ").Append(MaxProxyNodeNum).Append("\n");
            sb.Append("  supportBalanceRouteModeForFavoredVersion: ").Append(SupportBalanceRouteModeForFavoredVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRdSforMySqlProxyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRdSforMySqlProxyResponse input)
        {
            if (input == null) return false;
            if (this.ProxyQueryInfoList != input.ProxyQueryInfoList || (this.ProxyQueryInfoList != null && input.ProxyQueryInfoList != null && !this.ProxyQueryInfoList.SequenceEqual(input.ProxyQueryInfoList))) return false;
            if (this.MaxProxyNum != input.MaxProxyNum || (this.MaxProxyNum != null && !this.MaxProxyNum.Equals(input.MaxProxyNum))) return false;
            if (this.MaxProxyNodeNum != input.MaxProxyNodeNum || (this.MaxProxyNodeNum != null && !this.MaxProxyNodeNum.Equals(input.MaxProxyNodeNum))) return false;
            if (this.SupportBalanceRouteModeForFavoredVersion != input.SupportBalanceRouteModeForFavoredVersion || (this.SupportBalanceRouteModeForFavoredVersion != null && !this.SupportBalanceRouteModeForFavoredVersion.Equals(input.SupportBalanceRouteModeForFavoredVersion))) return false;

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
                if (this.ProxyQueryInfoList != null) hashCode = hashCode * 59 + this.ProxyQueryInfoList.GetHashCode();
                if (this.MaxProxyNum != null) hashCode = hashCode * 59 + this.MaxProxyNum.GetHashCode();
                if (this.MaxProxyNodeNum != null) hashCode = hashCode * 59 + this.MaxProxyNodeNum.GetHashCode();
                if (this.SupportBalanceRouteModeForFavoredVersion != null) hashCode = hashCode * 59 + this.SupportBalanceRouteModeForFavoredVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
