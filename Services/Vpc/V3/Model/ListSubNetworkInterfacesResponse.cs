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
    /// Response Object
    /// </summary>
    public class ListSubNetworkInterfacesResponse : SdkResponse
    {

        /// <summary>
        /// 1、功能说明：请求ID 2、取值范围：标准UUID 3、约束：N/A 4、默认值：N/A 5、权限：N/A
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// 1、功能说明：辅助弹性网卡查询对象 2、取值范围：N/A 3、约束：N/A 4、默认值：N/A 5、权限：N/A
        /// </summary>
        [JsonProperty("sub_network_interfaces", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubNetworkInterface> SubNetworkInterfaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfo PageInfo { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSubNetworkInterfacesResponse {\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  subNetworkInterfaces: ").Append(SubNetworkInterfaces).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSubNetworkInterfacesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSubNetworkInterfacesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.SubNetworkInterfaces == input.SubNetworkInterfaces ||
                    this.SubNetworkInterfaces != null &&
                    input.SubNetworkInterfaces != null &&
                    this.SubNetworkInterfaces.SequenceEqual(input.SubNetworkInterfaces)
                ) && 
                (
                    this.PageInfo == input.PageInfo ||
                    (this.PageInfo != null &&
                    this.PageInfo.Equals(input.PageInfo))
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
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.SubNetworkInterfaces != null)
                    hashCode = hashCode * 59 + this.SubNetworkInterfaces.GetHashCode();
                if (this.PageInfo != null)
                    hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
