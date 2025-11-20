using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ProductSpecData 
    {

        /// <summary>
        /// 产品规格UUID
        /// </summary>
        [JsonProperty("product_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductUuid { get; set; }

        /// <summary>
        /// 套餐线路
        /// </summary>
        [JsonProperty("isp_spec", NullValueHandling = NullValueHandling.Ignore)]
        public string IspSpec { get; set; }

        /// <summary>
        /// 机房
        /// </summary>
        [JsonProperty("data_center", NullValueHandling = NullValueHandling.Ignore)]
        public string DataCenter { get; set; }

        /// <summary>
        /// 产品规格类型
        /// </summary>
        [JsonProperty("spec_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? SpecType { get; set; }

        /// <summary>
        /// 保底带宽值
        /// </summary>
        [JsonProperty("basic_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? BasicBandwidth { get; set; }

        /// <summary>
        /// 弹性带宽值
        /// </summary>
        [JsonProperty("elastic_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? ElasticBandwidth { get; set; }

        /// <summary>
        /// 业务带宽值
        /// </summary>
        [JsonProperty("service_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceBandwidth { get; set; }

        /// <summary>
        /// 端口数
        /// </summary>
        [JsonProperty("port_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PortNum { get; set; }

        /// <summary>
        /// 域名数
        /// </summary>
        [JsonProperty("bind_domain_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? BindDomainNum { get; set; }

        /// <summary>
        /// 弹性业务带宽值
        /// </summary>
        [JsonProperty("elastic_service_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? ElasticServiceBandwidth { get; set; }

        /// <summary>
        /// 弹性业务带宽类型
        /// </summary>
        [JsonProperty("elastic_service_bandwidth_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ElasticServiceBandwidthType { get; set; }

        /// <summary>
        /// 主资源类型
        /// </summary>
        [JsonProperty("main_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MainResourceType { get; set; }

        /// <summary>
        /// 主资源规格编码
        /// </summary>
        [JsonProperty("main_resource_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string MainResourceSpecCode { get; set; }

        /// <summary>
        /// 主资源产品id
        /// </summary>
        [JsonProperty("main_resource_product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MainResourceProductId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductSpecData {\n");
            sb.Append("  productUuid: ").Append(ProductUuid).Append("\n");
            sb.Append("  ispSpec: ").Append(IspSpec).Append("\n");
            sb.Append("  dataCenter: ").Append(DataCenter).Append("\n");
            sb.Append("  specType: ").Append(SpecType).Append("\n");
            sb.Append("  basicBandwidth: ").Append(BasicBandwidth).Append("\n");
            sb.Append("  elasticBandwidth: ").Append(ElasticBandwidth).Append("\n");
            sb.Append("  serviceBandwidth: ").Append(ServiceBandwidth).Append("\n");
            sb.Append("  portNum: ").Append(PortNum).Append("\n");
            sb.Append("  bindDomainNum: ").Append(BindDomainNum).Append("\n");
            sb.Append("  elasticServiceBandwidth: ").Append(ElasticServiceBandwidth).Append("\n");
            sb.Append("  elasticServiceBandwidthType: ").Append(ElasticServiceBandwidthType).Append("\n");
            sb.Append("  mainResourceType: ").Append(MainResourceType).Append("\n");
            sb.Append("  mainResourceSpecCode: ").Append(MainResourceSpecCode).Append("\n");
            sb.Append("  mainResourceProductId: ").Append(MainResourceProductId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProductSpecData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProductSpecData input)
        {
            if (input == null) return false;
            if (this.ProductUuid != input.ProductUuid || (this.ProductUuid != null && !this.ProductUuid.Equals(input.ProductUuid))) return false;
            if (this.IspSpec != input.IspSpec || (this.IspSpec != null && !this.IspSpec.Equals(input.IspSpec))) return false;
            if (this.DataCenter != input.DataCenter || (this.DataCenter != null && !this.DataCenter.Equals(input.DataCenter))) return false;
            if (this.SpecType != input.SpecType || (this.SpecType != null && !this.SpecType.Equals(input.SpecType))) return false;
            if (this.BasicBandwidth != input.BasicBandwidth || (this.BasicBandwidth != null && !this.BasicBandwidth.Equals(input.BasicBandwidth))) return false;
            if (this.ElasticBandwidth != input.ElasticBandwidth || (this.ElasticBandwidth != null && !this.ElasticBandwidth.Equals(input.ElasticBandwidth))) return false;
            if (this.ServiceBandwidth != input.ServiceBandwidth || (this.ServiceBandwidth != null && !this.ServiceBandwidth.Equals(input.ServiceBandwidth))) return false;
            if (this.PortNum != input.PortNum || (this.PortNum != null && !this.PortNum.Equals(input.PortNum))) return false;
            if (this.BindDomainNum != input.BindDomainNum || (this.BindDomainNum != null && !this.BindDomainNum.Equals(input.BindDomainNum))) return false;
            if (this.ElasticServiceBandwidth != input.ElasticServiceBandwidth || (this.ElasticServiceBandwidth != null && !this.ElasticServiceBandwidth.Equals(input.ElasticServiceBandwidth))) return false;
            if (this.ElasticServiceBandwidthType != input.ElasticServiceBandwidthType || (this.ElasticServiceBandwidthType != null && !this.ElasticServiceBandwidthType.Equals(input.ElasticServiceBandwidthType))) return false;
            if (this.MainResourceType != input.MainResourceType || (this.MainResourceType != null && !this.MainResourceType.Equals(input.MainResourceType))) return false;
            if (this.MainResourceSpecCode != input.MainResourceSpecCode || (this.MainResourceSpecCode != null && !this.MainResourceSpecCode.Equals(input.MainResourceSpecCode))) return false;
            if (this.MainResourceProductId != input.MainResourceProductId || (this.MainResourceProductId != null && !this.MainResourceProductId.Equals(input.MainResourceProductId))) return false;

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
                if (this.ProductUuid != null) hashCode = hashCode * 59 + this.ProductUuid.GetHashCode();
                if (this.IspSpec != null) hashCode = hashCode * 59 + this.IspSpec.GetHashCode();
                if (this.DataCenter != null) hashCode = hashCode * 59 + this.DataCenter.GetHashCode();
                if (this.SpecType != null) hashCode = hashCode * 59 + this.SpecType.GetHashCode();
                if (this.BasicBandwidth != null) hashCode = hashCode * 59 + this.BasicBandwidth.GetHashCode();
                if (this.ElasticBandwidth != null) hashCode = hashCode * 59 + this.ElasticBandwidth.GetHashCode();
                if (this.ServiceBandwidth != null) hashCode = hashCode * 59 + this.ServiceBandwidth.GetHashCode();
                if (this.PortNum != null) hashCode = hashCode * 59 + this.PortNum.GetHashCode();
                if (this.BindDomainNum != null) hashCode = hashCode * 59 + this.BindDomainNum.GetHashCode();
                if (this.ElasticServiceBandwidth != null) hashCode = hashCode * 59 + this.ElasticServiceBandwidth.GetHashCode();
                if (this.ElasticServiceBandwidthType != null) hashCode = hashCode * 59 + this.ElasticServiceBandwidthType.GetHashCode();
                if (this.MainResourceType != null) hashCode = hashCode * 59 + this.MainResourceType.GetHashCode();
                if (this.MainResourceSpecCode != null) hashCode = hashCode * 59 + this.MainResourceSpecCode.GetHashCode();
                if (this.MainResourceProductId != null) hashCode = hashCode * 59 + this.MainResourceProductId.GetHashCode();
                return hashCode;
            }
        }
    }
}
