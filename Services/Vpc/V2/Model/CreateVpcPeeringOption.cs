using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// peering对象
    /// </summary>
    public class CreateVpcPeeringOption 
    {

        /// <summary>
        /// 功能说明：对等连接名称 取值范围：支持1~64个字符
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 功能说明：对等连接的描述 取值范围：0-255个字符，不能包含“&lt;”和“&gt;”。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("request_vpc_info", NullValueHandling = NullValueHandling.Ignore)]
        public VpcInfo RequestVpcInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("accept_vpc_info", NullValueHandling = NullValueHandling.Ignore)]
        public VpcInfo AcceptVpcInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateVpcPeeringOption {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  requestVpcInfo: ").Append(RequestVpcInfo).Append("\n");
            sb.Append("  acceptVpcInfo: ").Append(AcceptVpcInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateVpcPeeringOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateVpcPeeringOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.RequestVpcInfo == input.RequestVpcInfo ||
                    (this.RequestVpcInfo != null &&
                    this.RequestVpcInfo.Equals(input.RequestVpcInfo))
                ) && 
                (
                    this.AcceptVpcInfo == input.AcceptVpcInfo ||
                    (this.AcceptVpcInfo != null &&
                    this.AcceptVpcInfo.Equals(input.AcceptVpcInfo))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.RequestVpcInfo != null)
                    hashCode = hashCode * 59 + this.RequestVpcInfo.GetHashCode();
                if (this.AcceptVpcInfo != null)
                    hashCode = hashCode * 59 + this.AcceptVpcInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
