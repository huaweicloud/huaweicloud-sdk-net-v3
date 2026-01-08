using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 批量删除的响应结果
    /// </summary>
    public class BatchDeletePoolsResp 
    {

        /// <summary>
        /// 被删除的后端服务器组id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 对应id的后端服务器组删除后的结果，not found表示后端服务器组不存在，successful表示删除成功
        /// </summary>
        [JsonProperty("ret_status", NullValueHandling = NullValueHandling.Ignore)]
        public string RetStatus { get; set; }

        /// <summary>
        /// 错误码，删除失败时返回此字段
        /// </summary>
        [JsonProperty("ret_code", NullValueHandling = NullValueHandling.Ignore)]
        public string RetCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeletePoolsResp {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  retStatus: ").Append(RetStatus).Append("\n");
            sb.Append("  retCode: ").Append(RetCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeletePoolsResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeletePoolsResp input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.RetStatus != input.RetStatus || (this.RetStatus != null && !this.RetStatus.Equals(input.RetStatus))) return false;
            if (this.RetCode != input.RetCode || (this.RetCode != null && !this.RetCode.Equals(input.RetCode))) return false;

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
                if (this.RetStatus != null) hashCode = hashCode * 59 + this.RetStatus.GetHashCode();
                if (this.RetCode != null) hashCode = hashCode * 59 + this.RetCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
