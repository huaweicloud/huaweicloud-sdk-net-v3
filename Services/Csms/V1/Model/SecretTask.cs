using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Csms.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SecretTask 
    {

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 凭据名称。
        /// </summary>
        [JsonProperty("secret_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretName { get; set; }

        /// <summary>
        /// FunctionGraph函数的urn。
        /// </summary>
        [JsonProperty("rotation_func_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string RotationFuncUrn { get; set; }

        /// <summary>
        /// 任务状态。
        /// </summary>
        [JsonProperty("task_status", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// 任务尝试次数。
        /// </summary>
        [JsonProperty("attempt_nums", NullValueHandling = NullValueHandling.Ignore)]
        public int? AttemptNums { get; set; }

        /// <summary>
        /// 轮转类型。
        /// </summary>
        [JsonProperty("operate_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperateType { get; set; }

        /// <summary>
        /// 任务创建时间。
        /// </summary>
        [JsonProperty("task_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? TaskTime { get; set; }

        /// <summary>
        /// 任务错误码。
        /// </summary>
        [JsonProperty("task_error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskErrorCode { get; set; }

        /// <summary>
        /// 任务错误信息。
        /// </summary>
        [JsonProperty("task_error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskErrorMsg { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecretTask {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  secretName: ").Append(SecretName).Append("\n");
            sb.Append("  rotationFuncUrn: ").Append(RotationFuncUrn).Append("\n");
            sb.Append("  taskStatus: ").Append(TaskStatus).Append("\n");
            sb.Append("  attemptNums: ").Append(AttemptNums).Append("\n");
            sb.Append("  operateType: ").Append(OperateType).Append("\n");
            sb.Append("  taskTime: ").Append(TaskTime).Append("\n");
            sb.Append("  taskErrorCode: ").Append(TaskErrorCode).Append("\n");
            sb.Append("  taskErrorMsg: ").Append(TaskErrorMsg).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SecretTask);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SecretTask input)
        {
            if (input == null) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.SecretName != input.SecretName || (this.SecretName != null && !this.SecretName.Equals(input.SecretName))) return false;
            if (this.RotationFuncUrn != input.RotationFuncUrn || (this.RotationFuncUrn != null && !this.RotationFuncUrn.Equals(input.RotationFuncUrn))) return false;
            if (this.TaskStatus != input.TaskStatus || (this.TaskStatus != null && !this.TaskStatus.Equals(input.TaskStatus))) return false;
            if (this.AttemptNums != input.AttemptNums || (this.AttemptNums != null && !this.AttemptNums.Equals(input.AttemptNums))) return false;
            if (this.OperateType != input.OperateType || (this.OperateType != null && !this.OperateType.Equals(input.OperateType))) return false;
            if (this.TaskTime != input.TaskTime || (this.TaskTime != null && !this.TaskTime.Equals(input.TaskTime))) return false;
            if (this.TaskErrorCode != input.TaskErrorCode || (this.TaskErrorCode != null && !this.TaskErrorCode.Equals(input.TaskErrorCode))) return false;
            if (this.TaskErrorMsg != input.TaskErrorMsg || (this.TaskErrorMsg != null && !this.TaskErrorMsg.Equals(input.TaskErrorMsg))) return false;

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
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.SecretName != null) hashCode = hashCode * 59 + this.SecretName.GetHashCode();
                if (this.RotationFuncUrn != null) hashCode = hashCode * 59 + this.RotationFuncUrn.GetHashCode();
                if (this.TaskStatus != null) hashCode = hashCode * 59 + this.TaskStatus.GetHashCode();
                if (this.AttemptNums != null) hashCode = hashCode * 59 + this.AttemptNums.GetHashCode();
                if (this.OperateType != null) hashCode = hashCode * 59 + this.OperateType.GetHashCode();
                if (this.TaskTime != null) hashCode = hashCode * 59 + this.TaskTime.GetHashCode();
                if (this.TaskErrorCode != null) hashCode = hashCode * 59 + this.TaskErrorCode.GetHashCode();
                if (this.TaskErrorMsg != null) hashCode = hashCode * 59 + this.TaskErrorMsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
