using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowClusterListRequest 
    {

        /// <summary>
        /// 获取特定category的集群。
        /// </summary>
        [SDKProperty("category", IsQuery = true)]
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 是否获取集群的资源信息。不填或者填写为true为获取集群资源汇总信息，置为false为不获取集群状态信息；缺省值为true
        /// </summary>
        [SDKProperty("enablestatus", IsQuery = true)]
        [JsonProperty("enablestatus", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablestatus { get; set; }

        /// <summary>
        /// 容器舰队ID。不填会返回用户所有集群，填了之后会返回属于该容器舰队的集群。
        /// </summary>
        [SDKProperty("clustergroupid", IsQuery = true)]
        [JsonProperty("clustergroupid", NullValueHandling = NullValueHandling.Ignore)]
        public string Clustergroupid { get; set; }

        /// <summary>
        /// 分页获取列表时，页的大小，默认为-1
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页获取列表时，起始偏移量，默认为0
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 分页获取列表时，排序参数，支持 create_at 和 update_at
        /// </summary>
        [SDKProperty("order_by", IsQuery = true)]
        [JsonProperty("order_by", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderBy { get; set; }

        /// <summary>
        /// 分页获取列表时，排序方向，支持 desc 和 asc
        /// </summary>
        [SDKProperty("order", IsQuery = true)]
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public string Order { get; set; }

        /// <summary>
        /// 获取集群列表时，根据集群类型筛选，不传参时默认为 all ，支持 all ，grouped，discrete 三种类型。 - grouped：在舰队中纳管的集群 - discrete：未加入舰队的集群 - all：所有集群
        /// </summary>
        [SDKProperty("managetype", IsQuery = true)]
        [JsonProperty("managetype", NullValueHandling = NullValueHandling.Ignore)]
        public string Managetype { get; set; }

        /// <summary>
        /// 集群ID。多个ID以英文逗号分隔。
        /// </summary>
        [SDKProperty("clusterids", IsQuery = true)]
        [JsonProperty("clusterids", NullValueHandling = NullValueHandling.Ignore)]
        public string Clusterids { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowClusterListRequest {\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  enablestatus: ").Append(Enablestatus).Append("\n");
            sb.Append("  clustergroupid: ").Append(Clustergroupid).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  orderBy: ").Append(OrderBy).Append("\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("  managetype: ").Append(Managetype).Append("\n");
            sb.Append("  clusterids: ").Append(Clusterids).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowClusterListRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowClusterListRequest input)
        {
            if (input == null) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.Enablestatus != input.Enablestatus || (this.Enablestatus != null && !this.Enablestatus.Equals(input.Enablestatus))) return false;
            if (this.Clustergroupid != input.Clustergroupid || (this.Clustergroupid != null && !this.Clustergroupid.Equals(input.Clustergroupid))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.OrderBy != input.OrderBy || (this.OrderBy != null && !this.OrderBy.Equals(input.OrderBy))) return false;
            if (this.Order != input.Order || (this.Order != null && !this.Order.Equals(input.Order))) return false;
            if (this.Managetype != input.Managetype || (this.Managetype != null && !this.Managetype.Equals(input.Managetype))) return false;
            if (this.Clusterids != input.Clusterids || (this.Clusterids != null && !this.Clusterids.Equals(input.Clusterids))) return false;

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
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Enablestatus != null) hashCode = hashCode * 59 + this.Enablestatus.GetHashCode();
                if (this.Clustergroupid != null) hashCode = hashCode * 59 + this.Clustergroupid.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.OrderBy != null) hashCode = hashCode * 59 + this.OrderBy.GetHashCode();
                if (this.Order != null) hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Managetype != null) hashCode = hashCode * 59 + this.Managetype.GetHashCode();
                if (this.Clusterids != null) hashCode = hashCode * 59 + this.Clusterids.GetHashCode();
                return hashCode;
            }
        }
    }
}
