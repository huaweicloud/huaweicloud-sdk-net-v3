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
    /// 批量查询任务状态返回体
    /// </summary>
    public class QueryJobStatusResp 
    {
        /// <summary>
        /// 任务状态。 - CREATING：创建中 - CREATE_FAILED：创建失败 - CONFIGURATION：配置中 - STARTJOBING：启动中 - WAITING_FOR_START：等待启动中 - START_JOB_FAILED：启动失败 - PAUSING：已暂停 - FULL_TRANSFER_STARTED：全量开始，灾备场景下为初始化 - FULL_TRANSFER_FAILED：全量失败，灾备场景下为初始化失败 - FULL_TRANSFER_COMPLETE：全量完成，灾备场景下为初始化完成 - INCRE_TRANSFER_STARTED：增量开始，灾备场景下为灾备中 - INCRE_TRANSFER_FAILED：增量失败，灾备场景下为灾备异常 - RELEASE_RESOURCE_STARTED：结束任务中 - RELEASE_RESOURCE_FAILED：结束任务失败 - RELEASE_RESOURCE_COMPLETE：已结束 - REBUILD_NODE_STARTED：故障恢复中 - REBUILD_NODE_FAILED：故障恢复失败 - CHANGE_JOB_STARTED：任务变更中 - CHANGE_JOB_FAILED：任务变更失败 - DELETED：已删除 - CHILD_TRANSFER_STARTING：再编辑子任务启动中 - CHILD_TRANSFER_STARTED：再编辑子任务迁移中 - CHILD_TRANSFER_COMPLETE：再编辑子任务迁移完成 - CHILD_TRANSFER_FAILED：再编辑子任务迁移失败 - RELEASE_CHILD_TRANSFER_STARTED：再编辑子任务结束中 - RELEASE_CHILD_TRANSFER_COMPLETE：再编辑子任务已结束 - NODE_UPGRADE_START：升级开始 - NODE_UPGRADE_COMPLETE：升级完成 - NODE_UPGRADE_FAILED：升级失败
        /// </summary>
        /// <value>任务状态。 - CREATING：创建中 - CREATE_FAILED：创建失败 - CONFIGURATION：配置中 - STARTJOBING：启动中 - WAITING_FOR_START：等待启动中 - START_JOB_FAILED：启动失败 - PAUSING：已暂停 - FULL_TRANSFER_STARTED：全量开始，灾备场景下为初始化 - FULL_TRANSFER_FAILED：全量失败，灾备场景下为初始化失败 - FULL_TRANSFER_COMPLETE：全量完成，灾备场景下为初始化完成 - INCRE_TRANSFER_STARTED：增量开始，灾备场景下为灾备中 - INCRE_TRANSFER_FAILED：增量失败，灾备场景下为灾备异常 - RELEASE_RESOURCE_STARTED：结束任务中 - RELEASE_RESOURCE_FAILED：结束任务失败 - RELEASE_RESOURCE_COMPLETE：已结束 - REBUILD_NODE_STARTED：故障恢复中 - REBUILD_NODE_FAILED：故障恢复失败 - CHANGE_JOB_STARTED：任务变更中 - CHANGE_JOB_FAILED：任务变更失败 - DELETED：已删除 - CHILD_TRANSFER_STARTING：再编辑子任务启动中 - CHILD_TRANSFER_STARTED：再编辑子任务迁移中 - CHILD_TRANSFER_COMPLETE：再编辑子任务迁移完成 - CHILD_TRANSFER_FAILED：再编辑子任务迁移失败 - RELEASE_CHILD_TRANSFER_STARTED：再编辑子任务结束中 - RELEASE_CHILD_TRANSFER_COMPLETE：再编辑子任务已结束 - NODE_UPGRADE_START：升级开始 - NODE_UPGRADE_COMPLETE：升级完成 - NODE_UPGRADE_FAILED：升级失败</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum CREATING for value: CREATING
            /// </summary>
            public static readonly StatusEnum CREATING = new StatusEnum("CREATING");

            /// <summary>
            /// Enum CREATE_FAILED for value: CREATE_FAILED
            /// </summary>
            public static readonly StatusEnum CREATE_FAILED = new StatusEnum("CREATE_FAILED");

            /// <summary>
            /// Enum CONFIGURATION for value: CONFIGURATION
            /// </summary>
            public static readonly StatusEnum CONFIGURATION = new StatusEnum("CONFIGURATION");

            /// <summary>
            /// Enum STARTJOBING for value: STARTJOBING
            /// </summary>
            public static readonly StatusEnum STARTJOBING = new StatusEnum("STARTJOBING");

            /// <summary>
            /// Enum WAITING_FOR_START for value: WAITING_FOR_START
            /// </summary>
            public static readonly StatusEnum WAITING_FOR_START = new StatusEnum("WAITING_FOR_START");

            /// <summary>
            /// Enum START_JOB_FAILED for value: START_JOB_FAILED
            /// </summary>
            public static readonly StatusEnum START_JOB_FAILED = new StatusEnum("START_JOB_FAILED");

            /// <summary>
            /// Enum PAUSING for value: PAUSING
            /// </summary>
            public static readonly StatusEnum PAUSING = new StatusEnum("PAUSING");

            /// <summary>
            /// Enum FULL_TRANSFER_STARTED for value: FULL_TRANSFER_STARTED
            /// </summary>
            public static readonly StatusEnum FULL_TRANSFER_STARTED = new StatusEnum("FULL_TRANSFER_STARTED");

            /// <summary>
            /// Enum FULL_TRANSFER_FAILED for value: FULL_TRANSFER_FAILED
            /// </summary>
            public static readonly StatusEnum FULL_TRANSFER_FAILED = new StatusEnum("FULL_TRANSFER_FAILED");

            /// <summary>
            /// Enum FULL_TRANSFER_COMPLETE for value: FULL_TRANSFER_COMPLETE
            /// </summary>
            public static readonly StatusEnum FULL_TRANSFER_COMPLETE = new StatusEnum("FULL_TRANSFER_COMPLETE");

            /// <summary>
            /// Enum INCRE_TRANSFER_STARTED for value: INCRE_TRANSFER_STARTED
            /// </summary>
            public static readonly StatusEnum INCRE_TRANSFER_STARTED = new StatusEnum("INCRE_TRANSFER_STARTED");

            /// <summary>
            /// Enum INCRE_TRANSFER_FAILED for value: INCRE_TRANSFER_FAILED
            /// </summary>
            public static readonly StatusEnum INCRE_TRANSFER_FAILED = new StatusEnum("INCRE_TRANSFER_FAILED");

            /// <summary>
            /// Enum RELEASE_RESOURCE_STARTED for value: RELEASE_RESOURCE_STARTED
            /// </summary>
            public static readonly StatusEnum RELEASE_RESOURCE_STARTED = new StatusEnum("RELEASE_RESOURCE_STARTED");

            /// <summary>
            /// Enum RELEASE_RESOURCE_FAILED for value: RELEASE_RESOURCE_FAILED
            /// </summary>
            public static readonly StatusEnum RELEASE_RESOURCE_FAILED = new StatusEnum("RELEASE_RESOURCE_FAILED");

            /// <summary>
            /// Enum RELEASE_RESOURCE_COMPLETE for value: RELEASE_RESOURCE_COMPLETE
            /// </summary>
            public static readonly StatusEnum RELEASE_RESOURCE_COMPLETE = new StatusEnum("RELEASE_RESOURCE_COMPLETE");

            /// <summary>
            /// Enum REBUILD_NODE_STARTED for value: REBUILD_NODE_STARTED
            /// </summary>
            public static readonly StatusEnum REBUILD_NODE_STARTED = new StatusEnum("REBUILD_NODE_STARTED");

            /// <summary>
            /// Enum REBUILD_NODE_FAILED for value: REBUILD_NODE_FAILED
            /// </summary>
            public static readonly StatusEnum REBUILD_NODE_FAILED = new StatusEnum("REBUILD_NODE_FAILED");

            /// <summary>
            /// Enum CHANGE_JOB_STARTED for value: CHANGE_JOB_STARTED
            /// </summary>
            public static readonly StatusEnum CHANGE_JOB_STARTED = new StatusEnum("CHANGE_JOB_STARTED");

            /// <summary>
            /// Enum CHANGE_JOB_FAILED for value: CHANGE_JOB_FAILED
            /// </summary>
            public static readonly StatusEnum CHANGE_JOB_FAILED = new StatusEnum("CHANGE_JOB_FAILED");

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            public static readonly StatusEnum DELETED = new StatusEnum("DELETED");

            /// <summary>
            /// Enum CHILD_TRANSFER_STARTING for value: CHILD_TRANSFER_STARTING
            /// </summary>
            public static readonly StatusEnum CHILD_TRANSFER_STARTING = new StatusEnum("CHILD_TRANSFER_STARTING");

            /// <summary>
            /// Enum CHILD_TRANSFER_STARTED for value: CHILD_TRANSFER_STARTED
            /// </summary>
            public static readonly StatusEnum CHILD_TRANSFER_STARTED = new StatusEnum("CHILD_TRANSFER_STARTED");

            /// <summary>
            /// Enum CHILD_TRANSFER_COMPLETE for value: CHILD_TRANSFER_COMPLETE
            /// </summary>
            public static readonly StatusEnum CHILD_TRANSFER_COMPLETE = new StatusEnum("CHILD_TRANSFER_COMPLETE");

            /// <summary>
            /// Enum CHILD_TRANSFER_FAILED for value: CHILD_TRANSFER_FAILED
            /// </summary>
            public static readonly StatusEnum CHILD_TRANSFER_FAILED = new StatusEnum("CHILD_TRANSFER_FAILED");

            /// <summary>
            /// Enum RELEASE_CHILD_TRANSFER_STARTED for value: RELEASE_CHILD_TRANSFER_STARTED
            /// </summary>
            public static readonly StatusEnum RELEASE_CHILD_TRANSFER_STARTED = new StatusEnum("RELEASE_CHILD_TRANSFER_STARTED");

            /// <summary>
            /// Enum RELEASE_CHILD_TRANSFER_COMPLETE for value: RELEASE_CHILD_TRANSFER_COMPLETE
            /// </summary>
            public static readonly StatusEnum RELEASE_CHILD_TRANSFER_COMPLETE = new StatusEnum("RELEASE_CHILD_TRANSFER_COMPLETE");

            /// <summary>
            /// Enum NODE_UPGRADE_START for value: NODE_UPGRADE_START
            /// </summary>
            public static readonly StatusEnum NODE_UPGRADE_START = new StatusEnum("NODE_UPGRADE_START");

            /// <summary>
            /// Enum NODE_UPGRADE_COMPLETE for value: NODE_UPGRADE_COMPLETE
            /// </summary>
            public static readonly StatusEnum NODE_UPGRADE_COMPLETE = new StatusEnum("NODE_UPGRADE_COMPLETE");

            /// <summary>
            /// Enum NODE_UPGRADE_FAILED for value: NODE_UPGRADE_FAILED
            /// </summary>
            public static readonly StatusEnum NODE_UPGRADE_FAILED = new StatusEnum("NODE_UPGRADE_FAILED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "CREATING", CREATING },
                { "CREATE_FAILED", CREATE_FAILED },
                { "CONFIGURATION", CONFIGURATION },
                { "STARTJOBING", STARTJOBING },
                { "WAITING_FOR_START", WAITING_FOR_START },
                { "START_JOB_FAILED", START_JOB_FAILED },
                { "PAUSING", PAUSING },
                { "FULL_TRANSFER_STARTED", FULL_TRANSFER_STARTED },
                { "FULL_TRANSFER_FAILED", FULL_TRANSFER_FAILED },
                { "FULL_TRANSFER_COMPLETE", FULL_TRANSFER_COMPLETE },
                { "INCRE_TRANSFER_STARTED", INCRE_TRANSFER_STARTED },
                { "INCRE_TRANSFER_FAILED", INCRE_TRANSFER_FAILED },
                { "RELEASE_RESOURCE_STARTED", RELEASE_RESOURCE_STARTED },
                { "RELEASE_RESOURCE_FAILED", RELEASE_RESOURCE_FAILED },
                { "RELEASE_RESOURCE_COMPLETE", RELEASE_RESOURCE_COMPLETE },
                { "REBUILD_NODE_STARTED", REBUILD_NODE_STARTED },
                { "REBUILD_NODE_FAILED", REBUILD_NODE_FAILED },
                { "CHANGE_JOB_STARTED", CHANGE_JOB_STARTED },
                { "CHANGE_JOB_FAILED", CHANGE_JOB_FAILED },
                { "DELETED", DELETED },
                { "CHILD_TRANSFER_STARTING", CHILD_TRANSFER_STARTING },
                { "CHILD_TRANSFER_STARTED", CHILD_TRANSFER_STARTED },
                { "CHILD_TRANSFER_COMPLETE", CHILD_TRANSFER_COMPLETE },
                { "CHILD_TRANSFER_FAILED", CHILD_TRANSFER_FAILED },
                { "RELEASE_CHILD_TRANSFER_STARTED", RELEASE_CHILD_TRANSFER_STARTED },
                { "RELEASE_CHILD_TRANSFER_COMPLETE", RELEASE_CHILD_TRANSFER_COMPLETE },
                { "NODE_UPGRADE_START", NODE_UPGRADE_START },
                { "NODE_UPGRADE_COMPLETE", NODE_UPGRADE_COMPLETE },
                { "NODE_UPGRADE_FAILED", NODE_UPGRADE_FAILED },
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
        /// 任务ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 任务状态。 - CREATING：创建中 - CREATE_FAILED：创建失败 - CONFIGURATION：配置中 - STARTJOBING：启动中 - WAITING_FOR_START：等待启动中 - START_JOB_FAILED：启动失败 - PAUSING：已暂停 - FULL_TRANSFER_STARTED：全量开始，灾备场景下为初始化 - FULL_TRANSFER_FAILED：全量失败，灾备场景下为初始化失败 - FULL_TRANSFER_COMPLETE：全量完成，灾备场景下为初始化完成 - INCRE_TRANSFER_STARTED：增量开始，灾备场景下为灾备中 - INCRE_TRANSFER_FAILED：增量失败，灾备场景下为灾备异常 - RELEASE_RESOURCE_STARTED：结束任务中 - RELEASE_RESOURCE_FAILED：结束任务失败 - RELEASE_RESOURCE_COMPLETE：已结束 - REBUILD_NODE_STARTED：故障恢复中 - REBUILD_NODE_FAILED：故障恢复失败 - CHANGE_JOB_STARTED：任务变更中 - CHANGE_JOB_FAILED：任务变更失败 - DELETED：已删除 - CHILD_TRANSFER_STARTING：再编辑子任务启动中 - CHILD_TRANSFER_STARTED：再编辑子任务迁移中 - CHILD_TRANSFER_COMPLETE：再编辑子任务迁移完成 - CHILD_TRANSFER_FAILED：再编辑子任务迁移失败 - RELEASE_CHILD_TRANSFER_STARTED：再编辑子任务结束中 - RELEASE_CHILD_TRANSFER_COMPLETE：再编辑子任务已结束 - NODE_UPGRADE_START：升级开始 - NODE_UPGRADE_COMPLETE：升级完成 - NODE_UPGRADE_FAILED：升级失败
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("error_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryJobStatusResp {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  errorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryJobStatusResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryJobStatusResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                return hashCode;
            }
        }
    }
}
