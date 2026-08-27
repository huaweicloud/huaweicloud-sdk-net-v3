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
    public class ListApplyObjectsRequest 
    {

        /// <summary>
        /// 策略ID（精确查询）
        /// </summary>
        [SDKProperty("strategy_id", IsPath = true)]
        [JsonProperty("strategy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StrategyId { get; set; }

        /// <summary>
        /// 应用对象名称（支持模糊查询）
        /// </summary>
        [SDKProperty("object_name", IsQuery = true)]
        [JsonProperty("object_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectName { get; set; }

        /// <summary>
        /// 应用对象类型，包括DESKTOP、ALL_DESKTOPS、DESKTOP_POOL、DESKTOP_TAG、ALL_USERS、USER、USER_GROUP
        /// </summary>
        [SDKProperty("object_type", IsQuery = true)]
        [JsonProperty("object_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectType { get; set; }

        /// <summary>
        /// 偏移量，默认0
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页数量，默认10，最大100
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
            sb.Append("class ListApplyObjectsRequest {\n");
            sb.Append("  strategyId: ").Append(StrategyId).Append("\n");
            sb.Append("  objectName: ").Append(ObjectName).Append("\n");
            sb.Append("  objectType: ").Append(ObjectType).Append("\n");
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
            return this.Equals(input as ListApplyObjectsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListApplyObjectsRequest input)
        {
            if (input == null) return false;
            if (this.StrategyId != input.StrategyId || (this.StrategyId != null && !this.StrategyId.Equals(input.StrategyId))) return false;
            if (this.ObjectName != input.ObjectName || (this.ObjectName != null && !this.ObjectName.Equals(input.ObjectName))) return false;
            if (this.ObjectType != input.ObjectType || (this.ObjectType != null && !this.ObjectType.Equals(input.ObjectType))) return false;
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
                if (this.StrategyId != null) hashCode = hashCode * 59 + this.StrategyId.GetHashCode();
                if (this.ObjectName != null) hashCode = hashCode * 59 + this.ObjectName.GetHashCode();
                if (this.ObjectType != null) hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
