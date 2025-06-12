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
    /// 
    /// </summary>
    public class ResizeInstanceReq 
    {

        /// <summary>
        /// 规格变更后的规格ID。 若只扩展磁盘大小，则规格ID保持和原实例不变。
        /// </summary>
        [JsonProperty("new_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string NewSpecCode { get; set; }

        /// <summary>
        /// 规格变更后的消息存储空间，单位：GB。 若扩展实例基准带宽，则new_storage_space不能低于基准带宽规定的最小磁盘大小。
        /// </summary>
        [JsonProperty("new_storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewStorageSpace { get; set; }

        /// <summary>
        /// 扩容类型， 新规格支持扩容类型：\&quot;horizontal\&quot;、\&quot;vertical\&quot;、\&quot;node\&quot;、\&quot;storage\&quot;四种类型。
        /// </summary>
        [JsonProperty("oper_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperType { get; set; }

        /// <summary>
        /// 扩容后集群节点数。
        /// </summary>
        [JsonProperty("new_broker_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewBrokerNum { get; set; }

        /// <summary>
        /// 新规格变更后的产品ID。 涉及垂直扩容场景，需指定该项。 产品ID可以从[查询产品规格列表](ListEngineProducts.xml)获取。
        /// </summary>
        [JsonProperty("new_product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NewProductId { get; set; }

        /// <summary>
        /// 实例绑定的弹性IP地址的ID。 以英文逗号隔开多个弹性IP地址的ID。 如果开启了公网再进行扩容，需要填写此参数。
        /// </summary>
        [JsonProperty("publicip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipId { get; set; }

        /// <summary>
        /// 创建节点可以手动指定实例节点的内网IP地址，仅支持指定IPv4地址。  指定内网地址数量必须小于等于购买的节点数量。  当小于购买的节点数量时，未指定的节点则随机分配。
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
            sb.Append("class ResizeInstanceReq {\n");
            sb.Append("  newSpecCode: ").Append(NewSpecCode).Append("\n");
            sb.Append("  newStorageSpace: ").Append(NewStorageSpace).Append("\n");
            sb.Append("  operType: ").Append(OperType).Append("\n");
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
            return this.Equals(input as ResizeInstanceReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResizeInstanceReq input)
        {
            if (input == null) return false;
            if (this.NewSpecCode != input.NewSpecCode || (this.NewSpecCode != null && !this.NewSpecCode.Equals(input.NewSpecCode))) return false;
            if (this.NewStorageSpace != input.NewStorageSpace || (this.NewStorageSpace != null && !this.NewStorageSpace.Equals(input.NewStorageSpace))) return false;
            if (this.OperType != input.OperType || (this.OperType != null && !this.OperType.Equals(input.OperType))) return false;
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
                if (this.NewSpecCode != null) hashCode = hashCode * 59 + this.NewSpecCode.GetHashCode();
                if (this.NewStorageSpace != null) hashCode = hashCode * 59 + this.NewStorageSpace.GetHashCode();
                if (this.OperType != null) hashCode = hashCode * 59 + this.OperType.GetHashCode();
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
