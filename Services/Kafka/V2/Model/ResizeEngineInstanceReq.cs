using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 实例规格变更请求体。
    /// </summary>
    public class ResizeEngineInstanceReq 
    {

        /// <summary>
        /// 变更类型。  取值范围：   - storage：存储空间扩容，代理数量不变。    - horizontal：代理数量扩容，每个broker的存储空间不变。    [- vertical：垂直扩容，broker的底层虚机规格变更，代理数量和存储空间不变。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm,dt,fcs,sbc,hk_sbc,hcs,ax,srg)
        /// </summary>
        [JsonProperty("oper_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperType { get; set; }

        /// <summary>
        /// 扩容后的存储空间。注意：磁盘容量仅支持设置为100的整数倍。  实例存储空间 &#x3D; 代理数量 * 每个broker的存储空间。  当oper_type类型是storage或horizontal时，该参数有效且必填。    - 当oper_type类型是storage时，代理数量不变，每个broker存储空间最少扩容100GB。    - 当oper_type类型是horizontal时，每个broker的存储空间不变。
        /// </summary>
        [JsonProperty("new_storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewStorageSpace { get; set; }

        /// <summary>
        /// 当oper_type参数为horizontal时，该参数有效。  [取值范围：最多支持50个broker。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,sbc,hk_sbc,g42,hk_g42,tm,hk_tm,ax)
        /// </summary>
        [JsonProperty("new_broker_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewBrokerNum { get; set; }

        /// <summary>
        /// 垂直扩容时的新产品ID。  当oper_type类型是vertical时，该参数才有效且必填。  产品ID可以从[查询产品规格列表](ListEngineProducts.xml)获取。
        /// </summary>
        [JsonProperty("new_product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NewProductId { get; set; }

        /// <summary>
        /// 实例绑定的弹性IP地址的ID。[获取方法：参考[[《弹性公网IP API参考》](https://support.huaweicloud.com/api-eip/ListPublicipsV3.html)](tag:hws)[[《弹性公网IP API参考》](https://support.huaweicloud.com/intl/zh-cn/api-eip/ListPublicipsV3.html)](tag:hws_hk)[[《弹性公网IP API参考》](https://support.huaweicloud.com/eu/api-eip/ListPublicipsV3.html)](tag:hws_eu)[《弹性公网IP API参考》](tag:ax,cmcc,ctc,sbc,hk_sbc,g42,hk_g42,srg,dt,ocb,hws_ocb,hcs,fcs)，调用“查询弹性公网IP列表”接口，从响应体中获取弹性公网IP的ID。](tag:ax,cmcc,ctc,sbc,hk_sbc,g42,hk_g42,srg,dt,ocb,hws_ocb,hcs,fcs,hws,hws_hk,hws_eu)  以英文逗号隔开多个弹性IP地址的ID。  当oper_type类型是horizontal时，该参数必填。
        /// </summary>
        [JsonProperty("publicip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipId { get; set; }

        /// <summary>
        /// 指定的内网IP地址，仅支持指定IPv4。  指定的IP数量只能小于等于新增节点数量。  当指定IP小于节点数量时，未指定的节点随机分配内网IP地址。
        /// </summary>
        [JsonProperty("tenant_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TenantIps { get; set; }

        /// <summary>
        /// 实例扩容时新节点使用备用子网的id。  当实例扩容使用备用子网，则传入此值。  需要联系客服添加白名单才能传入此值。
        /// </summary>
        [JsonProperty("second_tenant_subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecondTenantSubnetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResizeEngineInstanceReq {\n");
            sb.Append("  operType: ").Append(OperType).Append("\n");
            sb.Append("  newStorageSpace: ").Append(NewStorageSpace).Append("\n");
            sb.Append("  newBrokerNum: ").Append(NewBrokerNum).Append("\n");
            sb.Append("  newProductId: ").Append(NewProductId).Append("\n");
            sb.Append("  publicipId: ").Append(PublicipId).Append("\n");
            sb.Append("  tenantIps: ").Append(TenantIps).Append("\n");
            sb.Append("  secondTenantSubnetId: ").Append(SecondTenantSubnetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResizeEngineInstanceReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResizeEngineInstanceReq input)
        {
            if (input == null) return false;
            if (this.OperType != input.OperType || (this.OperType != null && !this.OperType.Equals(input.OperType))) return false;
            if (this.NewStorageSpace != input.NewStorageSpace || (this.NewStorageSpace != null && !this.NewStorageSpace.Equals(input.NewStorageSpace))) return false;
            if (this.NewBrokerNum != input.NewBrokerNum || (this.NewBrokerNum != null && !this.NewBrokerNum.Equals(input.NewBrokerNum))) return false;
            if (this.NewProductId != input.NewProductId || (this.NewProductId != null && !this.NewProductId.Equals(input.NewProductId))) return false;
            if (this.PublicipId != input.PublicipId || (this.PublicipId != null && !this.PublicipId.Equals(input.PublicipId))) return false;
            if (this.TenantIps != input.TenantIps || (this.TenantIps != null && input.TenantIps != null && !this.TenantIps.SequenceEqual(input.TenantIps))) return false;
            if (this.SecondTenantSubnetId != input.SecondTenantSubnetId || (this.SecondTenantSubnetId != null && !this.SecondTenantSubnetId.Equals(input.SecondTenantSubnetId))) return false;

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
                if (this.OperType != null) hashCode = hashCode * 59 + this.OperType.GetHashCode();
                if (this.NewStorageSpace != null) hashCode = hashCode * 59 + this.NewStorageSpace.GetHashCode();
                if (this.NewBrokerNum != null) hashCode = hashCode * 59 + this.NewBrokerNum.GetHashCode();
                if (this.NewProductId != null) hashCode = hashCode * 59 + this.NewProductId.GetHashCode();
                if (this.PublicipId != null) hashCode = hashCode * 59 + this.PublicipId.GetHashCode();
                if (this.TenantIps != null) hashCode = hashCode * 59 + this.TenantIps.GetHashCode();
                if (this.SecondTenantSubnetId != null) hashCode = hashCode * 59 + this.SecondTenantSubnetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
