using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 创建任务响应体
    /// </summary>
    public class CreateJobResp 
    {

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 任务状态 CREATING：创建中，CREATE_FAILED：创建失败，CONFIGURATION：配置中，WAITING_FOR_START：等待启动中，RELEASE_RESOURCE_COMPLETE：已结束，DELETED：已删除，INCRE_TRANSFER_STARTED：增量迁移中，INCRE_TRANSFER_FAILED：增量迁移失败，FULL_TRANSFER_STARTED：全量迁移中，FULL_TRANSFER_COMPLETE：全量迁移完成，PAUSING：暂停中，FULL_TRANSFER_FAILED：全量迁移失败
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 创建时间，时间戳
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 子任务ID，有子任务时返回该字段。
        /// </summary>
        [JsonProperty("child_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ChildIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateJobResp {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("  childIds: ").Append(ChildIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateJobResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateJobResp input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;
            if (this.ErrorMsg != input.ErrorMsg || (this.ErrorMsg != null && !this.ErrorMsg.Equals(input.ErrorMsg))) return false;
            if (this.ChildIds != input.ChildIds || (this.ChildIds != null && input.ChildIds != null && !this.ChildIds.SequenceEqual(input.ChildIds))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMsg != null) hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                if (this.ChildIds != null) hashCode = hashCode * 59 + this.ChildIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
