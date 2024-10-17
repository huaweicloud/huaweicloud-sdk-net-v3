using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowMetadataResponse : SdkResponse
    {

        /// <summary>
        /// Metadata的ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 身份提供商ID。
        /// </summary>
        [JsonProperty("idp_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IdpId { get; set; }

        /// <summary>
        /// Metadata文件中的entityID字段。
        /// </summary>
        [JsonProperty("entity_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EntityId { get; set; }

        /// <summary>
        /// 协议ID。
        /// </summary>
        [JsonProperty("protocol_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtocolId { get; set; }

        /// <summary>
        /// 用户所属账号ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 账号来源，默认为空。
        /// </summary>
        [JsonProperty("xaccount_type", NullValueHandling = NullValueHandling.Ignore)]
        public string XaccountType { get; set; }

        /// <summary>
        /// 导入或更新Metadata文件的时间。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// Metadata文件的内容。
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public string Data { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMetadataResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  idpId: ").Append(IdpId).Append("\n");
            sb.Append("  entityId: ").Append(EntityId).Append("\n");
            sb.Append("  protocolId: ").Append(ProtocolId).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  xaccountType: ").Append(XaccountType).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMetadataResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMetadataResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.IdpId != input.IdpId || (this.IdpId != null && !this.IdpId.Equals(input.IdpId))) return false;
            if (this.EntityId != input.EntityId || (this.EntityId != null && !this.EntityId.Equals(input.EntityId))) return false;
            if (this.ProtocolId != input.ProtocolId || (this.ProtocolId != null && !this.ProtocolId.Equals(input.ProtocolId))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.XaccountType != input.XaccountType || (this.XaccountType != null && !this.XaccountType.Equals(input.XaccountType))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.Data != input.Data || (this.Data != null && !this.Data.Equals(input.Data))) return false;

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
                if (this.IdpId != null) hashCode = hashCode * 59 + this.IdpId.GetHashCode();
                if (this.EntityId != null) hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.ProtocolId != null) hashCode = hashCode * 59 + this.ProtocolId.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.XaccountType != null) hashCode = hashCode * 59 + this.XaccountType.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.Data != null) hashCode = hashCode * 59 + this.Data.GetHashCode();
                return hashCode;
            }
        }
    }
}
