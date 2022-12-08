using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class GetStackMetadataResponse : SdkResponse
    {
        /// <summary>
        /// 资源栈的执行状态     * &#x60;DEPLOYMENT_IN_PROGRESS&#x60; - 正在部署     * &#x60;DEPLOYMENT_FAILED&#x60; - 部署失败。请于StatusMessage见更多详情     * &#x60;DEPLOYMENT_COMPLETE &#x60; - 部署结束     * &#x60;ROLLBACK_IN_PROGRESS&#x60; - 正在回滚     * &#x60;ROLLBACK_FAILED&#x60; - 回滚失败。请于StatusMessage见更多详情     * &#x60;ROLLBACK_COMPLETE&#x60; - 回滚完成     * &#x60;DELETION_IN_PROGRESS&#x60; - 正在删除     * &#x60;DELETION_FAILED&#x60; - 删除失败     * &#x60;CREATION_COMPLETE&#x60; - 生成完成，并没有任何部署
        /// </summary>
        /// <value>资源栈的执行状态     * &#x60;DEPLOYMENT_IN_PROGRESS&#x60; - 正在部署     * &#x60;DEPLOYMENT_FAILED&#x60; - 部署失败。请于StatusMessage见更多详情     * &#x60;DEPLOYMENT_COMPLETE &#x60; - 部署结束     * &#x60;ROLLBACK_IN_PROGRESS&#x60; - 正在回滚     * &#x60;ROLLBACK_FAILED&#x60; - 回滚失败。请于StatusMessage见更多详情     * &#x60;ROLLBACK_COMPLETE&#x60; - 回滚完成     * &#x60;DELETION_IN_PROGRESS&#x60; - 正在删除     * &#x60;DELETION_FAILED&#x60; - 删除失败     * &#x60;CREATION_COMPLETE&#x60; - 生成完成，并没有任何部署</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum DEPLOYMENT_IN_PROGRESS for value: DEPLOYMENT_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum DEPLOYMENT_IN_PROGRESS = new StatusEnum("DEPLOYMENT_IN_PROGRESS");

            /// <summary>
            /// Enum DEPLOYMENT_FAILED for value: DEPLOYMENT_FAILED
            /// </summary>
            public static readonly StatusEnum DEPLOYMENT_FAILED = new StatusEnum("DEPLOYMENT_FAILED");

            /// <summary>
            /// Enum DEPLOYMENT_COMPLETE for value: DEPLOYMENT_COMPLETE
            /// </summary>
            public static readonly StatusEnum DEPLOYMENT_COMPLETE = new StatusEnum("DEPLOYMENT_COMPLETE");

            /// <summary>
            /// Enum ROLLBACK_IN_PROGRESS for value: ROLLBACK_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum ROLLBACK_IN_PROGRESS = new StatusEnum("ROLLBACK_IN_PROGRESS");

            /// <summary>
            /// Enum ROLLBACK_FAILED for value: ROLLBACK_FAILED
            /// </summary>
            public static readonly StatusEnum ROLLBACK_FAILED = new StatusEnum("ROLLBACK_FAILED");

            /// <summary>
            /// Enum ROLLBACK_COMPLETE for value: ROLLBACK_COMPLETE
            /// </summary>
            public static readonly StatusEnum ROLLBACK_COMPLETE = new StatusEnum("ROLLBACK_COMPLETE");

            /// <summary>
            /// Enum DELETION_IN_PROGRESS for value: DELETION_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum DELETION_IN_PROGRESS = new StatusEnum("DELETION_IN_PROGRESS");

            /// <summary>
            /// Enum DELETION_FAILED for value: DELETION_FAILED
            /// </summary>
            public static readonly StatusEnum DELETION_FAILED = new StatusEnum("DELETION_FAILED");

            /// <summary>
            /// Enum CREATION_COMPLETE for value: CREATION_COMPLETE
            /// </summary>
            public static readonly StatusEnum CREATION_COMPLETE = new StatusEnum("CREATION_COMPLETE");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "DEPLOYMENT_IN_PROGRESS", DEPLOYMENT_IN_PROGRESS },
                { "DEPLOYMENT_FAILED", DEPLOYMENT_FAILED },
                { "DEPLOYMENT_COMPLETE", DEPLOYMENT_COMPLETE },
                { "ROLLBACK_IN_PROGRESS", ROLLBACK_IN_PROGRESS },
                { "ROLLBACK_FAILED", ROLLBACK_FAILED },
                { "ROLLBACK_COMPLETE", ROLLBACK_COMPLETE },
                { "DELETION_IN_PROGRESS", DELETION_IN_PROGRESS },
                { "DELETION_FAILED", DELETION_FAILED },
                { "CREATION_COMPLETE", CREATION_COMPLETE },
            };

            private string Value;

            public StatusEnum(string value)
            {
                Value = value;
            }

            public static StatusEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 栈的唯一Id
        /// </summary>
        [JsonProperty("stack_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StackId { get; set; }

        /// <summary>
        /// 栈的名字
        /// </summary>
        [JsonProperty("stack_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StackName { get; set; }

        /// <summary>
        /// 栈的描述，此描述为用户在创建资源栈时指定
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 参数列表
        /// </summary>
        [JsonProperty("vars_structure", NullValueHandling = NullValueHandling.Ignore)]
        public List<VarsStructure> VarsStructure { get; set; }

        /// <summary>
        /// vars文件中的内容
        /// </summary>
        [JsonProperty("vars_uri_content", NullValueHandling = NullValueHandling.Ignore)]
        public string VarsUriContent { get; set; }

        /// <summary>
        /// terraform支持参数，即，同一个模板可以给予不同的参数而达到不同的效果。vars_body用于接收用户直接提交的tfvars文件内容
        /// </summary>
        [JsonProperty("vars_body", NullValueHandling = NullValueHandling.Ignore)]
        public string VarsBody { get; set; }

        /// <summary>
        /// 栈的生成时间，格式遵循RFC3339，即yyyy-mm-ddTHH:MM:SSZ，如1970-01-01T00:00:00Z
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 由于栈可以被更新，此处为上次更新时间，格式遵循RFC3339，即yyyy-mm-ddTHH:MM:SSZ，如1970-01-01T00:00:00Z
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 资源栈删除保护的目标状态
        /// </summary>
        [JsonProperty("enable_deletion_protection", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableDeletionProtection { get; set; }

        /// <summary>
        /// 资源栈是否开启自动回滚的标识位
        /// </summary>
        [JsonProperty("enable_auto_rollback", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAutoRollback { get; set; }

        /// <summary>
        /// 资源栈的执行状态     * &#x60;DEPLOYMENT_IN_PROGRESS&#x60; - 正在部署     * &#x60;DEPLOYMENT_FAILED&#x60; - 部署失败。请于StatusMessage见更多详情     * &#x60;DEPLOYMENT_COMPLETE &#x60; - 部署结束     * &#x60;ROLLBACK_IN_PROGRESS&#x60; - 正在回滚     * &#x60;ROLLBACK_FAILED&#x60; - 回滚失败。请于StatusMessage见更多详情     * &#x60;ROLLBACK_COMPLETE&#x60; - 回滚完成     * &#x60;DELETION_IN_PROGRESS&#x60; - 正在删除     * &#x60;DELETION_FAILED&#x60; - 删除失败     * &#x60;CREATION_COMPLETE&#x60; - 生成完成，并没有任何部署
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 展示更多细节的信息
        /// </summary>
        [JsonProperty("status_message", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// 委托授权的信息
        /// </summary>
        [JsonProperty("agencies", NullValueHandling = NullValueHandling.Ignore)]
        public List<Agency> Agencies { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetStackMetadataResponse {\n");
            sb.Append("  stackId: ").Append(StackId).Append("\n");
            sb.Append("  stackName: ").Append(StackName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  varsStructure: ").Append(VarsStructure).Append("\n");
            sb.Append("  varsUriContent: ").Append(VarsUriContent).Append("\n");
            sb.Append("  varsBody: ").Append(VarsBody).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  enableDeletionProtection: ").Append(EnableDeletionProtection).Append("\n");
            sb.Append("  enableAutoRollback: ").Append(EnableAutoRollback).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  statusMessage: ").Append(StatusMessage).Append("\n");
            sb.Append("  agencies: ").Append(Agencies).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetStackMetadataResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetStackMetadataResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StackId == input.StackId ||
                    (this.StackId != null &&
                    this.StackId.Equals(input.StackId))
                ) && 
                (
                    this.StackName == input.StackName ||
                    (this.StackName != null &&
                    this.StackName.Equals(input.StackName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.VarsStructure == input.VarsStructure ||
                    this.VarsStructure != null &&
                    input.VarsStructure != null &&
                    this.VarsStructure.SequenceEqual(input.VarsStructure)
                ) && 
                (
                    this.VarsUriContent == input.VarsUriContent ||
                    (this.VarsUriContent != null &&
                    this.VarsUriContent.Equals(input.VarsUriContent))
                ) && 
                (
                    this.VarsBody == input.VarsBody ||
                    (this.VarsBody != null &&
                    this.VarsBody.Equals(input.VarsBody))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) && 
                (
                    this.EnableDeletionProtection == input.EnableDeletionProtection ||
                    (this.EnableDeletionProtection != null &&
                    this.EnableDeletionProtection.Equals(input.EnableDeletionProtection))
                ) && 
                (
                    this.EnableAutoRollback == input.EnableAutoRollback ||
                    (this.EnableAutoRollback != null &&
                    this.EnableAutoRollback.Equals(input.EnableAutoRollback))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusMessage == input.StatusMessage ||
                    (this.StatusMessage != null &&
                    this.StatusMessage.Equals(input.StatusMessage))
                ) && 
                (
                    this.Agencies == input.Agencies ||
                    this.Agencies != null &&
                    input.Agencies != null &&
                    this.Agencies.SequenceEqual(input.Agencies)
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
                if (this.StackId != null)
                    hashCode = hashCode * 59 + this.StackId.GetHashCode();
                if (this.StackName != null)
                    hashCode = hashCode * 59 + this.StackName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.VarsStructure != null)
                    hashCode = hashCode * 59 + this.VarsStructure.GetHashCode();
                if (this.VarsUriContent != null)
                    hashCode = hashCode * 59 + this.VarsUriContent.GetHashCode();
                if (this.VarsBody != null)
                    hashCode = hashCode * 59 + this.VarsBody.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.EnableDeletionProtection != null)
                    hashCode = hashCode * 59 + this.EnableDeletionProtection.GetHashCode();
                if (this.EnableAutoRollback != null)
                    hashCode = hashCode * 59 + this.EnableAutoRollback.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusMessage != null)
                    hashCode = hashCode * 59 + this.StatusMessage.GetHashCode();
                if (this.Agencies != null)
                    hashCode = hashCode * 59 + this.Agencies.GetHashCode();
                return hashCode;
            }
        }
    }
}
