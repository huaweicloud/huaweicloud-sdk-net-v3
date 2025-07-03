using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAccessPointResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("gmt_create", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("gmt_modify", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtModify { get; set; }

        /// <summary>
        /// 当前局点
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 接入点地址
        /// </summary>
        [JsonProperty("accessPoint", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessPoint { get; set; }

        /// <summary>
        /// token
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// token隐藏字符
        /// </summary>
        [JsonProperty("hidden_token", NullValueHandling = NullValueHandling.Ignore)]
        public string HiddenToken { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("sw_business_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SwBusinessId { get; set; }

        /// <summary>
        /// agent下载地址
        /// </summary>
        [JsonProperty("agent_download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentDownloadUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAccessPointResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  gmtCreate: ").Append(GmtCreate).Append("\n");
            sb.Append("  gmtModify: ").Append(GmtModify).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  accessPoint: ").Append(AccessPoint).Append("\n");
            sb.Append("  token: ").Append(Token).Append("\n");
            sb.Append("  hiddenToken: ").Append(HiddenToken).Append("\n");
            sb.Append("  swBusinessId: ").Append(SwBusinessId).Append("\n");
            sb.Append("  agentDownloadUrl: ").Append(AgentDownloadUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAccessPointResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAccessPointResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.GmtCreate != input.GmtCreate || (this.GmtCreate != null && !this.GmtCreate.Equals(input.GmtCreate))) return false;
            if (this.GmtModify != input.GmtModify || (this.GmtModify != null && !this.GmtModify.Equals(input.GmtModify))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.AccessPoint != input.AccessPoint || (this.AccessPoint != null && !this.AccessPoint.Equals(input.AccessPoint))) return false;
            if (this.Token != input.Token || (this.Token != null && !this.Token.Equals(input.Token))) return false;
            if (this.HiddenToken != input.HiddenToken || (this.HiddenToken != null && !this.HiddenToken.Equals(input.HiddenToken))) return false;
            if (this.SwBusinessId != input.SwBusinessId || (this.SwBusinessId != null && !this.SwBusinessId.Equals(input.SwBusinessId))) return false;
            if (this.AgentDownloadUrl != input.AgentDownloadUrl || (this.AgentDownloadUrl != null && !this.AgentDownloadUrl.Equals(input.AgentDownloadUrl))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.GmtCreate != null) hashCode = hashCode * 59 + this.GmtCreate.GetHashCode();
                if (this.GmtModify != null) hashCode = hashCode * 59 + this.GmtModify.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.AccessPoint != null) hashCode = hashCode * 59 + this.AccessPoint.GetHashCode();
                if (this.Token != null) hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.HiddenToken != null) hashCode = hashCode * 59 + this.HiddenToken.GetHashCode();
                if (this.SwBusinessId != null) hashCode = hashCode * 59 + this.SwBusinessId.GetHashCode();
                if (this.AgentDownloadUrl != null) hashCode = hashCode * 59 + this.AgentDownloadUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
