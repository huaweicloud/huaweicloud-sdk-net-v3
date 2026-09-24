using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResourceSpecsPriceQueryReq 
    {

        /// <summary>
        /// 云服务类型编码，非必填，范围1-64，此参数不携带或携带值为null时，不作为筛选条件。
        /// </summary>
        [JsonProperty("cloud_service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceType { get; set; }

        /// <summary>
        /// 资源类型编码，非必填，范围1-64，此参数不携带或携带值为null时，不作为筛选条件。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 区域编码，必填，范围1-64。
        /// </summary>
        [JsonProperty("region_code", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionCode { get; set; }

        /// <summary>
        /// 过滤条件列表，非必填，最多1个。此参数不携带或携带值为空列表或携带值为null时，不作为筛选条件。
        /// </summary>
        [JsonProperty("filters", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceSpecsPriceFilter> Filters { get; set; }

        /// <summary>
        /// 是否返回资源规格属性信息，非必填，false：不返回（默认）true：返回
        /// </summary>
        [JsonProperty("need_attributes", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NeedAttributes { get; set; }

        /// <summary>
        /// 是否返回资源规格官网定价信息，非必填，false：不返回（默认）true：返回
        /// </summary>
        [JsonProperty("need_price", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NeedPrice { get; set; }

        /// <summary>
        /// 翻页信息，非必填，首页查询不携带此参数或携带值为null，非首页查询传入上一页响应返回的next_marker
        /// </summary>
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 查询条数，非必填，取值范围1-50，默认值50
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceSpecsPriceQueryReq {\n");
            sb.Append("  cloudServiceType: ").Append(CloudServiceType).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  regionCode: ").Append(RegionCode).Append("\n");
            sb.Append("  filters: ").Append(Filters).Append("\n");
            sb.Append("  needAttributes: ").Append(NeedAttributes).Append("\n");
            sb.Append("  needPrice: ").Append(NeedPrice).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceSpecsPriceQueryReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceSpecsPriceQueryReq input)
        {
            if (input == null) return false;
            if (this.CloudServiceType != input.CloudServiceType || (this.CloudServiceType != null && !this.CloudServiceType.Equals(input.CloudServiceType))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.RegionCode != input.RegionCode || (this.RegionCode != null && !this.RegionCode.Equals(input.RegionCode))) return false;
            if (this.Filters != input.Filters || (this.Filters != null && input.Filters != null && !this.Filters.SequenceEqual(input.Filters))) return false;
            if (this.NeedAttributes != input.NeedAttributes || (this.NeedAttributes != null && !this.NeedAttributes.Equals(input.NeedAttributes))) return false;
            if (this.NeedPrice != input.NeedPrice || (this.NeedPrice != null && !this.NeedPrice.Equals(input.NeedPrice))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
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
                if (this.CloudServiceType != null) hashCode = hashCode * 59 + this.CloudServiceType.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.RegionCode != null) hashCode = hashCode * 59 + this.RegionCode.GetHashCode();
                if (this.Filters != null) hashCode = hashCode * 59 + this.Filters.GetHashCode();
                if (this.NeedAttributes != null) hashCode = hashCode * 59 + this.NeedAttributes.GetHashCode();
                if (this.NeedPrice != null) hashCode = hashCode * 59 + this.NeedPrice.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
