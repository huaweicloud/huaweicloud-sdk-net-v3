using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListWhitelistsRequest 
    {

        /// <summary>
        /// 分页查询中每页的白名单个数
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页查询的起始的资源id，表示上一页最后一条查询记录的白名单的id。不指定时表示查询第一页。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 分页的顺序，true表示从后往前分页，false表示从前往后分页，默认为false。
        /// </summary>
        [SDKProperty("page_reverse", IsQuery = true)]
        [JsonProperty("page_reverse", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PageReverse { get; set; }

        /// <summary>
        /// 白名单ID。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 是否开启访问控制开关。true：打开false：关闭
        /// </summary>
        [SDKProperty("enable_whitelist", IsQuery = true)]
        [JsonProperty("enable_whitelist", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableWhitelist { get; set; }

        /// <summary>
        /// 白名单关联的监听器ID。
        /// </summary>
        [SDKProperty("listener_id", IsQuery = true)]
        [JsonProperty("listener_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ListenerId { get; set; }

        /// <summary>
        /// 白名单IP的字符串。
        /// </summary>
        [SDKProperty("whitelist", IsQuery = true)]
        [JsonProperty("whitelist", NullValueHandling = NullValueHandling.Ignore)]
        public string Whitelist { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListWhitelistsRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  pageReverse: ").Append(PageReverse).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  enableWhitelist: ").Append(EnableWhitelist).Append("\n");
            sb.Append("  listenerId: ").Append(ListenerId).Append("\n");
            sb.Append("  whitelist: ").Append(Whitelist).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListWhitelistsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListWhitelistsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.PageReverse == input.PageReverse ||
                    (this.PageReverse != null &&
                    this.PageReverse.Equals(input.PageReverse))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.EnableWhitelist == input.EnableWhitelist ||
                    (this.EnableWhitelist != null &&
                    this.EnableWhitelist.Equals(input.EnableWhitelist))
                ) && 
                (
                    this.ListenerId == input.ListenerId ||
                    (this.ListenerId != null &&
                    this.ListenerId.Equals(input.ListenerId))
                ) && 
                (
                    this.Whitelist == input.Whitelist ||
                    (this.Whitelist != null &&
                    this.Whitelist.Equals(input.Whitelist))
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
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.PageReverse != null)
                    hashCode = hashCode * 59 + this.PageReverse.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.EnableWhitelist != null)
                    hashCode = hashCode * 59 + this.EnableWhitelist.GetHashCode();
                if (this.ListenerId != null)
                    hashCode = hashCode * 59 + this.ListenerId.GetHashCode();
                if (this.Whitelist != null)
                    hashCode = hashCode * 59 + this.Whitelist.GetHashCode();
                return hashCode;
            }
        }
    }
}
