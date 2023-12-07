using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListGaussMySqlInstancesUnifyStatusRequest 
    {

        /// <summary>
        /// 请求语言类型。默认en-us。 取值范围： - en-us - zh-cn
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }

        /// <summary>
        /// 实例ID。 “\\*”为系统保留字符，如果id是以“\\*”起始，表示按照“\\*”后面的值模糊匹配，否则，按照id精确匹配查询。不能只传入“\\*”。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 实例名称。  “\\*”为系统保留字符，如果name是以“\\*”起始，表示按照“\\*”后面的值模糊匹配，否则，按照name精确匹配查询。不能只传入“\\*”。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 按照实例类型查询。目前仅支持Cluster。
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 数据库类型，现在只支持gaussdb-mysql。
        /// </summary>
        [SDKProperty("datastore_type", IsQuery = true)]
        [JsonProperty("datastore_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DatastoreType { get; set; }

        /// <summary>
        /// 虚拟私有云ID。
        /// </summary>
        [SDKProperty("vpc_id", IsQuery = true)]
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 子网的网络ID信息。
        /// </summary>
        [SDKProperty("subnet_id", IsQuery = true)]
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 读写内网IP地址。
        /// </summary>
        [SDKProperty("private_ip", IsQuery = true)]
        [JsonProperty("private_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateIp { get; set; }

        /// <summary>
        /// 读内网IP地址。
        /// </summary>
        [SDKProperty("readonly_private_ip", IsQuery = true)]
        [JsonProperty("readonly_private_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ReadonlyPrivateIp { get; set; }

        /// <summary>
        /// 读写分离IP地址。
        /// </summary>
        [SDKProperty("proxy_ip", IsQuery = true)]
        [JsonProperty("proxy_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyIp { get; set; }

        /// <summary>
        /// 索引位置，偏移量。从第一条数据偏移offset条数据后开始查询，默认为0（偏移0条数据，表示从第一条数据开始查询），必须为数字，不能为负数。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询记录数。默认为100，不能为负数，最小值为1，最大值为100。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 根据实例标签键值对进行查询。 - {key}表示标签键。 - {value}表示标签值。  如果同时使用多个标签键值对进行查询，中间使用逗号分隔开，表示查询同时包含指定标签键值对的实例。key不能重复，key之间是与的关系。
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
            sb.Append("class ListGaussMySqlInstancesUnifyStatusRequest {\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  datastoreType: ").Append(DatastoreType).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  privateIp: ").Append(PrivateIp).Append("\n");
            sb.Append("  readonlyPrivateIp: ").Append(ReadonlyPrivateIp).Append("\n");
            sb.Append("  proxyIp: ").Append(ProxyIp).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListGaussMySqlInstancesUnifyStatusRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListGaussMySqlInstancesUnifyStatusRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.XLanguage == input.XLanguage ||
                    (this.XLanguage != null &&
                    this.XLanguage.Equals(input.XLanguage))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.DatastoreType == input.DatastoreType ||
                    (this.DatastoreType != null &&
                    this.DatastoreType.Equals(input.DatastoreType))
                ) && 
                (
                    this.VpcId == input.VpcId ||
                    (this.VpcId != null &&
                    this.VpcId.Equals(input.VpcId))
                ) && 
                (
                    this.SubnetId == input.SubnetId ||
                    (this.SubnetId != null &&
                    this.SubnetId.Equals(input.SubnetId))
                ) && 
                (
                    this.PrivateIp == input.PrivateIp ||
                    (this.PrivateIp != null &&
                    this.PrivateIp.Equals(input.PrivateIp))
                ) && 
                (
                    this.ReadonlyPrivateIp == input.ReadonlyPrivateIp ||
                    (this.ReadonlyPrivateIp != null &&
                    this.ReadonlyPrivateIp.Equals(input.ReadonlyPrivateIp))
                ) && 
                (
                    this.ProxyIp == input.ProxyIp ||
                    (this.ProxyIp != null &&
                    this.ProxyIp.Equals(input.ProxyIp))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
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
                if (this.XLanguage != null)
                    hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DatastoreType != null)
                    hashCode = hashCode * 59 + this.DatastoreType.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetId != null)
                    hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.PrivateIp != null)
                    hashCode = hashCode * 59 + this.PrivateIp.GetHashCode();
                if (this.ReadonlyPrivateIp != null)
                    hashCode = hashCode * 59 + this.ReadonlyPrivateIp.GetHashCode();
                if (this.ProxyIp != null)
                    hashCode = hashCode * 59 + this.ProxyIp.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
