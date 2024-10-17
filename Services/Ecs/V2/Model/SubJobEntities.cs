using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SubJobEntities 
    {

        /// <summary>
        /// 云服务器相关操作显示server_id。
        /// </summary>
        [JsonProperty("server_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerId { get; set; }

        /// <summary>
        /// 网卡相关操作显示nic_id。
        /// </summary>
        [JsonProperty("nic_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NicId { get; set; }

        /// <summary>
        /// 子任务执行失败的具体原因。
        /// </summary>
        [JsonProperty("errorcode_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorcodeMessage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubJobEntities {\n");
            sb.Append("  serverId: ").Append(ServerId).Append("\n");
            sb.Append("  nicId: ").Append(NicId).Append("\n");
            sb.Append("  errorcodeMessage: ").Append(ErrorcodeMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubJobEntities);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubJobEntities input)
        {
            if (input == null) return false;
            if (this.ServerId != input.ServerId || (this.ServerId != null && !this.ServerId.Equals(input.ServerId))) return false;
            if (this.NicId != input.NicId || (this.NicId != null && !this.NicId.Equals(input.NicId))) return false;
            if (this.ErrorcodeMessage != input.ErrorcodeMessage || (this.ErrorcodeMessage != null && !this.ErrorcodeMessage.Equals(input.ErrorcodeMessage))) return false;

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
                if (this.ServerId != null) hashCode = hashCode * 59 + this.ServerId.GetHashCode();
                if (this.NicId != null) hashCode = hashCode * 59 + this.NicId.GetHashCode();
                if (this.ErrorcodeMessage != null) hashCode = hashCode * 59 + this.ErrorcodeMessage.GetHashCode();
                return hashCode;
            }
        }
    }
}
