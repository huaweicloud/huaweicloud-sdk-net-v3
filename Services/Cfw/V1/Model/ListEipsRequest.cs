using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListEipsRequest 
    {

        /// <summary>
        /// 防护对象id，是创建云防火墙后用于区分互联网边界防护和VPC边界防护的标志id，可通过调用[查询防火墙实例接口](ListFirewallDetail.xml)获得，通过返回值中的data.records.protect_objects.object_id（.表示各对象之间层级的区分）获得，type为0时，object_id为互联网边界防护对象ID，type为1时，object_id为VPC边界防护对象ID。此处仅取type为0的防护对象id，可通过data.records.protect_objects.type（.表示各对象之间层级的区分）获得。
        /// </summary>
        [SDKProperty("object_id", IsQuery = true)]
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// 查询防护EIP列表关键字，可选用弹性公网ID和弹性公网IP
        /// </summary>
        [SDKProperty("key_word", IsQuery = true)]
        [JsonProperty("key_word", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyWord { get; set; }

        /// <summary>
        /// 防护状态 null-全部 0-开启防护 1-关闭防护
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 是否同步租户EIP数据 0-不同步 1-同步
        /// </summary>
        [SDKProperty("sync", IsQuery = true)]
        [JsonProperty("sync", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sync { get; set; }

        /// <summary>
        /// 每页显示个数，范围为1-1024
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 偏移量：指定返回记录的开始位置，必须为数字，取值范围为大于或等于0，默认0
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 企业项目ID，用户根据组织规划企业项目，对应的ID为企业项目ID，可通过[如何获取企业项目ID](cfw_02_0027.xml)获取，用户未开启企业项目时为0
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 设备关键字，是eip绑定的资产的名称或id，可通过EIP服务的查询弹性公网IP列表接口获取，通过返回值中的publicips.id（.表示各对象之间层级的区分）获得
        /// </summary>
        [SDKProperty("device_key", IsQuery = true)]
        [JsonProperty("device_key", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceKey { get; set; }

        /// <summary>
        /// 地址类型0 ipv4，1 ipv6
        /// </summary>
        [SDKProperty("address_type", IsQuery = true)]
        [JsonProperty("address_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AddressType { get; set; }

        /// <summary>
        /// 防火墙ID，可通过[防火墙ID获取方式](cfw_02_0028.xml)获取
        /// </summary>
        [SDKProperty("fw_instance_id", IsQuery = true)]
        [JsonProperty("fw_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FwInstanceId { get; set; }

        /// <summary>
        /// 防火墙关键字，可使用防火墙ID或名称查询，可通过[防火墙ID获取方式](cfw_02_0028.xml)
        /// </summary>
        [SDKProperty("fw_key_word", IsQuery = true)]
        [JsonProperty("fw_key_word", NullValueHandling = NullValueHandling.Ignore)]
        public string FwKeyWord { get; set; }

        /// <summary>
        /// 弹性公网ip的企业项目id，可通过[如何获取企业项目ID](cfw_02_0027.xml)获取，租户未开启企业项目时为0
        /// </summary>
        [SDKProperty("eps_id", IsQuery = true)]
        [JsonProperty("eps_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EpsId { get; set; }

        /// <summary>
        /// 标签列表信息可通过查询EIP服务界面列表标签页签获得
        /// </summary>
        [SDKProperty("tags", IsQuery = true)]
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEipsRequest {\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  keyWord: ").Append(KeyWord).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  sync: ").Append(Sync).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  deviceKey: ").Append(DeviceKey).Append("\n");
            sb.Append("  addressType: ").Append(AddressType).Append("\n");
            sb.Append("  fwInstanceId: ").Append(FwInstanceId).Append("\n");
            sb.Append("  fwKeyWord: ").Append(FwKeyWord).Append("\n");
            sb.Append("  epsId: ").Append(EpsId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEipsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEipsRequest input)
        {
            if (input == null) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;
            if (this.KeyWord != input.KeyWord || (this.KeyWord != null && !this.KeyWord.Equals(input.KeyWord))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Sync != input.Sync || (this.Sync != null && !this.Sync.Equals(input.Sync))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.DeviceKey != input.DeviceKey || (this.DeviceKey != null && !this.DeviceKey.Equals(input.DeviceKey))) return false;
            if (this.AddressType != input.AddressType || (this.AddressType != null && !this.AddressType.Equals(input.AddressType))) return false;
            if (this.FwInstanceId != input.FwInstanceId || (this.FwInstanceId != null && !this.FwInstanceId.Equals(input.FwInstanceId))) return false;
            if (this.FwKeyWord != input.FwKeyWord || (this.FwKeyWord != null && !this.FwKeyWord.Equals(input.FwKeyWord))) return false;
            if (this.EpsId != input.EpsId || (this.EpsId != null && !this.EpsId.Equals(input.EpsId))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && !this.Tags.Equals(input.Tags))) return false;

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
                if (this.ObjectId != null) hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.KeyWord != null) hashCode = hashCode * 59 + this.KeyWord.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Sync != null) hashCode = hashCode * 59 + this.Sync.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.DeviceKey != null) hashCode = hashCode * 59 + this.DeviceKey.GetHashCode();
                if (this.AddressType != null) hashCode = hashCode * 59 + this.AddressType.GetHashCode();
                if (this.FwInstanceId != null) hashCode = hashCode * 59 + this.FwInstanceId.GetHashCode();
                if (this.FwKeyWord != null) hashCode = hashCode * 59 + this.FwKeyWord.GetHashCode();
                if (this.EpsId != null) hashCode = hashCode * 59 + this.EpsId.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
