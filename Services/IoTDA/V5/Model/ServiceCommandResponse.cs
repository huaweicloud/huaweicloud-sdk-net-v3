using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 命令参数响应对象。
    /// </summary>
    public class ServiceCommandResponse 
    {

        /// <summary>
        /// 设备命令响应名称。
        /// </summary>
        [JsonProperty("response_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResponseName { get; set; }

        /// <summary>
        /// 设备命令响应的参数列表。
        /// </summary>
        [JsonProperty("paras", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServiceCommandPara> Paras { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceCommandResponse {\n");
            sb.Append("  responseName: ").Append(ResponseName).Append("\n");
            sb.Append("  paras: ").Append(Paras).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceCommandResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServiceCommandResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResponseName == input.ResponseName ||
                    (this.ResponseName != null &&
                    this.ResponseName.Equals(input.ResponseName))
                ) && 
                (
                    this.Paras == input.Paras ||
                    this.Paras != null &&
                    input.Paras != null &&
                    this.Paras.SequenceEqual(input.Paras)
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
                if (this.ResponseName != null)
                    hashCode = hashCode * 59 + this.ResponseName.GetHashCode();
                if (this.Paras != null)
                    hashCode = hashCode * 59 + this.Paras.GetHashCode();
                return hashCode;
            }
        }
    }
}
