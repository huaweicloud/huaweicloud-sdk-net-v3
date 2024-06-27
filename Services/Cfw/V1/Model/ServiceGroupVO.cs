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
    /// 
    /// </summary>
    public class ServiceGroupVO 
    {

        /// <summary>
        /// 服务组名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 协议列表
        /// </summary>
        [JsonProperty("protocols", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Protocols { get; set; }

        /// <summary>
        /// 服务组类型，0表示自定义服务组，1表示常用WEB服务，2表示常用远程登录和PING，3表示常用数据库
        /// </summary>
        [JsonProperty("service_set_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceSetType { get; set; }

        /// <summary>
        /// 服务组ID
        /// </summary>
        [JsonProperty("set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceGroupVO {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  protocols: ").Append(Protocols).Append("\n");
            sb.Append("  serviceSetType: ").Append(ServiceSetType).Append("\n");
            sb.Append("  setId: ").Append(SetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceGroupVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServiceGroupVO input)
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
                    this.Protocols == input.Protocols ||
                    this.Protocols != null &&
                    input.Protocols != null &&
                    this.Protocols.SequenceEqual(input.Protocols)
                ) && 
                (
                    this.ServiceSetType == input.ServiceSetType ||
                    (this.ServiceSetType != null &&
                    this.ServiceSetType.Equals(input.ServiceSetType))
                ) && 
                (
                    this.SetId == input.SetId ||
                    (this.SetId != null &&
                    this.SetId.Equals(input.SetId))
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
                if (this.Protocols != null)
                    hashCode = hashCode * 59 + this.Protocols.GetHashCode();
                if (this.ServiceSetType != null)
                    hashCode = hashCode * 59 + this.ServiceSetType.GetHashCode();
                if (this.SetId != null)
                    hashCode = hashCode * 59 + this.SetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
