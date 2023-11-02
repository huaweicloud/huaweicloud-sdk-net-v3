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
    public class ShowStackInstanceResponse : SdkResponse
    {
        /// <summary>
        /// 资源栈实例的状态  * &#x60;WAIT_IN_PROGRESS&#x60; - 资源栈实例等待操作中 * &#x60;CANCEL_COMPLETE&#x60; - 资源栈实例操作取消完成 * &#x60;OPERATION_IN_PROGRESS&#x60; - 资源栈实例操作中 * &#x60;OPERATION_FAILED&#x60; - 资源栈实例操作失败 * &#x60;INOPERABLE&#x60; - 资源栈实例不可操作 * &#x60;OPERATION_COMPLETE&#x60; - 资源栈实例操作完成
        /// </summary>
        /// <value>资源栈实例的状态  * &#x60;WAIT_IN_PROGRESS&#x60; - 资源栈实例等待操作中 * &#x60;CANCEL_COMPLETE&#x60; - 资源栈实例操作取消完成 * &#x60;OPERATION_IN_PROGRESS&#x60; - 资源栈实例操作中 * &#x60;OPERATION_FAILED&#x60; - 资源栈实例操作失败 * &#x60;INOPERABLE&#x60; - 资源栈实例不可操作 * &#x60;OPERATION_COMPLETE&#x60; - 资源栈实例操作完成</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum WAIT_IN_PROGRESS for value: WAIT_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum WAIT_IN_PROGRESS = new StatusEnum("WAIT_IN_PROGRESS");

            /// <summary>
            /// Enum CANCEL_COMPLETE for value: CANCEL_COMPLETE
            /// </summary>
            public static readonly StatusEnum CANCEL_COMPLETE = new StatusEnum("CANCEL_COMPLETE");

            /// <summary>
            /// Enum OPERATION_IN_PROGRESS for value: OPERATION_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum OPERATION_IN_PROGRESS = new StatusEnum("OPERATION_IN_PROGRESS");

            /// <summary>
            /// Enum OPERATION_FAILED for value: OPERATION_FAILED
            /// </summary>
            public static readonly StatusEnum OPERATION_FAILED = new StatusEnum("OPERATION_FAILED");

            /// <summary>
            /// Enum INOPERABLE for value: INOPERABLE
            /// </summary>
            public static readonly StatusEnum INOPERABLE = new StatusEnum("INOPERABLE");

            /// <summary>
            /// Enum OPERATION_COMPLETE for value: OPERATION_COMPLETE
            /// </summary>
            public static readonly StatusEnum OPERATION_COMPLETE = new StatusEnum("OPERATION_COMPLETE");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "WAIT_IN_PROGRESS", WAIT_IN_PROGRESS },
                { "CANCEL_COMPLETE", CANCEL_COMPLETE },
                { "OPERATION_IN_PROGRESS", OPERATION_IN_PROGRESS },
                { "OPERATION_FAILED", OPERATION_FAILED },
                { "INOPERABLE", INOPERABLE },
                { "OPERATION_COMPLETE", OPERATION_COMPLETE },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
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
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// 资源栈集（stack_set）的唯一ID。  此ID由资源编排服务在生成资源栈的时候生成，为UUID。  由于资源栈集名仅仅在同一时间下唯一，即用户允许先生成一个叫HelloWorld的资源栈集，删除，在重新创建一个同名资源栈集。  对于团队并行开发，用户可能希望确保，当前我操作的资源栈集就是我以为的那个，而不是又其他队友删除后创建的同名资源栈集。因此，使用ID就可以做到强匹配。  资源编排服务保证每次创建的资源栈集所对应的ID都不相同，更新不会影响ID。如果给与的stack_set_id和当前资源栈集的ID不一致，则返回400
        /// </summary>
        [JsonProperty("stack_set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StackSetId { get; set; }

        /// <summary>
        /// 资源栈集（stack_set）的名字。此名字在domain_id+region下应唯一，可以使用中文、大小写英文、数字、下划线、中划线。首字符需为中文或者英文，区分大小写。
        /// </summary>
        [JsonProperty("stack_set_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StackSetName { get; set; }

        /// <summary>
        /// 资源栈实例的状态  * &#x60;WAIT_IN_PROGRESS&#x60; - 资源栈实例等待操作中 * &#x60;CANCEL_COMPLETE&#x60; - 资源栈实例操作取消完成 * &#x60;OPERATION_IN_PROGRESS&#x60; - 资源栈实例操作中 * &#x60;OPERATION_FAILED&#x60; - 资源栈实例操作失败 * &#x60;INOPERABLE&#x60; - 资源栈实例不可操作 * &#x60;OPERATION_COMPLETE&#x60; - 资源栈实例操作完成
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 在资源栈实例状态为&#x60;INOPERABLE&#x60;或&#x60;OPERATION_FAILED&#x60;时，会显示简要的错误信息总结以供debug
        /// </summary>
        [JsonProperty("status_message", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// 资源栈（stack）的唯一ID。  此ID由资源编排服务在生成资源栈的时候生成，为UUID。  由于资源栈名仅仅在同一时间下唯一，即用户允许先生成一个叫HelloWorld的资源栈，删除，再重新创建一个同名资源栈。  对于团队并行开发，用户可能希望确保，当前我操作的资源栈就是我认为的那个，而不是其他队友删除后创建的同名资源栈。因此，使用ID就可以做到强匹配。  资源编排服务保证每次创建的资源栈所对应的ID都不相同，更新不会影响ID。如果给与的stack_id和当前资源栈的ID不一致，则返回400
        /// </summary>
        [JsonProperty("stack_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StackId { get; set; }

        /// <summary>
        /// 资源栈的名称。此名字在domain_id+区域+project_id下应唯一，可以使用中文、大小写英文、数字、下划线、中划线。首字符需为中文或者英文，区分大小写。
        /// </summary>
        [JsonProperty("stack_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StackName { get; set; }

        /// <summary>
        /// 资源栈实例所关联的资源栈所在的租户ID
        /// </summary>
        [JsonProperty("stack_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StackDomainId { get; set; }

        /// <summary>
        /// 最新一次部署该资源栈实例的资源栈集操作ID  此Id由资源编排服务在生成资源栈集操作的时候生成，为UUID
        /// </summary>
        [JsonProperty("latest_stack_set_operation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LatestStackSetOperationId { get; set; }

        /// <summary>
        /// 资源栈实例所关联的资源栈所在的区域
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 资源栈实例的创建时间，格式为YYYY-MM-DDTHH:mm:ss.SSSZ，精确到毫秒，UTC时区，即，如1970-01-01T00:00:00.000Z
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 资源栈实例的更新时间，格式为YYYY-MM-DDTHH:mm:ss.SSSZ，精确到毫秒，UTC时区，即，如1970-01-01T00:00:00.000Z
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 该资源栈实例的参数覆盖内容  若用户通过CreateStackInstances或UpdateStackInstances API 对该资源栈实例设置了参数覆盖，该字段会返回资源栈实例记录的最新参数覆盖内容  若该字段未返回，用户使用资源栈集中记录的参数部署该实例
        /// </summary>
        [JsonProperty("var_overrides", NullValueHandling = NullValueHandling.Ignore)]
        public Object VarOverrides { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStackInstanceResponse {\n");
            sb.Append("  stackSetId: ").Append(StackSetId).Append("\n");
            sb.Append("  stackSetName: ").Append(StackSetName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  statusMessage: ").Append(StatusMessage).Append("\n");
            sb.Append("  stackId: ").Append(StackId).Append("\n");
            sb.Append("  stackName: ").Append(StackName).Append("\n");
            sb.Append("  stackDomainId: ").Append(StackDomainId).Append("\n");
            sb.Append("  latestStackSetOperationId: ").Append(LatestStackSetOperationId).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  varOverrides: ").Append(VarOverrides).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStackInstanceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStackInstanceResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StackSetId == input.StackSetId ||
                    (this.StackSetId != null &&
                    this.StackSetId.Equals(input.StackSetId))
                ) && 
                (
                    this.StackSetName == input.StackSetName ||
                    (this.StackSetName != null &&
                    this.StackSetName.Equals(input.StackSetName))
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
                    this.StackDomainId == input.StackDomainId ||
                    (this.StackDomainId != null &&
                    this.StackDomainId.Equals(input.StackDomainId))
                ) && 
                (
                    this.LatestStackSetOperationId == input.LatestStackSetOperationId ||
                    (this.LatestStackSetOperationId != null &&
                    this.LatestStackSetOperationId.Equals(input.LatestStackSetOperationId))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
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
                    this.VarOverrides == input.VarOverrides ||
                    (this.VarOverrides != null &&
                    this.VarOverrides.Equals(input.VarOverrides))
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
                if (this.StackSetId != null)
                    hashCode = hashCode * 59 + this.StackSetId.GetHashCode();
                if (this.StackSetName != null)
                    hashCode = hashCode * 59 + this.StackSetName.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusMessage != null)
                    hashCode = hashCode * 59 + this.StatusMessage.GetHashCode();
                if (this.StackId != null)
                    hashCode = hashCode * 59 + this.StackId.GetHashCode();
                if (this.StackName != null)
                    hashCode = hashCode * 59 + this.StackName.GetHashCode();
                if (this.StackDomainId != null)
                    hashCode = hashCode * 59 + this.StackDomainId.GetHashCode();
                if (this.LatestStackSetOperationId != null)
                    hashCode = hashCode * 59 + this.LatestStackSetOperationId.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.VarOverrides != null)
                    hashCode = hashCode * 59 + this.VarOverrides.GetHashCode();
                return hashCode;
            }
        }
    }
}
