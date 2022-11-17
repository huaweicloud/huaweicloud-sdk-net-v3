using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListSubNetworkInterfacesRequest 
    {

        /// <summary>
        /// 功能说明：每页返回的个数 取值范围：0-2000
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页查询起始的资源ID，为空时查询第一页
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 功能说明：辅助弹性网卡ID，支持多ID过滤 使用场景：查询需要的多个辅助弹性网卡信息
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// 功能说明：辅助弹性网卡所属虚拟子网的ID，支持多个ID过滤 使用场景：过滤需要的单个或者多个虚拟子网下的辅助弹性网卡
        /// </summary>
        [SDKProperty("virsubnet_id", IsQuery = true)]
        [JsonProperty("virsubnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VirsubnetId { get; set; }

        /// <summary>
        /// 功能说明：辅助弹性网卡的私有IPv4地址，支持多个地址同时过滤 使用场景：通过单个或者多个ip地址过滤查询辅助弹性网卡
        /// </summary>
        [SDKProperty("private_ip_address", IsQuery = true)]
        [JsonProperty("private_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PrivateIpAddress { get; set; }

        /// <summary>
        /// 功能说明：辅助弹性网卡的mac地址，支持多个同时过滤 使用场景：使用mac地址精确过滤辅助弹性网卡
        /// </summary>
        [SDKProperty("mac_address", IsQuery = true)]
        [JsonProperty("mac_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MacAddress { get; set; }

        /// <summary>
        /// 功能说明：辅助弹性网卡所属的VPC_ID，支持多ID过滤 使用场景：过滤单个或多个VPC下的辅助弹性网卡信息
        /// </summary>
        [SDKProperty("vpc_id", IsQuery = true)]
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VpcId { get; set; }

        /// <summary>
        /// 功能说明：辅助弹性网卡的描述信息，支持多个同时过滤 使用场景：通过描述信息过滤辅助弹性网卡
        /// </summary>
        [SDKProperty("description", IsQuery = true)]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Description { get; set; }

        /// <summary>
        /// 功能说明：辅助弹性网卡的宿主网卡的ID，支持多ID过滤 使用场景：过滤单个或多个宿主网卡下存在的辅助弹性网卡
        /// </summary>
        [SDKProperty("parent_id", IsQuery = true)]
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ParentId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSubNetworkInterfacesRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  virsubnetId: ").Append(VirsubnetId).Append("\n");
            sb.Append("  privateIpAddress: ").Append(PrivateIpAddress).Append("\n");
            sb.Append("  macAddress: ").Append(MacAddress).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSubNetworkInterfacesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSubNetworkInterfacesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id != null &&
                    input.Id != null &&
                    this.Id.SequenceEqual(input.Id)
                ) && 
                (
                    this.VirsubnetId == input.VirsubnetId ||
                    this.VirsubnetId != null &&
                    input.VirsubnetId != null &&
                    this.VirsubnetId.SequenceEqual(input.VirsubnetId)
                ) && 
                (
                    this.PrivateIpAddress == input.PrivateIpAddress ||
                    this.PrivateIpAddress != null &&
                    input.PrivateIpAddress != null &&
                    this.PrivateIpAddress.SequenceEqual(input.PrivateIpAddress)
                ) && 
                (
                    this.MacAddress == input.MacAddress ||
                    this.MacAddress != null &&
                    input.MacAddress != null &&
                    this.MacAddress.SequenceEqual(input.MacAddress)
                ) && 
                (
                    this.VpcId == input.VpcId ||
                    this.VpcId != null &&
                    input.VpcId != null &&
                    this.VpcId.SequenceEqual(input.VpcId)
                ) && 
                (
                    this.Description == input.Description ||
                    this.Description != null &&
                    input.Description != null &&
                    this.Description.SequenceEqual(input.Description)
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    this.ParentId != null &&
                    input.ParentId != null &&
                    this.ParentId.SequenceEqual(input.ParentId)
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
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.VirsubnetId != null)
                    hashCode = hashCode * 59 + this.VirsubnetId.GetHashCode();
                if (this.PrivateIpAddress != null)
                    hashCode = hashCode * 59 + this.PrivateIpAddress.GetHashCode();
                if (this.MacAddress != null)
                    hashCode = hashCode * 59 + this.MacAddress.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                return hashCode;
            }
        }
    }
}
