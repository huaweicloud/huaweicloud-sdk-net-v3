using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 更新云连接实例的请求体。
    /// </summary>
    public class UpdateCloudConnectionRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cloud_connection", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateCloudConnection CloudConnection { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCloudConnectionRequestBody {\n");
            sb.Append("  cloudConnection: ").Append(CloudConnection).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateCloudConnectionRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateCloudConnectionRequestBody input)
        {
            if (input == null) return false;
            if (this.CloudConnection != input.CloudConnection || (this.CloudConnection != null && !this.CloudConnection.Equals(input.CloudConnection))) return false;

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
                if (this.CloudConnection != null) hashCode = hashCode * 59 + this.CloudConnection.GetHashCode();
                return hashCode;
            }
        }
    }
}
