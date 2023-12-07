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
    public class ShowStackSetOperationMetadataResponse : SdkResponse
    {
        /// <summary>
        /// 资源栈集操作状态   * &#x60;QUEUE_IN_PROGRESS&#x60; - 正在排队   * &#x60;OPERATION_IN_PROGRESS&#x60; - 正在操作   * &#x60;OPERATION_COMPLETE&#x60; - 操作完成   * &#x60;OPERATION_FAILED&#x60; - 操作失败   * &#x60;STOP_IN_PROGRESS&#x60; - 正在停止   * &#x60;STOP_COMPLETE&#x60; - 停止完成   * &#x60;STOP_FAILED&#x60; - 停止失败
        /// </summary>
        /// <value>资源栈集操作状态   * &#x60;QUEUE_IN_PROGRESS&#x60; - 正在排队   * &#x60;OPERATION_IN_PROGRESS&#x60; - 正在操作   * &#x60;OPERATION_COMPLETE&#x60; - 操作完成   * &#x60;OPERATION_FAILED&#x60; - 操作失败   * &#x60;STOP_IN_PROGRESS&#x60; - 正在停止   * &#x60;STOP_COMPLETE&#x60; - 停止完成   * &#x60;STOP_FAILED&#x60; - 停止失败</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum QUEUE_IN_PROGRESS for value: QUEUE_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum QUEUE_IN_PROGRESS = new StatusEnum("QUEUE_IN_PROGRESS");

            /// <summary>
            /// Enum OPERATION_IN_PROGRESS for value: OPERATION_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum OPERATION_IN_PROGRESS = new StatusEnum("OPERATION_IN_PROGRESS");

            /// <summary>
            /// Enum OPERATION_COMPLETE for value: OPERATION_COMPLETE
            /// </summary>
            public static readonly StatusEnum OPERATION_COMPLETE = new StatusEnum("OPERATION_COMPLETE");

            /// <summary>
            /// Enum OPERATION_FAILED for value: OPERATION_FAILED
            /// </summary>
            public static readonly StatusEnum OPERATION_FAILED = new StatusEnum("OPERATION_FAILED");

            /// <summary>
            /// Enum STOP_IN_PROGRESS for value: STOP_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum STOP_IN_PROGRESS = new StatusEnum("STOP_IN_PROGRESS");

            /// <summary>
            /// Enum STOP_COMPLETE for value: STOP_COMPLETE
            /// </summary>
            public static readonly StatusEnum STOP_COMPLETE = new StatusEnum("STOP_COMPLETE");

            /// <summary>
            /// Enum STOP_FAILED for value: STOP_FAILED
            /// </summary>
            public static readonly StatusEnum STOP_FAILED = new StatusEnum("STOP_FAILED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "QUEUE_IN_PROGRESS", QUEUE_IN_PROGRESS },
                { "OPERATION_IN_PROGRESS", OPERATION_IN_PROGRESS },
                { "OPERATION_COMPLETE", OPERATION_COMPLETE },
                { "OPERATION_FAILED", OPERATION_FAILED },
                { "STOP_IN_PROGRESS", STOP_IN_PROGRESS },
                { "STOP_COMPLETE", STOP_COMPLETE },
                { "STOP_FAILED", STOP_FAILED },
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
        /// 用户当前的操作   * &#x60;CREATE_STACK_INSTANCES&#x60; - 创建资源栈实例   * &#x60;DELETE_STACK_INSTANCES&#x60; - 删除资源栈实例   * &#x60;DEPLOY_STACK_SET&#x60; - 部署资源栈集   * &#x60;DEPLOY_STACK_INSTANCES&#x60; - 部署资源栈实例   * &#x60;UPDATE_STACK_INSTANCES&#x60; - 更新资源栈实例
        /// </summary>
        /// <value>用户当前的操作   * &#x60;CREATE_STACK_INSTANCES&#x60; - 创建资源栈实例   * &#x60;DELETE_STACK_INSTANCES&#x60; - 删除资源栈实例   * &#x60;DEPLOY_STACK_SET&#x60; - 部署资源栈集   * &#x60;DEPLOY_STACK_INSTANCES&#x60; - 部署资源栈实例   * &#x60;UPDATE_STACK_INSTANCES&#x60; - 更新资源栈实例</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum CREATE_STACK_INSTANCES for value: CREATE_STACK_INSTANCES
            /// </summary>
            public static readonly ActionEnum CREATE_STACK_INSTANCES = new ActionEnum("CREATE_STACK_INSTANCES");

            /// <summary>
            /// Enum DELETE_STACK_INSTANCES for value: DELETE_STACK_INSTANCES
            /// </summary>
            public static readonly ActionEnum DELETE_STACK_INSTANCES = new ActionEnum("DELETE_STACK_INSTANCES");

            /// <summary>
            /// Enum DEPLOY_STACK_SET for value: DEPLOY_STACK_SET
            /// </summary>
            public static readonly ActionEnum DEPLOY_STACK_SET = new ActionEnum("DEPLOY_STACK_SET");

            /// <summary>
            /// Enum DEPLOY_STACK_INSTANCES for value: DEPLOY_STACK_INSTANCES
            /// </summary>
            public static readonly ActionEnum DEPLOY_STACK_INSTANCES = new ActionEnum("DEPLOY_STACK_INSTANCES");

            /// <summary>
            /// Enum UPDATE_STACK_INSTANCES for value: UPDATE_STACK_INSTANCES
            /// </summary>
            public static readonly ActionEnum UPDATE_STACK_INSTANCES = new ActionEnum("UPDATE_STACK_INSTANCES");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "CREATE_STACK_INSTANCES", CREATE_STACK_INSTANCES },
                { "DELETE_STACK_INSTANCES", DELETE_STACK_INSTANCES },
                { "DEPLOY_STACK_SET", DEPLOY_STACK_SET },
                { "DEPLOY_STACK_INSTANCES", DEPLOY_STACK_INSTANCES },
                { "UPDATE_STACK_INSTANCES", UPDATE_STACK_INSTANCES },
            };

            private string _value;

            public ActionEnum()
            {

            }

            public ActionEnum(string value)
            {
                _value = value;
            }

            public static ActionEnum FromValue(string value)
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

                if (this.Equals(obj as ActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActionEnum a, ActionEnum b)
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

            public static bool operator !=(ActionEnum a, ActionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 资源栈集操作（stack_set_operation）的唯一Id。  此ID由资源编排服务在生成资源栈集操作的时候生成，为UUID。
        /// </summary>
        [JsonProperty("stack_set_operation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StackSetOperationId { get; set; }

        /// <summary>
        /// 资源栈集（stack_set）的唯一ID。  此ID由资源编排服务在生成资源栈集的时候生成，为UUID。  由于资源栈集名仅仅在同一时间下唯一，即用户允许先生成一个叫HelloWorld的资源栈集，删除，在重新创建一个同名资源栈集。  对于团队并行开发，用户可能希望确保，当前我操作的资源栈集就是我以为的那个，而不是又其他队友删除后创建的同名资源栈集。因此，使用ID就可以做到强匹配。  资源编排服务保证每次创建的资源栈集所对应的ID都不相同，更新不会影响ID。如果给与的stack_set_id和当前资源栈集的ID不一致，则返回400
        /// </summary>
        [JsonProperty("stack_set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StackSetId { get; set; }

        /// <summary>
        /// 资源栈集（stack_set）的名字。此名字在domain_id+region下应唯一，可以使用中文、大小写英文、数字、下划线、中划线。首字符需为中文或者英文，区分大小写。
        /// </summary>
        [JsonProperty("stack_set_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StackSetName { get; set; }

        /// <summary>
        /// 资源栈集操作状态   * &#x60;QUEUE_IN_PROGRESS&#x60; - 正在排队   * &#x60;OPERATION_IN_PROGRESS&#x60; - 正在操作   * &#x60;OPERATION_COMPLETE&#x60; - 操作完成   * &#x60;OPERATION_FAILED&#x60; - 操作失败   * &#x60;STOP_IN_PROGRESS&#x60; - 正在停止   * &#x60;STOP_COMPLETE&#x60; - 停止完成   * &#x60;STOP_FAILED&#x60; - 停止失败
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 资源栈集操作失败时会展示此次操作失败的原因，例如，资源栈实例部署或删除失败个数超过上限或资源栈集操作超时。  如果需要查看详细失败信息，可通过ListStackInstances API获取查看资源栈实例的status_message。
        /// </summary>
        [JsonProperty("status_message", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// 用户当前的操作   * &#x60;CREATE_STACK_INSTANCES&#x60; - 创建资源栈实例   * &#x60;DELETE_STACK_INSTANCES&#x60; - 删除资源栈实例   * &#x60;DEPLOY_STACK_SET&#x60; - 部署资源栈集   * &#x60;DEPLOY_STACK_INSTANCES&#x60; - 部署资源栈实例   * &#x60;UPDATE_STACK_INSTANCES&#x60; - 更新资源栈实例
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// 管理委托名称  资源编排服务使用该委托获取成员账号委托给管理账号的权限  当用户定义SELF_MANAGED权限类型时，administration_agency_name和administration_agency_urn 必须有且只有一个存在。  推荐用户在使用v5委托时给与administration_agency_urn，administration_agency_name只支持接收v3委托名称，若给与了v5委托名称，则会在部署模板时失败。  当用户使用SERVICE_MANAGED权限类型时，指定该参数将报错400。  [创建委托及授权方式](https://support.huaweicloud.com/usermanual-iam/iam_06_0002.html)
        /// </summary>
        [JsonProperty("administration_agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AdministrationAgencyName { get; set; }

        /// <summary>
        /// 管理委托URN  资源编排服务使用该委托获取成员账号委托给管理账号的权限  当用户定义SELF_MANAGED权限类型时，administration_agency_name和administration_agency_urn 必须有且只有一个存在。  推荐用户在使用v5委托时给与administration_agency_urn，administration_agency_name只支持接收普通委托名称，若给与了v5委托名称，则会在部署模板时失败。  当用户使用SERVICE_MANAGED权限类型时，指定该参数将报错400。
        /// </summary>
        [JsonProperty("administration_agency_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string AdministrationAgencyUrn { get; set; }

        /// <summary>
        /// 被管理的委托名称。  资源编排服务会使用该委托获取实际部署资源所需要的权限  不同成员账号委托给管理账号的委托名称需要保持一致。暂不支持根据不同provider定义不同委托权限  当用户定义SELF_MANAGED权限类型时，必须指定该参数。当用户使用SERVICE_MANAGED权限类型时，指定该参数将报错400  [创建委托及授权方式](https://support.huaweicloud.com/usermanual-iam/iam_06_0002.html)
        /// </summary>
        [JsonProperty("managed_agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagedAgencyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("deployment_targets", NullValueHandling = NullValueHandling.Ignore)]
        public DeploymentTargets DeploymentTargets { get; set; }

        /// <summary>
        /// 资源栈集操作的创建时间，格式为YYYY-MM-DDTHH:mm:ss.SSSZ，精确到毫秒，UTC时区，即，如1970-01-01T00:00:00.000Z。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 资源栈集操作的更新时间，格式为YYYY-MM-DDTHH:mm:ss.SSSZ，精确到毫秒，UTC时区，即，如1970-01-01T00:00:00.000Z。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStackSetOperationMetadataResponse {\n");
            sb.Append("  stackSetOperationId: ").Append(StackSetOperationId).Append("\n");
            sb.Append("  stackSetId: ").Append(StackSetId).Append("\n");
            sb.Append("  stackSetName: ").Append(StackSetName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  statusMessage: ").Append(StatusMessage).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  administrationAgencyName: ").Append(AdministrationAgencyName).Append("\n");
            sb.Append("  administrationAgencyUrn: ").Append(AdministrationAgencyUrn).Append("\n");
            sb.Append("  managedAgencyName: ").Append(ManagedAgencyName).Append("\n");
            sb.Append("  deploymentTargets: ").Append(DeploymentTargets).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStackSetOperationMetadataResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStackSetOperationMetadataResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StackSetOperationId == input.StackSetOperationId ||
                    (this.StackSetOperationId != null &&
                    this.StackSetOperationId.Equals(input.StackSetOperationId))
                ) && 
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
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.AdministrationAgencyName == input.AdministrationAgencyName ||
                    (this.AdministrationAgencyName != null &&
                    this.AdministrationAgencyName.Equals(input.AdministrationAgencyName))
                ) && 
                (
                    this.AdministrationAgencyUrn == input.AdministrationAgencyUrn ||
                    (this.AdministrationAgencyUrn != null &&
                    this.AdministrationAgencyUrn.Equals(input.AdministrationAgencyUrn))
                ) && 
                (
                    this.ManagedAgencyName == input.ManagedAgencyName ||
                    (this.ManagedAgencyName != null &&
                    this.ManagedAgencyName.Equals(input.ManagedAgencyName))
                ) && 
                (
                    this.DeploymentTargets == input.DeploymentTargets ||
                    (this.DeploymentTargets != null &&
                    this.DeploymentTargets.Equals(input.DeploymentTargets))
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
                if (this.StackSetOperationId != null)
                    hashCode = hashCode * 59 + this.StackSetOperationId.GetHashCode();
                if (this.StackSetId != null)
                    hashCode = hashCode * 59 + this.StackSetId.GetHashCode();
                if (this.StackSetName != null)
                    hashCode = hashCode * 59 + this.StackSetName.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusMessage != null)
                    hashCode = hashCode * 59 + this.StatusMessage.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.AdministrationAgencyName != null)
                    hashCode = hashCode * 59 + this.AdministrationAgencyName.GetHashCode();
                if (this.AdministrationAgencyUrn != null)
                    hashCode = hashCode * 59 + this.AdministrationAgencyUrn.GetHashCode();
                if (this.ManagedAgencyName != null)
                    hashCode = hashCode * 59 + this.ManagedAgencyName.GetHashCode();
                if (this.DeploymentTargets != null)
                    hashCode = hashCode * 59 + this.DeploymentTargets.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
