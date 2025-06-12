using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 下单请求体
    /// </summary>
    public class CreateMetaStudioOrdersReq 
    {

        /// <summary>
        /// 云服务信息列表
        /// </summary>
        [JsonProperty("cloud_services", NullValueHandling = NullValueHandling.Ignore)]
        public List<PublicCloudServiceOrder> CloudServices { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateMetaStudioOrdersReq {\n");
            sb.Append("  cloudServices: ").Append(CloudServices).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateMetaStudioOrdersReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateMetaStudioOrdersReq input)
        {
            if (input == null) return false;
            if (this.CloudServices != input.CloudServices || (this.CloudServices != null && input.CloudServices != null && !this.CloudServices.SequenceEqual(input.CloudServices))) return false;

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
                if (this.CloudServices != null) hashCode = hashCode * 59 + this.CloudServices.GetHashCode();
                return hashCode;
            }
        }
    }
}
