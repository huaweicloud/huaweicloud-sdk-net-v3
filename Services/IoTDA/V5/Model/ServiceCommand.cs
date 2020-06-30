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
    /// 命令服务对象。
    /// </summary>
    public class ServiceCommand 
    {

        /// <summary>
        /// 设备命令名称。
        /// </summary>
        [JsonProperty("command_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CommandName { get; set; }

        /// <summary>
        /// 设备命令的参数列表。
        /// </summary>
        [JsonProperty("paras", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServiceCommandPara> Paras { get; set; }

        /// <summary>
        /// 设备命令的响应列表。
        /// </summary>
        [JsonProperty("responses", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServiceCommandResponse> Responses { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceCommand {\n");
            sb.Append("  commandName: ").Append(CommandName).Append("\n");
            sb.Append("  paras: ").Append(Paras).Append("\n");
            sb.Append("  responses: ").Append(Responses).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceCommand);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServiceCommand input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CommandName == input.CommandName ||
                    (this.CommandName != null &&
                    this.CommandName.Equals(input.CommandName))
                ) && 
                (
                    this.Paras == input.Paras ||
                    this.Paras != null &&
                    input.Paras != null &&
                    this.Paras.SequenceEqual(input.Paras)
                ) && 
                (
                    this.Responses == input.Responses ||
                    this.Responses != null &&
                    input.Responses != null &&
                    this.Responses.SequenceEqual(input.Responses)
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
                if (this.CommandName != null)
                    hashCode = hashCode * 59 + this.CommandName.GetHashCode();
                if (this.Paras != null)
                    hashCode = hashCode * 59 + this.Paras.GetHashCode();
                if (this.Responses != null)
                    hashCode = hashCode * 59 + this.Responses.GetHashCode();
                return hashCode;
            }
        }
    }
}
