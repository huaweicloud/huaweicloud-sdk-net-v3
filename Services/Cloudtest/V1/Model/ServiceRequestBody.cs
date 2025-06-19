using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 新测试类型服务信息
    /// </summary>
    public class ServiceRequestBody 
    {

        /// <summary>
        /// 测试类型名称，用于界面显示，不能使用当前保留名，长度小于等于16位字符
        /// </summary>
        [JsonProperty("service_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceName { get; set; }

        /// <summary>
        /// server_host是由用户提供的域名。 我们会通过此域名进行接口调用，请以https/http开头,长度小于等于128位字符。 TestHub将会通过此域名下的接口，保证服务数据与用户系统数据的一致性。
        /// </summary>
        [JsonProperty("server_host", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerHost { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceRequestBody {\n");
            sb.Append("  serviceName: ").Append(ServiceName).Append("\n");
            sb.Append("  serverHost: ").Append(ServerHost).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServiceRequestBody input)
        {
            if (input == null) return false;
            if (this.ServiceName != input.ServiceName || (this.ServiceName != null && !this.ServiceName.Equals(input.ServiceName))) return false;
            if (this.ServerHost != input.ServerHost || (this.ServerHost != null && !this.ServerHost.Equals(input.ServerHost))) return false;

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
                if (this.ServiceName != null) hashCode = hashCode * 59 + this.ServiceName.GetHashCode();
                if (this.ServerHost != null) hashCode = hashCode * 59 + this.ServerHost.GetHashCode();
                return hashCode;
            }
        }
    }
}
