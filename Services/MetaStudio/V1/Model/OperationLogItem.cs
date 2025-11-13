using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 操作
    /// </summary>
    public class OperationLogItem 
    {

        /// <summary>
        /// 操作时间
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public long? Time { get; set; }

        /// <summary>
        /// 操作名称,当前已有的action为CREATE_JOB(创建任务),COMMIT_JOB(提交任务),SYSTEM_AUDIT_PASS(系统审核通过),ADMIN_AUDIT_PASS(管理员审核通过),AUDIT_NOT_PASS(审核未通过),TRAINING_FINISH(训练完成),UPLOADING_MODEL(上传语音模型),COMPLETE_JOB(任务完成)
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// 操作者,USER(用户),ADMIN(管理员),SYSTEM(系统用户)
        /// </summary>
        [JsonProperty("operator", NullValueHandling = NullValueHandling.Ignore)]
        public string Operator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("external_info", NullValueHandling = NullValueHandling.Ignore)]
        public OpExternalInfo ExternalInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationLogItem {\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  externalInfo: ").Append(ExternalInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OperationLogItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OperationLogItem input)
        {
            if (input == null) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.Operator != input.Operator || (this.Operator != null && !this.Operator.Equals(input.Operator))) return false;
            if (this.ExternalInfo != input.ExternalInfo || (this.ExternalInfo != null && !this.ExternalInfo.Equals(input.ExternalInfo))) return false;

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
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Operator != null) hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.ExternalInfo != null) hashCode = hashCode * 59 + this.ExternalInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
