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
    /// Request Object
    /// </summary>
    public class ListEngineFlavorsRequest 
    {

        /// <summary>
        /// 实例ID
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 可用区，多个用\&quot;,\&quot;分割，如cn-southwest-244a,cn-southwest-244b
        /// </summary>
        [SDKProperty("availability_zone_ids", IsQuery = true)]
        [JsonProperty("availability_zone_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZoneIds { get; set; }

        /// <summary>
        /// 模式，包括如下类型： ha：主备实例。 replica：只读实例。 single：单实例。
        /// </summary>
        [SDKProperty("ha_mode", IsQuery = true)]
        [JsonProperty("ha_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string HaMode { get; set; }

        /// <summary>
        /// 性能规格,如rds.dec.pg.s1.medium，模糊匹配该规格类型
        /// </summary>
        [SDKProperty("spec_code_like", IsQuery = true)]
        [JsonProperty("spec_code_like", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCodeLike { get; set; }

        /// <summary>
        /// 规格类型，包括如下类型：simple、dec
        /// </summary>
        [SDKProperty("flavor_category_type", IsQuery = true)]
        [JsonProperty("flavor_category_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorCategoryType { get; set; }

        /// <summary>
        /// 是否显示高可用只读类型
        /// </summary>
        [SDKProperty("is_rha_flavor", IsQuery = true)]
        [JsonProperty("is_rha_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRhaFlavor { get; set; }

        /// <summary>
        /// 索引位置，偏移量。 从第一条数据偏移offset条数据后开始查询，默认为0。 取值必须为数字，且不能为负数。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询个数上限值。 取值范围：1~100。 不传该参数时，默认查询前100条信息。
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
            sb.Append("class ListEngineFlavorsRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  availabilityZoneIds: ").Append(AvailabilityZoneIds).Append("\n");
            sb.Append("  haMode: ").Append(HaMode).Append("\n");
            sb.Append("  specCodeLike: ").Append(SpecCodeLike).Append("\n");
            sb.Append("  flavorCategoryType: ").Append(FlavorCategoryType).Append("\n");
            sb.Append("  isRhaFlavor: ").Append(IsRhaFlavor).Append("\n");
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
            return this.Equals(input as ListEngineFlavorsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEngineFlavorsRequest input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.AvailabilityZoneIds != input.AvailabilityZoneIds || (this.AvailabilityZoneIds != null && !this.AvailabilityZoneIds.Equals(input.AvailabilityZoneIds))) return false;
            if (this.HaMode != input.HaMode || (this.HaMode != null && !this.HaMode.Equals(input.HaMode))) return false;
            if (this.SpecCodeLike != input.SpecCodeLike || (this.SpecCodeLike != null && !this.SpecCodeLike.Equals(input.SpecCodeLike))) return false;
            if (this.FlavorCategoryType != input.FlavorCategoryType || (this.FlavorCategoryType != null && !this.FlavorCategoryType.Equals(input.FlavorCategoryType))) return false;
            if (this.IsRhaFlavor != input.IsRhaFlavor || (this.IsRhaFlavor != null && !this.IsRhaFlavor.Equals(input.IsRhaFlavor))) return false;
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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.AvailabilityZoneIds != null) hashCode = hashCode * 59 + this.AvailabilityZoneIds.GetHashCode();
                if (this.HaMode != null) hashCode = hashCode * 59 + this.HaMode.GetHashCode();
                if (this.SpecCodeLike != null) hashCode = hashCode * 59 + this.SpecCodeLike.GetHashCode();
                if (this.FlavorCategoryType != null) hashCode = hashCode * 59 + this.FlavorCategoryType.GetHashCode();
                if (this.IsRhaFlavor != null) hashCode = hashCode * 59 + this.IsRhaFlavor.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
