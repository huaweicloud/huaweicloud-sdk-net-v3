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
        /// 资源栈的状态    * &#x60;CREATION_COMPLETE&#x60; - 生成空资源栈完成，并没有任何部署    * &#x60;DEPLOYMENT_IN_PROGRESS&#x60; - 正在部署，请等待    * &#x60;DEPLOYMENT_FAILED&#x60; - 部署失败。请从status_message获取错误信息汇总，或者调用ListStackEvents获得事件详情    * &#x60;DEPLOYMENT_COMPLETE&#x60; - 部署完成    * &#x60;ROLLBACK_IN_PROGRESS&#x60; - 部署失败，正在回滚，请等待    * &#x60;ROLLBACK_FAILED&#x60; - 回滚失败。请从status_message获取错误信息汇总，或者调用ListStackEvents获得事件详情    * &#x60;ROLLBACK_COMPLETE&#x60; - 回滚完成    * &#x60;DELETION_IN_PROGRESS&#x60; - 正在删除，请等待    * &#x60;DELETION_FAILED&#x60; - 删除失败。请从status_message获取错误信息汇总，或者调用ListStackEvents获得事件详情
        /// </summary>
        /// <value>资源栈的状态    * &#x60;CREATION_COMPLETE&#x60; - 生成空资源栈完成，并没有任何部署    * &#x60;DEPLOYMENT_IN_PROGRESS&#x60; - 正在部署，请等待    * &#x60;DEPLOYMENT_FAILED&#x60; - 部署失败。请从status_message获取错误信息汇总，或者调用ListStackEvents获得事件详情    * &#x60;DEPLOYMENT_COMPLETE&#x60; - 部署完成    * &#x60;ROLLBACK_IN_PROGRESS&#x60; - 部署失败，正在回滚，请等待    * &#x60;ROLLBACK_FAILED&#x60; - 回滚失败。请从status_message获取错误信息汇总，或者调用ListStackEvents获得事件详情    * &#x60;ROLLBACK_COMPLETE&#x60; - 回滚完成    * &#x60;DELETION_IN_PROGRESS&#x60; - 正在删除，请等待    * &#x60;DELETION_FAILED&#x60; - 删除失败。请从status_message获取错误信息汇总，或者调用ListStackEvents获得事件详情</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum CREATION_COMPLETE for value: CREATION_COMPLETE
            /// </summary>
            public static readonly StatusEnum CREATION_COMPLETE = new StatusEnum("CREATION_COMPLETE");

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

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "CREATION_COMPLETE", CREATION_COMPLETE },
                { "DEPLOYMENT_IN_PROGRESS", DEPLOYMENT_IN_PROGRESS },
                { "DEPLOYMENT_FAILED", DEPLOYMENT_FAILED },
                { "DEPLOYMENT_COMPLETE", DEPLOYMENT_COMPLETE },
                { "ROLLBACK_IN_PROGRESS", ROLLBACK_IN_PROGRESS },
                { "ROLLBACK_FAILED", ROLLBACK_FAILED },
                { "ROLLBACK_COMPLETE", ROLLBACK_COMPLETE },
                { "DELETION_IN_PROGRESS", DELETION_IN_PROGRESS },
                { "DELETION_FAILED", DELETION_FAILED },
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
        /// 资源栈（stack）的唯一ID。  此ID由资源编排服务在生成资源栈的时候生成，为UUID。  由于资源栈名仅仅在同一时间下唯一，即用户允许先生成一个叫HelloWorld的资源栈，删除，再重新创建一个同名资源栈。  对于团队并行开发，用户可能希望确保，当前我操作的资源栈就是我认为的那个，而不是其他队友删除后创建的同名资源栈。因此，使用ID就可以做到强匹配。  资源编排服务保证每次创建的资源栈所对应的ID都不相同，更新不会影响ID。如果给予的stack_id和当前资源栈的ID不一致，则返回400
        /// </summary>
        [JsonProperty("stack_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StackId { get; set; }

        /// <summary>
        /// 资源栈的名称。此名字在domain_id+区域+project_id下应唯一，可以使用中文、大小写英文、数字、下划线、中划线。首字符需为中文或者英文，区分大小写。
        /// </summary>
        [JsonProperty("stack_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StackName { get; set; }

        /// <summary>
        /// 资源栈的描述。可用于客户识别自己的资源栈。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// HCL参数结构。HCL模板支持参数传入，即，同一个模板可以给予不同的参数而达到不同的效果。  * var_structure可以允许客户提交最简单的字符串类型的参数  * 资源编排服务支持vars_structure，vars_body和vars_uri，如果以上三种方式中声名了同一个变量，将报错400  * vars_structure中的值只支持简单的字符串类型，如果需要使用其他类型，需要用户自己在HCL引用时转换， 或者用户可以使用vars_uri、vars_body，vars_uri和vars_body中支持HCL支持的各种类型以及复杂结构  * 如果vars_structure过大，可以使用vars_uri  * 注意：vars_structure中默认不应该含有任何敏感信息，资源编排服务会直接明文使用、log、展示、存储对应的vars。如为敏感信息，建议设置encryption字段开启加密
        /// </summary>
        [JsonProperty("vars_structure", NullValueHandling = NullValueHandling.Ignore)]
        public List<VarsStructure> VarsStructure { get; set; }

        /// <summary>
        /// HCL参数文件的内容。HCL模板支持参数传入，即，同一个模板可以给予不同的参数而达到不同的效果。  * vars_body使用HCL的tfvars格式，用户可以将“.tfvars”中的内容提交到vars_body中  * 资源编排服务支持vars_body和vars_uri，如果以上两种方式中声名了同一个变量，将报错400  * 如果vars_body过大，可以使用vars_uri  * 资源栈集不支持敏感数据加密，资源编排服务会直接明文使用、log、展示、存储对应的vars_body。
        /// </summary>
        [JsonProperty("vars_body", NullValueHandling = NullValueHandling.Ignore)]
        public string VarsBody { get; set; }

        /// <summary>
        /// 删除保护的标识位，如果不传默认为false，即默认不开启资源栈删除保护（删除保护开启后资源栈不允许被删除）  *在UpdateStack API中，如果该参数未在RequestBody中给予，则不会对资源栈的删除保护属性进行更新*
        /// </summary>
        [JsonProperty("enable_deletion_protection", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableDeletionProtection { get; set; }

        /// <summary>
        /// 自动回滚的标识位，如果不传默认为false，即默认不开启资源栈自动回滚（自动回滚开启后，如果部署失败，则会自动回滚，并返回上一个稳定状态）  *在UpdateStack API中，如果该参数未在RequestBody中给予，则不会对资源栈的自动回滚属性进行更新* *该属性与使用模板导入资源功能互斥，如果堆栈的自动回滚设置为true，则不允许部署包含导入资源的模板*
        /// </summary>
        [JsonProperty("enable_auto_rollback", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAutoRollback { get; set; }

        /// <summary>
        /// 资源栈的状态    * &#x60;CREATION_COMPLETE&#x60; - 生成空资源栈完成，并没有任何部署    * &#x60;DEPLOYMENT_IN_PROGRESS&#x60; - 正在部署，请等待    * &#x60;DEPLOYMENT_FAILED&#x60; - 部署失败。请从status_message获取错误信息汇总，或者调用ListStackEvents获得事件详情    * &#x60;DEPLOYMENT_COMPLETE&#x60; - 部署完成    * &#x60;ROLLBACK_IN_PROGRESS&#x60; - 部署失败，正在回滚，请等待    * &#x60;ROLLBACK_FAILED&#x60; - 回滚失败。请从status_message获取错误信息汇总，或者调用ListStackEvents获得事件详情    * &#x60;ROLLBACK_COMPLETE&#x60; - 回滚完成    * &#x60;DELETION_IN_PROGRESS&#x60; - 正在删除，请等待    * &#x60;DELETION_FAILED&#x60; - 删除失败。请从status_message获取错误信息汇总，或者调用ListStackEvents获得事件详情
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 委托授权的信息。  RFS仅在创建资源栈（触发部署）、创建执行计划、部署资源栈、删除资源栈等涉及资源操作的请求中使用委托，且该委托仅作用于与之绑定的Provider对资源的操作中。如果委托中提供的权限不足，有可能导致相关资源操作失败。  [[创建委托及授权方式](https://support.huaweicloud.com/usermanual-iam/iam_06_0002.html)](tag:hws) [[创建委托及授权方式](https://support.huaweicloud.com/intl/zh-cn/usermanual-iam/iam_06_0002.html)](tag:hws_hk) [[创建委托及授权方式](https://support.huaweicloud.com/eu/usermanual-iam/iam_06_0002.html)](tag:hws_eu)
        /// </summary>
        [JsonProperty("agencies", NullValueHandling = NullValueHandling.Ignore)]
        public List<Agency> Agencies { get; set; }

        /// <summary>
        /// 当资源栈的状态为任意失败状态（即以 &#x60;FAILED&#x60; 结尾时），将会展示简要的错误信息总结以供debug
        /// </summary>
        [JsonProperty("status_message", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// vars_uri对应的文件内容
        /// </summary>
        [JsonProperty("vars_uri_content", NullValueHandling = NullValueHandling.Ignore)]
        public string VarsUriContent { get; set; }

        /// <summary>
        /// 资源栈的生成时间 格式遵循RFC3339，即yyyy-mm-ddTHH:MM:SSZ，如1970-01-01T00:00:00Z
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 资源栈的更新时间（更新场景包括元数据更新场景和部署场景） 格式遵循RFC3339，即yyyy-mm-ddTHH:MM:SSZ，如1970-01-01T00:00:00Z
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }



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
            sb.Append("  varsBody: ").Append(VarsBody).Append("\n");
            sb.Append("  enableDeletionProtection: ").Append(EnableDeletionProtection).Append("\n");
            sb.Append("  enableAutoRollback: ").Append(EnableAutoRollback).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  agencies: ").Append(Agencies).Append("\n");
            sb.Append("  statusMessage: ").Append(StatusMessage).Append("\n");
            sb.Append("  varsUriContent: ").Append(VarsUriContent).Append("\n");
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
                    this.VarsBody == input.VarsBody ||
                    (this.VarsBody != null &&
                    this.VarsBody.Equals(input.VarsBody))
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
                    this.Agencies == input.Agencies ||
                    this.Agencies != null &&
                    input.Agencies != null &&
                    this.Agencies.SequenceEqual(input.Agencies)
                ) && 
                (
                    this.StatusMessage == input.StatusMessage ||
                    (this.StatusMessage != null &&
                    this.StatusMessage.Equals(input.StatusMessage))
                ) && 
                (
                    this.VarsUriContent == input.VarsUriContent ||
                    (this.VarsUriContent != null &&
                    this.VarsUriContent.Equals(input.VarsUriContent))
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
                if (this.StackId != null)
                    hashCode = hashCode * 59 + this.StackId.GetHashCode();
                if (this.StackName != null)
                    hashCode = hashCode * 59 + this.StackName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.VarsStructure != null)
                    hashCode = hashCode * 59 + this.VarsStructure.GetHashCode();
                if (this.VarsBody != null)
                    hashCode = hashCode * 59 + this.VarsBody.GetHashCode();
                if (this.EnableDeletionProtection != null)
                    hashCode = hashCode * 59 + this.EnableDeletionProtection.GetHashCode();
                if (this.EnableAutoRollback != null)
                    hashCode = hashCode * 59 + this.EnableAutoRollback.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Agencies != null)
                    hashCode = hashCode * 59 + this.Agencies.GetHashCode();
                if (this.StatusMessage != null)
                    hashCode = hashCode * 59 + this.StatusMessage.GetHashCode();
                if (this.VarsUriContent != null)
                    hashCode = hashCode * 59 + this.VarsUriContent.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
