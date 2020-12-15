using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// Job操作的对象。根据不同Job类型，显示不同的内容。裸金属服务器相关操作显示server_id；网卡相关操作显示nic_id
    /// </summary>
    public class Entitie 
    {

        /// <summary>
        /// 裸金属服务器相关操作显示server_id
        /// </summary>
        [JsonProperty("server_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerId { get; set; }

        /// <summary>
        /// 网卡相关操作显示nic_id
        /// </summary>
        [JsonProperty("nic_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NicId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Entitie {\n");
            sb.Append("  serverId: ").Append(ServerId).Append("\n");
            sb.Append("  nicId: ").Append(NicId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Entitie);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Entitie input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServerId == input.ServerId ||
                    (this.ServerId != null &&
                    this.ServerId.Equals(input.ServerId))
                ) && 
                (
                    this.NicId == input.NicId ||
                    (this.NicId != null &&
                    this.NicId.Equals(input.NicId))
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
                if (this.ServerId != null)
                    hashCode = hashCode * 59 + this.ServerId.GetHashCode();
                if (this.NicId != null)
                    hashCode = hashCode * 59 + this.NicId.GetHashCode();
                return hashCode;
            }
        }
    }
}
