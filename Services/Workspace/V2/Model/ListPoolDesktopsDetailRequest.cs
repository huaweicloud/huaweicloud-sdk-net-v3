using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListPoolDesktopsDetailRequest 
    {

        /// <summary>
        /// 桌面池ID。
        /// </summary>
        [SDKProperty("pool_id", IsPath = true)]
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolId { get; set; }

        /// <summary>
        /// 通过该类型过滤出与桌面池规格类型不一致的桌面 - PRODUCT: 查找productID与桌面池套餐ID不一致的桌面 - IMAGE: 查找imageID与桌面池镜像ID不一致的桌面
        /// </summary>
        [SDKProperty("inconsistent_type", IsQuery = true)]
        [JsonProperty("inconsistent_type", NullValueHandling = NullValueHandling.Ignore)]
        public string InconsistentType { get; set; }

        /// <summary>
        /// 用于分页查询，查询的起始记录序号，从0开始
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 用于分页查询，返回桌面数量限制。取值范围0-100，默认值是10
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPoolDesktopsDetailRequest {\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  inconsistentType: ").Append(InconsistentType).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPoolDesktopsDetailRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPoolDesktopsDetailRequest input)
        {
            if (input == null) return false;
            if (this.PoolId != input.PoolId || (this.PoolId != null && !this.PoolId.Equals(input.PoolId))) return false;
            if (this.InconsistentType != input.InconsistentType || (this.InconsistentType != null && !this.InconsistentType.Equals(input.InconsistentType))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.PoolId != null) hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.InconsistentType != null) hashCode = hashCode * 59 + this.InconsistentType.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
