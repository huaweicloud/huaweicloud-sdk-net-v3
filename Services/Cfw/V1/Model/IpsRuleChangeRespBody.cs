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
    public class IpsRuleChangeRespBody 
    {

        /// <summary>
        /// 错误代码
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 分组id
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 防火墙ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// ips的id列表
        /// </summary>
        [JsonProperty("ips_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IpsIds { get; set; }

        /// <summary>
        /// 修改结果
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Result { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpsRuleChangeRespBody {\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  ipsIds: ").Append(IpsIds).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IpsRuleChangeRespBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IpsRuleChangeRespBody input)
        {
            if (input == null) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;
            if (this.ErrorMsg != input.ErrorMsg || (this.ErrorMsg != null && !this.ErrorMsg.Equals(input.ErrorMsg))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.IpsIds != input.IpsIds || (this.IpsIds != null && input.IpsIds != null && !this.IpsIds.SequenceEqual(input.IpsIds))) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;

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
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMsg != null) hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IpsIds != null) hashCode = hashCode * 59 + this.IpsIds.GetHashCode();
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                return hashCode;
            }
        }
    }
}
