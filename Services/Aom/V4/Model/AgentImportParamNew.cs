using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AgentImportParamNew 
    {

        /// <summary>
        /// 机器登录密码。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// agent唯一值，重复导入时需要传递。
        /// </summary>
        [JsonProperty("agent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentId { get; set; }

        /// <summary>
        /// 机器IP。
        /// </summary>
        [JsonProperty("inner_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string InnerIp { get; set; }

        /// <summary>
        /// 机器登录端口，默认22。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// 机器ssh账号。
        /// </summary>
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public string Account { get; set; }

        /// <summary>
        /// 机器操作系统类型。
        /// </summary>
        [JsonProperty("os_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OsType { get; set; }

        /// <summary>
        /// 机器所属VPC ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 外来唯一标识，COC用。
        /// </summary>
        [JsonProperty("coc_cmdb_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CocCmdbId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentImportParamNew {\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  agentId: ").Append(AgentId).Append("\n");
            sb.Append("  innerIp: ").Append(InnerIp).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  account: ").Append(Account).Append("\n");
            sb.Append("  osType: ").Append(OsType).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  cocCmdbId: ").Append(CocCmdbId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgentImportParamNew);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgentImportParamNew input)
        {
            if (input == null) return false;
            if (this.Password != input.Password || (this.Password != null && !this.Password.Equals(input.Password))) return false;
            if (this.AgentId != input.AgentId || (this.AgentId != null && !this.AgentId.Equals(input.AgentId))) return false;
            if (this.InnerIp != input.InnerIp || (this.InnerIp != null && !this.InnerIp.Equals(input.InnerIp))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.Account != input.Account || (this.Account != null && !this.Account.Equals(input.Account))) return false;
            if (this.OsType != input.OsType || (this.OsType != null && !this.OsType.Equals(input.OsType))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.CocCmdbId != input.CocCmdbId || (this.CocCmdbId != null && !this.CocCmdbId.Equals(input.CocCmdbId))) return false;

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
                if (this.Password != null) hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.AgentId != null) hashCode = hashCode * 59 + this.AgentId.GetHashCode();
                if (this.InnerIp != null) hashCode = hashCode * 59 + this.InnerIp.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Account != null) hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.OsType != null) hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.CocCmdbId != null) hashCode = hashCode * 59 + this.CocCmdbId.GetHashCode();
                return hashCode;
            }
        }
    }
}
